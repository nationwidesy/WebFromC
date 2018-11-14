using System;
using System.Collections; //for Queue
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
 

namespace WebApplicationCWebForm.App_Code 
{
    class Factory
    {
        private static int _PoolMaxSize = 2;
        //my collection pool
        private static readonly Queue objPool = new Queue(_PoolMaxSize);

        public Employee GetEmployee ()
        {
            Employee oEmployee;
            //check from the collection pool
            //if exists retrun object
            //else create new object
            if (Employee.Counter >= _PoolMaxSize && objPool.Count > 0)
            {
                //retrive from pool
                oEmployee = RetrieveFromPool();
            }
            else
            {
                oEmployee = GetNewEmployee();
            }
            return oEmployee;
        }
        private Employee GetNewEmployee()
        {
            //Created a new employee
            Employee oEmp = new Employee();
            objPool.Enqueue(oEmp);
            return oEmp;
        }
        protected Employee RetrieveFromPool()
        {
            Employee oEmp;
            //if there is any object in my collection
            if (objPool.Count > 0)
            {
                oEmp = (Employee)objPool.Dequeue();
            }
            else
            {
                oEmp = new Employee();
            }
            //return a new object
            return oEmp;
        }

            
    }
    //=======================================
    class Employee
    {
        public static int Counter = 0;
        public Employee()
        {
            ++Counter;
        }
        private string _Firstname;
        private string _Lastname;
        public string FirstName
        {
            get { return _Firstname; }
            set { _Firstname = value; }
        }
        public string LastName
        {
            get { return _Lastname ;}
            set { _Lastname = value; }
        }
        public string Name()
        {
            return this.FirstName + ' ' + this.LastName;        }
    }

}
