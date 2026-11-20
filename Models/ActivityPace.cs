namespace Group1_WebSerAppDev.Models
{
    public class ActivityPace
    {
        public int Id { get; set; }
        public string Description { get; set; } = "";
        public double Met { get; set; }
        public int CardioActivityId { get; set; }
        public CardioActivity CardioActivity { get; set; } = null!;
    }
}
