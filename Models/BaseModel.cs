using System;
using Newtonsoft.Json;

namespace Projekt.Models
{
    public class BaseModel
    {
        
        public int Id { get; set; }
        [JsonIgnore]
        public DateTime CreatedAt {get;set;} = DateTime.UtcNow;
        [JsonIgnore]
        public DateTime? UpdatedAt {get; set;}
        [JsonIgnore]
        public bool IsDeleted { get; set; } = false;
    }
}