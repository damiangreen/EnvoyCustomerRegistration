using System.Web.Mvc;
using Envoy.CustomRegistrar.Core.Models;
using Envoy.CustomRegistrar.Core.Services;

namespace Envoy.CustomerRegistrar.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUserService _userService;

        public HomeController(IUserService userService)
        {
            _userService = userService;
        }
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public void Register(User user)
        {
            if (ModelState.IsValid)
            {
                _userService.Register(user);
            }
            else RedirectToAction("Index",user);
        }
    }
}