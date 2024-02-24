using FluentValidation;
using MediatR;

namespace Application.Behavior
{
    /// <summary>
    /// ValidationBehavior
    /// </summary>
    /// <typeparam name="TRequest"></typeparam>
    /// <typeparam name="TResponse"></typeparam>
    public class ValidationBehavior<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> where TRequest : IRequest<TResponse>
    {
        /// <summary>
        /// Property Validator
        /// </summary>
        private readonly IEnumerable<IValidator<TRequest>> _validator;
        /// <summary>
        /// Constructor ValidationBehavior with dependency inyection
        /// </summary>
        /// <param name="validator"></param>
        public ValidationBehavior(IEnumerable<IValidator<TRequest>> validator)
        {
            _validator = validator;
        }
        /// <summary>
        /// Handle to implement validator
        /// </summary>
        /// <param name="request"></param>
        /// <param name="next"></param>
        /// <param name="cancellationToken"></param>
        /// <returns></returns>
        /// <exception cref="Exceptions.ValidationException"></exception>
        public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
        {
            if (_validator.Any())
            {
                var context = new ValidationContext<TRequest>(request);
                var validationResult = await Task.WhenAll(_validator.Select(v => v.ValidateAsync(context, cancellationToken)));
                var failures = validationResult.SelectMany(s => s.Errors).Where(w => w != null).ToList();

                if (failures.Any()) throw new Exceptions.ValidationException(failures);
            }
            return await next();
        }
    }
}
