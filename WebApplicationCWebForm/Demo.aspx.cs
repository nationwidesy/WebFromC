using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplicationCWebForm.App_Code;
using System.Threading;
using System.IO;
//add following lines
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Collections; //query
using System.Data;
using System.Data.SqlClient;
using System.Threading;


namespace WebApplicationCWebForm
{
    public partial class Demo : System.Web.UI.Page
    {
        double distance, hour, fuel = 0.0;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                Factory fa = new Factory();
                Employee myEmp = fa.GetEmployee();
                myEmp.FirstName = "Sophy";
                myEmp.LastName = "Yang";
                TextBox1.Text = "First Object created: " + myEmp.Name();
                Employee myEmp1 = fa.GetEmployee();
                myEmp1.FirstName = "Michael";
                myEmp1.LastName = "Yang";
                TextBox1.Text += "\r\nSecond Object created: " + myEmp1.Name();
                Employee myEmp2 = fa.GetEmployee();
                myEmp2.FirstName = "Tammy";
                myEmp2.LastName = "Yang";
                TextBox1.Text += "\r\nSecond Object created: " + myEmp2.Name();
                Employee myEmp4 = fa.GetEmployee();
                myEmp4.FirstName = "Jame";
                myEmp4.LastName = "Yang";
                TextBox1.Text += "\r\nSecond Object created: " + myEmp4.Name();
            }
            catch (Exception ex)
            {
                TextBox1.Text += "\r\n" + ex.Message;
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            QueuePool qPool = new QueuePool();
            qPool.Store(new Person());
            //Person p = qPool.Fetch();

            QueuePool<Person> qPoolPerson = new QueuePool<Person>();
            qPoolPerson.Store(new Person());
            Person p1 = qPoolPerson.Fetch();

            ObjectPoolObject<Person> pPoolObject = new ObjectPoolObject<Person>(10);
            Person a = pPoolObject.Get();
            Person a1 = pPoolObject.Get();
            a.Name = "Sophy";
            a1.Name = "Tammy";

            this.TextBox1.Text += string.Format($"\r\n {a.Name } meet {a1.Name} total employee in the queue {pPoolObject.Count()}");
            this.TextBox1.Text += "\r\nQueue is a Simple DataStucture which allows Add or Remove of Items at one of the ends only. It is basically called as First in First out data structure. Enqueue() and Dequeue()";
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            StackPool<Person> pStackPool = new StackPool<Person>();
            pStackPool.Store(new Person());
            pStackPool.Store(new Person());

            Person p1 = pStackPool.Fetch();
            Person p2 = pStackPool.Fetch();
            this.TextBox1.Text += string.Format($"\r\nThe Stack class implements a Last in First Out data structure. Push() and Pop()");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
        }

        protected void Button5_Click(object sender, EventArgs e)
        {

            GenericList<int> list1 = new GenericList<int>();
            GenericList<string> list2 = new GenericList<string>();
            GenericList<Person> list31 = new GenericList<Person>();
            //reusability, you can put any data type


            this.TextBox1.Text += string.Format($" generics allow you to write a class or method that can work with any data type.");

            this.TextBox1.Text += Swap.Swaptest();
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            NumberChanger<int> deN1 = new NumberChanger<int>(DelegateDemo.AddNum);
            NumberChanger<int> deN2 = new NumberChanger<int>(DelegateDemo.MultNum);

            deN1(25);
            this.TextBox1.Text += string.Format($"\r\nValue of Num: {DelegateDemo.getNum()}"); //35 = 10+25
            deN2(5);
            this.TextBox1.Text += string.Format($"\r\nValue of Num: {DelegateDemo.getNum()}"); //175 = 35*5

        }




        protected void CustomValidator1_ServerValidate(object source, ServerValidateEventArgs args)
        {
            double myNum;
            if (this.TextBox2.Text == string.Empty)
            {
                this.CustomValidator1.ErrorMessage = "Please enter Distance (0.00)";
                args.IsValid = false;
            }
            else if (double.TryParse(this.TextBox2.Text, out myNum))
            {
                args.IsValid = true;
            }
            else
            {
                this.CustomValidator1.ErrorMessage = "Please enter number only.";
                args.IsValid = false;
            }
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
           this.TextBox1.Text = string.Empty;
            
            //clean gridview data
            int totalRow = this.GridView1.Rows.Count;
            if (totalRow > 0)
            {
                 
                this.GridView1.DataSource = null;
                this.GridView1.DataBind();

            }
            this.GridView1.Visible = false;
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                ArrayListDemo a = new ArrayListDemo();

                this.TextBox1.Text += string.Format($"\r\n{a.ArrayListTest()}");
            }
            catch (Exception ex)
            {
                this.TextBox1.Text += string.Format($"\r\nError occurred {ex.Message }");
            }
        }

    




        protected void Button7_Click(object sender, EventArgs e)
        {

            this.TextBox1.Text += string.Format($"A virtual method is a method that can be redefined in derived classes. Base Class (virtual keyword) Derived Class (override)");
            this.Label2.Visible = true;
            this.Label2.Text = "Enter the Distance";
            this.TextBox2.Visible = true;
            this.Label3.Visible = true;
            this.Label3.Text = "Enter the Hours";
            this.TextBox3.Visible = true;
            this.Label4.Visible = true;
            this.Label4.Text = "Enter the Fuel";
            this.TextBox4.Visible = true;
            this.Button11.Visible = true;

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.distance = Convert.ToDouble(this.TextBox2.Text);

            }
            catch (Exception ex)
            {
                this.TextBox1.Text += "\r\nError occurred (" + ex.Message + ")";
                this.TextBox2.Text = "0";
            }
            finally
            {
                this.TextBox1.Text += "\r\nDistance = " + this.distance;
            }
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Car oCar = new Car(distance, hour, fuel);
            Vehicle oVeh = new Vehicle(distance, hour, fuel);
            this.TextBox1.Text += string.Format($"\r\n{oCar.Average()}");
            this.TextBox1.Text += string.Format($"\r\n{oVeh.Average()}");
            this.TextBox1.Text += string.Format($"\r\n{oCar.Speed()}");
            this.TextBox1.Text += string.Format($"\r\n{oVeh.Speed()}");
            this.Button11.Visible = false;
            this.Label2.Visible = false;
            this.TextBox2.Visible = false;
            this.Label3.Visible = false;
            this.TextBox3.Visible = false;
            this.Label4.Visible = false;
            this.TextBox4.Visible = false;

        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            IEnumeratorDemo iEnum = new IEnumeratorDemo();
            this.TextBox1.Text += string.Format($"\r\n{iEnum.IEnumeratorTest () }");
        }

        protected void Button12_Click(object sender, EventArgs e)
        {
            ValueVsReference v = new ValueVsReference();
            this.TextBox1.Text += string.Format($"\r\n{ v.ValueVsReferenceDemo() }");
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text += string.Format($"\r\nSerialization means saving the state of your object to secondary memory, such as a file  ");
            XmlSerializationDemo x = new XmlSerializationDemo();
            this.TextBox1.Text += string.Format($"{x.XmlSerializationTest () }");
            x.WriteXML();
            
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text += string.Format($"\r\nDeserialization is reverse of serialization i.e. it's a process of reading objects from a file where they have been stored.");
            XmlSerializationDemo x = new XmlSerializationDemo();
            this.TextBox1.Text += string.Format($"{x.ReadXML () }");
             

        }

        protected void Button15_Click(object sender, EventArgs e)
        {//not working
            ReadWriteFiles rw = new ReadWriteFiles();
            string fileLocation = "c:\\Users\\Sophy_2\\Documents\\temp.txt";
            rw.CreadFile(fileLocation);
            this.TextBox1.Text = string.Format($"\r\nFile Creaded at {fileLocation}");
/*
            SerializeDemo rwB = new SerializeDemo();
            this.TextBox1.Text = rwB.WriteToBinary() ;
*/
        }

        protected void Button16_Click(object sender, EventArgs e)
        {
            UsingDemo u = new UsingDemo();
            this.TextBox1.Text = string.Format($"\r\nUsing sttement block must implement the IDisposable interface");
            this.TextBox1.Text = string.Format($"\r\n");

            this.TextBox1.Text = string.Format($"\r\n");
        }

        protected void Button17_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text = string.Format($"\r\nA jagged array is an array whose elements are arrays");
            int[][] jaggedArray = new int[5][];

            jaggedArray[0] = new int[3];
            jaggedArray[1] = new int[5];
            jaggedArray[2] = new int[2];
            jaggedArray[3] = new int[8];
            jaggedArray[4] = new int[10];

            jaggedArray[0] = new int[3] { 3, 5, 7 };
            jaggedArray[1] = new int[5] {1,0,2,4,6};
            jaggedArray[2] = new int[2] {1,6 };
            jaggedArray[3] = new int[8] { 1,0,2,4,6,45,67,78};
            jaggedArray[4] = new int[10] { 1, 0, 2, 4, 6,34, 45, 67,87, 78 };

            int[][] jaggedArray1 = new int[][]
            {
                new int[] { 3, 5, 7, },
                new int[] { 1, 0, 2, 4, 6 },
                new int[] { 1, 6 },
                new int[] { 1, 0, 2, 4, 6, 45, 67, 78 }
            };


            

            this.TextBox1.Text = string.Format($"\r\nJagged Arrays (array-of-arrays)");
        }

        protected void Button18_Click(object sender, EventArgs e)
        {
            string mRef = string.Empty;
            MultitreadingDemo m = new MultitreadingDemo( );

            this.TextBox1.Text += string.Format($"\r\nA thread is similar to a sequential program. However, a thread itself is not a program, it can't run on its own, instead it runs within a program's context.");
            m.MultitreadingTest(out mRef);
            this.TextBox1.Text = string.Format($"\r\n { mRef}");
             this.TextBox1.Text += string.Format($"\r\n");
        }

        protected void Button19_Click(object sender, EventArgs e)
        {
            // m = new MultitreadingDemo();
            ThreadStart childthread = new ThreadStart(childThreadCall);
            Response.Write("Child Thread Started<br/>");
            Thread child = new Thread(childthread);

            child.Start();

            Response.Write("Main sleeping for 2 seconds...... <br/>");
            Thread.Sleep(200);
            Response.Write("<br/>Main aborting child thread<br/>");

            child.Abort();
        }
        public void childThreadCall()
        {
            try
            {
                this.Label5.Text = "<br/>Child thread start<br/>";
                this.Label5.Text += "Child Thread: Coiunting to 10";

                for (int i = 0; i < 10; i++)
                {
                    Thread.Sleep(200);
                    this.Label5.Text += "<br/> in Child thread </br>";
                }

                this.Label5.Text += "<br/> child thread finished </br>";
            }
            catch (ThreadAbortException e)
            {
                this.Label5.Text += "<br/>child thread - exception " + e.Message ;
            }
            finally
            {
                this.Label5.Text += "<br/> child thread - unable to catch the exception";
            }

        }
        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button20_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text += "\r\nHaving too much locking in an application can get your application into trouble. In a deadlock, at least two threads wait for each other to release a lock. As both threads wait for each other, a deadlock situation occurs and threads wait endlessly and the program stops responding.";
            this.TextBox1.Text += "\r\nhttps://www.c-sharpcorner.com/UploadFile/84c85b/multithreading-with-net/";
        }

        protected void Button21_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text += "\r\n A Hashtable is a collection that stores (Keys, Values) pairs.";
            HashtableDemo ht = new HashtableDemo();
            this.TextBox1.Text += "\r\n" +ht.HashtableTest();
        }

        protected void Button22_Click(object sender, EventArgs e)
        {
            this.TextBox1.Text += "\r\nProperties of the Anonymous type is read only";
            this.TextBox1.Text += "\r\nAnonymous types are also used with the 'Select' clause of LINQ query expression to return subset of properties.";
            this.TextBox1.Text += "\r\n";
            this.TextBox1.Text += "\r\n";
        }

        protected void Button23_Click(object sender, EventArgs e)
        {
            try
            {         
                this.GridView1.Visible = true;
                this.TextBox1.Text += "\r\nLINQ stands for Language Integrated Query";
                LINQdemo l = new LINQdemo();
                this.TextBox1.Text += "\r\n"+ l.myDemo();
                this.TextBox1.Text += "\r\ntotal people illegible for vote: " + l.TotalPatientillegibleforVote  () ;

                /*
                this.GridView1.DataSource = from a in pList select a;
                */


                this.GridView1.DataSource =
                    from a in l.PatientList()
                    where a.Age > 5
                    orderby a.PatientName, a.Gender, a.Age
                    select a;
                                     
                this.GridView1.DataBind();

 
                var mypatient = from pa in l.PatientList()
                                where pa.Age >= 5
                                select pa;
                foreach (var pp in mypatient)
                {
                    this.TextBox1.Text += "\r\n" + pp.PatientName  ;
                   
                }

        

            }
            catch (Exception ex)
            {
                this.TextBox1.Text += "\r\n" + ex.Message ;
            }
            this.TextBox1.Text += "\r\n"  ;
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        protected void Button24_Click(object sender, EventArgs e)
        {
            FileHandlingDemo fh = new FileHandlingDemo();

            this.TextBox1.Text += "\r\n" + fh.fileHandingTest();

        }
        protected void Button25_Click(object sender, EventArgs e)
        {
            string fileLocationPath = string.Format (@"C:\Users\Sophy_2\source\repos\SophyTestCreateSubDirectory\");
        
            string fileName = "sophyTest.txt";
            string testFileName = "sophyExistTestData.txt";
            
            // concatenate 2 string
            var sb = new System.Text.StringBuilder();
            sb.AppendLine(fileLocationPath);
            sb.AppendLine(fileName);
            string filePath = sb.ToString();

            string[] words = new string[2];
            words[0] = fileLocationPath;
            words[1] = testFileName;
            var filePath1 = string.Concat(words);

            this.TextBox1.Text += "\r\nFile name : " + filePath;

            this.TextBox1.Text += "\r\nFile name : " + filePath1;

            //read file
            this.TextBox1.Text += "\r\n" + File.ReadAllText(@"C:\Users\Sophy_2\source\repos\SophyTestCreateSubDirectory\" + fileName);
            this.TextBox1.Text += "\r\n" + File.ReadAllText(@"C:\Users\Sophy_2\source\repos\SophyTestCreateSubDirectory\"+ testFileName);
            //write file 
            this.TextBox1.Text += "\r\n================\r\rWrite to file";
            //File.AppendAllText(@"C:\Users\Sophy_2\source\repos\SophyTestCreateSubDirectory\sophyTest.txt",Environment.NewLine + "add new testing line"  );
            File.WriteAllText(@"C:\Users\Sophy_2\source\repos\SophyTestCreateSubDirectory\sophyTest.txt",  TextBox1.Text);
        }

        protected void Button27_Click(object sender, EventArgs e)
        {
             
            DBconnectionDemo.connectionBuildingDemo();
            this.TextBox1.Text += "\r\n" + DBconnectionDemo.messageDBconnectionDemo();
        }

        protected void Button26_Click(object sender, EventArgs e)
        {
            ReflectionDemo r = new ReflectionDemo();
            string typName = "System.Math";
            Type t = Type.GetType(typName);
            this.TextBox1.Text += "\r\n" + r.FieldInvestigation(t);
            this.TextBox1.Text += "\r\n" + r.MethodInvestigation(t);
        }

        protected void Button29_Click(object sender, EventArgs e)
        {
            SerializationDemo s = new SerializationDemo();
            this.TextBox1.Text = s.output;
        }

        protected void Button30_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebApplicationCWebFormDemo.aspx");
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.hour  = Convert.ToDouble(this.TextBox3.Text);

            }
            catch (Exception ex)
            {
                this.TextBox1.Text += "\r\nError occurred (" + ex.Message + ")";
                this.TextBox3.Text = "0";
            }
            finally
            {
                this.TextBox1.Text += "\r\nHour  = " + this.hour ;
            }
        }
        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                this.fuel  = Convert.ToDouble(this.TextBox4.Text);

            }
            catch (Exception ex)
            {
                this.TextBox1.Text += "\r\nError occurred (" + ex.Message + ")";
                this.TextBox4.Text = "0";
            }
            finally
            {
                this.TextBox1.Text += "\r\nHour  = " + this.fuel ;
            }
        }
    }
}
    
