using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Threading;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace WebApplicationCWebForm.App_Code
{
    public class XmlSerializationDemo
    {
        public string XmlSerializationTest ()
        {
            Test oc = new Test();
            string str = string.Empty;
            oc.FirstName = "sophy";
            oc.MI = "s";
            oc.LastName = "yang";

            XmlSerializer writer = new XmlSerializer(oc.GetType());
            Stream fs = File.OpenWrite ("c:\\users\\Sophy_2\\Documents\\test1.xml");
            writer.Serialize(fs, oc);
            fs.Close();
            oc.Dispose();
            System.GC.Collect();
            System.GC.WaitForPendingFinalizers();

            str = string.Format($"\r\nFile created at c:\\users\\Sophy_2\\Documents\\test1.xml");
            return str;
        }
        public void WriteXML()
        {
            Book bObj = new Book();
            bObj.title = "Serialization Overview";
            bObj.author = "sophy";
            bObj.datePublish = "9/4/2018";

            string fileName = "//tempBook.xml";
            XmlSerializer reader = new XmlSerializer(bObj.GetType()); //typeof(bObj)
            var path = string.Format($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\{fileName}");
            FileStream fs = File.Create(path);
            reader.Serialize(fs, bObj);
            fs.Close();
        }
        public void WriteXML(string fileName , object obj)
        {
            XmlSerializer writer = new XmlSerializer(obj.GetType()); //typeof(bObj)
            FileStream fs = File.Create(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\" + fileName); 
            writer.Serialize(fs, obj);
            fs.Close();

        }
        public string ReadXML()
        {
            string str = string.Empty;
            string fileName = "//tempBook.xml";
            var path = string.Format($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\{fileName}");
            XmlSerializer reader  = new XmlSerializer(typeof(Book));
            StreamReader file = new StreamReader(path);
            Book bObj = (Book)reader.Deserialize(file);
            file.Close();
            str += string.Format ($"\r\nAuther:{ bObj.author} Title: {bObj.title}");
            return str;
        }
        public string readXMLfile()
        {
            string str = string.Empty;

             


            str = string.Format($"\r\n");
            return str;
        }
    }
    public class Book
    {
        public string title;
        public string author;
        public string datePublish;
    }
    public class Test : IDisposable
    {
        public string FirstName;
        public string MI;
        public string LastName;
        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}