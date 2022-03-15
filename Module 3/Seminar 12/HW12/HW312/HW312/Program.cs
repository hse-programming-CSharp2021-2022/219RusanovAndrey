using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HW312
{
    [Serializable]
    public class Human
    {
        public string Name { get; set; }

        public Human()
        {
        }

        public Human(string name)
        {
            Name = name;
        }
    }

    [Serializable]
    public class Professor : Human
    {
        public Professor()
        {
        }

        public Professor(string name) : base(name)
        {
        }
    }

    [Serializable]
    [XmlInclude(typeof(Professor))]
    [XmlInclude(typeof(Human))]
    public class Department
    {
        public string Name { get; set; }
        public List<Human> People { get; set; }

        public Department()
        {
        }

        public Department(string name, List<Human> people)
        {
            Name = name;
            People = new List<Human>(people);
        }
    }

    [Serializable]
    [XmlInclude(typeof(Professor))]
    [XmlInclude(typeof(Human))]
    [XmlInclude(typeof(Department))]
    public class University
    {
        public string Name { get; set; }

        public List<Department> Departments { get; set; }

        public University()
        {
        }

        public University(string name, List<Department> departments)
        {
            Name = name;
            Departments = departments;
        }
    }

    class Program
    {
        public static string GenerateName()
        {
            string name = "";
            var rand = new Random();
            name += Convert.ToChar(rand.Next(65, 91));
            int len = rand.Next(3, 12);
            for (int i = 0; i < len; i++)
            {
                name += Convert.ToChar(rand.Next(97, 123));
            }

            return name;
        }

        public static async Task Main()
        {
            Random random = new Random();
            List<University> universities = new List<University>();
            for (int i = 0; i < random.Next(2, 5); i++)
            {
                University university =
                    new University(GenerateName(), new List<Department>());
                for (int j = 0; j < random.Next(4, 6); j++)
                {
                    Department department = new Department(GenerateName(), new List<Human>());
                    for (int k = 0; k < random.Next(7, 10); k++)
                    {
                        int t = random.Next(0, 2);
                        if (t == 0)
                        {
                            department.People.Add(new Human(GenerateName()));
                        }

                        if (t == 1)
                        {
                            department.People.Add(new Professor(GenerateName()));
                        }
                    }

                    university.Departments.Add(department);
                }

                universities.Add(university);
            }

            BinaryFormatter binaryFormatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("universities.dat", FileMode.Create))
            {
                binaryFormatter.Serialize(fs, universities);

                Console.WriteLine("Объект сериализован");
            }

            using (FileStream fs = new FileStream("universities.dat", FileMode.Open))
            {
                var deserializedUniversities = (List<University>)binaryFormatter.Deserialize(fs);

                Console.WriteLine("Объект десериализован");
            }

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<University>));

            using (FileStream fs = new FileStream("universities.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, universities);

                Console.WriteLine("Объект сериализован");
            }

            using (var fs = new FileStream("universities.xml", FileMode.Open))
            {
                var deserializedUniversities = (List<University>)xmlSerializer.Deserialize(fs);
                Console.WriteLine("Объект десериализован");
            }


            using (var fs = new FileStream("universities.json", FileMode.Create))
            {
                await JsonSerializer.SerializeAsync(fs, universities);
                Console.WriteLine("Объект сериализован");
            }

            using (var fs = new FileStream("universities.json", FileMode.Open))
            {
                var deserializedUniversities = await JsonSerializer.DeserializeAsync<List<University>>(fs);
                Console.WriteLine("Объект десериализован");
            }
        }
    }
}