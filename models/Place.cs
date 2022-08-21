using System.Text.Json.Serialization;

namespace models
{
    

public class Place
    {
        [JsonIgnore]
        public int Id {get;set;}
        [JsonIgnore]
        public DateTime CreatedAt {get;set;} = DateTime.UtcNow;
        public string? Title {get;set;}
        public string? Adress {get;set;}
        public string FIO { get; internal set; }
    }
}