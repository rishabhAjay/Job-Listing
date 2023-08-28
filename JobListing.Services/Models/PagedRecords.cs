namespace JobListing.Core.Models
{
    public class PagedRecords<T>
    {
        public int TotalCount { get; set; }
        public int PageNumber { get; set; }

        public int Offset { get; set; }

        public List<T> Records { get; set; }
    }
}
