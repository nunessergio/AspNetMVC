using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GnaritasDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "Hello World!!";
        }

        public string Ola(string id)
        {
            return "Oi " + id; 
        }

        public double Somar(double num1, double num2)
        {
            return num1 + num2;

        }
    }
}