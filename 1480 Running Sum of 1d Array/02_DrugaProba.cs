using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadaniaProgramistyczne._1480_Running_Sum_of_1d_Array
{
    public class DrugaProba
    {
        public int[] RunningSum(int[] nums)
        {
            for (int i = 1; i < nums.Length; i++)
            {
                nums[i] = nums[i - 1] + nums[i];
            }
            return nums;
        }
    }
}
