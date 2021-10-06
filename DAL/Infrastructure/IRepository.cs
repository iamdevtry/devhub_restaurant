using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Dev69Restaurant.DAL.Infrastructure
{
    public interface IRepository<T> where T : class
    {
        /// <summary>
        /// Add an new Entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        T Add(T entity);

        /// <summary>
        /// Update an entity
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

        /// <summary>
        /// Delete an entity
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        T Delete(T entity);

        /// <summary>
        /// Delete an entity with Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T Delete(int id);

        /// <summary>
        /// Get data of an entity with Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        T GetSingleById(int id);

        /// <summary>
        /// Get data of an entity with expression
        /// </summary>
        /// <param name="expression"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        T GetSingleByCondition(Expression<Func<T, bool>> expression, string[] includes = null);

        /// <summary>
        /// Get all entities
        /// </summary>
        /// <param name="includes"></param>
        /// <returns></returns>
        IEnumerable<T> GetAll(string[] includes = null);

        /// <summary>
        /// Get multi entities with expression
        /// </summary>
        /// <param name="predicate"></param>
        /// <param name="includes"></param>
        /// <returns></returns>
        IEnumerable<T> GetMulti(Expression<Func<T, bool>> predicate, string[] includes = null);
    }
}