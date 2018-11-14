using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//add following lines
using System.IO;
using System.Collections;


namespace WebApplicationCWebForm.App_Code
{
    public class ReadWriteFiles
    {
        public ReadWriteFiles()
        {
            string fileName = "//tempBook.xml";
            string fileLocation = string.Format($"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\{fileName}");


        }
        public void CreadFile(string fileLocation)
        {
             
        }
    }
}