using System;

namespace LeetCode
{
    /// <summary>
    /// Leetcode 1: Two Sum
    /// </summary>

        /// <summary>
        /// Given an array of integers nums and an integer target, 
        /// return indices of the two numbers such that they add up to target
        /// </summary>
        /// <param name="nums, target"></param>
        /// <returns>int array</returns>

    public class Solution
    {

        public int[] TwoSum(int[] nums, int target) 
        {
            int[] solution = new int[2];
            int sum = 0;
            bool isTarget = false;

            do{
                for (int i = 0; i < nums.Length-1; i++)
                {
                    for(int j = i+1; j < nums.Length; j++)
                    {
                        sum = nums[i]+nums[j];
                        if(sum == target)
                        {
                            solution[0] = i;
                            solution[1] = j;
                            isTarget = true;
                            break;
                        }
                    }

                    if(isTarget)
                    break;
                }
            }while(!isTarget);
            
            return solution;
        }

        /// <summary>
        /// Main to run program
        /// </summary>
        static void Main(string[] args)
        {
            Solution s = new Solution();

            int[] nums = {2,7,11,15};
            int target = 9;

            int[] arr = s.TwoSum(nums, target);

            Console.WriteLine("X1:" + arr[0] + " & X2:" + arr[1]);
        }
    }

}



//PROBLEM
// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
// You may assume that each input would have exactly one solution, and you may not use the same element twice.
// You can return the answer in any order.

// Example 1:
// Input: nums = [2,7,11,15], target = 9
// Output: [0,1]
// Explanation: Because nums[0] + nums[1] == 9, we return [0, 1].

// Example 2:
// Input: nums = [3,2,4], target = 6
// Output: [1,2]

// Example 3:
// Input: nums = [3,3], target = 6
// Output: [0,1]
 

// Constraints:
// 2 <= nums.length <= 104
// -109 <= nums[i] <= 109
// -109 <= target <= 109
// Only one valid answer exists.
 

// Follow-up: Can you come up with an algorithm that is less than O(n2) time complexity?