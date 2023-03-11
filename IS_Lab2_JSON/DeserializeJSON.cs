using System.Text.Json;

namespace IS_Lab2_JSON;

public class DeserializeJSON
{
    public List<JST> data { get; set; }

    public DeserializeJSON(string file)
    {
        Console.WriteLine("let's deserialize something");
        string jsonString = File.ReadAllText(file);
        this.data = JsonSerializer.Deserialize<List<JST>>(jsonString)!;
    }

    public void someStats()
    {
        Dictionary<string, Dictionary<string, int>> wojewodztwa = new Dictionary<string, Dictionary<string, int>>();
        foreach (var d in this.data)
        {
            if (!wojewodztwa.ContainsKey(d.Województwo))
            {
                wojewodztwa[d.Województwo] = new Dictionary<string, int>();
            }

            if (!wojewodztwa[d.Województwo].ContainsKey(d.typ_JST))
            {
                wojewodztwa[d.Województwo][d.typ_JST] = 0;
            }
            wojewodztwa[d.Województwo][d.typ_JST]++;
        }

        foreach (var woj in wojewodztwa)
        {
            Console.WriteLine(woj.Key);
            foreach (var jednostka in woj.Value)
            {
                Console.WriteLine("\t" + jednostka.Key + ": " + jednostka.Value);
            }
        }
    }
}