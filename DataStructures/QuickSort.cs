using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class QuickSort
    {
       

        public static void Qs( int[] arr, int l, int r)
        {
            
            if (l < r)
            {
                var i = Partition(l, r, arr);
                Qs(arr, l, i - 1);
                Qs(arr, i + 1, r);
            }
        }

        public static int Partition(int l, int r, int[] arr)
        {
            var pivot = arr[r];
            var i = l - 1;

            for (var j = l; j < r; j++)
            {
                if (arr[j] <= pivot)
                {
                    i++;
                    var temp = arr[j];
                    arr[j] = arr[i];
                    arr[i] = temp;

                }
            }

            var tPivot = arr[i+1];
            arr[i + 1] = arr[r];
            arr[r] = tPivot;

            return i+1;
        }

    }
}
