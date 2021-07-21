using System;
using System.Collections.Generic;
using System.Text;

namespace SR.Ext
{
    public class Fibonacci
    {
        public static int[] GetSequence(int n)
        {
            int[] fs = new int[n];
            for(int i = 0; i < n; i++)
            {
                if (0 == i)
                {
                    fs[i] = 0;
                }
                else if (1 == i)
                {
                    fs[i] = 1;
                }
                else
                {
                    fs[i] = fs[i - 2] + fs[i - 1];
                }
            }
            return fs;
        }
    }
}
