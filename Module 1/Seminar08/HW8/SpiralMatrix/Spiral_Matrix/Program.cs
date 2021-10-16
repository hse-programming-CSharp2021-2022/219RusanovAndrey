using System;

namespace Spiral_Matrix
{
    class Program
    {
        public static void Print(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            if (int.TryParse(s, out int n))
            {
                int[,] spiralMatrix = new int [n, n];
                int count = 0;
                for (int d = 0; d < n / 2; d++)
                {
                    for (int j = d; j < n - d; j++)
                    {
                        spiralMatrix[d, j] = ++count;
                    }

                    for (int i = d + 1; i < n - d; i++)
                    {
                        spiralMatrix[i, n - d - 1] = ++count;
                    }

                    for (int j = n - d - 2; j > d; j--)
                    {
                        spiralMatrix[n - d - 1, j] = ++count;
                    }

                    for (int i = n - d - 1; i > d; i--)
                    {
                        spiralMatrix[i, d] = ++count;
                    }
                }

                if (n % 2 == 1)
                {
                    spiralMatrix[n / 2, n / 2] = ++count;
                }

                Print(spiralMatrix);
            }
        }
    }
}