using PessoaSPA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PessoaSPA.Controllers
{
    public class PessoasController : Controller
    {

        // Criar uma lista de pessoas
        private static List<Pessoa> modelo;

        // Não prmitir que haja erro se o objeto estiver vazio
        public PessoasController()
        {
            if (modelo == null)
            {
                modelo = new List<Pessoa>();
            }
        }

        public ActionResult Index()
        {
            return View();
        }

        // GET: Pessoas
        public ActionResult Listar()
        {
            return PartialView(modelo);
        }

        // GET: Pessoas/Details/5
        public ActionResult Visualizar(Guid id)
        {
            return PartialView();
        }

        // GET: Pessoas/Create
        public ActionResult Criar()
        {
            return View();
        }

        // POST: Pessoas/Create
        [HttpPost]
        public JsonResult Criar(Pessoa pessoa)
        {

            modelo.Add(pessoa);

            return Json(new { resultado = true, mensagem = "Pessoa cadastrada com sucesso" });
        
        }

        // GET: Pessoas/Edit/5
        public ActionResult Atualizar(Guid id)
        {

            //Pessoa pessoa = modelo.Find(delegate (Pessoa p1) { return p1.Id == id; });

            var found = modelo.FirstOrDefault(c => c.Id == id);

            return PartialView(found);
        }

        // POST: Pessoas/Edit/5
        [HttpPut]
        public ActionResult Atualizar(Pessoa pessoa)
        {

            //modelo.Nome = pessoa.Nome;

            var result = modelo.Where(d => d.Id == pessoa.Id).FirstOrDefault();
            if (result != null) { result.Nome = pessoa.Nome; }

            return PartialView(modelo);
        }

        // GET: Pessoas/Delete/5
        public ActionResult Excluir(Guid id)
        {
            return PartialView();
        }

    }
}


