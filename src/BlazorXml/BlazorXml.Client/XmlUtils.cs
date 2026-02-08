namespace BlazorXml.Client;

public class XmlUtils
{
    public static string GetXml() => """
    <Property>
        <Name>Foo Property</Name>
        <PropertyMap Lat="45" Long="90.5">
            <KML>
                <Placemark>
                    <name>Simple placemark</name>
                    <description>
                        Attached to the ground. Intelligently places itself 
                        at the height of the underlying terrain.
                    </description>
                    <Point>
                    <coordinates>-122.0822035425683,37.42228990140251,0</coordinates>
                    </Point>
                </Placemark>
            </KML>
        </PropertyMap>
    </Property>
    """;
}
