using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/*
 * The where clause is used in a query express to specify
 * which elements from the data source will be returned 
 * in the query expression 
 * 
 * 
 */ 
namespace WebApplicationCWebForm.App_Code
{
    public class WhereClause
    {
        public string outPut;
        public WhereClause ()
        {
            WhereSample();
        }
        public void WhereSample()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            var queryLowNums =
                from num in numbers
                where num > 5
                select num;

            outPut += "\r\nThe numbers that are great than 5:";
            foreach (var s in queryLowNums)
            {
                outPut += "\r\n[" + s+"]";
            }

            var queryLowNums2 =
                from num in numbers
                where num > 5 && num % 2 ==0
                select num;

            outPut += "\r\nThe numbers that are great than 5 and is Even number:";
            foreach (var s in queryLowNums2)
            {
                outPut += "\r\n[" + s + "]";
            }

            var queryLowNums3 =
                from num in numbers
                where num > 5 
                where num % 2 == 0
                select num;

            outPut += "\r\nThe numbers that are great than 5 and is Even number:";
            foreach (var s in queryLowNums3)
            {
                outPut += "\r\n[" + s + "]";
            }
        }
    }

 
}