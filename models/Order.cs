using System.Text.Json.Serialization;

namespace models
{
    

public class Order
    {
       
        public int Id {get;set;}
        [JsonIgnore]
        public DateTime CreatedAt {get;set;} = DateTime.UtcNow;
        public bool IsActive {get; set;}
        public string Bludos {get;set;}
        public int Cost {get;set;}
        public string Status {get;set;}
        public List<Bludo> Dishes = new List<Bludo>();
    }
}