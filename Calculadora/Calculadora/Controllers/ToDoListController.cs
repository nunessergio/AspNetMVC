using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculadora.Controllers
{
    public class ToDoListController : Controller
    {
        private static List<string> todolist;

        public ToDoListController()
        {
            if (todolist == null)
            {
                todolist = new List<string>();
            }
        }

        public ActionResult Index(string atividade)
        {
            if (!string.IsNullOrWhiteSpace(atividade))
            {
                todolist.Add(atividade);
            }
            return View(todolist);
        }

  

    }
}