namespace Group1_WebSerAppDev.Models
{
    public enum ImpactLevel
    {
        Low,
        Moderate,
        High
    }

    public class CardioActivity
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public ImpactLevel JointImpact { get; set; }
        public string MusclesWorked { get; set; } = "";
        public string Equipment { get; set; } = "";

        public List<ActivityPace> Paces { get; set; } = new();
    }
}
