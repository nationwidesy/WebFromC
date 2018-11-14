using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//add lines bleow
using System.IO;
using System.Text; //for encoding
using System.Collections.Specialized;
using System.Collections;

 

namespace WebApplicationCWebForm.App_Code
{
    public class FileHandlingDemo
    {
        public string fileHandingTest()
        {
            string str = string.Empty;

            DriveInfo[] di = DriveInfo.GetDrives();
            str += string.Format($"\r\nTotal Partitions");
            foreach(DriveInfo items in di)
            {
                str += string.Format($"\r\n{items.Name }");
            }
            str += string.Format($"\r\n");

            DriveInfo d1 = new DriveInfo("C");
            str += string.Format($"\r\n{d1.Name}");
            str += string.Format("\r\nTotal Space: {0:#,###,###,##,##0}", d1.TotalSize);
            str += string.Format("\r\nTotal Space: {0:#,###,###,##,##0}", d1.TotalFreeSpace);
            str += string.Format($"\r\nDriver Format: {d1.DriveFormat }");
            str += string.Format($"\r\nVolumn Label: {d1.VolumeLabel }");
            str += string.Format($"\r\nDrive Type: {d1.DriveType }");
            str += string.Format($"\r\nRoot directory: {d1.RootDirectory }");
            str += string.Format($"\r\nDrive is Reasy: {d1.IsReady }");

            DirectoryInfo dri = new DirectoryInfo(@"C:\Users\Sophy_2\source\repos");
            str += string.Format($"\r\n********* Directory Information ***********");
            str += string.Format($"\r\nFull Name {dri.FullName }");
            str += string.Format($"\r\nRoot = {dri.Root }");
            str += string.Format($"\r\nAttributes= {dri.Attributes }");
            str += string.Format($"\r\nCreation Time = {dri.CreationTime }");
            str += string.Format($"\r\nParent = {dri.Parent}");
            dri.CreateSubdirectory("SophyTestCreateSubDirectory");
            dri.CreateSubdirectory(@"SophyTestCreateSubDirectory\test");
            DirectoryInfo dr1 = new DirectoryInfo(@"C:\Users\Sophy_2\source\repos\SophyTestCreateSubDirectory\test");
            Directory.Delete(@"C:\Users\Sophy_2\source\repos\SophyTestCreateSubDirectory\test", true  );
            DirectoryInfo fileDir = new DirectoryInfo(@"C:\Users\Sophy_2\source\repos\SophyTestCreateSubDirectory");
            string fileNameDAT = "sophyTest.dat";
            string fileNameTXT = "sophytext.txt";
            
            //Create binary file
            //using statement blcok: object will automatically destroyed, IDisposable
            //garabge collector dispose method
            using (FileStream fs = new FileStream ($@"{fileDir.FullName}\{fileNameDAT}" , FileMode.Create))
            {
                string msg = string.Format($"First Prgram: {Convert.ToString (DateTime.Now)}");
                byte[] byteArray = Encoding.Default.GetBytes(msg);
                fs.Write(byteArray, 0, byteArray.Length);
                fs.Position = 0;

                byte[] rFile = new byte[byteArray.Length];
                str += string.Format($"\r\n====== Binary file readin =====\r\n");
                for (int i=0;i<byteArray.Length; i++)
                {
                    rFile[i] = (byte)fs.ReadByte();
                    str += rFile[i];
                }
            }
            str += string.Format($"\r\n");
            //*************** FileInfo ***************************
            FileInfo fi = new FileInfo($@"{fileDir.FullName}\{fileNameDAT}");
            //*************** FileInfo ***************************

            //read write Binary file
            //BinaryWriter
            using (BinaryWriter bWriter = new BinaryWriter(fi.OpenWrite()))
            {
                int x = 7;
                string str1 = "BinaryWrite ==> FileInfo.OpenWrite(), FileInfo.OpenRead()";
                bWriter.Write(x);
                bWriter.Write(str1);
            }
            str += string.Format($@"Binary file locaton: {fileDir.FullName}\{fileNameDAT}");

            //reading binary file
            //BinaryReader
            str += string.Format($"\r\n=================");
            using (BinaryReader bReader = new BinaryReader(fi.OpenRead()))
            {
                
                str += string.Format($"\r\n {bReader.ReadInt32 ()}");
                str += string.Format($"\r\n {bReader.ReadString()}");
            }

            //reading string
            //StringWrite
            using (StringWriter sWriter = new StringWriter())
            {
                sWriter.WriteLine(string.Format($"This is test on {DateTime.Now.DayOfWeek } at {DateTime.Now}"));
                //read
                using (StringReader sReader = new StringReader(sWriter.ToString()))
                {
                    string input = null;
                    while ((input = sReader.ReadLine()) != null) 
                    {
                        str += string.Format($"\r\n{input}");
                    }

                }
            }
            //TextWriter 
            using (TextWriter tWriter = File.CreateText($@"{fileDir.FullName}\{fileNameTXT}"))
            {
                tWriter.WriteLine("====== TextWriter =====");
                tWriter.WriteLine("1. write first line");
                tWriter.WriteLine("TextWrite use FileStream.File.CreatText");
                tWriter.WriteLine("BinaryWrite use FileInfo.OpenWrite() and FileInfo.OpenRead()" );
                tWriter.WriteLine("StringWrite StringWriter.WriteLin() and StringReader.ReadLine()");
                tWriter.Write(tWriter.NewLine);
            }

            str += string.Format($"\r\n");

            //FileString  write file
            FileStream fs1 = new FileStream($@"{fileDir.FullName}\{fileNameTXT}", FileMode.Create , FileAccess.Write);
            StreamWriter sWriter1 = new StreamWriter(fs1);
            sWriter1.WriteLine("==== StreamWriter =====");
            sWriter1.WriteLine("StreamWriter use FileStream to assign new fs");
            sWriter1.WriteLine("StreamReader");
            sWriter1.WriteLine("sw.Flush(), sw.Close()");
            sWriter1.WriteLine("need remember close fs.Close()");
            sWriter1.Flush();
            sWriter1.Close();
            fs1.Close();
            str += string.Format($"\r\nFileStream writed to ");
            str += string.Format($@"{fileDir.FullName}\{fileNameTXT}");
            //FileStream read file
            FileStream fs2 = new FileStream($@"{fileDir.FullName}\{fileNameTXT}", FileMode.OpenOrCreate , FileAccess.Read);
            StreamReader sRead = new StreamReader(fs2);
            string strLine = sRead.ReadLine();
            while (strLine != null)
            {
                str += string.Format($"\r\nWrite to file: ");
                str += string.Format($"\r\n");
                str += string.Format($@"{fileDir.FullName}\{fileNameTXT}");
            }
            sRead.Close();
            fs2.Close();
            /*

             */

            return str;
        }
    }

   
}