using System;
using SortClass;

namespace SortConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 78, 55, 45, 98, 13 };
            int[] arr = Misc.GenerateRandomIntArray(800, 0, 100000);
            var BubbleSort = Sorts.BubbleSort(arr);
            Console.WriteLine($"The bubble sort took {BubbleSort.Item2} milliseconds");
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
