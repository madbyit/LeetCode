using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Solution
    {
        /// <summary>
        /// Leetcode 383 Ransome Note 
        /// </summary>

            /// <summary>
            /// Given an integer n, return a string array answer (1-indexed) where:
            /// answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
            /// answer[i] == "Fizz" if i is divisible by 3.
            /// answer[i] == "Buzz" if i is divisible by 5.
            /// answer[i] == i (as a string) if none of the above conditions are true.
            /// </summary>
            /// <param name="n"></param>
            /// <returns>string array</returns>
        public IList<string> FizzBuzz(int n) 
        {

            /* 
            NOTE: 
            The main difference between List and IList in C# is that List is a class that represents a list of objects which can be accessed by index 
            while IList is an interface that represents a collection of objects which can be accessed by index.
            */
            IList<string> fizzbuzz_lst = new List<string>();
            
            for(int i = 1; i <= n; i++)
            {
                if((i % 3 == 0) && (i % 5 == 0))
                    fizzbuzz_lst.Add("FizzBuzz");
                else if(i % 3 == 0 )
                    fizzbuzz_lst.Add("Fizz");
                else if(i % 5 == 0)
                    fizzbuzz_lst.Add("Buzz");
                else
                    fizzbuzz_lst.Add(i.ToString());
            }
            
            return fizzbuzz_lst;
        }

        static void Main(string[] args)
        {
            Solution s = new Solution();

            int tstval = 15;
            IList<string> tstlist = s.FizzBuzz(tstval);

            foreach(string fb in tstlist)
            {
                Console.WriteLine(fb);
            }
        }
    }
}



//PROBLEM
/*
Given an integer n, return a string array answer (1-indexed) where:

answer[i] == "FizzBuzz" if i is divisible by 3 and 5.
answer[i] == "Fizz" if i is divisible by 3.
answer[i] == "Buzz" if i is divisible by 5.
answer[i] == i (as a string) if none of the above conditions are true.
 

Example 1:

Input: n = 3
Output: ["1","2","Fizz"]
Example 2:

Input: n = 5
Output: ["1","2","Fizz","4","Buzz"]
Example 3:

Input: n = 15
Output: ["1","2","Fizz","4","Buzz","Fizz","7","8","Fizz","Buzz","11","Fizz","13","14","FizzBuzz"]
 

Constraints:

1 <= n <= 104
*/