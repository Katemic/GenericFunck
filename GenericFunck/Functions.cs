using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFunck
{
    public class Functions
    {

        //public static T FindLargest<T>(List<T> list)
        //{
        //    T largest = list[0];
        //    if (list[0] is string)
        //    {
        //        foreach (var item in list)
        //        {
        //            if ((string)largest.Length < (string)item.Length)
        //            {
        //                largest = item;
        //            }
        //        }

        //        return largest;
        //    }
        //}

        public static T FindLargestCompare<T>(List<T> list)
        {
            list.Sort();
            return list[list.Count-1];
        }

    }
}
