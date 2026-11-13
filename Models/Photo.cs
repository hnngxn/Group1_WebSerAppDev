namespace Group1_WebSerAppDev.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Title { get; set; } = "";
        public string Location { get; set; } = "";
        public string Camera { get; set; } = "";
        public DateTime DateTaken { get; set; }
    }
}