using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationCWebForm.App_Code
{
    public class Swap
    {
        static void SwapDemo<T>(ref T lhs, ref T rhs)
        {
            T temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }

        public static string Swaptest()
        {
            int a, b;
            char c, d;
            a = 10;
            b = 20;
            c = 'I'; //char use ' instead of "
            d = 'V';
            string str = string.Empty;

            //display values before swap
            str += "\r\nInt values before calling swap:";
            str += string.Format("\r\na ={0}, b= {1}", a, b);
            str += string.Format("\r\nChar values before calling swap:");
            str += string.Format("\r\nc ={0} d ={1}", c, d);

            //call generic Swap
            SwapDemo<int>(ref a, ref b);
            SwapDemo<char>(ref c, ref d);

            //display values after Swap
            str += "\r\nInt values after  calling swap:";
            str += string.Format("\r\na ={0}, b= {1}", a, b);
            str += string.Format("\r\nChar values  after calling swap:");
            str += string.Format("\r\nc ={0} d ={1}", c, d);

            return str;
        }
    }
}