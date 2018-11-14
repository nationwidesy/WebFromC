using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary; 


namespace WebApplicationCWebForm.App_Code
{
    public class SerializeDemo
    {
        public string WriteToBinary()
        {
            string str = string.Empty;
            Person p = new Person();
            p.FirstName = "sophy";
            p.LastName = "yang";
            p.Address = "madison";
            p.Age = 10;
            p.City = "Urbandale";
            
            p.Notes = "This is test";
            p.State = "IA";

            Book book = new Book();
            book.author = "sophy";
            book.datePublish = "9/4/2018";
            book.title = "cannot be null";
            string fileName = "//temp.txt";
            string docPath =  Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + fileName  ;
            FileStream fs = new FileStream(docPath,FileMode.OpenOrCreate);
            BinaryFormatter reader = new BinaryFormatter();
            reader.Serialize(fs, book);
            fs.Close();


            str += string.Format($"\r\ndata binary wrote to {docPath}\\{fileName }");
            return str;
        }
    }

 
}