using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Solution
    {
    /// <summary>
    /// Leetcode 1672: Richest Customer Wealth
    /// </summary>

        /// <summary>
        /// You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank. 
        /// Return the wealth that the richest customer has.
        /// A customer's wealth is the amount of money they have in all their bank accounts. 
        /// The richest customer is the customer that has the maximum wealth.
        /// </summary>
        /// <param name="accounts"></param>
        /// <returns>int</returns>

        public int MaximumWealth(int[][] accounts) 
        {
            int nrOfAccounts = accounts.Length;
            int wealthOfRichest = 0;

            for(int i = 0; i < nrOfAccounts; i++)
            {
                int sum = 0;
                foreach(int j in accounts[i])
                {
                    sum += j;
                }

                if(sum > wealthOfRichest)
                    wealthOfRichest = sum;
            }

            return wealthOfRichest;
        }


        /// <summary>
        /// Main to run program
        /// </summary>
        static void Main(string[] args)
        {
            Solution s = new Solution();

        /*  A jagged array is:
            - an array whose elements are arrays, possibly of different sizes. 
            - sometimes called an "array of arrays." 
            - an array of arrays, and therefore its elements are reference types and are initialized to null. 
        */

            //Declaration of a single-dimensional array that has three elements, each of which is a single-dimensional array of integers
            int[][] jaggedArray = new int[3][];

            // Initialize the elements
            jaggedArray[0] = new int[] { 1, 5 }; // Account of the first customer
            jaggedArray[1] = new int[] { 7, 3 }; // Account of the second customer
            jaggedArray[2] = new int[] { 3, 5 }; // Account of the third customer
        
            int wealthOfRichest = s.MaximumWealth(jaggedArray);

            Console.WriteLine("The richest customer is: " + wealthOfRichest);
           
        }
    }

}



//PROBLEM
/*
You are given an m x n integer grid accounts where accounts[i][j] is the amount of money the i​​​​​​​​​​​th​​​​ customer has in the j​​​​​​​​​​​th​​​​ bank. Return the wealth that the richest customer has.
A customer's wealth is the amount of money they have in all their bank accounts. The richest customer is the customer that has the maximum wealth.


Example 1:
Input: accounts = [[1,2,3],[3,2,1]]
Output: 6
Explanation:
1st customer has wealth = 1 + 2 + 3 = 6
2nd customer has wealth = 3 + 2 + 1 = 6
Both customers are considered the richest with a wealth of 6 each, so return 6.

Example 2:
Input: accounts = [[1,5],[7,3],[3,5]]
Output: 10
Explanation: 
1st customer has wealth = 6
2nd customer has wealth = 10 
3rd customer has wealth = 8
The 2nd customer is the richest with a wealth of 10.

Example 3:
Input: accounts = [[2,8,7],[7,1,3],[1,9,5]]
Output: 17
 

Constraints:
m == accounts.length
n == accounts[i].length
1 <= m, n <= 50
1 <= accounts[i][j] <= 100

*/