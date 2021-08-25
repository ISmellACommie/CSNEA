using System;
using SortClass;

namespace SortConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr = { 78, 55, 45, 98, 13 };
            /*int[] arr = Misc.GenerateRandomIntArray(100, 0, 100);
            var sorted = Sorts.InsertionSort(arr);
            Console.WriteLine($"{sorted.Item2} ms");
            foreach (int i in sorted.Item1)
            {
                Console.Write(i + " ");
            }
            Console.ReadKey();*/

            int[] arr = { 78, 55, 45, 98, 13 };
            //int[] arr = Misc.GenerateRandomIntArray(100, 0, 100);
            bool isInMenu = true;
            while (isInMenu == true)
            {
                string prompt = "Menu";
                string[] options = { "Bubble Sort", "Insertion Sort", "Exit" };
                int selectedIndex = Misc.CreateMenu(prompt, options);
                switch (selectedIndex)
                {
                    case 0:
                        {
                            var sort = Sorts.BubbleSort(arr);
                            Misc.PrintArray(sort.Item1, sort.Item2);
                            Console.WriteLine("\nPress any key to return to the menu.");
                            Console.ReadKey(true);
                            Console.Clear();
                            isInMenu = false;
                            break;
                        }
                    case 1:
                        {
                            var sort = Sorts.InsertionSort(arr);
                            Misc.PrintArray(sort.Item1, sort.Item2);
                            Console.WriteLine("\nPress any key to return to the menu.");
                            Console.ReadKey(true);
                            Console.Clear();
                            isInMenu = false;
                            break;
                        }
                    case 2:
                        {
                            isInMenu = false;
                            Console.WriteLine("\nPress any key to exit.");
                            Console.ReadKey(true);
                            Environment.Exit(0);
                            break;
                        }
                }
            }
        }
    }
}
