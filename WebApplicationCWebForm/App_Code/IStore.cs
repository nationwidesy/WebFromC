using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections; // for Queue

namespace WebApplicationCWebForm.App_Code
{
    public interface IStore<T>
    { 
        T Fetch();
        void Store(T obj);
        int Count { get; }
        void ClearAll();
    }
    public class QueuePool<T> : Queue<T>, IStore<T>
    {
        public void ClearAll()
        {
            base.Clear();
        }

        public T Fetch()
        {
            return (T)Dequeue();
        }

        public void Store(T obj)
        {
             
            Enqueue(obj);
        }
    }

         
}
