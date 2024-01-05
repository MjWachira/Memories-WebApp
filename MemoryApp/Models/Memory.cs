namespace MemoryApp.Models
{
    public class Memory
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime Date { get; set; } =DateTime.Now;
        public string location { get; set; } = string.Empty;
    }
}
