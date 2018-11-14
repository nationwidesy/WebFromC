using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections; //for Queue

namespace WebApplicationCWebForm.App_Code
{
    public class QueuePool :Queue
    {
        public Person Fetch()
        {
            return (Person)Dequeue(); //Dequeue remove, first in first out, so remove first item, Enqueue() Dequeue()
        } 
        public void Store(Person person)
        {
            Enqueue(person);
        }
        public void ClearAll()
        {
            base.Clear();
        }

        internal void Store(WebApplicationCWebForm.Person person)
        {
            throw new NotImplementedException();
        }
    }
}