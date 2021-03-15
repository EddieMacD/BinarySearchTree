using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree(48);

            tree.AddItem(79);
            tree.AddItem(83);
            tree.AddItem(82);
            tree.AddItem(23);
            tree.AddItem(73);
            tree.AddItem(90);
            tree.AddItem(8);
            tree.AddItem(56);
            tree.AddItem(61);

            Console.WriteLine(tree.TreeCount());
            tree.TreePrint();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            tree.AddItem(52);
            tree.AddItem(73);
            tree.AddItem(68);
            tree.AddItem(85);
            tree.AddItem(58);
            tree.AddItem(18);
            tree.AddItem(49);
            tree.AddItem(47);
            tree.AddItem(87);
            tree.AddItem(61);

            Console.WriteLine(tree.TreeCount());
            tree.TreePrint();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            tree.AddItem(83);
            tree.AddItem(66);
            tree.AddItem(31);
            tree.AddItem(64);
            tree.AddItem(58);
            tree.AddItem(97);
            tree.AddItem(59);
            tree.AddItem(10);
            tree.AddItem(54);
            tree.AddItem(45);

            Console.WriteLine(tree.TreeCount());
            tree.TreePrint();

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Breadth First");

            List<int> nodes = tree.BreadthFirst();
            for (int i = 0; i < nodes.Count(); i++)
            {
                Console.Write(nodes[i] + "    ");
            }

            Console.ReadLine();
        }
    }
}
