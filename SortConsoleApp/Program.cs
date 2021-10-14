using static SortClass.Sorts;
using static SortClass.Misc;
using static System.Console;
using static System.Environment;

namespace SortConsoleApp
{
    class Program
    {
        static void Main()
        {
            //int[] arr = { 78, 55, 45, 98, 13 };
            int[] arr = GenerateRandomIntArray(10000, 0, 100);
            bool isInMenu = true;
            string prompt = @"
   _____ _                                                      _   _             
  / ____| |                                                    | | (_)            
 | |    | |__   ___   ___  ___  ___    __ _ _ __     ___  _ __ | |_ _  ___  _ __  
 | |    | '_ \ / _ \ / _ \/ __|/ _ \  / _` | '_ \   / _ \| '_ \| __| |/ _ \| '_ \ 
 | |____| | | | (_) | (_) \__ \  __/ | (_| | | | | | (_) | |_) | |_| | (_) | | | |
  \_____|_| |_|\___/ \___/|___/\___|  \__,_|_| |_|  \___/| .__/ \__|_|\___/|_| |_|
                                                         | |                      
                                                         |_|                      ";
            string[] options = { "Bubble Sort", "Insertion Sort", "Exit" };
            while (isInMenu)
            {
                switch (CreateMenu(prompt, options))
                {
                    case 0:
                        {
                            PrintArray(BubbleSort(arr), stopWatchTime);
                            WriteLine("\nPress any key to return to the menu.");
                            ReadKey(true);
                            Clear();
                            break;
                        }
                    case 1:
                        {
                            PrintArray(InsertionSort(arr), stopWatchTime);
                            WriteLine("\nPress any key to return to the menu.");
                            ReadKey(true);
                            Clear();
                            break;
                        }
                    case 2:
                        {
                            isInMenu = !isInMenu;
                            Exit(0);
                            break;
                        }
                }
            }
        }
    }
}
