using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

public interface IMyInterface { }

namespace WebApplicationCWebForm.App_Code
{
    public class GenericTypeConstraint
    {
    }

    public class AGenericClass<T> where T : IComparable<T> { }
 
    //where class specify that type is a class or a stuct
    //both class and struct constraints
    class MyClass<T,U>
        where T : class
        where U : struct
    { }

    public class MyGenericClass<T> where T : IComparable<T>, new()
    {
        T item = new T();
    }

    class Dictionary<Tkey, TVal> 
        where Tkey : IComparable<Tkey >
        where TVal : IMyInterface
    {
        public void Add(Tkey key, TVal val) { }
        public void MyMethod<T>(T t) where T : IMyInterface { }
    }



    
   


    
}