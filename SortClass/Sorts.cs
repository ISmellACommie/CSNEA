using System.Diagnostics;

namespace SortClass
{
    public class Sorts
    {
        static readonly Stopwatch sw = new();

        public static (int[], long) BubbleSort(int[] arr) // uses "Tuples" to return 2 items (array of sorted values and time taken in ms)
        {
            // Start stopwatch
            sw.Start();

            // Begin sort
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        int temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }

            // Stop stopwatch
            sw.Stop();

            return (arr, sw.ElapsedMilliseconds);
        }

        public static (int[], long) InsertionSort(int[] arr)
        {
            // Start stopwatch
            sw.Start();

            // Begin sort
            for (int i = 1; i < arr.Length; i++)
            {
                int currentNumber = arr[i];
                int previousIndex = i - 1;

                while (previousIndex >= 0 && arr[previousIndex] > currentNumber)
                {
                    arr[previousIndex + 1] = arr[previousIndex];
                    previousIndex -= 1;
                }
                arr[previousIndex + 1] = currentNumber;
            }

            // Stop stopwatch
            sw.Stop();

            return (arr, sw.ElapsedMilliseconds);
        }
    }
}
