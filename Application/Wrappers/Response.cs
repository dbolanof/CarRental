namespace Application.Wrappers
{
    /// <summary>
    /// Class general response
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Response<T>
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
        public List<string> Errors { get; set; }
        /// <summary>
        /// Empty constructor
        /// </summary>
        public Response()
        {
        }
        /// <summary>
        /// Constructor to assign data
        /// </summary>
        /// <param name="data"></param>
        /// <param name="message"></param>
        public Response(T data, string message = null)
        {
            this.Success = true;
            this.Message = message;
            this.Data = data;
        }
        /// <summary>
        /// Constructor to assign message
        /// </summary>
        /// <param name="message"></param>
        public Response(string message)
        {
            this.Success = false;
            this.Message = message;
        }
    }
}
