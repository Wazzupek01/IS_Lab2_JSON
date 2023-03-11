

namespace IS_Lab2_JSON
{
    class Program
    {
        public static void Main()
        { 
            // DeserializeJSON deserializedJson = new DeserializeJSON("./Assets/data.json");
            // deserializedJson.someStats();
            //
            // SerializeJSON.run("./Assets/data.json", "../../../Assets/data_mod.json");
            
            ConvertJSONToYAML.run(new DeserializeJSON("../../../Assets/data_mod.json"), "../../../data_ymod.yml");
        }
    }
}