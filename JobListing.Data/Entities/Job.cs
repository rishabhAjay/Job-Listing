namespace JobListing.Data.Entities
{
    //Define the Country Entity that models that Countries Table
    public class Job : Timestamps
    {
        public int Id { get; set; }
        public string JobTitle { get; set; }
        public JobTypesEnums JobType { get; set; }

        public string JobLocation { get; set; }
        public string CompanyName
        {
            get; set;
        }
        public List<Skill> Skills { get; } = new();
        public string? Description { get; set; }


    }
}
