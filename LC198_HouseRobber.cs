using System;

namespace LeetCode
{
    /// <summary>
    /// Leetcode 198: House Robber
    /// </summary>

        /// <summary>
        /// Given an integer array nums representing the amount of money of each house, 
        /// return the maximum amount of money you can rob tonight without alerting the police.
        /// <param name="nums"></param>
        /// <returns>int</returns>

    public class Solution
    {

        public int Rob(int[] nums) {

            // Create a new int array with an extra slot/index to store
            var control = new int[nums.Length+1];
            int max = 0;
        
            // Init first control index with a zero to use count first sum
            control[0] = 0;
 
            // Set control starting point at index 1
            control[1] = nums[0];

            for(int i=1;i<nums.Length;i++)
            {
                // Control what is max of: current value or previous integer 0 next.
                // Store the new max in next control index for try nex compare
                control[i+1] = Math.Max(control[i], nums[i] + control[i-1]);
            }
        
            // Max value is now stored in the last index of control
            max = control[nums.Length];
        
            return max;
        }

            /// <summary>
            /// Main to run program
            /// </summary>
            static void Main(string[] args)
            {
                Solution s = new Solution();

                int[] nums = new int[] { 1, 2, 3, 1}; //4
                int[] nums2 = new int[] { 2, 7, 9, 3, 1 }; // 12
                int[] nums3 = new int[] { 5, 7, 1, 1, 7, 1, 1 }; //15
                int[] nums4 = new int[] { 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 3, 5 }; //27
                int[] nums5 = new int[] { 2, 1, 1, 2}; //4

                int sum = s.Rob(nums4);

                Console.WriteLine("Max total sum: " + sum);
            }
        }

}



/*PROBLEM
You are a professional robber planning to rob houses along a street. 
Each house has a certain amount of money stashed, the only constraint stopping you from robbing each of them 
is that adjacent houses have security systems connected and it will automatically contact the police if two adjacent houses were broken into on the same night.

Given an integer array nums representing the amount of money of each house, 
return the maximum amount of money you can rob tonight without alerting the police.

 

Example 1:
Input: nums = [1,2,3,1]
Output: 4
Explanation: Rob house 1 (money = 1) and then rob house 3 (money = 3).
Total amount you can rob = 1 + 3 = 4.
Example 2:

Input: nums = [2,7,9,3,1]
Output: 12
Explanation: Rob house 1 (money = 2), rob house 3 (money = 9) and rob house 5 (money = 1).
Total amount you can rob = 2 + 9 + 1 = 12.
 

Constraints:
1 <= nums.length <= 100
0 <= nums[i] <= 400


Explaination of my solution:

// Example: [ 5, 6, 7, 8, 9, 0, 0, 0, 0, 1, 3, 5 ] //27
// i: x val: 0 
// i: 0 val: 5
// i: 1 val: 6 || Math.Max( 5, (6 + 0) ) = 6 
// i: 2 val: 7 || Math.Max( 6, (7 + 5) ) = 12 
// i: 3 val: 8 || Math.Max( 12, (8 + 6) ) = 14 
// i: 4 val: 9 || Math.Max( 14, (9 + 12) ) = 21 
// i: 5 val: 0 || Math.Max( 21, (0 + 14) ) = 21 
// i: 6 val: 0 || Math.Max( 21, (0 + 21) ) = 21 
// i: 7 val: 0 || Math.Max( 21, (0 + 21) ) = 21 
// i: 8 val: 0 || Math.Max( 21, (0 + 21) ) = 21 
// i: 9 val: 1 || Math.Max( 21, (1 + 21) ) = 22 
// Console.WriteLine("i: {0} val: {1} || Math.Max( {2}, ({3} + {4}) ) = {5} ", i, nums[i], control[i], nums[i], control[i-1], control[i+1]);
*/