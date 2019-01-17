using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agenda.Project.Web.Models {

    public class Contato {

        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nome { get; set; } 
        public string Sobrenome { get; set; }
        public bool Sexo { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Mae { get; set; }
        public string Pai { get; set; }
        public string Telefone { get; set; }
        public string Celular { get; set; }


    }
}