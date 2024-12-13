using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UrnasBR
{
    public partial class selecionarCargo : Form
    {
        Thread SelecionarCargo;
        public selecionarCargo()
        {
            InitializeComponent();
        }

        private void cadastro(int opcao)
        {
            //CadastroEleicoes tela = new CadastroEleicoes(opcao);
            //this.Close();
            //SelecionarCargo = new Thread(abrirCadastroEleicoes);
            //SelecionarCargo.SetApartmentState(ApartmentState.STA);
            //SelecionarCargo.Start();
        }

        private void abrirCadastroEleicoes(object obj,int opcao)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cadastro(1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cadastro(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cadastro(3);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            cadastro(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            cadastro(5);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            cadastro(6);
        }
    }
}
