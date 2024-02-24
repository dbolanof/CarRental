using Ardalis.Specification;

namespace Application.Interfaces
{
    /// <summary>
    /// Interface Repository implement Ardalis.Specification
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IRepositoryAsync<T> : IRepositoryBase<T> where T : class
    {
    }
    /// <summary>
    /// Interface Repository reader implement Ardalis.Specification
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IReadRepositoryAsync<T> : IReadRepositoryBase<T> where T : class
    {
    }
}
