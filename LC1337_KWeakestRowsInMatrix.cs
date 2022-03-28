using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public class Solution
    {
    /// <summary>
    /// Leetcode 1337: The K Weakest Rows in a Matrix
    /// </summary>

        /// <summary>
        /// A row i is weaker than a row j if one of the following is true:
        /// The number of soldiers in row i is less than the number of soldiers in row j.
        /// Both rows have the same number of soldiers and i < j.
        /// Return the indices of the k weakest rows in the matrix ordered from weakest to strongest.
        /// </summary>
        /// <param name="mat,k"></param>
        /// <returns>int array</returns>

        public int[] KWeakestRows(int[][] mat, int k)
        {
            var rows = new List<KeyValuePair<int, int>>();
            
            int nrOfRows = mat.Length;
            int[] weakestRowsTmp = new int[nrOfRows];
            int[] weakestRows = new int[k];
            
            
            for (int i = 0; i < nrOfRows; i++)
            {
                int sum = mat[i].Sum(); //Sum the values, like this: row 0 = 1+1+0+0+0 = 2, for each rows!
                rows.Add(new KeyValuePair<int, int>(i, sum)); //Add to dictionary, key = row number
            }

            //Sort dictionary by value
            var sortedDict = from entry in rows orderby entry.Value ascending select entry; 

            //Create a temporary int array with the row numbers in order 
            int j = 0;
            foreach(var x in sortedDict)
            {
                Console.WriteLine(x);
                weakestRowsTmp[j] = x.Key;
                j++;
            }

            //Poulate int array with k number of rows
            for(int a = 0; a<k; a++)
            {
                weakestRows[a] = weakestRowsTmp[a];
            }

            return weakestRows;
        }

    

        /// <summary>
        /// Main to run program
        /// </summary>
        static void Main(string[] args)
        {
            Solution s = new Solution();
            int k = 5;

        /*  A jagged array is:
            - an array whose elements are arrays, possibly of different sizes. 
            - sometimes called an "array of arrays." 
            - an array of arrays, and therefore its elements are reference types and are initialized to null. 
        */

            //Declaration of a single-dimensional array that has five elements, each of which is a single-dimensional array of integers
            int[][] jaggedArray = new int[5][];

            // Initialize the elements
            jaggedArray[0] = new int[] { 1, 1, 0, 0, 0 };
            jaggedArray[1] = new int[] { 1, 1, 1, 1, 0 };
            jaggedArray[2] = new int[] { 1, 0, 0, 0, 0 };
            jaggedArray[3] = new int[] { 1, 1, 0, 0, 0 };
            jaggedArray[4] = new int[] { 1, 1, 1, 1, 1 };

            int[] arr = s.KWeakestRows(jaggedArray, k);

            Console.WriteLine("The {0} rows ordered from weakest to strongest are: ", k);
            for(int i = 0; i< arr.Length; i++)
            {
                 Console.WriteLine("{0}: {1}" , i+1, arr[i]);
            }
        }
    }

}



//PROBLEM
/*
You are given an m x n binary matrix mat of 1's (representing soldiers) and 0's (representing civilians). 
The soldiers are positioned in front of the civilians. That is, all the 1's will appear to the left of all the 0's in each row.

A row i is weaker than a row j if one of the following is true:

The number of soldiers in row i is less than the number of soldiers in row j.
Both rows have the same number of soldiers and i < j.
Return the indices of the k weakest rows in the matrix ordered from weakest to strongest.

 

Example 1:
Input: mat = 
[[1,1,0,0,0],
 [1,1,1,1,0],
 [1,0,0,0,0],
 [1,1,0,0,0],
 [1,1,1,1,1]], 
k = 3
Output: [2,0,3]

Explanation: 
The number of soldiers in each row is: 
- Row 0: 2 
- Row 1: 4 
- Row 2: 1 
- Row 3: 2 
- Row 4: 5 
The rows ordered from weakest to strongest are [2,0,3,1,4].

Example 2:
Input: mat = 
[[1,0,0,0],
 [1,1,1,1],
 [1,0,0,0],
 [1,0,0,0]], 
k = 2
Output: [0,2]

Explanation: 
The number of soldiers in each row is: 
- Row 0: 1 
- Row 1: 4 
- Row 2: 1 
- Row 3: 1 
The rows ordered from weakest to strongest are [0,2,3,1].
 

Constraints:

m == mat.length
n == mat[i].length
2 <= n, m <= 100
1 <= k <= m
matrix[i][j] is either 0 or 1.

*/