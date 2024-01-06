using System.Collections.Generic; 

namespace Studying.Leetcode.Trees
{
    /// <summary>
    /// 
    /// </summary>
    public class ImplementBinarySearchTree : Studying.Leetcode.ILeetcodeProblem
    {
        /// <summary>
        /// 
        /// </summary>
        public class TreeElement<T>
        {
            #region Public properties
            /// <summary>
            /// 
            /// </summary>
            public T Value { get; private set; }
            /// <summary>
            /// 
            /// </summary>
            public TreeElement<T> Parent { get; private set; }
            /// <summary>
            /// 
            /// </summary>
            public ICollection<TreeElement<T>> Childs { get; private set; }
            #endregion  // Public properties

            #region Constructors
            /// <summary>
            /// 
            /// </summary>
            public TreeElement(T value) : this(value, null)
            {
            }

            /// <summary>
            /// 
            /// </summary>
            public TreeElement(T value, ICollection<TreeElement<T>> childs) : this(value, null, childs)
            {
            }

            /// <summary>
            /// 
            /// </summary>
            public TreeElement(T value, TreeElement<T> parent, ICollection<TreeElement<T>> childs)
            {
                if (childs == null) 
                    childs = new List<TreeElement<T>>();
                foreach (var child in childs)
                {
                    child.SetParent(this);
                }
                
                Value = value;
                Parent = parent;
                Childs = childs;
            }
            #endregion  // Constructors

            public void SetParent(TreeElement<T> parent)
            {
                // 
            }

            /// <summary>
            /// 
            /// </summary>
            public void AddChild(TreeElement<T> child)
            {
                if (child == null)
                    throw new System.Exception("Cannot add the child element: child element could not be null");
            
                Childs.Add(child);
            }

            #region ToString methods
            /// <summary>
            /// Gets a full representation of a node, including values and childs of it childs, in a following form:  
            /// [value: 0, childs: [value: 1, childs: []], [values: childs: []]]
            /// </summary>
            public override string ToString()
            {
                return $"[value: {Value}, childs: {ToChildTreeString()}]".Replace(",]", "]"); 
            }
            
            /// <summary>
            /// 
            /// </summary>
            public string ToChildsString()
            {
                string result = "["; 
                foreach (var element in Childs) 
                    result += element.Value + ","; 
                result += "]"; 
                return result.Replace(",]", "]"); 
            }

            /// <summary>
            /// 
            /// </summary>
            public string ToChildTreeString()
            {
                string result = string.Empty; 
                foreach (var element in Childs) 
                {
                    result += "[value: " + element.Value + ", childs: "; 
                    result += element.Childs.Count == 0 ? element.ToChildsString() : element.ToChildTreeString(); 
                    result += "],"; 
                }
                return result.Replace(",]", "]"); 
            }
            #endregion  // ToString methods
        }

        /// <summary>
        /// 
        /// </summary>
        public class BinarySearchTree<T>
        {
            #region Public properties
            /// <summary>
            /// 
            /// </summary>
            public TreeElement<T> Root { get; private set; }
            /// <summary>
            /// 
            /// </summary>
            public System.Predicate<T> AddPredicate { get; private set; }
            #endregion  // Public properties

            #region Constructors
            /// <summary>
            /// 
            /// </summary>
            public BinarySearchTree() : this(null, null)
            {
            }

            /// <summary>
            /// 
            /// </summary>
            public BinarySearchTree(TreeElement<T> root) : this(root, null)
            {
            }

            /// <summary>
            /// 
            /// </summary>
            public BinarySearchTree(System.Predicate<T> addPredicate) : this(null, addPredicate)
            {
            }

            /// <summary>
            /// 
            /// </summary>
            public BinarySearchTree(TreeElement<T> root, System.Predicate<T> addPredicate)
            {
                Root = root;
                AddPredicate = addPredicate == null ? (x => true) : addPredicate;
            }
            #endregion  // Constructors

            /// <summary>
            /// 
            /// </summary>
            public void AddValue(T value)
            {
                if (value == null)
                    throw new System.Exception("Cannot add the specified value: the value could not be null");
                if (!AddPredicate(value))
                    throw new System.Exception("Cannot add the specified value: the value violates predicate condition");
                
                if (Root == null)
                {
                    Root = new TreeElement<T>(value);
                    return;
                }

                // Since this is a binary search tree, we start traversing the tree.
                // First we take the root element and compare it with the value:
                // - if the value is greater, then look at the second child element;
                // - if the value is less, then look at the first child element.
            }

            /// <summary>
            /// 
            /// </summary>
            public override string ToString()
            {
                return Root.ToString(); 
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void Execute()
        {
            // Example 1: 
            // input1: [value: 1, childs: [value: 2, childs: [value: 5, childs: []]],[value: 3, childs: []],[value: 4, childs: []]]
            var tree = new BinarySearchTree<int>(
                new TreeElement<int>(1, new List<TreeElement<int>> 
                {
                    new TreeElement<int>(2, new List<TreeElement<int>> { new TreeElement<int>(5)}),
                    new TreeElement<int>(3),
                    new TreeElement<int>(4)
                })
            );

            System.Console.WriteLine("tree: " + tree.ToString());
        }
    }
}