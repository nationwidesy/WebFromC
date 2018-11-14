using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationCWebForm.App_Code
{
    public class BassClass
    {
        protected int myValue = 0;
        private string myName = string.Empty;
    }
    //==========================
    public class DerivedClass1 : BassClass
    {
        void Access()
        {
            BassClass bassObj = new BassClass();

            //myValue can only be accessed by
            //classes devived from BassClass
            //bassObj.myValue = 5;
            //since it is protected so cannot access by new object

            myValue = 5;
            //can access BassClass myValue 
            //since DerivedClass1 implement/inheritance BassClass

            //myName = "Sophy";
            //can not access BaseClass myName
            //since it is private
            
        }
    }
    //==============================
    public class DerivedClass3  
    {
        void Access()
        {
            //myValue = 5;
            //can not access protected value
            //since not inheritance BassClass
        }
     }
}
