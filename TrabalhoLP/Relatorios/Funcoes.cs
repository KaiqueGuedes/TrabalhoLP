using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TrabalhoLP.Relatorios
{
    public class Funcoes
    {
        public static string diretorioPasta()
        {
            string folder = @"C:\RelProdutos";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            return folder;
        }

        public static string diretorioPasta2()
        {
            string folder = @"C:\RelOrdemServ";
            if (!Directory.Exists(folder))
            {
                Directory.CreateDirectory(folder);
            }
            return folder;
        }
    }
}
