using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP.Camadas.Model

{
    public class Os // regra de negocio
    {
        public int idOs { get; set; }
        public int idcli { get; set; }
        public string cliente { get; set; }
        public string descricao { get; set; }
        public decimal valor { get; set; }
        public DateTime data_ini { get; set; }
        public DateTime data_final { get; set; }
        public string status { get; set; }



        public int id_prod { get; set; }
        public string nome_p { get; set; }
        public decimal qtd { get; set; }
        public decimal valor_unit { get; set; }
      
    }
}
