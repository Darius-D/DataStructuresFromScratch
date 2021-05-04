using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class BinarySearchTree
    {
        public BSTNode RootNode;

        public BinarySearchTree()
        {
            RootNode = null;
        }
        public void Insert(int value)
        {
            if (RootNode == null)
            {
                RootNode = new BSTNode(value);
            }
            else
            {
                RootNode.InsertNode(value);
            }
        }

        public void Print()
        {
            if (RootNode != null)
            {
                RootNode.PrintInOrder();
            }
        }
    }

    public class BSTNode
    {
        public int RootValue;
        public BSTNode Left;
        public BSTNode Right;

        public BSTNode(int rootValue)
        {
            RootValue = rootValue;
        }

       

        public void InsertNode(int value)
        {
            if (value < RootValue)
            {
                if (Left == null)
                {
                    Left = new BSTNode(value);
                }
                else
                {
                    Left.InsertNode(value);
                }
            }

            if (value > RootValue)
            {
                if (Right == null)
                {
                    Right = new BSTNode(value);
                }
                else
                {
                    Right.InsertNode(value);
                }
            }
        }

        public void PrintInOrder()
        {
            Console.WriteLine($"{Left}/");
            Console.WriteLine($"{RootValue}\\");
            Console.WriteLine($"{Right}");
        }
    }
}
