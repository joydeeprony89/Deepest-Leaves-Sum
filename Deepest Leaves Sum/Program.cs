using System;
using System.Collections.Generic;

namespace Deepest_Leaves_Sum
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }
  }

  /**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
  public class Solution
  {
    // https://leetcode.com/problems/deepest-leaves-sum/submissions/
    public int DeepestLeavesSum(TreeNode root)
    {
      // deepest leaves are present in the last level
      // we need to do level order, will return the final sum in the last level
      // BFS 
      int sum = 0;
      Queue<TreeNode> q = new Queue<TreeNode>();
      q.Enqueue(root);
      while (q.Count > 0)
      {
        int size = q.Count;
        // when a new level start reset the sum
        sum = 0;
        while (size-- > 0)
        {
          var node = q.Dequeue();
          sum += node.val;
          if (node.left != null) q.Enqueue(node.left);
          if (node.right != null) q.Enqueue(node.right);
        }
      }
      return sum;
    }
  }
}
