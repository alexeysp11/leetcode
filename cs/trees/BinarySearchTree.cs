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
            public T Value { get; private set; }
            public TreeElement<T> Parent { get; set; }
            public ICollection<TreeElement<T>> Childs { get; private set; }

            public TreeElement(T value) : this(value, null)
            {
            }
            public TreeElement(T value, TreeElement<T> parent) : this(value, parent, null)
            {
            }
            public TreeElement(T value, TreeElement<T> parent, ICollection<TreeElement<T>> childs)
            {
                Value = value;
                Parent = parent;
                Childs = childs == null ? new List<TreeElement<T>>() : childs;
            }

            public void AddChild(TreeElement<T> child)
            {
                if (child == null)
                    throw new System.Exception("Cannot add the child element: child element could not be null");
            
                Childs.Add(child);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public class BinarySearchTree<T>
        {
            public TreeElement<T> Root { get; private set; }
            private System.Predicate<T> Predicate { get; set; }

            public BinarySearchTree() : this(null, null)
            {
            }
            public BinarySearchTree(TreeElement<T> root) : this(root, null)
            {
            }
            public BinarySearchTree(System.Predicate<T> predicate) : this(null, predicate)
            {
            }
            public BinarySearchTree(TreeElement<T> root, System.Predicate<T> predicate)
            {
                Root = root;
                Predicate = predicate == null ? (x => true) : predicate;
            }

            public void AddValue(T value)
            {
                if (value == null)
                    throw new System.Exception("Cannot add the specified value: the value could not be null");
                if (!Predicate(value))
                    throw new System.Exception("Cannot add the specified value: the value violates predicate condition");
                
                if (Root == null)
                {
                    Root = new TreeElement<T>(value);
                    return;
                }

                // Поскольку это дерево бинарного поиска, то начинаем проходить по дереву.
                // Сначала берём корневой элемент и сравниваем со значением:
                //   - если значение больше, то смотрим на второй дочерний элемент;
                //   - если значение меньше, то смотрим на первый дочерний элемент.
            }
        }

        public void Execute()
        {
            // 
        }
    }
}