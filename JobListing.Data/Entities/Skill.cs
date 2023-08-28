namespace JobListing.Data.Entities
{
    public class Skill
    {
        public int Id { get; set; }

        public string SkillName { get; set; }

        public string SkillDescription { get; set; }

        public List<Job> Jobs { get; } = new();
    }
}
