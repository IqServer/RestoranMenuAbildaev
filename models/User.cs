using System.Text.Json.Serialization;

namespace models
{
    

public class User
    {
        [JsonIgnore]
        public long Id {get;set;}
        [JsonIgnore]
        public DateTime CreatedAt {get;set;} = DateTime.UtcNow;
        public string? Name {get;set;}
        public int Age {get;set;}

        
    }
}