﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //generic constraint
    //class demek refereans tipi olabilir demekve Ientity olabilir ya da implemente eden olabilir
    //new lenebilir olmalı
   public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Uptade(T entity);
        void Delete(T entity);
    }
}
