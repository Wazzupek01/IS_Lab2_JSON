using System.Text;

namespace IS_Lab2_JSON;
using YamlDotNet.Serialization;

public class ConvertJSONToYAML
{
    public static void run(string path, string savePath)
    {
        DeserializeJSON deserialized = new DeserializeJSON(path);
        var serializer = new Serializer();
        var yaml = serializer.Serialize(deserialized.data);
        File.WriteAllText(savePath, yaml, Encoding.UTF8);
    }

    public static void run(DeserializeJSON deserialized, string savePath)
    {
        var serializer = new Serializer();
        var yaml = serializer.Serialize(deserialized.data);
        File.WriteAllText(savePath, yaml, Encoding.UTF8);
    }
}