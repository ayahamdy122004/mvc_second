using Microsoft.AspNetCore.Mvc;
using MVC_second.Models;
namespace MVC_second.Controllers
{
    public class departmentController : Controller
    {
        iticontext context = new iticontext();
        public IActionResult index()
        {
            List<department> deptlist = context.departments.ToList();
            return View("index", deptlist);
        }
        // you do this action for open form to receive date
        public IActionResult add()
        {
            return View("add");
        }
        //you do this action for save date from fronted to backend
        //my action can be handle any request(get,post)just different mothed 
        public IActionResult saveadd(department newdeptFormRequest)
        {
            if (newdeptFormRequest != null)
            {
                context.departments.Add(newdeptFormRequest);
                context.SaveChanges();
                // call action from another action
                return RedirectToAction("index");
            }
            // you use "newdeptFormRequest" becuase user مدخلش input to backend
            // عشان هو كان بيصفر الفروم عند حدوث خطا ف كدا هيحتفظ بالدتا الغلط الي حد ما تتصلح
            return View("add", newdeptFormRequest);
        }
    }
}