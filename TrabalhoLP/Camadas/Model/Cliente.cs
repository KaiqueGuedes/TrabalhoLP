﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP.Camadas.Model
{
    public class Cliente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string cpf_cnpj { get; set; }
        public string cidade { get; set; }
        public string cep { get; set; }
        public string endereco { get; set; }
        public string uf { get; set; }
        public string email { get; set; }
        public string fone { get; set; }
    }
}
