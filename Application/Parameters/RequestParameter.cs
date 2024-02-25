namespace Application.Parameters
{
    public class RequestParameter
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        /// <summary>
        /// Constructor initialize parameters
        /// </summary>
        public RequestParameter()
        {
            PageNumber = 1;
            PageSize = 10;
        }
        /// <summary>
        /// constructor to Assign parameters
        /// </summary>
        /// <param name="PageNumber"></param>
        /// <param name="PageSize"></param>
        public RequestParameter(int PageNumber, int PageSize)
        {
            this.PageNumber = PageNumber < 1 ? 1 : PageNumber;
            this.PageSize = PageSize < 1 ? 1 : PageSize;
        }
    }
}
