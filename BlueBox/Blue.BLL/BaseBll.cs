using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blue.DAL;

namespace Blue.BLL
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract partial class BaseBll<T>
        where T : class
    {
        public BaseDal<T> dal;
        public abstract BaseDal<T> GetDal();

        public BaseBll()
        {
            dal = GetDal();
        }

        public IQueryable<T> GetPageList(int pageSize, int pageIndex)
        {
           return dal.GetPageList(pageSize, pageIndex);
        }

        public T GetById(int id)
        {
            return dal.GetById(id);
        }

        public bool Add(T model)
        {
            return dal.Add(model) > 0;
        }

        public bool Edit(T model)
        {
            return dal.Edit(model) > 0;
        }

        public bool Remove(int id)
        {
            return dal.Remove(id) > 0;
        }

        public int GetCount()
        {
            return dal.GetCount();
        }

        public T Exist(T model)
        {
            return dal.Exist(model);
        }
    }
}
