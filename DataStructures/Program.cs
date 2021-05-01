using System;
using System.Collections;
using System.ComponentModel;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
           
          var test = new LinkedListPractice();
          test.AddToEnd(1);
          test.AddToEnd(2);
          test.PrintList();
          Console.WriteLine("\n");
          test.AddToStart(0);
          test.PrintList();

          Console.WriteLine("\n");
          test.AddToEnd(3);
          test.AddToEnd(4);
          test.AddToEnd(5);
          test.AddToEnd(6);
          test.AddToEnd(7);



            Console.WriteLine(test.Contains(4));

        }
    }
}
