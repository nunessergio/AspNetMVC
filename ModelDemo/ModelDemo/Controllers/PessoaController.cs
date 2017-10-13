using ModelDemo.Modelos;
using ModelDemo.Servico;
using ModelDemo.ServicoBanco;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ModelDemo.Controllers
{
    public class PessoaController : Controller
    {
        //Agregando a interface 
        private IComportamentoServico servico;

        public PessoaController()
        {
            servico = new PessoaServico();
        }

        public ActionResult Index()
        {
            return View(servico.VerTodos());
        }

        public ActionResult Criar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Criar(Pessoa pessoa)
        {
            servico.Criar(pessoa);
            return RedirectToAction("Index");
        }


        public ActionResult Ler()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Ler(string cpf)
        {
            return View();
        }

        public PartialViewResult Visualizar(string cpf)
        {
            return PartialView(servico.Ler(cpf));
        }


    }
}