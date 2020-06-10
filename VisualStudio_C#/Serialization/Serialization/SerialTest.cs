using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public class SerialTest
    {
        public void SerializeNow()
        {
            Person p = new Person();
            p.age = 19;
            p.name = "Aman";
            Stream Str = File.Open("info.dat", FileMode.Create);
            BinaryFormatter b = new BinaryFormatter();
            b.Serialize(Str,p);
            Str.Close();
        }

        public void DeserializeNow()
        {
            Person P_ = new Person();
            Stream S = File.Open("info.dat", FileMode.Open);
            BinaryFormatter b_ = new BinaryFormatter();
            object obj = b_.Deserialize(S);

            P_ = (Person)obj;
            Console.WriteLine(P_.age);
            Console.WriteLine(P_.name);
            Console.ReadKey();
        }
    }
}
