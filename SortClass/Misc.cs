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
    }
}
