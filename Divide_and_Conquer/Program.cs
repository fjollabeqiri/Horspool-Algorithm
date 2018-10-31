using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divide_and_Conquer
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() {1, 9, 2, 8 };

            List<int> sortedList = MergeSort(list);
            foreach(object o in sortedList)
            {
                Console.Write(o+" ");
            }

            Console.Write("\n");
          
        }

        static List<int> Merge(List<int> left, List<int> right)
        {
            List<int> sorted = new List<int>();

            while(left.Count > 0 && right.Count>0)
            {
                if (left[0] < right[0])
                {
                    sorted.Add(left[0]);
                    left.RemoveAt(0);
                }
                else
                {
                    sorted.Add(right[0]);
                    right.RemoveAt(0);
                }
            }

            sorted.AddRange(left);
            sorted.AddRange(right);

            return sorted;
        }

        static List<int> MergeSort(List<int> list)
        {
            if(list.Count==1)
            {
                return list;
            }

            List<int> left = list.GetRange(0, list.Count / 2);
            List<int> right = list.GetRange(list.Count / 2, list.Count - list.Count / 2);

            left = MergeSort(left);
            right = MergeSort(right);

            return Merge(left, right);
        }
    }
}
