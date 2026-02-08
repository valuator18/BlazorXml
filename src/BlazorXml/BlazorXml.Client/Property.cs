using System.Xml.Linq;
using System.Xml.Serialization;

namespace BlazorXml.Client;

[XmlRoot]
public class Property
{
    public string? Name { get; set; }

    [XmlElement("PropertyMap")]
    public PropertyMap? Map { get; set; }
}

public class PropertyMap
{
    [XmlAttribute]
    public double Lat { get; set; }

    [XmlAttribute]
    public double Long { get; set; }

    public XElement? KML { get; set; } 
}
