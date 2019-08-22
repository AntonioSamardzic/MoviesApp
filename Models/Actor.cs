using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Projekt.Models
{
    public class Actor: BaseModel
    {
        
        [Required(ErrorMessage="Ovo polje je obavezno")]
        [StringLength(20,ErrorMessage="Ime ne smije imati vise od 20 znakova")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage="Ovo polje je obavezno")]
        [StringLength(20,ErrorMessage="Prezime ne smije imati vise od 20 znakova")]
        public string LastName { get; set; }

        
        
        [JsonIgnore]
        public ICollection<Engagement> Engagements {get; set;}
    }
}