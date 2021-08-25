using System;

namespace SortClass
{
    public class Misc
    {
        public static int[] GenerateRandomIntArray(int size, int minNum, int maxNum)
        {
            int[] randomArr = new int[size];
            Random rnd = new();

            for (int i = 0; i < randomArr.Length; i++)
            {
                randomArr[i] = rnd.Next(minNum, maxNum);
            }

            return randomArr;
        }

        public static void PrintArray(int[] arr, long timeTaken)
        {
            Console.WriteLine($"The sort took {timeTaken} ms to complete.");
            foreach (int i in arr)
            {
                Console.Write($"[{i}]");
            }
        }

        public static int CreateMenu(string prompt, string[] options)
        {
            int selectedIndex = 0;
            ConsoleKey keyPressed;
            do
            {
                Console.Clear();
                Console.WriteLine(prompt);

                for (int i = 0; i < options.Length; i++)
                {
                    string currentOption = options[i];
                    string prefix;

                    if (i == selectedIndex)
                    {
                        prefix = "=>";
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        prefix = " ";
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.BackgroundColor = ConsoleColor.Black;
                    }

                    Console.WriteLine($"{prefix} <<{currentOption}>>");
                }
                Console.ResetColor();

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                keyPressed = keyInfo.Key;

                // Update selectedIndex based on arrow keys.
                if (keyPressed == ConsoleKey.UpArrow)
                {
                    selectedIndex--;
                    if (selectedIndex == -1)
                    {
                        selectedIndex = options.Length - 1;
                    }
                }
                else if(keyPressed == ConsoleKey.DownArrow)
                {
                    selectedIndex++;
                    if (selectedIndex == options.Length)
                    {
                        selectedIndex = 0;
                    }
                }
            } 
            while (keyPressed != ConsoleKey.Enter);
            
            return selectedIndex;
        }
    }
}
