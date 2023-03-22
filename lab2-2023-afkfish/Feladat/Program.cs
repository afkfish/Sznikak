using System.Xml.Serialization;

namespace feladat
{
    class Program
    {
        private static bool MyFilter(int n)
        {
            return n % 2 == 1;
        }
        
        private static void PersonAgeChanging(int oldAge, int newAge)
        {
            Console.WriteLine(oldAge + " => " + newAge);
        }
        
        private static void Main()
        {
            var p = new Person
            {
                Name = "Luke",
                Age = 27
            };
            p.AgeChanging += PersonAgeChanging;
            p.AgeChanging += PersonAgeChanging;
            p.AgeChanging -= PersonAgeChanging;
            p.Age = 2;
            p.Age++;
            Console.WriteLine(p.Age);
            Console.WriteLine(p.Name);
            
            Console.WriteLine(p);
            
            var serializer = new XmlSerializer(typeof(Person));
            var stream = new FileStream("person.txt", FileMode.Create);
            serializer.Serialize(stream, p);
            stream.Close();
            // Process.Start(new ProcessStartInfo
            // {
            //     FileName = "person.txt",
            //     UseShellExecute = true,
            // });
            
            var list = new List<int>
            {
                1, 2, 3
            };
            list = list.FindAll(n => n % 2 == 1);

            foreach (var n in list)
            {
                Console.WriteLine($"Value: {n}");
            }
            
        }
    }
}
