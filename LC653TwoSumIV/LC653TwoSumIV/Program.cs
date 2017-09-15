using System;
using System.Collections.Generic;

namespace LC653TwoSumIV
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int x) { val = x; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            TreeNode t = new TreeNode(5);            
            t.left = new TreeNode(3);
            t.right = new TreeNode(6);
            t.left.left = new TreeNode(2);
            t.left.right = new TreeNode(4);
            t.right.right = new TreeNode(7);

            Program p = new Program();
            Console.WriteLine(p.FindTarget(t, 9));
            Console.WriteLine(p.FindTarget(t, 28));
            Console.WriteLine(p.FindTarget(t, 0));
            Console.WriteLine(p.FindTarget(t, -3));

            Console.ReadLine();
        }

        public TreeNode GenerateTree(int[] nodes)
        {
            TreeNode parent = null, left = null, right = null;
            parent = new TreeNode(nodes[0]);

            TreeNode root = parent;

            for (int i = 1; i < nodes.Length; i++)
            {
                if (i != int.MinValue)
                {
                    left = new TreeNode(nodes[i]);
                }

                if (i != int.MinValue && (i+1)<=nodes.Length)
                {
                    right = new TreeNode(nodes[i + 1]);
                }

                parent.left = left;
                parent.right = right;
                
            }

            return root;
        }

        public bool FindTarget(TreeNode root, int k)
        {
            if (k < 0)
                return false;

            HashSet<int> set = Program.BFS(root);
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            TreeNode temp = null;
            
            while (queue.Count > 0)
            {
                temp = queue.Dequeue();
                if (k > temp.val)
                    if (set.Contains(k - temp.val))
                        return true;
                    else
                        if (set.Contains(temp.val - k))
                            return true;

                if (temp.left != null)
                    queue.Enqueue(temp.left);
                if (temp.right != null)
                    queue.Enqueue(temp.right);
            }

            return false;
        }

        public static HashSet<int> BFS(TreeNode root)
        {
            HashSet<int> set = new HashSet<int>();
            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);
            TreeNode temp = null;

            while (queue.Count > 0)
            {
                temp = queue.Dequeue();
                set.Add(temp.val);
                if (temp.left != null)
                    queue.Enqueue(temp.left);
                if (temp.right != null)
                    queue.Enqueue(temp.right);
            }

            return set;
        }
    }
}