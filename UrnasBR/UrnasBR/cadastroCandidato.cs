using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrnasBR.Classes;
using UrnasBR.Classes.ClassesConexaoBanco;

namespace UrnasBR
{
    public partial class cadastroCandidato : Form
    {
        Thread CadastroCandidato;
        ConexaoCandidatos conexao = new ConexaoCandidatos();
        public cadastroCandidato()
        {
            InitializeComponent();
            try
            {
                conexao.Buscar(selectPartido);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }
        }

        private void btnCadastrarCandidato_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Inserir(nomeCandidato.Text,cpfCandidato.Text,naturCandidato.Text,selectPartido.Text,selectCargo.Text);
                MessageBox.Show("Candidato Cadastrado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                nomeCandidato.Text = "";
                cpfCandidato.Text = "";
                naturCandidato.Text = "";
                selectPartido.Text = "";
                selectCargo.Text = "";
                conexao.FecharConexao();
            }
        }

        

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            this.Close();
            CadastroCandidato = new Thread(abrirMenuPrincipal);
            CadastroCandidato.SetApartmentState(ApartmentState.STA);
            CadastroCandidato.Start();
        }

        private void abrirMenuPrincipal(object obj)
        {
            Application.Run(new Form1());
        }
    }
}
