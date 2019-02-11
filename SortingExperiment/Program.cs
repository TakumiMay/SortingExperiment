using SortingExperiment;
using System;
using System.Diagnostics;

namespace ConsoleApp2
{
     public class Program
    {
       static void Main(string[] args)
        {
            //int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            int[] arr = createArr(1000, false, true, 0, 1100);

            Console.WriteLine("Original array : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            // QuickSort.sort(arr, 0, arr.Length - 1);
            Stopwatch sw = new Stopwatch();
            sw.Start();
            HeapSort.sort(arr);
            sw.Stop();

            Console.WriteLine();
            Console.WriteLine("Sorted array : ");

            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            Console.WriteLine("Time elapsed (ms): {0}", sw.Elapsed.TotalMilliseconds );

        }

        static int[] createArr(int size, bool ascOrder, bool random, int min, int max)
        {
            int[] arr = new int[size];
            if (random)
            {
                Random randomN = new Random();
                for (int i = 0; i < size; i++)
                {
                    int randomNumber = randomN.Next(min, max);
                    arr[i] = randomNumber;
                }
            }
            else
            {
                Random randomN = new Random();
                int randomNumber = randomN.Next(min, max);
                arr[0] = randomNumber;
                if (ascOrder)
                {
                    for (int i = 1; i < size; i++)
                    {
                        randomNumber++;
                        arr[i] = randomNumber;
                    }
                }
                else
                {
                    for (int i = 1; i < size; i++)
                    {
                        randomNumber--;
                        arr[i] = randomNumber;
                    }
                }
            }
            return arr;
        }
    }
}
