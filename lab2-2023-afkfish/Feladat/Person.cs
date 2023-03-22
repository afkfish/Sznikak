using System.Reflection;
using System.Text;
using System.Xml.Serialization;

namespace feladat
{
    public delegate void AgeChangingDelegate(int oldAge, int newAge);
    
    [XmlRoot("Szemely")]
    public class Person
    {
        private int _age;
        [XmlAttribute("Kor")]
        [WriteInToString(IsEnabled = true)]
        public int Age
        {
            get => _age;
            set { 
                if (value == _age)
                    return;
                if (value < 0)
                    throw new ArgumentException("Érvénytelen életkor!");
                AgeChanging?.Invoke(_age, value);
                _age = value;
            }
        }
        
        [XmlIgnore]
        public string Name { get; init; } = "anonymous";
        
        public event AgeChangingDelegate? AgeChanging;
        
        public override string ToString()
        {
            var s = new StringBuilder();
            s.AppendLine(base.ToString());

            foreach (var property in typeof(Person).GetProperties())
            {
                if (property.GetCustomAttribute<WriteInToStringAttribute>()?.IsEnabled ?? false)
                {
                    s.AppendLine($"\t{property.Name} = {property.GetValue(this)}");
                }
            }

            return s.ToString();
        }
    }
}

