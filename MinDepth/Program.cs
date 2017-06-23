using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinDepth
{
    class Program
    {
        private static readonly int levelIdentifier = Int32.MaxValue;
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            TreeNode root_left = new TreeNode(2);
            TreeNode root_right = new TreeNode(3);
            root.left = root_left;
            root.right = root_right;
            TreeNode root_left_left = new TreeNode(4);
            TreeNode root_left_right = new TreeNode(5);
            root.left.left = root_left_left;
            root.left.right = root_left_right;
            TreeNode root_right_left = new TreeNode(6);
            TreeNode root_right_right = new TreeNode(7);
            root.right.left = root_right_left;
            root.right.right = root_right_right;
            TreeNode root_left_left_left = new TreeNode(8);
            TreeNode root_left_left_right = new TreeNode(9);
            root.left.left.left = root_left_left_left;
            root.left.left.right = root_left_left_right;
            TreeNode root_left_right_left = new TreeNode(10);
            TreeNode root_left_right_right = new TreeNode(11);
            root.left.right.left = root_left_right_left;
            root.left.right.right = root_left_right_right;
            TreeNode root_right_right_left = new TreeNode(12);
            TreeNode root_right_right_right = new TreeNode(13);
            root.right.right.left = root_right_right_left;
            root.right.right.right = root_right_right_right;
            Console.WriteLine(MinDepth(root));
            Console.Read();
        }

        public static int MinDepth(TreeNode root)
        {
            if (root == null) return 0;
            int levelCounter = 1;
            if (IsLeaf(root)) return levelCounter;
            Queue<TreeNode> q = new Queue<TreeNode>();
            if (root.left != null)
            {
                q.Enqueue(root.left);
            }
            if (root.right != null)
            {
                q.Enqueue(root.right);
            }
            q.Enqueue(new TreeNode(levelIdentifier));
            levelCounter++;
            while (q.Count > 0)
            {
                TreeNode first = q.Dequeue();
                if (IsLevelIdentifier(first))
                {
                    q.Enqueue(first);
                    levelCounter++;
                    continue;
                }
                if (IsLeaf(first))
                {
                    return levelCounter;
                }
                if (first.left != null)
                {
                    q.Enqueue(first.left);
                }
                if (first.right != null)
                {
                    q.Enqueue(first.right);
                }
            }
            return levelCounter;
        }

        private static bool IsLevelIdentifier(TreeNode first)
        {
            return first.val == levelIdentifier;
        }

        public static bool IsLeaf(TreeNode n)
        {
            return n.left == null && n.right == null;
        }
    }
}
