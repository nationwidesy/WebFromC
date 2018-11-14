using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationCWebForm.App_Code
{
    public sealed class ObjectPoolObject<T> where T: new()
    { //T is an Object, take in on paramter
        private readonly int _poolSize;
        private readonly object _threadLocker;
        private readonly Queue<T> _poolManager;

        public ObjectPoolObject (int expectedPoolSize)
        {
            if (expectedPoolSize <= 0)
            {
                throw new ArgumentOutOfRangeException("expectedPoolSize", "Pool size can't be null or zero or less than zero");
            }
                _poolManager = new Queue<T>();
                _threadLocker = new object();
                _poolSize = expectedPoolSize;
            
        }
        public T Get()
        {
            lock(_threadLocker)
            {
                if(_poolManager.Count >0)
                {
                    return _poolManager.Dequeue();
                }
                else
                {
                    return new T();
                }
            }
        }
        public int Count()
        {
            return _poolManager.Count();
        }
        public void Put(T obj)
        {
            lock(_threadLocker )
            {
                if(_poolManager.Count< _poolSize)
                {
                    _poolManager.Enqueue (obj);
                }
            }            
        }
    }
}