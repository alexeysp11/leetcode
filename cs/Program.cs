namespace Studying.Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {
            // ILeetcodeProblem problem = new Studying.Leetcode.Graphs.LargestColorInDirectedGraph(); 
            // ILeetcodeProblem problem = new Studying.Leetcode.Arrays.ArrayConcatenation(); 
            // ILeetcodeProblem problem = new Studying.Leetcode.Lists.AddTwoNumbers(); 
            ILeetcodeProblem problem = new Studying.Leetcode.Algorithms.SlotsInCalendar(); 
            problem.Execute();
        }
    }
}
