using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BAL
{
    public class BalClass
    {
        public int AddTwoNumbers(int n1, int n2)
        {
            return n1 + n2;
        }

        public double MulTwoNumbers(int n1, int n2)
        {
            return n1 * n2;
        }

        public double SubTwoNumbers(int n1, int n2)
        {
            double res = 0;
            if (n1 > n2)
                res = n1 - n2;
            else
                res = n2 - n1;
            return res;
        }
    }
}
