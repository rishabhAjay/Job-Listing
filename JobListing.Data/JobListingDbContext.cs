using HotelListing.API.Data.Entities;
using JobListing.Data.Configurations;
using JobListing.Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace JobListing.Data
{

    public class JobListingDbContext : DbContext

    {
        public JobListingDbContext(DbContextOptions options)
            : base(options) { }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<Skill> Skills { get; set; }

        //public DbSet<JobsSkills> JobsSkills { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.ApplyConfiguration(new JobConfiguration());
            modelBuilder.ApplyConfiguration(new SkillConfiguration());
        }
    }

    public class JobListingDbContextFactory : IDesignTimeDbContextFactory<JobListingDbContext>
    {
        public JobListingDbContext CreateDbContext(string[] args)
        {
            IConfiguration config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<JobListingDbContext>();
            var conn = config.GetConnectionString("JobListingDbConnectionString");
            optionsBuilder.UseSqlServer(conn);
            return new JobListingDbContext(optionsBuilder.Options);
        }
    }
}
