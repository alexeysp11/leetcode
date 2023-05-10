namespace Studying.Leetcode.Graphs
{
    /// <summary>
    /// Given a black and white image that is represented in a form of a matrix,
    /// which is a 2D array consisted of the numbers 0 and 1 (where 1 - black, 0 - white). 
    /// Remove all the black pixels that are not connected to the border of the image. 
    /// Connected pixels are one or more pixels that are horizontally or vertically adjecent. 
    /// </summary>
    public class RemovingIslands : Studying.Leetcode.ILeetcodeProblem
    {
        private class Matrix 
        {
            public int Rows { get; }
            public int Cols { get; }

            public int[,] Values; 

            public Matrix(int rows, int cols)
            {
                Rows = rows; 
                Cols = cols; 
                Values = new int[rows, cols]; 
            }

            public void InitPixels()
            {
                // 
            }
            public void SetPixel(int row, int col, int value)
            {
                CheckIndex(row, col); 
                Values[row, col] = value; 
            }
            public int GetPixel(int row, int col)
            {
                CheckIndex(row, col); 
                return Values[row, col]; 
            }

            public Matrix RemoveIslands()
            {
                return this; 
            }

            private void CheckIndex(int row, int col)
            {
                if (row >= Rows) throw new System.Exception("Incorrect number of rows"); 
                if (col >= Cols) throw new System.Exception("Incorrect number of columns"); 
            }
        }

        public void Execute()
        {
            System.Console.WriteLine("Remove Islands\n".ToUpper()); 

            Matrix matrix = new Matrix(5, 6); 
            System.Console.WriteLine($"rows: {matrix.Rows}, cols: {matrix.Cols}"); 
            InitMatrix(matrix); 

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Cols; j++)
                {
                    // 
                    System.Console.Write(matrix.Values[i, j] + " "); 
                }
                System.Console.WriteLine(); 
            }
        }

        private void InitMatrix(Matrix matrix)
        {
            // 
            matrix.SetPixel(0, 0, 1); 
            matrix.SetPixel(0, 1, 0); 
            matrix.SetPixel(0, 2, 1); 
            matrix.SetPixel(0, 3, 0); 
            matrix.SetPixel(0, 4, 0); 
            matrix.SetPixel(0, 5, 0); 

            //
            matrix.SetPixel(1, 0, 1); 
            matrix.SetPixel(1, 1, 0); 
            matrix.SetPixel(1, 2, 1); 
            matrix.SetPixel(1, 3, 0); 
            matrix.SetPixel(1, 4, 0); 
            matrix.SetPixel(1, 5, 1); 

            //
            matrix.SetPixel(2, 0, 0); 
            matrix.SetPixel(2, 1, 1); 
            matrix.SetPixel(2, 2, 0); 
            matrix.SetPixel(2, 3, 1); 
            matrix.SetPixel(2, 4, 0); 
            matrix.SetPixel(2, 5, 0); 

            //
            matrix.SetPixel(3, 0, 1); 
            matrix.SetPixel(3, 1, 1); 
            matrix.SetPixel(3, 2, 0); 
            matrix.SetPixel(3, 3, 0); 
            matrix.SetPixel(3, 4, 1); 
            matrix.SetPixel(3, 5, 0); 

            //
            matrix.SetPixel(4, 0, 0); 
            matrix.SetPixel(4, 1, 1); 
            matrix.SetPixel(4, 2, 1); 
            matrix.SetPixel(4, 3, 1); 
            matrix.SetPixel(4, 4, 0); 
            matrix.SetPixel(4, 5, 1); 
        }
    }
}
