using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelDemo.Modelos
{
    public class Pessoa
    {
        public string Nome { get; set; }
        [Key]
        public string cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public double Peso { get; set; }
        public decimal Saldo { get; set; }

    }
}