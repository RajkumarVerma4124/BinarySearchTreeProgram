using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    //Creating binary search tree using generics and IComparable to use CompareTo method in program(UC1)
    public class BinSearchTree<T> where T : IComparable<T>
    {
        public int leftCount, rightCount;
        public bool result = false;

        public T NodeData { get; set; }
        public BinSearchTree<T> LeftTree { get; set; }
        public BinSearchTree<T> RightTree { get; set; }

        public BinSearchTree(T nodeData)
        {
            this.NodeData = nodeData;
            this.LeftTree = null;
            this.RightTree = null;
        }

        //Method to check node and add node value to either left or right by comparing(UC1)
        public void Insert(T data)
        {
            T currentNodeValue = NodeData;
            if ((data.CompareTo(currentNodeValue)) < 0)
            {
                if (this.LeftTree == null)
                {
                    this.LeftTree = new BinSearchTree<T>(data);
                    leftCount++;
                }
                else
                {
                    leftCount++;
                    this.LeftTree.Insert(data);
                }
            }
            else
            {
                if (this.RightTree == null)
                {
                    leftCount++;
                    this.RightTree = new BinSearchTree<T>(data);
                }
                else
                {
                    rightCount++;
                    this.RightTree.Insert(data);
                }
            }
        }

        //Displaying the data in the binary tree(UC1)
        public void Display()
        {
            if (this.LeftTree != null)
            {
                LeftTree.Display();
            }
            Console.Write(NodeData.ToString()+" ");
            if (this.RightTree != null)
            {
                RightTree.Display();
            }
        }

        //Method to get the size of the binary tree(UC2)
        public void GetSize()
        {
            Console.WriteLine("Size of the binary tree is : " + (1 + this.leftCount + this.rightCount)+"\n");
        }

        //Method to search the given value in the binary tree(UC3)
        public bool IfValueExists(T data, BinSearchTree<T> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.NodeData.Equals(data))
            {
                result = true;
            }
            else if (data.CompareTo(node.NodeData) < 0)
            {
                IfValueExists(data, node.LeftTree);
            }
            else
            {
                IfValueExists(data, node.RightTree);
            }
            return result;
        }

    }
}
