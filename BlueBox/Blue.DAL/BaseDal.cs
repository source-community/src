using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Entity;
using System.Threading.Tasks;
using Blue.Model;
using System.Linq.Expressions;

namespace Blue.DAL
{
    /// <summary>
    /// 
    /// </summary>
    public abstract partial class BaseDal<T>
        where T:class 
    {
        DbContext db = new DbContent();

        /// <summary>
        /// Query paging data
        /// Version：1.0
        /// <author>
        ///		<name>Andy</name>
        ///		<date>27/11/2016</date>
        /// </author>
        /// </summary>
        public IQueryable<T> GetPageList(int pageSize,int pageIndex)
        {
            return db.Set<T>().OrderByDescending(GetOrderKey()).Skip((pageIndex - 1) * pageSize).Take(pageSize);
        }

        public abstract Expression<Func<T, object>> GetOrderKey();
        /// <summary>
        /// Query object by id 
        /// Version：1.0
        /// <author>
        ///		<name>Andy</name>
        ///		<date>27/11/2016</date>
        /// </author>
        /// </summary>
        public T GetById(int id)
        {
            return db.Set<T>().Where(GetByIdKey(id)).FirstOrDefault();
        }

        public abstract Expression<Func<T, bool>> GetByIdKey(int id);

        public int Add(T model)
        {
            db.Set<T>().Add(model);
            return db.SaveChanges();
        }

        public int Edit(T model)
        {
            db.Set<T>().Attach(model);
            db.Entry(model).State = EntityState.Modified;
            return db.SaveChanges();
        }

        public int Remove(int id)
        {
            db.Set<T>().Remove(GetById(id));
            return db.SaveChanges();
        }

        public int GetCount()
        {
            return db.Set<T>().Count();
        }


        public T Exist(T model)
        {
            return db.Set<T>().Where(GetExistKey(model)).FirstOrDefault();
        }

        public abstract Expression<Func<T, bool>> GetExistKey(T model);
    }
}
