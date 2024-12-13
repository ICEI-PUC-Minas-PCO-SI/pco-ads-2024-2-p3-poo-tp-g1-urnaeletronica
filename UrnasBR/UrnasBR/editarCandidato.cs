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
    public partial class editarCandidato : Form
    {
        Thread EditarCandidato;
        ConexaoCandidatos conexao = new ConexaoCandidatos();
        Candidato Candidato;

        public editarCandidato()
        {

        }

        public editarCandidato(Candidato candidato)
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

            nomeCandidato.Text = candidato.getNome();
            cpfCandidato.Text = candidato.getCpf();
            naturCandidato.Text = candidato.getNatu();
            selectPartido.Text = candidato.getPartido();
            selectCargo.Text = candidato.getCargo();

            Candidato = candidato;
        }

        private void btnEditarCandidato_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Editar(Candidato, nomeCandidato.Text, cpfCandidato.Text, naturCandidato.Text, selectPartido.Text, selectCargo.Text);
                MessageBox.Show("Candidato Alterado!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
                visualizarCandidatos tela = new visualizarCandidatos();
                this.Close();
                EditarCandidato = new Thread(abrirVisualizarCandidato);
                EditarCandidato.SetApartmentState(ApartmentState.STA);
                EditarCandidato.Start();
            }
            
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            visualizarCandidatos tela = new visualizarCandidatos();
            this.Close();
            EditarCandidato = new Thread(abrirVisualizarCandidato);
            EditarCandidato.SetApartmentState(ApartmentState.STA);
            EditarCandidato.Start();
        }

        private void abrirVisualizarCandidato(object obj)
        {
            Application.Run(new visualizarCandidatos());
        }
    }
}
