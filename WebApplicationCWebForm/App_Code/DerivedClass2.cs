using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCWebForm.App_Code
{
    public class DerivedClass2 :BassClass
    {
        void Access()
        {
            //can not access 
            //BassClass protected value myValue
            //since they are not in same class
            //even implement/inhentance BassClass
            //myValue = 10;
        }
    }
}
