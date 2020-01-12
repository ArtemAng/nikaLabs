using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5
{
    class Program
    {
        static int FindMinIdx(int[,] arr, int n)
        {
            int idx = 0;
            int tmp = arr[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] < tmp)
                    {
                        idx = i;
                        tmp = arr[i, j];
                    }
                }
            }
            return idx;
        }
        static int FindMaxIdx(int[,] arr, int n)
        {
            int idx = 0;
            int tmp = arr[0, 0];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[i, j] > tmp)
                    {
                        idx = i;
                        tmp = arr[i, j];
                    }
                }
            }
            return idx;
        }
        static int[,] GetMatrix(int n)
        {
            Random rand = new Random();
            int[,] matrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = rand.Next(0, 9);
                }
            }
            return matrix;
        }
        static int[,] fillMatrix(int n)
        {
            int[,] matrix = new int[n, n];
            int k = n;
            for (int i = n - 1; i >= 0; i--, k--)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = k - j;
                }
            }
            for (int i = 0; i < n; i++, k++)
            {
                k = 1;
                for (int j = i+1; j < n; j++)
                {
                    matrix[i, j] = ++k;
                }
            }
            return matrix;
        }
        static void PrintMatrix(int[,] matrix, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int[,] swapCols (int[,] matrix, int n, int first, int second)
        {
            int[,] newMatrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                newMatrix[i, first] = matrix[i, second];
            }
            for (int i = 0; i < n; i++)
            {
                newMatrix[i, second] = matrix[i, first];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != first && i != second)
                        newMatrix[j, i] = matrix[j, i];
                }
            }
            return newMatrix;
        }
        static int[,] SwapLines(int[,] matrix, int n)
        {
            int minIdx = FindMinIdx(matrix, n);
            int maxIdx = FindMaxIdx(matrix, n);
            int[,] newMatrix = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                newMatrix[maxIdx, i] = matrix[minIdx, i];
            }
            for (int i = 0; i < n; i++)
            {
                newMatrix[minIdx, i] = matrix[maxIdx, i];
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (i != minIdx && i != maxIdx)
                        newMatrix[i, j] = matrix[i, j];
                }
            }
            return newMatrix;
        }
        static int[,] MatrixSort(int [,] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (arr[0, i] < arr[0, j])
                    {
                        arr = swapCols(arr, n, i, j);
                    }
                }
            }
            return arr;

        }
        static int SumTriangle(int[,] matrix, int n)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    sum += matrix[i, j];
                }
            }
            return sum;
        }
        
        static void Main(string[] args)
        {
            int n = 5;
            int[,] matrix = GetMatrix(n);

            PrintMatrix(matrix, n);
            Console.WriteLine();
            //Console.WriteLine(SumTriangle(matrix,n));
            //PrintMatrix(SwapLines(matrix, n), n);
            matrix = MatrixSort(matrix, n);
            //matrix = fillMatrix(5);
            //Console.WriteLine();
            PrintMatrix(matrix, n);

        }
    }
}
