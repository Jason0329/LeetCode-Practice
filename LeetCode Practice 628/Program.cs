using System;

namespace LeetCode_Practice_628
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] input = new int[5] { -4,-3,-2,-1,60 };

            double answer = solution.MaximumProduct(input);
            Console.WriteLine(answer);
        }
    }

    public class Solution
    {
        public int MaximumProduct(int[] nums)
        {
            Array.Sort(nums);

            return Math.Max(nums[0] * nums[1] * nums[nums.Length-1], nums[nums.Length - 1]* nums[nums.Length - 2]* nums[nums.Length - 3]);
        }
    }
}