﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
namespace CIPLATFORM_SKILL_PM.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        public IEnumerable<T> GetAll();
        public void Add(T entity);
        public void Remove(T entity);
        void Delete(T entity);
        void Edit(T entity);
        public T GetFirstordefault(Expression<Func<T, bool>> filter);
    }
}