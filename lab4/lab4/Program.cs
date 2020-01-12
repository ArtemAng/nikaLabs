
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    class Program
    {

        static void GetDifferent(int[] arr)
        {
            Array.Sort(arr);
            string str = "";
            foreach (var item in arr)
            {
                str += item;
            }
            for (int i = 0; i < str.Length; i++)
            {
                if (str.LastIndexOf(str[i]) != i)
                {
                    str = str.Replace(str[i].ToString(), "");

                }
            }
            Console.WriteLine(str);
        }
        static void GetDifferent1(int[] arr)
        {
            //Array.Sort(arr);
            int count = 0;
            int[] arr1 = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                arr1[i] = count;
                count = 0;
            }
            Print(arr1);



        }
        static int[] SdvigKrishi(int[] arr, int k)
        {
            int[] newarr = new int[arr.Length];
            int tmp;
            for (int i = 0; i < k; i++)
            {
                tmp = arr[arr.Length - 1];
                Array.Copy(arr, 0, newarr, 1, arr.Length - 1);
                newarr[0] = tmp;
                arr = newarr;
            }
            return arr;
        }

        static void Print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        static void PrintPositiveNonZero(int[] arr)
        {
            foreach (var item in arr)
            {
                if (item > 0 && item % 2 == 0)
                {
                    Console.WriteLine(item);
                }
                if (item == 0)
                {
                    Console.WriteLine(0);
                    break;
                }
            }
        }

        static int SumBetweenKandL(int[] arr, int k, int l)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (i <= k || i >= l)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        static (int[], int[]) SwapArrays(int[] A, int[] B)
        {
            int tmp;
            for (int i = 0; i < A.Length; i++)
            {
                tmp = A[i];
                A[i] = B[i];
                B[i] = tmp;
            }
            return (A, B);
        }

        static int[] DeleteNotEvenId(int[] A)
        {
            int[] arr = new int[A.Length / 2 + 1];
            for (int i = 0, j = 0; i < A.Length; i+=2)
            {

                arr[j] = A[i];
                j++;

            }
            return arr;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[5] { 1, 2, 3, 4, 5 };
            int[] newarr = new int[5];
            //GetDifferent(arr);
            //Print(SdvigKrishi(arr, 2));
            //PrintPositiveNonZero(arr);
            //Console.WriteLine(SumBetweenKandL(arr, 0,3));
            Print(DeleteNotEvenId(arr));
            //(int[] A, int[] B) = SwapArrays(new int[5] { 1, 2, 3, 4, 5 }, new int[5] { 6, 7, 8, 9, 0 });
            //Print(A);
            //Print(B);

        }
    }
}
