namespace ModernLangToolsApp;

public delegate void ListManipulationDelegate(string msg);
public class JediStore
{
    public event ListManipulationDelegate listManipulation;

    private readonly List<Jedi> _jedis = new();

    public int Count => _jedis.Count;

    public int CountIf(Func<Jedi, bool> func)
    {
        var count = 0;
        foreach (var jedi in _jedis)
        {
            if (func(jedi))
            {
                count++;
            }
        }
        return count;
    }

    public void Add(Jedi jedi)
    {
        listManipulation?.Invoke("Jedi added to list.");
        _jedis.Add(jedi);
    }

    public void Remove()
    {
        if (_jedis.Count == 0) return;
        listManipulation?.Invoke(_jedis.Count == 1 ? "The jedi list is empty." : "A jedi has been removed.");
        _jedis.RemoveAt(_jedis.Count - 1);
    }

    public List<Jedi> ListWeakJedii_Delegate()
    {
        return _jedis.FindAll(Weakling);
    }

    private static bool Weakling(Jedi jedi)
    {
        return jedi.MidiChlorianCount < 530;
    }

    public List<Jedi> ListMediumJedi_Lambda()
    {
        return _jedis.FindAll(jedi1 => jedi1.MidiChlorianCount < 1000);
    }
}