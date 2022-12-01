using System.Xml.Serialization;

namespace XmlTransformation.Console;

[XmlRoot(ElementName = "Root")]
public class SampleOutputClass
{
    [XmlElement(ElementName = "ListOfStrings")]
    public string[] ListOfStrings { get; set; } = Array.Empty<string>();
}