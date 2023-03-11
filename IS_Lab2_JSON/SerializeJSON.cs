using System.Runtime.InteropServices;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Text.Unicode;

namespace IS_Lab2_JSON;

public class SerializeJSON
{
    public static void run(string path, string savePath)
    {
        Console.WriteLine("let's serialize something");
        DeserializeJSON deserialized = new DeserializeJSON(path);
        List<ShorterJST> shorterJsts = new List<ShorterJST>();
        foreach (var d in deserialized.data)
        {
            shorterJsts.Add(shorterJSTMapper(d));            
        }

        var options = new JsonSerializerOptions
        {
            Encoder = JavaScriptEncoder.Create(UnicodeRanges.LatinExtendedA, UnicodeRanges.LatinExtendedB, UnicodeRanges.Latin1Supplement, UnicodeRanges.BasicLatin),
            WriteIndented = true
        };
        string json = JsonSerializer.Serialize<List<ShorterJST>>(shorterJsts, options);
        File.WriteAllText(savePath, json, Encoding.UTF8);
    }

    public static void run(DeserializeJSON deserialized, string savePath)
    {
        Console.WriteLine("let's serialize something");
        List<ShorterJST> shorterJsts = new List<ShorterJST>();
        foreach (var d in deserialized.data)
        {
            shorterJsts.Add(shorterJSTMapper(d));            
        }

        string json = JsonSerializer.Serialize<List<ShorterJST>>(shorterJsts);
        File.WriteAllText(savePath, json);
    }

    private static ShorterJST shorterJSTMapper(JST jst)
    {
        ShorterJST mapped = new ShorterJST(jst.Kod_TERYT, jst.Województwo, jst.Powiat, jst.typ_JST,
            jst.nazwa_urzędu_JST, jst.miejscowość,
            Int32.Parse(jst.telefon_kierunkowy.ToString() + jst.telefon.ToString()));
        return mapped;
    }
    
}