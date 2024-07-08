using ConsoleApp1.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Text.Json;

namespace ConsoleApp1
{
    internal class Ex09Serialization
    {
        static void Main(string[] args)
        {
           // testforXMLSerialization();
            testforJsonSerialization();
        }

        private static void testforXMLSerialization()
        {
            //XMLSerialization();
            //XmlDeserializations();
            
        }

        private static void testforJsonSerialization()
        {
            JsonSerialization();
            JsonDeSerialization();
        }

        private static void JsonSerialization()
        {
            var student = new Student
            {
                Id = 1,
                Name = "Srushti",
                Address = "Sidnal"
            };
            

            AppSettings.Initialize();
            var file = AppSettings.Configuration["FileOptions:jsonFile"];
            

            var jsonString =  JsonSerializer.Serialize(student);
            File.WriteAllText(file, jsonString);


          
            Console.WriteLine(jsonString);

            

        }

        private static void JsonDeSerialization()
        {
            AppSettings.Initialize();
            var file = AppSettings.Configuration["FileOptions:jsonFile"];
            string jsonString = File.ReadAllText(file);
            //Console.WriteLine(jsonString);
               Student student = JsonSerializer.Deserialize<Student>(jsonString);
            Console.WriteLine(student.Name);

        }

        private static void XmlDeserializations()
        {
            AppSettings.Initialize();
            var file = AppSettings.Configuration["FileOptions:XMLFile"];
            FileStream fs = new FileStream(file, FileMode.Open,FileAccess.Read);

            var formatter = new XmlSerializer(typeof(Student));
            var student = formatter.Deserialize(fs) as Student;
            Console.WriteLine(student.Name);
            fs.Close();
        }

        private static void XMLSerialization()
        {
            Student student = new Student { Id = 11, Address = "Mysore", Name = "Srushti" };
            AppSettings.Initialize();
            var file = AppSettings.Configuration["FileOptions:XMLFile"];
            FileStream fs = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);
            var formatter = new XmlSerializer(typeof(Student));
            formatter.Serialize(fs, student);
            fs.Close();
        }
    }
}
