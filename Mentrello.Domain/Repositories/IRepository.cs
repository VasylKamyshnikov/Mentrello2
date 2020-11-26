using System.Collections.Generic;

namespace Mentrello.Domain.Repositories
{
    public interface IRepository<T, TKey> where T : class
    {
        IOutput<T> Create(T model);
        IOutput<IEnumerable<T>> GetAll();
        IOutput<T> GetById(TKey id);
        IOutput<T> UpdateById(TKey id);
        IOutput<T> DeleteById(TKey id);
    }
}
