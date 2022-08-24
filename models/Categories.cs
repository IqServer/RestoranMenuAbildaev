using System.Text.Json.Serialization;

namespace models
{
    

public class Categories
{
    public long Id {get; set;}
    [JsonIgnore]
    public DateTime CreatedAt {get;set;} = DateTime.UtcNow;
    public string? Tab {get;set;}
}
}