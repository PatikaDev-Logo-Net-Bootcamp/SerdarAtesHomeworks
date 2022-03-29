using Homeworkfour.Domain.Entities;
using System.Linq;

namespace Homeworkfour.DataAccess.EntityFramework.Repository.Abstracts
{
    public interface IRepository<T> where T : BaseEntity
    {
        IQueryable<T> Get();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
