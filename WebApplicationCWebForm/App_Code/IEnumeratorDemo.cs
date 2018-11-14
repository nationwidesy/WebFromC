using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections; //for ArrayList

namespace WebApplicationCWebForm.App_Code
{
    public class IEnumeratorDemo
    {
        public string IEnumeratorTest()
        {
            string str = string.Empty;
            ArrayList oArrayList = new ArrayList();
            oArrayList.Add("senthil");
            oArrayList.Add("Kumar");
            oArrayList.Add("99");
            oArrayList.Add("@");
            oArrayList.Add("5.55");

            Stack oStack = new Stack(); //LIFO
            oStack.Push(1);
            oStack.Push(2);
            oStack.Push(3);
            oStack.Push(4);
            oStack.Push("Stack LIFO");

            Queue oQueue = new Queue(); //FIFO
            oQueue.Enqueue("Queue FIFO");
            oQueue.Enqueue(1);
            oQueue.Enqueue(2);
            oQueue.Enqueue(3);
            oQueue.Enqueue(4);

            str += "IEnumerator is an interface object \r\n";
            str += string.Format($"Total items in the ArrayList: { oArrayList.Count} \r\n");

 
            IEnumerator oIEnum = oArrayList.GetEnumerator();
            
            while (oIEnum.MoveNext() )
            {
                str += string.Format($"\r\n { oIEnum.Current}");
            }

            ArrayList  pObj = new ArrayList ();
            Person p = new Person();
            p.FirstName = "Sophy";
            p.LastName = "Yang";
            pObj.Add(p.FullName );
            p.FirstName = "James";
            pObj.Add(p.FullName);
            p.FirstName = "Michael";
            pObj.Add(p.FullName);
            p.FirstName = "Paul";
            pObj.Add(p.FullName);
            p.FirstName = "Tammy";
            pObj.Add(p.FullName);
            p.FirstName = "Katie";
            p.LastName = "Cheng";
            pObj.Add(p.FullName);
            p.FirstName = "George";
            pObj.Add(p.FullName);

            oArrayList.AddRange(pObj);

            IEnumerator oIEnum1 = oArrayList.GetEnumerator();

            str += string.Format($"\r\n items in the ArrayList: { oArrayList.Count} \r\n");
            while (oIEnum1.MoveNext())
            {
                str += string.Format($"\r\n { oIEnum1.Current}");
            }


            return str;

        }
    }
}