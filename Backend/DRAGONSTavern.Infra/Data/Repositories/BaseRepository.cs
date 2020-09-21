using DRAGONSTavern.Domain.Core.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DRAGONSTavern.Infra.Data.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly DataContext _dataContext;

        public BaseRepository(DataContext dataContext) => _dataContext = dataContext;

        public IEnumerable<T> GetAll()
        {
            try
            {
                return _dataContext.Set<T>().ToList();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public T GetById(string id)
        {
            try
            {
                var obj = _dataContext.Set<T>().Find(id);

                return obj;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Add(T obj)
        {
            try
            {
                _dataContext.Set<T>().Add(obj);

                _dataContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Update(T obj)
        {
            try
            {
                _dataContext.Set<T>().Update(obj);

                _dataContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Remove(T obj)
        {
            try
            {
                _dataContext.Set<T>().Remove(obj);

                _dataContext.SaveChanges();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
