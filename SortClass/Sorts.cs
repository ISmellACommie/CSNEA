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
            for (int j = 1; j < arr.Length; j++)
            {
                int nextElement = arr[j];
                int i = j - 1;
                while (i >= 0 && arr[i] > nextElement)
                {
                    arr[j] = arr[i];
                    i -= 1;
                }
                arr[i + 1] = nextElement;
            }


            // Stop stopwatch
            sw.Stop();

            return (arr, sw.ElapsedMilliseconds);
        }
    }
}
