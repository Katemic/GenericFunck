using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFunck
{
    public class Functions
    {

        public static T FindLargest<T>(List<T> list) where T : IComparable<T>
        {
            T largest = list[0];


            foreach (var item in list)
            {
                if (largest.CompareTo(item) < 0) 
                {
                    largest = item;
                }
            }

            return largest;

        }

        public static T FindLargestCompare<T>(List<T> list)
        {
            list.Sort();
            return list[list.Count-1];
        }

    }
}
