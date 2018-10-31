using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort_BottomUp
{
    class Program
    {
        public static void Main()
        {
            int[] myArray = new int[] { 6, 2, 3, 9, 5, 4, 8, -1, 10};

            Sort(myArray);
            Console.Write(" | ");
            foreach (var item in myArray)
            {
                Console.Write(item+" | ");
            }
            Console.Write("\n");
        }
        static void Sort(int[] myArray)
        {
            int n = myArray.Length;
            int[] targetArr = new int[n];
            int[] sourceArr = myArray;

            for (int width = 1; width < n; width *= 2)
            {
                for (int l = 0; l < n; l += 2*width)
                {
                    int m = Math.Min(n, l + width);
                    int r = Math.Min(n, m + width);
                    Merge(sourceArr, targetArr, l, m, r);
                }
                int[] tempArr = sourceArr;
                sourceArr = targetArr;
                targetArr = tempArr;
            }

            
            if (myArray != sourceArr)
            {
                for (int i = 0; i < n; i++)
                {
                    myArray[i] = sourceArr[i];
                }
            }
        }
        static void Merge(int[] source, int[] target, int l, int m, int r)
        {
            int i = l;
            int j = m;
            int k = r;

            while (l < j || m < k)
            {
                if (l == j)
                {
                    target[i++] = source[m++];
                }
                else if (m == k)
                {
                    target[i++] = source[l++];
                }
                else if (source[l] <= source[m])
                {
                    target[i++] = source[l++];
                }
                else
                {
                    target[i++] = source[m++];
                }
            }
        }
    }
}
