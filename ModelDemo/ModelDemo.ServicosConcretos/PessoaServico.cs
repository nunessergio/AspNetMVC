using ModelDemo.Servico;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelDemo.Modelos;

namespace ModelDemo.ServicosConcretos
{
    public class PessoaServico : IComportamentoServico
    {
        private static List<Pessoa> pessoas;

        public PessoaServico()
        {
            if (pessoas == null)
            {
                pessoas = new List<Pessoa>();
            }
        }

        public void Apagar(string cpf)
        {
            throw new NotImplementedException();
        }

        public void Criar(Pessoa pessoa)
        {
            pessoas.Add(pessoa);
        }

        public Pessoa Ler(string cpf)
        {
            throw new NotImplementedException();
        }

        public void Modificar(Pessoa pessoa)
        {
            throw new NotImplementedException();
        }

        public List<Pessoa> VerTodos()
        {
            return pessoas;
        }


        



    }
}
