using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Exceptions
{
    public class ApiException: Exception
    {
        /// <summary>
        /// Constructor 
        /// </summary>
        public ApiException() : base() { }
        /// <summary>
        /// Constructor overload with message
        /// </summary>
        /// <param name="message"></param>
        public ApiException(string message) : base(message) { }
        /// <summary>
        /// Constructor with basic message and params
        /// </summary>
        /// <param name="message"></param>
        /// <param name="args"></param>
        public ApiException(string message, params object[] args) : base(String.Format(CultureInfo.CurrentCulture, message, args))
        {

        }
    }
}
