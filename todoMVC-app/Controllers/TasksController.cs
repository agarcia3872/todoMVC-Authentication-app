using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace todoMVC_app.Controllers
{
    public class TasksController : Controller
    {
        // GET: Tasks
        static private List<string> Tasks = new List<string>();

        // GET: /<controller>/
        public ActionResult Index()
        {
            //List<string> cheeses = new List<string>();

            //cheeses.Add("Cheddar");
            //cheeses.Add("Munster");
            //cheeses.Add("Parmesan");

            ViewBag.tasks = Tasks;

            return View();
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        [Route("/Tasks/Add")]
        public ActionResult NewTask(string name)
        {
            // Add the new cheese to my existing cheeses
            Tasks.Add(name);

            return Redirect("/Tasks");
        }

    }
}
