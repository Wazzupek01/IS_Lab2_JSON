using System.Text.Json.Serialization;

namespace IS_Lab2_JSON;

public class JST
{
    public int Kod_TERYT { get; set; }
    public string nazwa_samorządu { get; set; }
    public string Województwo { get; set; }
    public string Powiat { get; set; }
    public string typ_JST { get; set; }
    public string nazwa_urzędu_JST { get; set; }
    public string miejscowość { get; set; }
    
    [JsonPropertyName("Kod pocztowy")]
    public string Kod_pocztowy { get; set; }
    public string poczta { get; set; }
    public string Ulica { get; set; }
    
    [JsonPropertyName("Nr domu")]
    public object Nr_domu { get; set; }
    
    [JsonPropertyName("telefon kierunkowy")]
    public int telefon_kierunkowy { get; set; }
    public int telefon { get; set; }
    
    [JsonPropertyName("telefon 2")]
    public object telefon_2 { get; set; }
    public object wewnętrzny { get; set; }
    
    [JsonPropertyName("FAX kierunkowy")]
    public object FAX_kierunkowy { get; set; }
    public object FAX { get; set; }
    
    [JsonPropertyName("FAX wewnętrzny")]
    public object FAX_wewnętrzny { get; set; }
    
    [JsonPropertyName("ogólny adres poczty elektronicznej gminy/powiatu/województwa")]
    public string ogólny_adres_poczty_elektronicznej_gminy_powiatu_województwa { get; set; }
    
    [JsonPropertyName("adres www jednostki")]
    public string adres_www_jednostki { get; set; }
    public string ESP { get; set; }
}