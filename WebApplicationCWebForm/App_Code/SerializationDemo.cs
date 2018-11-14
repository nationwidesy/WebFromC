using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace WebApplicationCWebForm.App_Code
{
    class SerializationDemo
    {
        public String output = string.Empty;

        public SerializationDemo()
        {
            Person2 person = new Person2("Sophy", 12345);
            IFormatter formatter = new BinaryFormatter();

            using(FileStream stream = File.Create ("sophytestPersonal.data"))
            {
                formatter.Serialize(stream, person);
            }

            using (FileStream stream = File.OpenRead("sophytestPersonal.data"))
            {
                Person2 obj = (Person2)formatter.Deserialize(stream);
                output = obj.ToString();
            }



        }
    }


    [Serializable] public class Person2
    {
        private string name;
        private int id;
        public Person2 (string nameVal, int idVal)
        {
            this.name = nameVal;
            this.id = idVal;
        }
        public override string ToString()
        {
            return "name=" + this.name + " id=" + this.id;
        }
    }
}
