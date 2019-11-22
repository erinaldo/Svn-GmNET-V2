using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace Gm.Data
{
    public interface IRepository<T> : IDisposable where T : class
    {
        //para insertar un nuevo
        T Create(T reg);
        //para borrar un existente
        bool Delete(T reg);
        //para actualizar un existente
        bool Update(T reg);
        bool Update();
        //busca un elemento por cualquier tipo registro existente
        T Find(Expression<Func<T, bool>> expe);
        //busca barios elementos existenete
        List<T> Search(Expression<Func<T, bool>> expe);
        //Recuperamos la tabla
        List<T> GetAll();
        //Procedimientos almacenados
        //List<T> SQLQuery<T>(string sql);
        List<T> SQLQuery(string sql);
        bool Save();
        void Add(T reg);

        // Add multiple records
        void AddRange(IEnumerable<T> reg);

        // Remove records
        bool Remove(T reg);

        // remove multiple records
        bool RemoveRange(IEnumerable<T> entities);
    }
}
