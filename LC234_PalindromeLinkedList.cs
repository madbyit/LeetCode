using System;
using System.Collections.Generic;

namespace LeetCode
{
    public class Solution
    {
    /// <summary>
    /// Leetcode 234 Palindrome linked list 
    /// Could you do it in O(n) time and O(1) space?
    /// </summary>

        /// <summary>
        /// Design function using three APIs
        /// 1. get length of linked list
        /// 2. reverse linked list
        /// 3. get nmbr:th/other half of linked list node
        /// 4. compare
        /// </summary>
        /// <param name="head"></param>
        /// <returns>boolean value</returns>
        public bool IsPalindrome(ListNode head)
        {
            bool result = false;

            if(head == null)
                return true;

            if(head.next == null)
                return true;

            // 1.
            int length = GetLinkedListLength(head);

            //Is it even or odd list length
            bool isEven = length % 2 == 0;
            Console.WriteLine("EVEN = " + isEven);

            /*Split linked list in two parts*/
            
            //Set front part
            var front = GetNodeGivenNmbr(head, length/ 2);
            //If not even, get next node 
            if (!isEven)
            {
                front = front.next;
            }

            //Set back part
            var back = head;

            //Get reversed list of the front part
            var reversed = ReverseLinkedList(front);

            //Compare the two linked list
            result = Compare(reversed, back, length);        
            
            return result;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int val=0, ListNode next=null) {
                this.val = val;
                this.next = next;
            }
        }

        // 1. Get length
        /// <summary>
        /// Get length of the linked list
        /// </summary>
        /// <param name="head"></param>
        private int GetLinkedListLength(ListNode head)
        {
            if(head == null)
                return 0;

            int length = 0;
            var iterate = head;

            do
            {
                length++;
                iterate = iterate.next;
            }while(iterate != null);

            Console.WriteLine("LENGTH: " + length);
            return length;
        }

        // 2. Reverse the linked list
        /// <summary>
        /// Reverse a linked list using O(N) time and O(1) space
        /// </summary>
        /// <param name="head"></param>
         private ListNode ReverseLinkedList(ListNode head)
         {
            if (head == null)
                return null;
            if (head.next == null)
                return head;

            //Get next and call itself again with next in linked list until it is null
            var next = head.next;
            var reversed = ReverseLinkedList(next);

            //Reset values
            head.next = null;
            next.next = head;

            return reversed;
         }


        // 3. Iterate through the other side linked list node
        private ListNode GetNodeGivenNmbr(ListNode head, int nmbr)
        {
            if (nmbr == 0)
                return head;

            int index = 0;
            var iterate = head;

            do
            {
                iterate = iterate.next;
                index++;
            }while(index < nmbr);

            return iterate;
        }

        // 4. Compare two linked list, one element at time 
        private bool Compare(ListNode reversed, ListNode back, int length)
        {
            bool isPalindrom = true;
            
            var index = 0;
            while (index < length / 2)
            {
                if (back.val != reversed.val)
                    isPalindrom = false;

                back = back.next;
                reversed = reversed.next;
                index++;
            }

            return isPalindrom;
        }


        static void Main(string[] args)
        {
            Solution s = new Solution();

            //Build up the linked list with each nodes
            var head = new ListNode(1); //node1 = head
            var node2 = new ListNode(2);
            var node3 = new ListNode(2);
            var node4 = new ListNode(3);

            head.next = node2;
            node2.next = node3;
            node3.next = node4;

            Console.WriteLine("IsPalindrom: " + s.IsPalindrome(head));
        }
            
    }

}



//PROBLEM
/*
Given the head of a singly linked list, return true if it is a palindrome.


Example 1:
Input: head = [1,2,2,1]
Output: true

Example 2:
Input: head = [1,2]
Output: false

Constraints:

The number of nodes in the list is in the range [1, 105].
0 <= Node.val <= 9

Follow up: Could you do it in O(n) time and O(1) space?


    Definition for singly-linked list.
    public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
        }
    }

*/