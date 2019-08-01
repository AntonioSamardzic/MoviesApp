using System.ComponentModel.DataAnnotations;

namespace Projekt.Models
{
    public class MovieType:BaseModel
    {
        
        [Required(ErrorMessage="Ovo polje je obavezno")]
        public string Genre { get; set; } 
    }
}