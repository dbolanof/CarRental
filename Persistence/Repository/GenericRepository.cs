using Application.Interfaces;
using Ardalis.Specification.EntityFrameworkCore;
using Persistence.Context;

namespace Persistence.Repository
{
    /// <summary>
    /// Generic repository
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class GenericRepository<T> : RepositoryBase<T>, IRepositoryAsync<T> where T : class
    {
        /// <summary>
        /// property dbcontext
        /// </summary>
        private readonly ApplicationDbContext _dbContext;
        /// <summary>
        /// Constructor to set db context
        /// </summary>
        /// <param name="dbContext"></param>
        public GenericRepository(ApplicationDbContext dbContext) : base(dbContext)
        {
            this._dbContext = dbContext;
        }
    }
}
