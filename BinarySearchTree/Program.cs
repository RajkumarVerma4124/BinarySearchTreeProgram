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

            while (true)
            {
                Console.WriteLine("1: Insert Default Values \n2: Enter More Values \n3: Display Binary Tree Values \n4: Get Size Of Binary Tree"+
                                  "\n5: Exit");
                Console.Write("Enter A Choice From Above : ");
                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        //Inserting default values in binary tree
                        binaryTree.Insert(30);
                        binaryTree.Insert(70);
                        binaryTree.Insert(22);
                        binaryTree.Insert(40);
                        binaryTree.Insert(60);
                        binaryTree.Insert(95);
                        binaryTree.Insert(11);
                        binaryTree.Insert(65);
                        binaryTree.Insert(3);
                        binaryTree.Insert(16);
                        binaryTree.Insert(63);
                        binaryTree.Insert(67);
                        Console.WriteLine("Values is inserted into binary tree\n");
                        break;
                    case 2:
                        //Taking the value from user to enter value in binary tree
                        Console.Write("Enter The Value You Want To Enter In Binary Search Tree : ");
                        int binValue = int.Parse(Console.ReadLine());
                        binaryTree.Insert(binValue);
                        Console.WriteLine("Value is inserted into binary tree\n");
                        break;
                    case 3:
                        //Displaying the values in binary tree(UC1)
                        Console.Write("Binary Tree Values Are : ");
                        binaryTree.Display();
                        Console.WriteLine();
                        break;
                    case 4:
                        //Displaying the size of the binary tree(UC2)
                        binaryTree.GetSize();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Wrong Choice");
                        continue;
                }
            }  
        }
    }
}
