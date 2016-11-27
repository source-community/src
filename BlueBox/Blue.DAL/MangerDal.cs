using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Blue.Model;

namespace Blue.DAL
{
    public partial class MangerDal : BaseDal<Model.manager>
    {
        /// <summary>
        /// Query object's key by id
        /// </summary>
        public override Expression<Func<manager, bool>> GetByIdKey(int id)
        {
            return o => o.id == id;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override Expression<Func<manager, object>> GetOrderKey()
        {
            return o => o.id;
        }

        public override Expression<Func<manager, bool>> GetExistKey(manager model)
        {
            return o => o.user_name == model.user_name && o.password == model.password;
        }
    }
}
