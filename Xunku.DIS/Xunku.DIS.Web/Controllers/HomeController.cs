using System.Web.Mvc;
using Xunku.DIS.Entity;

namespace Xunku.DIS.Web.Controllers
{
    /// <summary>
    /// 首页控制器（登陆）
    /// </summary>
    public class HomeController : Controller
    {
        #region View

        public ActionResult Index()
        {
            return View();
        }

        #endregion View

        #region Json

        /// <summary>
        /// 登陆平台
        /// </summary>
        /// <param name="username">用户名</param>
        /// <param name="password">密码</param>
        /// <param name="validCode">验证码</param>
        /// <returns></returns>
        public JsonResult LoginPlatform(string username, string password, string validCode)
        {
            var ret = new ResultEntity();

            if (string.IsNullOrWhiteSpace(username))
            {
                return Json(ret);
            }

            return Json(ret);
        }

        #endregion
    }
}