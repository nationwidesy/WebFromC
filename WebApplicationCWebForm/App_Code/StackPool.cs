using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
 
namespace WebApplicationCWebForm.App_Code
{
    public class StackPool<T> :Stack<T>, IStore<T>
        //Last in First out, push and pop
        //IStore is interface, interface need implement all the methods
    {
        public  T Fetch()
        {
            return Pop();
        }
        public void Store(T obj)
        {
            Push(obj);
        }
        public void ClearAll()
        {
            Clear();
        }
    }
}