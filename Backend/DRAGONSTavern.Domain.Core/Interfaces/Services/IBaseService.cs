﻿using System.Collections.Generic;

namespace DRAGONSTavern.Domain.Core.Interfaces.Services
{
    public interface IBaseService<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetById(string id);
        void Add(T obj);
        void Update(T obj);
        void Remove(string id);
    }
}
