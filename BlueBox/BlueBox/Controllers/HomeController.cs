using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Blue.Model;
using Blue.BLL;
namespace BlueBox.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Verify the user login information
        /// Version：1.0
        /// <author>
        ///		<name>Andy</name>
        ///		<date>26/11/2016</date>
        /// </author>
        /// </summary>
        public ActionResult Valilogin(string txtUserName, string txtPassword)
        {
            #region 信息验证
            if(string.IsNullOrEmpty(txtUserName))
                return Json(new { status=0,msg="用户名不许为空" }, JsonRequestBehavior.AllowGet);
            if (string.IsNullOrEmpty(txtPassword))
                return Json(new { status = 0, msg = "密码不许为空" }, JsonRequestBehavior.AllowGet);
            #endregion 
            MangerBll mangerbll = new MangerBll();
            manager valimanger = new manager() { user_name = txtUserName, password = txtPassword };
            var manger= mangerbll.Exist(valimanger);
            if (manger == null)
                return Json(new { status = 1, msg = "用户名和密码错误" }, JsonRequestBehavior.AllowGet);
            //success
            //TODO: 登录成功之后要做事情
            return Json(new { status = 1, msg = "登录成功" }, JsonRequestBehavior.AllowGet);
        }
    }
}