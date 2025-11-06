using Microsoft.AspNetCore.Mvc;
using MVC_second.Models;
namespace MVC_second.Controllers
{
    public class employeeController : Controller
    {
        iticontext context = new iticontext();
        public IActionResult index()
        {
          List<employee> emp = context.employees.ToList();

            return View("index",emp);
        }
        // handle link
        public IActionResult edit(int id)
        {
            employee emp = context.employees.FirstOrDefault(edit => edit.id == id);
            return View("edit", emp);
        }
        public IActionResult saveedit(employee e)
        {

            employee emp = context.employees.FirstOrDefault(m => m.id == e.id);
            if (e.name != null)
            {
                emp.name = e.name;
                emp.jobtitle = e.jobtitle;
                // emp.jobtitle=e.jobtitle;
                emp.address = e.address;
                emp.salary = e.salary;
                emp.deptid=e.deptid;
                context.SaveChanges();
                return RedirectToAction("index");
            }
            return View("edit",e);
        }
    }
}
