using HotelListing.API.Data.Entities;
using JobListing.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace JobListing.Data.Configurations
{
    public class JobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder
               .HasData(
                   new Job
                   {
                       Id = 1,
                       JobTitle = "devops engineer",
                       JobType = JobTypesEnums.FullTime,
                       JobLocation = "mysore",
                       CompanyName = "Spurtree",
                       Description = "for 5 years",
                       DateCreated = DateTimeOffset.Now,
                       DateUpdated = DateTimeOffset.Now,

                   },
                   new Job
                   {
                       Id = 2,
                       JobTitle = "Network Admin",
                       JobType = JobTypesEnums.Contract,
                       JobLocation = "Bangalore",
                       CompanyName = "Spurtree",
                       Description = "Lorem Ipsum",
                       DateCreated = DateTimeOffset.Now,
                       DateUpdated = DateTimeOffset.Now,

                   }

               );
        }
    }
}
