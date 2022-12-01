using System.Xml.Serialization;

namespace XmlTransformation.Console;

[XmlRoot(ElementName = "Root")]
public class SampleOutputClass2
{
    [XmlElement(ElementName = "NestedClass")]
    public SampleNestedClass NestedClass { get; set; } = new();
}

public class SampleNestedClass
{
    [XmlElement(ElementName = "SampleNestedRepeatedClass")]
    public SampleNestedRepeatedClass[] SampleNestedRepeatedClass { get; set; } =
        Array.Empty<SampleNestedRepeatedClass>();

}

public class SampleNestedRepeatedClass
{
    [XmlElement(ElementName = "Name")] public string Name { get; set; }
    [XmlElement(ElementName = "Age")] public string Age { get; set; }
    [XmlElement(ElementName = "Word")] public string Word { get; set; }
}