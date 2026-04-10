using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prKol_ind_FormsZuev
{
    public class IsReverse
    {
        public static bool Reverse(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            Stack<char> stack = new Stack<char>(s2);
            return s1.SequenceEqual(stack);
        }
    }
}

