using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
    internal class RunningSum
    {
        public int[] RunningSumJeden(int[] nums)
        {
            var result = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                if (i == 0) { result[i] = nums[i]; continue; }

                result[i] = result[i - 1] + nums[i];
            }

            return result;
        }



        //Success

        //Runtime: 158 ms, faster than 83.18% of C# online submissions for Running Sum of 1d Array.
        //Memory Usage: 41.9 MB, less than 22.69% of C# online submissions for Running Sum of 1d Array.

        public int[] RunningSumDwa(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i - 1] + nums[i];
            }
            return nums;
        }

        public void Test()
        {
            var length = Random.Shared.Next(1, 10);
            var input = Generator.GenerateIntArray(length, 1000, 1);
            
            Console.WriteLine(string.Join(' ', input));

            //var result = RunningSumJeden(input);
            var result = RunningSumDwa(input);


            Console.WriteLine("---------------------------------------------------------------------------------------------------------");
            Console.WriteLine(string.Join(' ', result));
        }
    }
}
