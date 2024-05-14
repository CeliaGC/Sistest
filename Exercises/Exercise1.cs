using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistest.Exercises
{
    public class Exercise1
    {
        public int Solution(int N)
        {
            string strN = Math.Abs(N).ToString();
            bool isNegative = N < 0;
            string result = "";

            if (isNegative)
            {
                for (int i = 0; i < strN.Length; i++)
                {
                    if (strN[i] > '5')
                    {
                        result += '5' + strN.Substring(i);
                        break;
                    }
                    result += strN[i];
                    if (i == strN.Length - 1)
                    {
                        result += '5';
                    }
                }
                result = "-" + result;
            }
            else
            {
                for (int i = 0; i < strN.Length; i++)
                {
                    if (strN[i] < '5')
                    {
                        result += '5' + strN.Substring(i);
                        break;
                    }
                    result += strN[i];
                    if (i == strN.Length - 1)
                    {
                        result += '5';
                    }
                }
            }

            return int.Parse(result);
        }
    }
}
