﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agenda.Project.Web.Models {

    public class Endereco {

        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Cep { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

    }
}