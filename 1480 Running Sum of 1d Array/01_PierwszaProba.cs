using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZadaniaProgramistyczne.Okablowanie;

namespace ZadaniaProgramistyczne._1480_Running_Sum_of_1d_Array
{
    //Success
    //
    //Runtime: 158 ms, faster than 83.18% of C# online submissions for Running Sum of 1d Array.
    //Memory Usage: 43.2 MB, less than 6.45% of C# online submissions for Running Sum of 1d Array.
    internal class PierwszaProba : ITestable<int[]>
    {
        public int[] RunningSum(int[] nums)
        {
            var result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0) { result[i] = nums[i]; continue; }

                result[i] = result[i - 1] + nums[i];
            }

            return result;
        }
        public string Test(int[] nums)
        {
            var obiekt = new PierwszaProba();
            var result = "";
            foreach (int i in nums) result += i + " ";
            return 
        }

        int[] Test(int[] input)
        {
            throw new NotImplementedException();
        }

        public int[] WygenerujDaneWejsciowe()
        {
            throw new NotImplementedException();
        }
    }
}
