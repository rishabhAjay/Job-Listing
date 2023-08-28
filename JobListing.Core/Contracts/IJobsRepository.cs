using JobListing.Data.Entities;

namespace HotelListing.API.Core.Contracts
{

    //this will contain a contract of the specific repository or its specific implementations
    public interface IJobsRepository : IGenericRepository<Job>
    {

    }
}
