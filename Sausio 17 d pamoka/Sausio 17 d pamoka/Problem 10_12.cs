using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sausio_17_d_pamoka
{
    public class Problem10_12
    {
        public static string Problem10(string word)
        {
            char[] chars = word.ToCharArray();
            Array.Reverse(chars);

            return new string(chars);
        }

        public static bool Problem11(int num)
        {
            if (num % 2 == 0) return true;
            return false;
        }
    }
}