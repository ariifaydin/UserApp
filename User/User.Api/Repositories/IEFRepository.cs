﻿using System.Linq.Expressions;

namespace User.Api.Repositories
{
    public interface IEFRepository<T>
    {
        T GetById(int id);
        IEnumerable<T> GetAll();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
