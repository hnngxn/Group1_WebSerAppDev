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
        public string Pace { get; set; } = "";

        // Metabolic equivalent: energy cost relative to sitting at rest (1.0).
        // Calories per hour is roughly Met x body weight in kg.
        public double Met { get; set; }

        public ImpactLevel JointImpact { get; set; }
        public string MusclesWorked { get; set; } = "";
        public string Equipment { get; set; } = "";
    }
}
