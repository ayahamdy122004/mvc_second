using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_second.Models;

namespace MVC_second.Controllers
{
    public class HomeController : Controller
    {public  void show()
        {
            Console.WriteLine("Hello World !");
        }
       // action return type
      public ViewResult showr()
        {
            //declare
            ViewResult result = new ViewResult();
            //initail
            result.ViewName = "View1";
            //return
            return result;

        }
        public ContentResult showc()
        {
            //declare
            ContentResult result = new ContentResult();
            //initail
            result.Content = "Content1";
            //return
            return result;
        }
        // use iactionresult incase return two different action
        public IActionResult showmix(int id)
        {if(id %2== 0)
            {
                ViewResult result=new ViewResult();
                result.ViewName = "View1";
                return result;
            }
            else
            {
                ContentResult result = new ContentResult();
                result.Content = "aya hamdy sherif";
                return result;
            }
        }

















      private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
