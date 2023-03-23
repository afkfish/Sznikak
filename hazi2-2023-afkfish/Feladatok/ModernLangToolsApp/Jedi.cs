using System.Xml.Serialization;

namespace ModernLangToolsApp;

[XmlRoot("Jedi")]
public class Jedi
{
    [XmlAttribute("Név")]
    public string Name
    {
        get;
        init;
    }
    
    
    private int _midiChlorianCount;
    [XmlAttribute("Midiklorián_mennyiség")]
    public int MidiChlorianCount
    {
        get => _midiChlorianCount;
        set {
            if (value < 35)
            {
                throw new ArgumentException("You are not a true jedi!");
            }

            _midiChlorianCount = value;
        }
    }
}