using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniaProgramistyczne.Okablowanie
{
    internal class Generator
    {
        public static int[] GenerateIntArray(int length, int maxValue, int minValue = 0)
        {
            var result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = Random.Shared.Next(minValue, maxValue);
            }
            return result;
        }
    }
}
