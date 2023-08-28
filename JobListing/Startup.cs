using JobListing.Data;
using Microsoft.EntityFrameworkCore;
namespace JobListing.WebApi
{
    public class Startup
    {
        private readonly IConfiguration _configuration;

        public Startup(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            // use the policy we defined
            app.UseCors("AllowAll");

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private static void MapServices(IServiceCollection services)
        {
            //services.AddScoped<IEmployeeService, EmployeeService>();
            //services.AddScoped<IJobService, JobService>();
        }

        private static void MapRepositories(IServiceCollection services)
        {
            //services.AddScoped<IDbEmployeeRepository, EmployeeRepository>();
            //services.AddScoped<IDbJobRepository, JobRepository>();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();

            services.AddSwaggerGen();
            var connectionString = _configuration.GetConnectionString("JobListingDbConnectionString");

            services.AddDbContext<JobListingDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });


            //create a policy based on the requirements for your cors setup
            services.AddCors(options =>
            {
                options.AddPolicy(
                    "AllowAll",
                    b =>
                    {
                        b.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod();
                    }
                );
            });
            MapServices(services);

            MapRepositories(services);
        }

    }
}
