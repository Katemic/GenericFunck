using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericFunck
{
    public class Functions
    {

        public static int FindLargest(List<int> list)
        {
            int largest = list[0];

            foreach (var item in list )
            {
                //if (largest == null) 
                //{
                //    largest = item;
                //}
                if (largest < item) 
                {
                    largest = item;
                }
            }

            return largest;
        }
    }
}
