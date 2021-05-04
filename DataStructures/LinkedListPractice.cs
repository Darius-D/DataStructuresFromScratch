using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class LinkedListPractice
    {
        public LinkedListNode Head;

        public LinkedListPractice()
        {
            Head = null;
        }

        /// <summary>
        /// Uses recursion to check if "head" is null. If it is it will start the list with a new node
        /// else it will call the AddNode method in the Node class which will check if the next value is
        /// null. If it is it will point next to a new node else it will iterate through to the end. 
        /// </summary>
        /// <param name="value">int value of the node</param>
        
        public void AddToEnd(int value)
        {
            if (Head == null)
            {
                Head = new LinkedListNode(value);
            }
            else
            {
                Head.AddNode(value);
            }
        }

        public void AddToStart(int value)
        {
            if (Head != null)
            {
                var temp = new LinkedListNode(value);
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
}
