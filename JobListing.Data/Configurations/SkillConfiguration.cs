using JobListing.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobListing.Data.Configurations
{
    public class SkillConfiguration : IEntityTypeConfiguration<Skill>
    {
        public void Configure(EntityTypeBuilder<Skill> builder)
        {
            builder
               .HasData(
                   new Skill
                   {
                       Id = 1,
                       SkillName = "JS",
                       SkillDescription = "JavaScript"

                   },
                   new Skill
                   {
                       Id = 2,
                       SkillName = "Ruby",
                       SkillDescription = "Rust on Rails"

                   }

               );
        }


    }
}
