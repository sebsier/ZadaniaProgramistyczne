using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadaniaProgramistyczne.Okablowanie;

namespace ZadaniaProgramistyczne._724_Find_Pivot_Index
{
    internal class PivotIndex
    {
        //Success
        //Runtime: 601 ms, faster than 14.28% of C# online submissions for Find Pivot Index.
        //Memory Usage: 41.3 MB, less than 22.66% of C# online submissions for Find Pivot Index.
        public int PivotIndexJeden(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var sumLeft = 0;
                var sumRight = 0;
                for (int j = 0; j < i; j++)
                {
                    sumLeft += nums[j];
                }

                for (int k = i + 1; k < nums.Length; k++)
                {
                    sumRight += nums[k];
                }

                if (sumLeft == sumRight)
                    return i;
            }
            return -1;
        }
        //Success
        //Runtime: 1693 ms, faster than 5.02% of C# online submissions for Find Pivot Index.
        //Memory Usage: 41.2 MB, less than 25.51% of C# online submissions for Find Pivot Index.
        public int PivotIndexDwa(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                var sumLeft = 0;
                var sumRight = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j < i)
                    {
                        sumLeft += nums[j];
                    }

                    if (nums.Length - j - 1 > i)
                    {
                        sumRight += nums[nums.Length - j - 1];
                    }
                }

                if (sumLeft == sumRight)
                    return i;
            }
            return -1;
        }

        //Success
        //Runtime: 341 ms, faster than 21.43% of C# online submissions for Find Pivot Index.
        //Memory Usage: 46 MB, less than 9.68% of C# online submissions for Find Pivot Index.
        public int PivotIndexTrzy(int[] nums)
        {
            var sumLeft = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                var sumRight = 0;
                for (int j = i + 1; j < nums.Length; j++)
                {
                    sumRight += nums[j];
                }
                if (sumLeft == sumRight) return i;
                sumLeft += nums[i];
            }
            return -1;
        }

        public int PivotIndexcCztery(int[] nums)
        {
            for (int i = nums.Length/2; i < nums.Length; i++)
            {

            }
            return -1;
        }

        public void Test()
        {
            var input = Generator.GenerateIntArray(12, 15, 1);

            Console.WriteLine(string.Join(" ", input));
            Console.WriteLine("-------------------------------------");

            //var result = PivotIndexJeden(input);
            var result = PivotIndexJeden(new int[] { 1, 2, 2, 3 });

            Console.WriteLine(result);
        }
    }
}
