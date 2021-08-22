using System;
using System.Diagnostics;

namespace SortClass
{
    public class Sorts
    {
        public static (int[], long) BubbleSort(int[] arr)
        {
            Stopwatch sw = new();
            sw.Start();

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

            sw.Stop();
            long timeTakenMS = sw.ElapsedMilliseconds;

            return (arr, timeTakenMS);
        }
    }
}
