using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projekt.Models
{
    public class Bought:BaseModel
    {
        [DataType(DataType.Date)]
        public DateTime BoughtDate { get; set; } = DateTime.UtcNow;
        [Required(ErrorMessage="Ovo polje je obavezno")]
        [Column(TypeName="decimal(10, 2)")]
        public decimal Price { get; set; }
        [Required(ErrorMessage="Ovo polje je obavezno")]
        public int UserId { get; set; }
        public User User {get; set;}
        [Required(ErrorMessage="Ovo polje je obavezno")]
        public int MovieId {get;set;}
        public Movie Movie {get; set;}

        
    }
}