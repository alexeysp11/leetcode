using System.IO;
using System.Text;
using System.Threading.Tasks;

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

            // Download and process a large file in the background.
            ReadFileSyncFileStream(path);
            // ReadFileSyncStreamReader(path);
        }

        /// <summary>
        /// 
        /// </summary>
        private void AddText(FileStream fs, string value)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(value);
            fs.Write(info, 0, info.Length);
        }

        #region Methods for reading a file
        /// <summary>
        /// 
        /// </summary>
        private void ReadFileSyncFileStream(string path)
        {
            var totalReadLength = 0;
            var startDateTime = System.DateTime.Now;
            System.Console.WriteLine("START");
            using (FileStream fs = File.OpenRead(path))
            {
                int readLength = 0;
                byte[] buffer = new byte[1024];
                UTF8Encoding temp = new UTF8Encoding(true);
                while ((readLength = fs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    System.Console.WriteLine(temp.GetString(buffer, 0, readLength));
                    totalReadLength += readLength;
                }
            }
            var endDateTime = System.DateTime.Now;
            System.Console.WriteLine("FINISH");
            System.Console.WriteLine("totalReadLength: " + totalReadLength);
            System.Console.WriteLine("Read start: " + startDateTime.ToString());
            System.Console.WriteLine("Read finished: " + endDateTime.ToString());
            System.Console.WriteLine("Time elapsed: " + (endDateTime - startDateTime).ToString());
        }

        /// <summary>
        /// 
        /// </summary>
        private void ReadFileSyncStreamReader(string path)
        {
            var strNumber = 0;
            var startDateTime = System.DateTime.Now;
            System.Console.WriteLine("START");
            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                do
                {
                    line = sr.ReadLine();
                    strNumber += 1;
                    System.Console.WriteLine("strNumber: " + strNumber);
                } while (line != null);
            }
            var endDateTime = System.DateTime.Now;
            System.Console.WriteLine("FINISH");
            System.Console.WriteLine("Total strNumber: " + strNumber);
            System.Console.WriteLine("Read start: " + startDateTime.ToString());
            System.Console.WriteLine("Read finished: " + endDateTime.ToString());
            System.Console.WriteLine("Time elapsed: " + (endDateTime - startDateTime).ToString());
        }
        #endregion  // Methods for reading a file
    }
}