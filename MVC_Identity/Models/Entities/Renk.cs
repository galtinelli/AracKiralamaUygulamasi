namespace MVC_Identity.Models.Entities
{
    public class Renk
    {
        public int RenkId { get; set; }
        public string RenkAdi { get; set; }
        public ICollection<Arac> Araclar { get; set; }
    }
}
