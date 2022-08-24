using System.Text.Json.Serialization;

namespace models
{
    

public class Place
    {
        
        public int Id {get;set;}
        [JsonIgnore]
        public DateTime CreatedAt {get;set;} = DateTime.UtcNow;
        public bool? IsActive {set; get;}
        public string? Title {get;set;}
        public string? Adress {get;set;}
        public string? FIO { get; internal set; }
    }
}