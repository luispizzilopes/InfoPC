using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics; 
using System.Threading.Tasks;
using System.IO;
using System.Reflection.Metadata.Ecma335;

namespace InfoPC.Model
{
    internal class InformacoesPC
    {
        public int Bits { get; set; }
        public string NomePC { get; set; }
        public string VersaoSistema { get; set; }
        public string Processador { get; set; }
        public string Clr { get; set; }
        public string Usuario { get; set; }
        public string Diretorio { get; set; }
        public string Comando { get; set; }
        public void PegarInformacoes()
        {
            if(Environment.Is64BitOperatingSystem == true )
            {
                Bits = 64; 
            }
            else
            {
                Bits = 32; 
            }

            NomePC = Environment.MachineName;
            VersaoSistema = Environment.OSVersion.ToString();
            Processador = Environment.ProcessorCount.ToString();
            Clr = Environment.Version.ToString();
            Usuario = Environment.UserName;
            Diretorio = Environment.CurrentDirectory;
            Comando = Environment.CommandLine; 
        }

        public override string ToString()
        {
            return "Informações do PC:" +
                    "\nNome do PC: " + NomePC +
                    "\nVersão do sistema: " + VersaoSistema +
                    "\nBits: " + Bits + " Bits" +
                    "\nNúcleos do processador: " + Processador +
                    "\nVersão CLR: " + Clr +
                    "\n\nInformações do usuário: " +
                    "\nNome do usuário: " + Usuario +
                    "\nDiretório atual: " + Diretorio +
                    "\nComando de execução: " + Comando; 
        }
    }
}
