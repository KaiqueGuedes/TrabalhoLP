using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP.Camadas.Model
{
   public  class ModelProduto
    {
        public int idProduto { get; set; }
        public string nome { get; set; }
        public string descricao { get; set; }
        public string status { get; set; }
        public int id_fornecedor { get; set; }
        public decimal qtd { get; set; }
        public decimal valor { get; set; }

    }
}
