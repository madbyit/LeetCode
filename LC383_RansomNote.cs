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
            /// Given two strings ransomNote and magazine, return true if ransomNote can be constructed from magazine and false otherwise.
            /// Each letter in magazine can only be used once in ransomNote.
            /// </summary>
            /// <param name="ransomNote, magazine"></param>
            /// <returns>boolean value</returns>
            public bool CanConstruct(string ransomNote, string magazine) {

            if(string.IsNullOrEmpty(ransomNote)) 
                return true;

            // Create new Dictionary with char as key and int as value
            var dict = new Dictionary<char,int>();
            
            // Run through ransomNote and count each letter
            foreach (var c in ransomNote)
            {
                if(!dict.ContainsKey(c)) 
                    dict.Add(c,0);

                dict[c] +=1;
            }

            foreach (KeyValuePair<char,int> kvp in dict)
            {
                Console.WriteLine("RANSOMNOTE: Number of Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            // Run through magazine and erase each letter matching from ransomNote
            foreach(var c in magazine){
                if(dict.ContainsKey(c))
                {
                    dict[c] -=1;

                    if(dict[c] == 0) 
                        dict.Remove(c);

                    //If no more letters left from ransomeNote, then all is used == magazine can be constructed.
                    if(dict.Count == 0) 
                        return true;
                }
            }

            foreach (KeyValuePair<char,int> kvp in dict)
            {
                Console.WriteLine("RANSOMNOTE Number of leftover Key = {0}, Value = {1}", kvp.Key, kvp.Value);
            }

            return false;
        }


        static void Main(string[] args)
        {
            Solution s = new Solution();

            string ransomNote = "aaabgg";
            string magazine = "aaabb";

            string ransomNoteLower = ransomNote.ToLower();
            string magazineLower = magazine.ToLower();


            Console.WriteLine("Ransome Note can be constructed: " + s.CanConstruct(ransomNoteLower, magazineLower));
        }
            
    }

}



//PROBLEM
/*
Given two strings ransomNote and magazine, return true if ransomNote can be constructed from magazine and false otherwise.
Each letter in magazine can only be used once in ransomNote.

Example 1:
Input: ransomNote = "a", magazine = "b"
Output: false

Example 2:
Input: ransomNote = "aa", magazine = "ab"
Output: false

Example 3:
Input: ransomNote = "aa", magazine = "aab"
Output: true

Constraints:
1 <= ransomNote.length, magazine.length <= 105
ransomNote and magazine consist of lowercase English letters.

*/