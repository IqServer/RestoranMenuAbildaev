using System.Text.Json.Serialization;

namespace models
{
    

public class Bludo
    {
        
        public long Id {get;set;}
        [JsonIgnore]
        public DateTime CreatedAt {get;set;} = DateTime.UtcNow;
        public bool IsActive {get; set;}
        public int Cost{get;set;}
        public int Kkal{get;set;}
        public string Recipe{get;set;}
        public int Grams{get;set;}
        public string Photo{get;set;}
        
    }
}