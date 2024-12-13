using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//Este é o using de criação de threads
using System.Threading;
//Este é o using de conexão com o banco de dados
using MySql.Data.MySqlClient;
using UrnasBR.Classes;
using UrnasBR.Classes.ClassesConexaoBanco;

namespace UrnasBR
{
    public partial class CadastroPartido : Form
    {
        Thread cadastroPartido;

        //Instancia da classe de conexão
        ConexaoPartidos conexao = new ConexaoPartidos();
        public CadastroPartido()
        {
            InitializeComponent();
        }

        private void CadastroPartido_Load(object sender, EventArgs e)
        {
            //Ignorar este método
        }

        private void btnCadastrarPartido_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Inserir("partidos","nome_partido","sigla","presidente_partido",nomePartido.Text,siglaPartido.Text,presidPartido.Text);
                MessageBox.Show("Partido criado com sucesso!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível criar o partido!");
                MessageBox.Show(ex.Message);
            }
            finally
            {
                nomePartido.Text = "";
                siglaPartido.Text = "";
                presidPartido.Text = "";
                conexao.FecharConexao();
            }
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            this.Close();
            cadastroPartido = new Thread(abrirMenuPrincipal);
            cadastroPartido.SetApartmentState(ApartmentState.STA);
            cadastroPartido.Start();
        }

        private void abrirMenuPrincipal(object obj)
        {
            Application.Run(new Form1());
        }
    }
}
