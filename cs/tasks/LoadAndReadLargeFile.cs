using System.IO;
using System.Text;

namespace Studying.Leetcode.Tasks
{
    /// <summary>
    /// To load and process a large file in the background, you can use the Task class from the System.Threading.Tasks namespace. 
    /// In the Task.Run() method you can start an asynchronous operation of reading a file and processing it.
    /// </summary>
    public class LoadAndReadLargeFile : Studying.Leetcode.ILeetcodeProblem
    {
        /// <summary>
        /// 
        /// </summary>
        public void Execute()
        {
            string directory = "data";
            string path = Path.Combine(directory, "Studying.Leetcode.Tasks.LoadAndReadLargeFile.txt");
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            // Let's say, the file should be over 10 MB in size.
            // Calculations:
            // 1 megabyte = 1024 kilobytes = 1,048,576 bytes = 1,048,576 characters.
            // 10 megabytes = 10,485,760 characters.
            // Dummy string contains approximately 58 characters.
            // It's necessary to insert the dummy string around 180,790 times.
            string dummyString = "Default string to populate a large file with some data!!!\n";
            using (FileStream fs = File.Create(path))
            {
                for (int i = 0; i < 180_790; i++)
                {
                    AddText(fs, dummyString);
                }
            }
        }

        private void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }
    }
}