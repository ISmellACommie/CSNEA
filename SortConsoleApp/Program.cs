using System;
using SortClass;

namespace SortConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 78, 55, 45, 98, 13 };
            int[] arr = Misc.GenerateRandomIntArray(8000000, 0, 100000);
            var sorted = Sorts.InsertionSort(arr);
            Console.WriteLine($"{sorted.Item2} ms");
            foreach (int i in sorted.Item1)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();
        }
    }
}
