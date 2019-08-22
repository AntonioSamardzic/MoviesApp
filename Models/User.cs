using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Projekt.Models
{
    public class User:BaseModel
    {
        
        
        public string Email { get; set; }
        
        [Required(ErrorMessage="Ovo polje je obavezno")]
        public string Card { get; set; }

        [Required(ErrorMessage="Ovo polje je obavezno")]
        [StringLength(20,ErrorMessage="Ime ne smije imati vise od 20 znakova")]
        public string FirstName { get; set; }

        [Required(ErrorMessage="Ovo polje je obavezno")]
        [StringLength(20,ErrorMessage="Ime ne smije imati vise od 20 znakova")]
        public string LastName { get; set; }

       
        public ICollection<Bought> Boughts {get; set;}
    }
}