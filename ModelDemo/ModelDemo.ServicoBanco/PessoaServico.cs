using ModelDemo.Servico;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelDemo.Modelos;

namespace ModelDemo.ServicoBanco
{
    public class PessoaServico : DbContext, IComportamentoServico
    {
        public DbSet<Pessoa> Pessoas { get; set; }


        public void Criar(Pessoa pessoa)
        {
            Pessoas.Add(pessoa);
            SaveChanges();
        }

        public void Modificar(Pessoa pessoa)
        {
            this.Entry(pessoa).State = EntityState.Modified;
            SaveChanges();
        }


        public void Apagar(string cpf)
        {
            Pessoa pessoaDoBanco = Ler(cpf);
            
            Pessoas.Remove(pessoaDoBanco);
            SaveChanges();
        }

        

        public Pessoa Ler(string cpf)
        {
            Pessoa pessoaDoBanco = Pessoas.Where(p => p.cpf == cpf).FirstOrDefault();

            return pessoaDoBanco;
        }


        public List<Pessoa> VerTodos()
        {
            return Pessoas.ToList();
        }
    }
}
