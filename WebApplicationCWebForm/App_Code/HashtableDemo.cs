using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections; //must have

namespace WebApplicationCWebForm.App_Code
{
    public class HashtableDemo
    {
        public string HashtableTest()
        {
            string str = string.Empty;
            Hashtable HT = new Hashtable();
            HT.Add(1, "s");
            HT.Add(2, "i");
            HT.Add(3, "_");
            HT.Add(4, "y");
            HT.Add(5, "h");
            HT.Add(6, "p");
            HT.Add(7, "o");
            HT.Add(8, "s");
            foreach (object i in HT.Keys  )
            {
                str += i;
            }
            str += "\r\n";
            foreach (object i in HT.Values )
            {
                str += i;
            }
            str += "\r\nLIFO";
            foreach (DictionaryEntry di in HT)
            {
                str += string.Format($"\r\nKey={di.Key} Value={di.Value}" );
            }
            return str;
        }
    }
}