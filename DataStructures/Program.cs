using System;
using System.Collections;
using System.ComponentModel;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new int[] {-2, 80, -1, 5, 4, -3, 0};
            QuickSort.Qs(test, 0, test.Length-1);

            for(var i = 0; i < test.Length; i++)
            {
                Console.WriteLine(test[i]);
            }
        }

    }
    
}
