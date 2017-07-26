using System;

namespace LeetCode_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution solution = new Solution();

            int[] input = new int[10] { 7, 4, 5, 8, 8, 3, 9, 8, 7, 6 };

            double answer = solution.FindMaxAverage(input, 7);
            Console.WriteLine(answer);
        }
    }

    public class Solution
    {
        public double FindMaxAverage(int[] nums, int k)
        {
            double Max = 0;
            double MaxTemp = 0;

            for (int i = 0; i < k; i++)
            {
                Max += nums[i];
            }

            MaxTemp = Max;
            for (int i = 0; i + k < nums.Length; i++)
            {
                MaxTemp = MaxTemp - nums[i] + nums[i + k];

                if (MaxTemp > Max)
                    Max = MaxTemp;

                
            }

            double Average = Max / k;

            return Average;
        }
    }
}