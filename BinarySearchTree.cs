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

        private void TreeTraverse (List<int> nums)
        {
            //Left branch traversal
            if(LeftChild != null)
            {
                LeftChild.TreeTraverse(nums);
            }

            //Log current node
            nums.Add(Data);

            //Right branch traversal
            if (RightChild != null)
            {
                RightChild.TreeTraverse(nums);
            }
        }

        public int TreeCount ()
        {
            List<int> nums = new List<int>(0);
            TreeTraverse(nums);
            return nums.Count();
        }

        public void TreePrint ()
        {
            List<int> nums = new List<int>(0);
            TreeTraverse(nums);

            for (int i = 0; i < nums.Count(); i++)
            {
                Console.Write(nums[i] + "    ");
            }
        }
    }
}
