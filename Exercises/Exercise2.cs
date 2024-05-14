using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistest.Exercises
{
    public class Exercise2
    {
        public int Solution(int[] A)
        {
            int n = A.Length;
            int i = n - 1;
            int result = -1;
            int k = 0, maximal = 0;

            while (i >= 0)
            {
                if (A[i] == 1)
                {
                    k = k + 1;
                    if (k > maximal)
                        {
                        maximal = k;
                        result = i ; 
                    }
                }
                else
                {
                    k = 0;
                }
                i = i - 1;
            }

            if (A[0] == 1 && k + 1 > maximal)
            
                result = 0;
            

            return result;
        }


    }
}
