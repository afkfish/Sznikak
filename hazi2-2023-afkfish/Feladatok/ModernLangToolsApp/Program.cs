using System.ComponentModel;
using System.Xml.Serialization;

namespace ModernLangToolsApp;

public class Program
{
    private static void ListManipulation(string msg)
    {
        Console.WriteLine(msg);
    }

    private static JediStore FillList()
    {
        var jediStore = new JediStore();
        var starkiller = new Jedi
        {
            Name = "Starkiller",
            MidiChlorianCount = 20000
        };
        var raySkywalker = new Jedi
        {
            Name = "Ray Skywalker",
            MidiChlorianCount = 500
        };
        jediStore.Add(starkiller);
        jediStore.Add(raySkywalker);
        return jediStore;
    }

    private static bool SzuroFuggveny(Jedi jedi)
    {
        return jedi.Name == "Ray Skywalker";
    }

    [Description("Feladat2")]
    private static void TestSerialization()
    {
        var yoda = new Jedi
        {
            Name = "Yoda",
            MidiChlorianCount = 9000
        };

        var serializer = new XmlSerializer(typeof(Jedi));
        var stream = new FileStream("jedi.txt", FileMode.Create);
        serializer.Serialize(stream, yoda);
        stream.Close();
        
        stream = new FileStream("jedi.txt", FileMode.Open);
        var clone = (Jedi)serializer.Deserialize(stream);
        stream.Close();
        Console.WriteLine(clone?.Name);
    }

    [Description("Feladat3")]
    private static void TestJediList()
    {
        var jediStore = new JediStore();
        var yoda = new Jedi
        {
            Name = "Yoda",
            MidiChlorianCount = 9000
        };
        var obivan = new Jedi
        {
            Name = "Obivan Kenobi",
            MidiChlorianCount = 5000
        };
        jediStore.listManipulation += ListManipulation;
        jediStore.Add(yoda);
        jediStore.Add(obivan);
        jediStore.Remove();
        jediStore.Remove();
    }

    [Description("Feladat4")]
    private static void TestWeakJediiListing()
    {
        var jediStore = new JediStore();
        var jediBob = new Jedi
        {
            Name = "Bob",
            MidiChlorianCount = int.MaxValue
        };
        var weaklingJedi = new Jedi
        {
            Name = "Barni",
            MidiChlorianCount = 35
        };
        
        jediStore.Add(jediBob);
        jediStore.Add(weaklingJedi);

        var weaklings = jediStore.ListWeakJedii_Delegate();
        if (!weaklings.Contains(weaklingJedi))
        {
            throw new ApplicationException("Hibasan szamitott");
        }
        weaklings.ForEach(jedi1 => Console.WriteLine(jedi1.Name + " is weak!"));
    }

    [Description("Feladat5")]
    private static void TestMediumJediiListing()
    {
        var jediStore = FillList();

        var mediumJedii = jediStore.ListMediumJedi_Lambda();
        mediumJedii.ForEach(jedi1 => Console.WriteLine(jedi1.Name + " is medium jedi."));
    }

    [Description("Feladat6")]
    private static void TestCountIfJedi()
    {
        var jediStore = FillList();
        Console.WriteLine(jediStore.Count);

        Console.WriteLine(jediStore.CountIf(SzuroFuggveny));
    }
    
    public static void Main(string[] args)
    {
        TestSerialization();
        TestJediList();
        TestWeakJediiListing();
        TestMediumJediiListing();
        TestCountIfJedi();
    }
}
