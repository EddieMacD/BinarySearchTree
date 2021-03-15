using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        private int Data;
        private BinarySearchTree LeftChild;
        private BinarySearchTree RightChild;

        public BinarySearchTree(int data)
        {
            Data = data;
        }

        public void AddItem(int input)
        {
            if(input < Data)
            {
                if (LeftChild == null)
                {
                    LeftChild = new BinarySearchTree(input);
                }
                else
                {
                    LeftChild.AddItem(input);
                }
            }
            else
            {
                if (RightChild == null)
                {
                    RightChild = new BinarySearchTree(input);
                }
                else
                {
                    RightChild.AddItem(input);
                }
            }
        }

        private void DepthFirstInOrder (List<int> nums)
        {
            //Left branch traversal
            if(LeftChild != null)
            {
                LeftChild.DepthFirstInOrder(nums);
            }

            //Log current node
            nums.Add(Data);

            //Right branch traversal
            if (RightChild != null)
            {
                RightChild.DepthFirstInOrder(nums);
            }
        }

        public List<int> BreadthFirst ()
        {
            Queue<BinarySearchTree> queue = new Queue<BinarySearchTree>();
            List<int> nodeOrder = new List<int>();

            queue.Enqueue(this);

            while(queue.GetCount() != 0)
            {
                BinarySearchTree current = queue.Dequeue();

                nodeOrder.Add(current.Data);

                if (current.LeftChild != null)
                {
                    queue.Enqueue(current.LeftChild);
                }

                if (current.RightChild != null)
                {
                    queue.Enqueue(current.RightChild);
                }
            }

            return nodeOrder;
        }

        public int TreeCount ()
        {
            List<int> nums = new List<int>(0);
            DepthFirstInOrder(nums);
            return nums.Count();
        }

        public void TreePrint ()
        {
            List<int> nums = new List<int>(0);
            DepthFirstInOrder(nums);

            for (int i = 0; i < nums.Count(); i++)
            {
                Console.Write(nums[i] + "    ");
            }
        }
    }
}
