using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//add following lines
using System.Threading;


namespace WebApplicationCWebForm.App_Code
{
    public class MultitreadingDemo
    {
        public void  MultitreadingTest(out string str)
        {

            str = string.Empty;
            str += "\r\n***********  Current Thread Informations ***************";
 
            Thread t = Thread.CurrentThread;
            t.Name = "Primary_Thread";

            str += string.Format($"\r\nThread Name: {t.Name}");
            str += string.Format($"\r\nThread Status: {t.IsAlive}");
            str += string.Format($"\r\nPriority: {t.Priority}");
            str += string.Format($"\r\nCpmtext ID: {Thread.CurrentContext.ContextID} ");
            str += string.Format($"\r\nCurrent application domain: {Thread.GetDomain().FriendlyName}");
        }
        public static void RunTwoThread()
        {

            Thread t = new Thread(myFun);
            t.Name = "Thread1";
            t.IsBackground = false;
            t.Start();

        }
        static void myFun()
        {
            string str = string.Empty;
            str = string.Empty;
            str += string.Format($"\r\n");
            str += string.Format($"\r\nThread {Thread.CurrentThread.Name } started");
            Thread.Sleep(2000);
            str += string.Format($"\r\nThread {Thread.CurrentThread.Name } completed");
            str += string.Format($"\r\n");
             
        }
        public string StartMultiThread()
        {
            string str = string.Empty;
            ThreadStart childthread = new ThreadStart(childThreadCall);
            Thread child = new Thread(childthread);

            child.Start();

            str += "\r\nMain sleep for 2 seconds....";
            Thread.Sleep(2000);

            child.Abort();


            return str;
        }
        public void childThreadCall()
        {
            string str = string.Empty;
            try
            {            
                str += string.Format($"\r\nchild thread started");
                str += string.Format($"\r\n");
                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(500);
                    str += string.Format($"\r\nin child thread");
                }
               
                str += string.Format($"\r\nchild thread finished" );
            }
            catch (Exception ex)
            {
                str += "\r\nchild thread - Error occurred (" + ex.Message + ")";
            }
            finally
            {
                str += string.Format($"\r\n child thread - unable ot catch the exception");
            }
            
        }
    }
}