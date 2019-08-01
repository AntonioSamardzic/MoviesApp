namespace Projekt.Models
{
    public class Company:BaseModel
    {
        
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string URL { get; set; }
    }
}