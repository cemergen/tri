using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using tri.entity;

namespace tri.data.Repo

{
    interface IRepository<T> where T : BaseEntity
    {
        void Insert(T entity);
        void Update(T entity);
        T GetbyId(int Id);
        void Delete(T entity);

    }
}