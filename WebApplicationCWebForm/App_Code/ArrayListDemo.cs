using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections; //for ArrayList

/*
 * ArrayList Methods:
 * Add
 * AddRange
 * Clear
 * BinarySearch
 * Insert
 * InsertRange
 * Remove
 * RemoveAT
 * RemoveRange
 * Sort
 * Reverse
 * GetEnumerator: it will return the collection of object in the ArrayList as enumerator.
 * Contain: it checks whether the objects exists or not
 */
namespace WebApplicationCWebForm.App_Code
{
    public class ArrayListDemo
    {
        public string ArrayListTest()
        {
            ArrayList oArrayList = new ArrayList();
            oArrayList.Add("senthil");
            oArrayList.Add("Kumar");
            oArrayList.Add("99");
            oArrayList.Add("@");
            oArrayList.Add("5.55");

            string str = string.Empty;
            int iPos = 0;
            int iPos2 = 0;
            string searchStr = "Kumar";

            str += string.Format ($"Total items in the ArrayList: { oArrayList.Count} \r\n") ;
            foreach (object i in oArrayList )
            {
                str += i.ToString() + "\r\n";
            }
           
            iPos = oArrayList.BinarySearch(searchStr);
            str += string.Format($"   ===== Search item {searchStr} =====\r\nFound at position {iPos}\r\n");
 
            str += string.Format($"   ===== Sort ArrayList  =====\r\n");
            oArrayList.Sort();           
            foreach (object i in oArrayList)
            {
                str += i.ToString() + "\r\n";
            }
 
            iPos2 = oArrayList.BinarySearch(searchStr);
            str += string.Format($"   ===== Search item {searchStr} =====\r\nFound at position {iPos2}\r\n");

            str += string.Format($"   ===== Insert and Remove   =====\r\n");
            oArrayList.Insert(3,"Insert into index 3");
            oArrayList.Remove("@");

            Stack oStack = new Stack(); //LIFO
            oStack.Push(1);
            oStack.Push(2);
            oStack.Push(3);
            oStack.Push(4);
            oStack.Push("Stack LIFO");

            oArrayList.AddRange(oStack); //add Range of the object

 
            Queue oQueue = new Queue(); //FIFO
            oQueue.Enqueue("Queue FIFO");
            oQueue.Enqueue(1);
            oQueue.Enqueue(2);
            oQueue.Enqueue(3);
            oQueue.Enqueue(4);

            oArrayList.AddRange(oQueue); //add Range object

            oArrayList.Add("RemoveAt the last 3th item");
            oArrayList.RemoveAt(oArrayList.Count - 3);
           

            foreach (object i in oArrayList)
            {
                str += i.ToString() + "\r\n";
            }

            str += string.Format($"   ===== Clear ArrayList  ===== \r\n");
            oArrayList.Clear();
            str += string.Format($"Total items after clean become: { oArrayList.Count} \r\n");



            return str;

        }
    }
}