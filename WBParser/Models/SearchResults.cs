namespace WBParser.Models;

public class Advert
{
    public string code { get; set; }
    public int advertId { get; set; }
    public int id { get; set; }
    public int cpm { get; set; }
    public int subject { get; set; }
}

public class Page
{
    public List<int> positions { get; set; }
    public int page { get; set; }
    public int count { get; set; }
}

public class Root
{
    public List<Page> pages { get; set; }
    public List<int> prioritySubjects { get; set; }
    public List<Advert> adverts { get; set; }
    public int minCPM { get; set; }
    public SortWeights sortWeights { get; set; }
}

public class SortWeights
{
    public int cpm { get; set; }
    public int delivery { get; set; }
}
