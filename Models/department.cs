namespace MVC_second.Models
{
    public class department
    {
        public int id { get; set; }
        public string name { get; set; }
        public string? managername { get; set; }
        public List<employee> employees { get; set; }
    }
}
