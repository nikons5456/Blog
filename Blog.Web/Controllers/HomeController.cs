using Microsoft.AspNetCore.Mvc;
using Blog.Service.Passage;
using Blog.Service;
using Blog.IDAL.Repository.Passage.Dto.Passage;
using Blog.Models.Passage;

namespace Blog.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPassageAppService _passageService;

        public HomeController(IPassageAppService passageAppService)
        {
            //依赖注入
            _passageService = passageAppService;
        }

        //主页
        public IActionResult Index()
        {
            var res= _passageService.GetAll();
            return View(res);
        }
    }
}
