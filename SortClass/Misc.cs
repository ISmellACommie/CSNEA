using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortClass
{
    public class Misc
    {
        public static int[] GenerateRandomIntArray(int size, int minNum, int maxNum)
        {
            int[] randomArr = new int[size];
            Random rnd = new Random();

            for (int i = 0; i < randomArr.Length; i++)
            {
                randomArr[i] = rnd.Next(minNum, maxNum);
            }

            return randomArr;
        }
    }
}
