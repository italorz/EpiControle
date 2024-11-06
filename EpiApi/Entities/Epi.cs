namespace EpiApi.Entities
{
    public class Epi
    {
        public Guid id { get; set; }
        public string nome { get; set; }
        public int diasValidade { get; set; }
        public ICollection<Lista>? listas { get; set; }
    }
}
