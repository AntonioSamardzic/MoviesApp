using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Projekt.Models
{
    public class Movie:BaseModel
    {
         
         [Required(ErrorMessage="Ovo polje je obavezno")]
        public string Name { get; set; } 

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Column(TypeName="decimal(12, 2)")]
        public decimal Price { get; set; }
        public string Producent { get; set; }
        [Required(ErrorMessage="Ovo polje je obavezno")]
        public int CompanyId {get;set;}
        public Company Company {get;set;}
        [Required(ErrorMessage="Ovo polje je obavezno")]
        public int MovieTypeId {get;set;}
        public MovieType MovieType {get;set;}
        public string Description {get;set;}

        public ICollection<Bought> Boughts {get; set;}
        public ICollection<Engagement> Engagements {get; set;}
    }
}