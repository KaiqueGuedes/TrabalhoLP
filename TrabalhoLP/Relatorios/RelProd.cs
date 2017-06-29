using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoLP.Relatorios
{
    public class RelProd
    {
        public static void impRelProdutos()
        {
            List<Camadas.Model.ModelProduto> lstPro = new List<Camadas.Model.ModelProduto>();
            Camadas.BLL.BLLProduto bllProd = new Camadas.BLL.BLLProduto();
            lstPro = bllProd.Select();
            string folder = Funcoes.diretorioPasta();
            string arquivo = folder + @"\ListagemProdutos.html";
            using (System.IO.StreamWriter sw = new System.IO.StreamWriter(arquivo))
            {
                sw.WriteLine("<html>");
                sw.WriteLine("	<head>");
                sw.WriteLine("      <meta http-equiv=\"Content-Type\" content=\"text/html; charset =utf-8\">");
                sw.WriteLine("	</head>");
                sw.WriteLine("	<body>");
                sw.WriteLine(" <h1>Relatório de Produtos</h1>");
                sw.WriteLine("<table cellspacing=0 cellpading=0");
                sw.WriteLine("<tr cellpading=0 cellspacing=0 bgcolor='#fcfcfc' border: '0px' solid black;>");
                sw.WriteLine("<th width ='30px'  align='right'>ID</th>");
                sw.WriteLine("<th width ='150px' align='left'>Nome</th>");
                sw.WriteLine("<th width ='90px'  align='right'>Valor</th>");
                sw.WriteLine("<th width ='20px'  align='center'>Status</th>");
                sw.WriteLine("</tr>");
                int cont = 0;
                bool zebra = true;
                foreach (Camadas.Model.ModelProduto produto in lstPro)
                {
                    if (zebra)
                        sw.WriteLine("<tr cellpading=0 cellspacing=0 border:0 bgcolor='#db7a7a'>");
                    else sw.WriteLine("<tr cellpading=0  cellspacing=0 border: 0 bgcolor='#6e9fd3'>");
                    zebra = !zebra;
                    sw.WriteLine("<td width ='30px' align='right'>" + produto.idProduto + "</td>");
                    sw.WriteLine("<td width ='150px' align='left'>" + produto.nome + "</td>");
                    sw.WriteLine("<td width ='90px' align='right'> R$ " + produto.valor.ToString("0,0") + "</td>");
                    sw.WriteLine("<td width ='20px' align='center'>" + produto.status + "</td>");
                    sw.WriteLine("</tr>");
                    cont++;
                }
                sw.WriteLine("</table>");
                sw.WriteLine("<hr border='3px' width='300px' align='left'>");
                sw.WriteLine("<h4>Total de registros impressos: " + cont + "</h4>");
                sw.WriteLine("<h4>Total geral de valor: R$ " + lstPro.Sum(p => p.valor).ToString("0,0") + "</h4>");
                sw.WriteLine("	</body>");
                sw.WriteLine("</html>");
                sw.WriteLine("  </body>");
                sw.WriteLine("</html>");
            }
            System.Diagnostics.Process.Start(arquivo);
        }
    }
}
