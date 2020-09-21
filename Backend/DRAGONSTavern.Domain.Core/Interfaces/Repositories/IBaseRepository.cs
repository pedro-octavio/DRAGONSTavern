using System.Collections.Generic;

namespace DRAGONSTavern.Domain.Core.Interfaces.Repositories
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(string id);
        void Add(T obj);
        void Update(T obj);
        void Remove(T obj);
    }
}
