using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Calculadora.Controllers
{
    public class HomeController : Controller
    {

        public ActionResult Tela()
        {
            return View();
        }

        public ActionResult Somar()
        {
            ViewBag.Acao = "Somar";
            return View("Tela");
        }


        [HttpPost]
        public ActionResult Somar(double num1, double num2)
        {
            ViewBag.Resultado = $"O resultado da soma é = {num1 + num2}";
            ViewBag.Acao = "Somar";
            return View("Tela");
        }

        public ActionResult Subtrair()
        {
            ViewBag.Acao = "Subtrair";
            return View("Tela");
        }

        [HttpPost]
        public ActionResult Subtrair(double num1, double num2)
        {
            ViewBag.Resultado = $"O resultado da subtração é = {num1 - num2}";
            ViewBag.Acao = "Subtrair";
            return View("Tela"); 
        }


        public ActionResult Dividir()
        {
            ViewBag.Acao = "Dividir";
            return View("Tela");
        }

        [HttpPost]
        public ActionResult Dividir(double num1, double num2)
        {
            
            ViewBag.Resultado = $"O resultado da divisão é = {num1 / num2}";
            ViewBag.Acao = "Dividir";
            return View("Tela"); 
        }

        public ActionResult Multiplicar()
        {
            ViewBag.Acao = "Multiplicar";
            return View("Tela");
        }

        [HttpPost]
        public ActionResult Multiplicar(double num1, double num2)
        {
            ViewBag.Resultado = $"O resultado da multiplicação é = {num1 * num2}";
            ViewBag.Acao = "Multiplicar";
            return View("tela");
        }



    }

}