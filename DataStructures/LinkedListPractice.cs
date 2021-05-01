using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class LinkedListPractice
    {
        public PNode Head;

        public LinkedListPractice()
        {
            Head = null;
        }

        public void AddToEnd(int value)
        {
            if (Head == null)
            {
                Head = new PNode(value);
            }
            else
            {
                Head.AddPNode(value);
            }
        }

        public void AddToStart(int value)
        {
            if (Head != null)
            {
                var temp = new PNode(value);
                temp.Next = Head;

                Head = temp;
            }
        }

        public void PrintList()
        {
            if (Head != null)
            {
                Head.Print();
            }
        }

        public void Delete(int value)
        {
            var currentNode = Head;

            if (Head != null)
            {
                if (Head.Value == value)
                {
                    Head = Head.Next;
                }

                while (currentNode.Next.Value != value)
                {
                    currentNode = currentNode.Next;
                }

                currentNode.Next = currentNode.Next.Next;
            }
        }

        public bool Contains(int value)
        {
            var currentNode = Head;

            if (Head == null)
            {
                return false;
            }
            while (currentNode.Value != value && currentNode.Next != null)
            {
                currentNode = currentNode.Next;
            }

            if (currentNode.Value == value)
            {
                return true;
            }
            return false;
        }
    }

    public class PNode
    {
        public int Value;

        public PNode Next;

        public PNode(int value)
        {
            Value = value;
            Next = null;
        }

        public void AddPNode( int data)
        {
            if (Next == null)
            {
                Next = new PNode(data);
            }
            else
            {
                Next.AddPNode(data);
            }
        }

        public void Print()
        {
            
            Console.Write($"|{Value}|->");

            if (Next != null)
            {
                Next.Print();
            }
                
        }
    }
}
