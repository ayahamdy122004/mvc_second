using Microsoft.AspNetCore.Mvc;
using MVC_second.Models;

namespace MVC_second.Controllers
{
    public class studentController : Controller
    {
     public IActionResult showall()
        {
          StudentBL studentBL = new StudentBL();
            List<student>stulistmodel=studentBL.getall();
            return View("showall",stulistmodel);
        }
    }
}
