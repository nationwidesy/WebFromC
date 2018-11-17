using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplicationCWebForm.App_Code
{
    public class GenericDelegate
    {
        public static void Test()
        {
            Stack<double> s = new Stack<double>();
            SampleClass o = new SampleClass();
            s.stackEvent += o.HandleStackChange;
        }
    }

    delegate void StackEventHandler<T, U>(T sender, U eventArgs);
    class Stack<T>
    {
        public class StackEventArgs : System.EventArgs { }
        public event StackEventHandler<Stack<T>, StackEventArgs> stackEvent;

        protected virtual void OnStackChanged(StackEventArgs a)
        {
            stackEvent(this, a);
        }
    }
    class SampleClass
    {
        public void HandleStackChange<T>(Stack <T>, Stack <T>.StackEventArgs args) { }
    }
 
}