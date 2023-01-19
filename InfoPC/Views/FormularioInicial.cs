using InfoPC.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfoPC.Views
{
    public partial class FormularioInicial : Form
    {
        public FormularioInicial()
        {
            InitializeComponent();
        }

        InformacoesPC informacoes = new InformacoesPC();

        private void FormularioInicial_Shown(object sender, EventArgs e)
        {
            informacoes.PegarInformacoes();
            lbl_Bits.Text = lbl_Bits.Text + informacoes.Bits + " Bits";
            lbl_Clr.Text = lbl_Clr.Text + informacoes.Clr;
            lbl_Comando.Text = lbl_Comando.Text + informacoes.Comando;
            lbl_Diretorio.Text = lbl_Diretorio.Text + informacoes.Diretorio;
            lbl_NomePC.Text = lbl_NomePC.Text + informacoes.NomePC; 
            lbl_NomeUsuario.Text = lbl_NomeUsuario.Text + informacoes.Usuario;
            lbl_QntNucleos.Text = lbl_QntNucleos.Text + informacoes.Processador;
            lbl_VersaoSO.Text = lbl_VersaoSO.Text + informacoes.VersaoSistema; 
        }

        private void btn_SalvarTxt_Click(object sender, EventArgs e)
        {
            try
            {
                SalvarInformacoesTxt.GerarArquivo(informacoes);
                MessageBox.Show("Arquivo salvo com sucesso na pasta: \nC:\\Users\\" + Environment.UserName + "\\Documentos", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            catch(Exception) 
            {
                MessageBox.Show("Não foi possível salvaro arquivo em formato .txt", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); 
            }
        }
    }
}
