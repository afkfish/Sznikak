namespace feladat;

[AttributeUsage(AttributeTargets.Property)]
public class WriteInToStringAttribute : Attribute
{
    public bool IsEnabled { get; set; }
}