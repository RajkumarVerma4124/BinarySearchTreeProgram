using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Displaying the message
            Console.WriteLine("Welcome to the binary search tree program");
            Console.ReadLine();

            //Creating binary search tree to insert and display node values(UC1)
            BinSearchTree<int> binaryTree = new BinSearchTree<int>(56);
            binaryTree.Insert(30);
            binaryTree.Insert(70);
            binaryTree.Display();
            Console.ReadLine();
        }
    }
}
