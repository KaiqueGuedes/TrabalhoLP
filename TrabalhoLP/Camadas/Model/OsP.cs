using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP.Camadas.Model
{
    public class OsP
    {
        public int idOs { get; set; }
        public int id_prod { get; set; }
        public string nome_p { get; set; }
        public decimal valor_unit { get; set; }
        public decimal qtd { get; set; }
    }
}
