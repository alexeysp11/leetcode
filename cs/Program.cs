namespace Studying.Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            // ILeetcodeProblem problem = new Studying.Leetcode.Graphs.LargestColorInDirectedGraph(); 
            // ILeetcodeProblem problem = new Studying.Leetcode.Arrays.ArrayConcatenation(); 
            // ILeetcodeProblem problem = new Studying.Leetcode.Algorithms.SlotsInCalendar(); 
            // ILeetcodeProblem problem = new Studying.Leetcode.Lists.ReverseLinkedList(); 
            // ILeetcodeProblem problem = new Studying.Leetcode.Tree.ReplaceChangedElementInTree(); 
            // ILeetcodeProblem problem = new Studying.Leetcode.Orm.SlotsInCalendar(); 
            ILeetcodeProblem problem = new Studying.Leetcode.Nosql.EmployeeUniqueId(); 
            problem.Execute();
        }
    }
}
