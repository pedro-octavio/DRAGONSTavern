using DRAGONSTavern.Domain.Core.Interfaces.Repositories;
using DRAGONSTavern.Domain.Core.Interfaces.Services;
using DRAGONSTavern.Domain.Helpers.Validator;
using System;
using System.Collections.Generic;

namespace DRAGONSTavern.Domain.Services.Services
{
    public class BaseService<T> : IBaseService<T> where T : class
    {
        private readonly IBaseRepository<T> _baseRepository;
        private readonly Validator<T> _validator;

        public BaseService(IBaseRepository<T> baseRepository, Validator<T> validator)
        {
            _baseRepository = baseRepository;
            _validator = validator;
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                return _baseRepository.GetAll();
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
                var obj = _baseRepository.GetById(id);

                return obj switch
                {
                    null => throw new Exception("This Id is invalid."),
                    _ => obj,
                };
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
                _validator.Validate(obj);

                _baseRepository.Add(obj);
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
                _validator.Validate(obj);

                _baseRepository.Update(obj);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void Remove(string id)
        {
            try
            {
                var obj = GetById(id);

                _baseRepository.Remove(obj);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
