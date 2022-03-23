using System;

namespace LeetCode
{

    public class Solution
    {

        public int RomanToInt(string s) {

            int sum = 0;

            //Trimming string
            if(s.Contains("IV"))
            {
                sum = sum+4;
                s = s.Replace("IV","");
            }
            if(s.Contains("IX"))
            {
                sum = sum+9;
                s = s.Replace("IX","");
            }
            if(s.Contains("XL"))
            {
                sum = sum+40;
                s = s.Replace("XL","");
            }
            if(s.Contains("XC"))
            {
                sum = sum+90;
                s = s.Replace("XC","");
            }
            if(s.Contains("CD"))
            {
                sum = sum+400;
                s = s.Replace("CD","");
            }
            if(s.Contains("CM"))
            {
                sum = sum+900;
                s = s.Replace("CM","");
            }

            //Leftover letters
            foreach(char x in s)
            {
                switch(x)
                {
                    case 'I':
                        sum = sum+1;
                        break;
                    case 'V':
                        sum = sum+5;
                        break;
                    case 'X':
                        sum = sum+10;
                        break;
                    case 'L':
                        sum = sum+50;
                        break;
                    case 'C':
                        sum = sum+100;
                        break;
                    case 'D':
                        sum = sum+500;
                     break;
                    case 'M':
                        sum = sum+1000;
                        break;
                    default:
                        Console.WriteLine("Not valid roman...");
                        break;
                }
            }
            
            return sum;
        }

        static void Main(string[] args)
        {
            Solution s = new Solution();
            string roman = "MCMXCIV";
            int val = s.RomanToInt(roman);

            Console.WriteLine("Roman To Val: " + val);
        }
    }

}



//PROBLEM
/*
Roman numerals are represented by seven different symbols: I, V, X, L, C, D and M.

Symbol       Value
I             1
V             5
X             10
L             50
C             100
D             500
M             1000
For example, 2 is written as II in Roman numeral, just two one's added together. 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.

Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. Instead, the number four is written as IV. 
Because the one is before the five we subtract it making four. 
The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

I can be placed before V (5) and X (10) to make 4 and 9. 
X can be placed before L (50) and C (100) to make 40 and 90. 
C can be placed before D (500) and M (1000) to make 400 and 900.
Given a roman numeral, convert it to an integer.

 

Example 1:

Input: s = "III"
Output: 3
Explanation: III = 3.
Example 2:

Input: s = "LVIII"
Output: 58
Explanation: L = 50, V= 5, III = 3.
Example 3:

Input: s = "MCMXCIV"
Output: 1994
Explanation: M = 1000, CM = 900, XC = 90 and IV = 4.
 

Constraints:

1 <= s.length <= 15
s contains only the characters ('I', 'V', 'X', 'L', 'C', 'D', 'M').
It is guaranteed that s is a valid roman numeral in the range [1, 3999].
*/