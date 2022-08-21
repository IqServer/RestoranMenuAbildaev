using System.Text.Json.Serialization;

namespace models
{
    

public class Povar
    {
        [JsonIgnore]
        public int Id {get;set;}
        [JsonIgnore]
        public DateTime CreatedAt {get;set;} = DateTime.UtcNow;
        public string? Name {get;set;}
        public string? Profile {get;set;}
        public int Age {get;set;}

    }
}