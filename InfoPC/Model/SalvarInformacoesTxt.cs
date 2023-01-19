using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InfoPC.Model
{
    internal class SalvarInformacoesTxt
    {
        public static void GerarArquivo(InformacoesPC informacoes)
        {
            string endereco = "C:\\Users\\" + Environment.UserName + "\\Documents\\RelatorioPC.txt";
            using (StreamWriter stream = File.CreateText(endereco))
            {
                stream.WriteLine(informacoes.ToString()); 
            }
        }
    }
}
