using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationCWebForm.App_Code
{
    public class ValueVsReference
    {
        public string ValueVsReferenceDemo()
        {
            string str = string.Empty;
            A obj1 = new A(11);
            int v1 = 22;
            int v2 = 33;
            str += string.Format($"\r\n v1= {v1}, v2= {v2} ");
            v2 = v1;
            str += string.Format($"\r\n v1= {v1}, v2= {v2}, assigned v1 vaule to v2");

            A obj2 = new A(44);

            str += string.Format($"\r\n obj1 = {obj1.value}, obj2= {obj2.value} ");
            obj2 = obj1;
            str += string.Format($"\r\n obj1 = {obj1.value}, obj2= {obj2.value}, assigned obj1 vaule to obj2");

            int v3 = 55;
            str += string.Format($"\r\n v3 = {v3}  ");
            B obj3 = new B(ref v3);
            str += string.Format($"\r\n B class ref v3 = {v3}, reference value in B class is 999");

            int v4 = 66;
            str += string.Format($"\r\n v4 = {v4}  ");
            C obj4 = new C(out v4);
            str += string.Format($"\r\n C class out v4 = {v4}, out value in C class is 999");

 
            D obj5 = new D();
            obj5.val = 10;
            str += string.Format($"\r\n obj5.val = {obj5.val}  ");
            D.methodToShowref(ref obj5);
            str += string.Format($"\r\n D class reference obj5.val = {obj5.val} ");

            E obj6 = new E();
            obj6.val = 10;
            str += string.Format($"\r\n obj6.val = {obj6.val}  ");
            E.methodToShowref(obj6);
            str += string.Format($"\r\n E class reference obj6.val = {obj6.val} ");

            return str;
        }
    }

    class A
    {
        public int value { get; set; }
        public A(int passByref)
        {
            this.value = passByref;
        }
    }

    class B
    {
        public int value { get; set; }

        public B(ref int passByRef)
        {
            passByRef = 999;
            value = passByRef;
        }
    }

    class C
    {
        public int value { get; set; }

        public C(out int passByOut)
        {
            passByOut = 999;
            value = passByOut;
        }
    }

    struct D //class is reference type,(heap) struct is value type (stack)
    {
        public int val { get; set; }

        public static void methodToShowref(ref D obj)
        {
            //pass value type by reference 
            obj = new D();

        }
    }
    class E //class is reference type,(heap) struct is value type (stack)
    {
        public int val { get; set; }

        public static void methodToShowref( E obj)
        {
            //pass reference type by value (by default) 
            obj = null;

        }
    }
}

 