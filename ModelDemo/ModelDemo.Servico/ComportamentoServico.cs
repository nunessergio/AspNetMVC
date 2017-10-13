using ModelDemo.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDemo.Servico
{
    public interface IComportamentoServico
    {

        void Criar(Pessoa pessoa);
        Pessoa Ler(string cpf);
        void Modificar(Pessoa pessoa);
        void Apagar(string cpf);
        List<Pessoa> VerTodos();
   

    }
}
