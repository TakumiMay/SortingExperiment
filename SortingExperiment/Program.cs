using SortingExperiment;
using System;

namespace ConsoleApp2
{
     public class Program
    {
       static void Main(string[] args)
        {
            //int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };
            int[] arr = createArr(10, false, true, 10, 29);

            Console.WriteLine("Original array : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            // QuickSort.sort(arr, 0, arr.Length - 1);
            HeapSort.sort(arr);

            Console.WriteLine();
            Console.WriteLine("Sorted array : ");

            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
            

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
