namespace WBParser.Models;

public class Advert
{
    [JsonPropertyName("code")]
    public string Code { get; set; }
    [JsonPropertyName("advertId")]
    public int AdvertId { get; set; }
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("cpm")]
    public int Cpm { get; set; }
    [JsonPropertyName("subject")]
    public int Subject { get; set; }
}

public class Page
{
    [JsonPropertyName("positions")]
    public List<int> Positions { get; set; }
    [JsonPropertyName("page")]
    public int CurrentPage { get; set; }
    [JsonPropertyName("count")]
    public int Count { get; set; }
}

public class Root
{
    [JsonPropertyName("pages")]
    public List<Page> Pages { get; set; }
    [JsonPropertyName("prioritySubjects")]
    public List<int> PrioritySubjects { get; set; }
    [JsonPropertyName("adverts")]
    public List<Advert> Adverts { get; set; }
    [JsonPropertyName("minCPM")]
    public int MinCPM { get; set; }
    [JsonPropertyName("sortWeights")]
    public SortWeights SortWeights { get; set; }
}

public class SortWeights
{
    [JsonPropertyName("cpm")]
    public int Cpm { get; set; }
    [JsonPropertyName("delivery")]
    public int Delivery { get; set; }
}
