﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Regras_de_negócio {
    public class Usuario {

        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime Data_Nascimento { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }


    }
}
