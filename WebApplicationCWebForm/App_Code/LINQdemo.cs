using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 

namespace WebApplicationCWebForm.App_Code
{
    public class LINQdemo
    {
         
        public LINQdemo()
        {        
        }

        public string  myDemo()
        {
            string str = string.Empty;

            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            int oddNumbers = numbers.Count(n => n % 2 == 1);

            string[] words = { "cherry", "apple", "blueberry" };
            var storedWords = from w in words
                              orderby w
                              select w;
            foreach (var w in storedWords) { str += "\r\nMy words: " + w; }

            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };
            var pairs = from a in numbersA
                        from b in numbersB
                        where a < b
                        select new { a, b };
            foreach (var p in pairs)
            {
                str += string.Format($"\r\n  {p.a } is less than {p.b}");
            }


            return str;

        }
        public int TotalPatientillegibleforVote()
        {
            int i = 0;
            i = (from pa in this.PatientList()
                 where pa.Age >= 18
                 orderby pa.PatientName, pa.Gender, pa.Age
                 select pa
                ).Count();

            return i;
        }
        public int TotalPatientOver20yearsOld()
        {
            int i = 0;
            i = (from pa in this.PatientList()
                 where pa.Age >= 20
                 orderby pa.PatientName, pa.Gender, pa.Age
                 select pa
                ).Count();

            return i;
        }
        public List<patient> PatientList() { 
            List<patient> pList = new List<patient>();
            patient p = new patient();
            patient p1 = new patient();
            patient p2 = new patient();
            patient p3 = new patient();
            p.PatientName = "Sophy Yang";
            p.Age = 50;
            p.Area = "IA";
            p.Gender = "F";
            pList.Add(p);
            p1.PatientName = "Fourth  Yang";
            p1.Age = 40;
            p1.Area = "IA";
            p1.Gender = "F";
            pList.Add(p1);
            p2.PatientName = "Nineteen  Yang";
            p2.Age = 19;
            p2.Area = "IA";
            p2.Gender = "M";
            pList.Add(p2);
            p3.PatientName = "Fifteen  Yang";
            p3.Age = 15;
            p3.Area = "IA";
            p3.Gender = "M";
            pList.Add(p3);
            return pList;

        }
    }

    public class patient
    {
        private string _name;

        public string PatientName
        {
            get { return _name; }
            set { _name = value; }
        }
        private int _age;

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        private string _gender;

        public string Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        private string _area;

        public string Area
        {
            get { return _area; }
            set { _area = value; }
        }

    }
}