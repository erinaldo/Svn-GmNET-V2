using System;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

using Gm.Entities;

namespace Gm.Data
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly gm_mmercadoEntities Context;// = null;
        private readonly DbSet<T> DbSet;

        public string Error
        {
            get;
            set;
        }

        public Repository()
        {
            Context = new gm_mmercadoEntities();
            DbSet = Context.Set<T>();
        }

        private DbSet<T> EntitySet
        {
            get
            {
                return Context.Set<T>();
            }
        }
        public int Count()
        {
            return EntitySet.Count();
        }
        public int Count(Expression<Func<T, bool>> expe)
        {
            return EntitySet.Where(expe).Count();
        }
        public T Create(T reg)
        {
            T Result = null;
            try
            {
                EntitySet.Add(reg);
                Context.SaveChanges();
                Result = reg;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                //throw;
            }
            return Result;
        }

        public bool Delete(T reg)
        {
            bool Result = false;
            try
            {
                EntitySet.Attach(reg);
                EntitySet.Remove(reg);

                Result = Context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                //throw;
            }
            return Result;
        }

        public void Dispose()
        {
            //liberacion del contenido
            if (Context != null)
                Context.Dispose();
        }

        public T Find(Expression<Func<T, bool>> expe)
        {
            T Result = null;
            try
            {
                Result = EntitySet.FirstOrDefault(expe);
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                //throw;
            }
            return Result;
        }

        public List<T> GetAll()
        {
            List<T> Result = null;
            try
            {
                Result = EntitySet.ToList();
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                //throw;
            }
            return Result;
        }

        public List<T> Search(Expression<Func<T, bool>> expe)
        {
            List<T> Result = null;
            try
            {
                Result = EntitySet.Where(expe).ToList();
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                //throw;
            }
            return Result;
        }

        public bool Update(T reg)
        {
            bool Result = false;
            try
            {
                EntitySet.Attach(reg);
                
                Context.Entry<T>(reg).State = EntityState.Modified;
                Result = Context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                //throw;
            }
            return Result;
        }

        public bool Update()
        {
            bool Result = false;
            try
            {
                Result = Context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                //throw;
            }
            return Result;
        }

        //public List<T> SQLQuery<T>(string sql)
        //{
        //    return Context.Database.SqlQuery<T>(sql).ToList();
        //}
        public List<T> SQLQuery(string sql)
        {
            return Context.Database.SqlQuery<T>(sql).ToList();
        }

        public bool SQLQuery<T>(string sql, params object[] parameters)
        {
            bool Result = false;
            try
            {
                Result = Context.Database.ExecuteSqlCommand(sql, parameters) > 0;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                //throw;
            }
            return Result;
        }

        public DataTable GetTable()
        {
            DataTable Result = null;
            try
            {
                List<T> data = EntitySet.ToList();
                PropertyDescriptorCollection properties =
                    TypeDescriptor.GetProperties(typeof(T));
                Result = new DataTable();
                foreach (PropertyDescriptor prop in properties)
                    Result.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                foreach(T item in data)
                {
                    DataRow row = Result.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                    Result.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                //throw;
            }
            return Result;
        }

        public DataTable GetTable(List<T> data)
        {
            DataTable Result = null;
            try
            {
                PropertyDescriptorCollection properties =
                    TypeDescriptor.GetProperties(typeof(T));
                Result = new DataTable();
                foreach (PropertyDescriptor prop in properties)
                    Result.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
                foreach (T item in data)
                {
                    DataRow row = Result.NewRow();
                    foreach (PropertyDescriptor prop in properties)
                        row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                    Result.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                Error = ex.Message;
                //throw;
            }
            return Result;
        }
        public bool Save()
        {
            bool Result = false;
            try
            {
                Result = Context.SaveChanges()>0;
            }
            catch(Exception ex)
            {
                Error = ex.Message;
            }
            return Result;
        }
        public void Add(T reg)
        {
            DbSet.Add(reg);
        }
        public void AddRange(IEnumerable<T> reg)
        {
            DbSet.AddRange(reg);
        }
        public bool Remove(T reg)
        {
            bool Result = false;
            try
            {
                DbSet.Remove(reg);
                Result = Context.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                Error = ex.Message;
            }
            return Result;

        }
        public bool RemoveRange(IEnumerable<T> reg)
        {
            bool Result = false;
            try
            {
                DbSet.RemoveRange(reg);
                Result = Context.SaveChanges() > 0;
            }
            catch(Exception ex)
            {
                Error = ex.Message;
            }
            return Result;
        }
    }
}
