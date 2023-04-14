using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;


namespace Core.DataAccess
{
    //generic constraint
    //class:Referans tip 
    //IEntity olabilir ya da IEntity implemente eden bir nesne olabilir.
    //new'lenebilir olmalı
   public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> filter=null);//Expression filterleme yapabilme imkanı saglar linq ile.filter null olabilir
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity); 
        void Update(T entity);
        void Delete(int entityId);
        
    }
}
