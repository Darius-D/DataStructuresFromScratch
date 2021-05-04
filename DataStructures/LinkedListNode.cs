using System;

namespace DataStructures
{
    public class LinkedListNode
    {
        public int Value;

        public LinkedListNode Next;

        public LinkedListNode(int value)
        {
            Value = value;
            Next = null;
        }

        public void AddNode( int data)
        {
            if (Next == null)
            {
                Next = new LinkedListNode(data);
            }
            else
            {
                Next.AddNode(data);
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