using System.Text.Json.Serialization;

namespace models
{
    

public class Bludo
    {
        
        public long Id {get;set;}
        [JsonIgnore]
        public DateTime CreatedAt {get;set;} = DateTime.UtcNow;
        public bool IsActive {get; set;}
        public int CategoryId{get; set;}
        public string name{get; set;}
        public int price{get;set;}
        public int calories{get;set;}
        public string recipe{get;set;}
        public int grams{get;set;}
        public string Photo{get;set;}
        public string description{get; set;}
    }
}