using Microsoft.AspNetCore.Mvc;
using MVC_second.Models;

namespace MVC_second.Controllers
{
    public class bindController : Controller
    {// binding primitive 
        // take parameter as id ,string ,array
        public IActionResult primitive(string name,int id)
        {
            return Content("hello primitive");
        }
        //binding collction
        // take paramter dictionary ,list
        // url:dic["ahmed"]=aya
        public IActionResult colluction(Dictionary<string ,string>cap)
        {
            return Content("hello colluction");
        }
        public IActionResult objbind(department dept)
        {
            return Content("hello object");
        }



    }
}
