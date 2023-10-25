using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace PacktLibraryStandard2.folder
{
    public class Common
    {
        public delegate bool IntFilter(int i);

        public static int[] FilterArrayToInts(int[] ints, IntFilter filter)
        {
            ArrayList aList = new ArrayList();

            foreach (int i in ints)
            {
                aList.Add(i);
            }

            return ((int[])aList.ToArray(typeof(int)));
        }


        public static bool IsOdd(int i)
        {
            var test = (int a, int b) =>
            {
                if (a > b)
                {
                    return true;
                }
                return false;
            };
            return ((i & 1) == 1);
        }
    }
}
