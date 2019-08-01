using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Projekt.Models
{
    public class Engagement:BaseModel
    {
                
        [DataType(DataType.Date)]
        public DateTime Started { get; set; }
        [DataType(DataType.Date)]
        public DateTime Ended { get; set; }
        [Column(TypeName="decimal(10, 2)")]
        public decimal Fee { get; set; }
        [Required(ErrorMessage="Ovo polje je obavezno")]
        public int ActorId {get;set;}
        public Actor Actor {get;set;}
        [Required(ErrorMessage="Ovo polje je obavezno")]
        public int MovieId {get;set;}
        public Movie Movie {get; set;}
    }
}