using Application.Constants;
using FluentValidation.Results;

namespace Application.Exceptions
{
    /// <summary>
    /// Exceptions fluent validation
    /// </summary>
    public class ValidationException : Exception
    {
        /// <summary>
        /// Property errors
        /// </summary>
        public List<string> Errors { get; }
        /// <summary>
        /// Constructor with basic error
        /// </summary>
        public ValidationException() : base(Messages.BaseError)
        {
            Errors = new List<string>();
        }
        /// <summary>
        /// Constructor to catch errors
        /// </summary>
        /// <param name="failures"></param>
        public ValidationException(IEnumerable<ValidationFailure> failures) : this()
        {
            foreach (ValidationFailure failure in failures)
            {
                Errors.Add(failure.ErrorMessage);
            }
        }
    }
}
