namespace MVC_Identity.Models.Entities
{
    public class Model
    {
        public int ModelId { get; set; }
        public string ModelAdi { get; set; }
        public ICollection<Arac> Araclar { get; set; }
    }
}
