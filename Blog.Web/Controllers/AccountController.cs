using Microsoft.AspNetCore.Mvc;
using Blog.IDAL.Repository.User.Dto.User;
using Blog.Service.User;
using Blog.Web.Extension;

namespace Blog.Web.Controllers
{
    public class AccountController : Controller
    {
        private IUserAppService _userAppService;

        //依赖注入
        public AccountController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }
            public IActionResult Index()
        {
            return View();
        }
        //登陆操作
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserDto dto)
        {
            var res = _userAppService.Login(dto);
            if (res == null)
            {
                //如果查不到数据,添加错误信息,返回页面
                ModelState.AddModelError("Failed", "用户名或者密码不正确");
                return View();
            }
            //若用户名密码正确，将当前用户信息保存进Session
            HttpContext.Session.Set("UserId", res.UserId);
            HttpContext.Session.Set("UserName", res.UserName);

            //返回主页面
            return RedirectToAction("Index", "Home");
        }

        //退出登陆
        public IActionResult LoginOut()
        {
            //清除Session
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
    }
}