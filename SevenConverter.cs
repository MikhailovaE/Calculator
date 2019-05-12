using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calculator
{
    class SevenConverter
    {
        public static int ToDec(String s)
        {
            int n = 0;
            foreach (char c in s)
            {
                n = n * 7 + int.Parse(c.ToString());
            }
            return n;
        }
        public static String FromDec(int n)
        {
            String result = "";
            do
            {
                result = (n % 7).ToString() + result;
            }
            while ((n /= 7) > 0);
            return result;
        }
    }
}
