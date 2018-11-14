using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace  WebApplicationCWebForm.App_Code
{ 
    public class Student
    {
        private int mMarks;

        public int Marks
        {
            get {
                if (mMarks >=80) { mMarks += 5; }
                else if(mMarks <=79 && mMarks >=70) { mMarks += 2; }
                return mMarks; }
            set { mMarks = value; }
        }

    }
}
