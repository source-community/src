using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blue.DAL;
using Blue.Model;

namespace Blue.BLL
{
    public class MangerBll : BaseBll<Model.manager>
    {
        public override BaseDal<manager> GetDal()
        {
            return new MangerDal();
        }


    }

}
