using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Reflection;

namespace WebApplicationCWebForm.App_Code
{
    public class ReflectionDemo
    {
        public string FieldInvestigation(Type t)
        {
            string str = string.Empty;
            str += "\r\n********** Fields ********";
            FieldInfo[] fld = t.GetFields();
            foreach(FieldInfo f in fld)
            {
                str += "\r\n" + f.Name;
            }
            return str;
        }
        public string MethodInvestigation(Type t)
        {
            string str = string.Empty;
            str += "\r\n********** Methods ********";
             MethodInfo[] fld = t.GetMethods ();
            foreach ( MethodInfo m in fld)
            {
                str += "\r\n" + m.Name;
            }
            return str;
        }
    }
}