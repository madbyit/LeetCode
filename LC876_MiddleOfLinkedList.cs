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
        /// Given the head of a singly linked list, return the middle node of the linked list.
        /// If there are two middle nodes, return the second middle node.
        /// </summary>
        /// <param name="head"></param>
        /// <returns>boolean value</returns>
        public ListNode MiddleNode(ListNode head) {

            if(head == null) 
                return null;
            
            var fast = head;
            var slow = head;
        
            while((fast !=null) && (fast.next != null))
            {
                // Each time 'fast' goes its two steps, 'slow' will increase with half(!) speed
                Console.WriteLine("FAST: {0} | SLOW: {1} ", fast.val , slow.val);
                fast = fast.next.next;
                slow = slow.next;
            }
            Console.WriteLine("FAST: {0} | SLOW: {1} ", fast.val , slow.val);
        
        return slow;
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

        static void Main(string[] args)
        {
            Solution s = new Solution();

            //Build up the linked list with each nodes
            var head = new ListNode(1); //node1 = head
            var node2 = new ListNode(2);
            var node3 = new ListNode(3);
            var node4 = new ListNode(4);
            var node5 = new ListNode(5);
            var node6 = new ListNode(6);
            var node7 = new ListNode(7);
            var node8 = new ListNode(8);
            var node9 = new ListNode(9);


            head.next = node2;
            node2.next = node3;
            node3.next = node4;
            node4.next = node5;
            node5.next = node6;
            node6.next = node7;
            node7.next = node8;
            node8.next = node9;
            Console.WriteLine("Middle, or second middle is: " + s.MiddleNode(head).val);
        }
    }

}



//PROBLEM
/*
Given the head of a singly linked list, return the middle node of the linked list.

If there are two middle nodes, return the second middle node.

Example 1:
Input: head = [1,2,3,4,5]
Output: [3,4,5]
Explanation: The middle node of the list is node 3.

Example 2:
Input: head = [1,2,3,4,5,6]
Output: [4,5,6]
Explanation: Since the list has two middle nodes with values 3 and 4, we return the second one.
 
Constraints:
The number of nodes in the list is in the range [1, 100].
1 <= Node.val <= 100

*/