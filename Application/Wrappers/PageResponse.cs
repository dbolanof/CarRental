namespace Application.Wrappers
{
    /// <summary>
    /// Class response to pagination
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class PageResponse<T> : Response<T>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        /// <summary>
        /// Constructor to assign data
        /// </summary>
        /// <param name="data"></param>
        /// <param name="PageNumber"></param>
        /// <param name="PageSize"></param>
        public PageResponse(T data, int PageNumber, int PageSize)
        {
            this.PageNumber = PageNumber;
            this.PageSize = PageSize;
            this.Data = data;
            this.Message = null;
            this.Success = true;
            this.Errors = null;
        }
    }
}
