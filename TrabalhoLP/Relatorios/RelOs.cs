using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TrabalhoLP.Relatorios
{
    public class RelOs
    {
        public static void impRelOrdemServicos()
        {
            List<Camadas.Model.Os> lstOs = new List<Camadas.Model.Os>();
            Camadas.BLL.BLLOs bllOs = new Camadas.BLL.BLLOs();
            lstOs = bllOs.Select();
            string folder = Funcoes.diretorioPasta2();
            string arquivo = folder + @"\OrdensServico.html";
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(arquivo))
            {
                sw.WriteLine("<html>");
                sw.WriteLine("	<head>");
                sw.WriteLine("<meta http-equiv=\"Content-Type\" content=\"text/html; charset =utf-8\">");
                sw.WriteLine("	</head>");
                sw.WriteLine("	<body>");
                sw.WriteLine(" <h1>Ordens de Serviço</h1>");
                sw.WriteLine("<table cellspacing=0 cellpading=0");
                sw.WriteLine("<tr cellpading=0 cellspacing=0 bgcolor='#00BFFF' border: '0px' solid black;>");
                sw.WriteLine("<th width ='30px'  align='left'>idOS </th>");
                sw.WriteLine("<th width ='170px' align='rigth'>Cliente</th>");
                sw.WriteLine("<th width ='90px'  align='center'>Id Produto</th>");
                sw.WriteLine("<th width ='150px' align='center'>Nome </th>");
                sw.WriteLine("<th width ='150px' align='center'>QTD </th>");
                sw.WriteLine("<th width ='150px' align='center'>Valor </th>");
                sw.WriteLine("<th width ='20px'  align='center'>Status</th>");
                sw.WriteLine("</tr>");
                int cont = 0;
                bool zebra = true;
                foreach (Camadas.Model.Os ordem  in lstOs )
                {
                    if (zebra)
                        sw.WriteLine("<tr cellpading=0 cellspacing=0 border:0 bgcolor='#CEF6E3'>");
                    else sw.WriteLine("<tr cellpading=0  cellspacing=0 border: 0 bgcolor='#F5F6CE'>");
                    zebra = !zebra;
                    sw.WriteLine("<td width ='30px' align='center'>" + ordem.idOs + "</td>");
                    sw.WriteLine("<td width ='150px' align='center'>" + ordem.cliente + "</td>");
                    sw.WriteLine("<td width ='150px' align='center'>" + ordem.id_prod + "</td>");
                    sw.WriteLine("<td width ='150px' align='center'>" + ordem.nome_p + "</td>");
                    sw.WriteLine("<td width ='150px' align='center'>" + ordem.qtd + "</td>");
                    sw.WriteLine("<td width ='90px' align='center'> R$ " + ordem.valor.ToString("0,0") + "</td>");
                    sw.WriteLine("<td width ='20px' align='center'>" + ordem.status + "</td>");
                    sw.WriteLine("</tr>");
                    cont++;
                }
                sw.WriteLine("</table>");
                sw.WriteLine("<hr border='3px' width='300px' align='left'>");
                sw.WriteLine("<h4>Total de registros impressos: " + cont + "</h4>");
                sw.WriteLine("<h4>Total geral de valor: R$ " + lstOs.Sum(p => p.valor).ToString("0,0") + "</h4>");
                sw.WriteLine("	</body>");
                sw.WriteLine("</html>");
                sw.WriteLine("  </body>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }
    }
}
