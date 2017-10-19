using System;
using Microsoft.AspNetCore.Mvc;
using Blog.IDAL.Repository.Passage.Dto.Passage;
using Blog.Web.Extension;
using Blog.Service.Passage;
using Blog.Models.Passage;

namespace Blog.Web.Controllers
{

    /// <summary>
    /// 
    /// PassageController
    /// 
    /// 与文章有关的View操作，在这里处理
    /// 
    /// </summary>
    public class PassageController : Controller
    {
        private readonly IPassageAppService _passageAppService;

        public PassageController(IPassageAppService passageAppService)
        {
            //依赖注入
            _passageAppService = passageAppService;
        }
        //详情页
        public IActionResult Details(Passage passage)
        {
            var res = _passageAppService.GetPassageById(passage.Id);
            return View(res);
        }

        //文章中心
        public IActionResult Index()
        {
            var res = _passageAppService.GetAll();
            return View(res);
        }

        //写文章
        public IActionResult WritePassage()
        {
            var res = HttpContext.Session.Get<String>("UserName");
            if (res == null) return RedirectToAction("Login", "Account");
            return RedirectToAction("ManageCenter","Passage");
        }

        //写文章
        [HttpPost]
        public IActionResult WritePassage(PassageDto input)
        {
            var UserId = HttpContext.Session.Get<long>("UserId");
             _passageAppService.Add(input, UserId);
            return View();
        }

        //管理中心
        public IActionResult ManageCenter()
        {
            var userId = HttpContext.Session.Get<long>("UserId");
            return View(_passageAppService.GetAllByUserId(userId));
        }

        //编辑文章
        public IActionResult Manage(Passage passage)
        {
            passage = _passageAppService.GetPassageById(passage.Id);
            return View(passage);
        }

        //更新文章
        [HttpPost]
        public IActionResult Update(Passage passage)
        {
            _passageAppService.Change(passage);
            return RedirectToAction("Index", "Home");
        }

        //删除操作
        public IActionResult Delete(Passage passage)
        {
            _passageAppService.Delete(passage.Id);
            return RedirectToAction("ManageCenter","Passage");
        }
    }
}