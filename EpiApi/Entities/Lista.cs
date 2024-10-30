namespace EpiApi.Entities
{
    public class Lista
    {
        public Guid id { get; set; }
        public int EpiId { get; set; }
        public DateTime validade { get; set; }
        public Epi Epi { get; set; }
    }
}
