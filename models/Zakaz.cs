using System.Text.Json.Serialization;

namespace models
{
    

public class Zakaz
    {
        [JsonIgnore]
        public int Id {get;set;}
        [JsonIgnore]
        public DateTime CreatedAt {get;set;} = DateTime.UtcNow;
        public string list {get;set;}
        public int cost {get;set;}
        public string status {get;set;}
    
    }
}