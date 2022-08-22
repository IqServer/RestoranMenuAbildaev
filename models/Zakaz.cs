using System.Text.Json.Serialization;

namespace models
{
    

public class Zakaz
    {
       
        public int Id {get;set;}
        [JsonIgnore]
        public DateTime CreatedAt {get;set;} = DateTime.UtcNow;
        public bool IsActive {get; set;}
        public string bludos {get;set;}
        public int cost {get;set;}
        public string status {get;set;}
    
    }
}