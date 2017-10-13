using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PessoaSPA.Models
{
    public class Pessoa
    {
        public Pessoa()
        {
            Id = Guid.NewGuid();
        }

        public Guid Id { get; set; }
        [Required]
        public string Nome { get; set; }
    }
}