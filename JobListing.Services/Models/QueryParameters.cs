namespace JobListing.Core.Models
{
    public class QueryParameters
    {
        //move this to appsettings or env
        private int _pageSize = 15;
        public int Offset { get; set; }
        public int PageSize
        {
            get
            {
                return _pageSize;
            }
            set
            {
                _pageSize = value;
            }
        }
    }
}
