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
    public partial class visualizarCandidatos : Form
    {
        Thread VisualizarCandidatos;
        ConexaoCandidatos conexao = new ConexaoCandidatos();
        Candidato candidato = new Candidato();
        public visualizarCandidatos()
        {
            InitializeComponent();

            //Estes são os componentes estruturais da tabela
            viewCandidatos.View = View.Details;
            viewCandidatos.LabelEdit = true;
            viewCandidatos.AllowColumnReorder = true;
            viewCandidatos.FullRowSelect = true;
            viewCandidatos.GridLines = true;

            //Estas são as colunas com suas legendas
            viewCandidatos.Columns.Add("Código", 128, HorizontalAlignment.Left);
            viewCandidatos.Columns.Add("Nome", 128, HorizontalAlignment.Left);
            viewCandidatos.Columns.Add("CPF", 128, HorizontalAlignment.Left);
            viewCandidatos.Columns.Add("Naturalidade", 128, HorizontalAlignment.Left);
            viewCandidatos.Columns.Add("Partido", 128, HorizontalAlignment.Left);
            viewCandidatos.Columns.Add("Cargo", 128, HorizontalAlignment.Left);

            try
            {
                conexao.Buscar(viewCandidatos);
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

        private void viewCandidatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewCandidatos.SelectedItems.Count > 0)
            {
                ListViewItem item = viewCandidatos.SelectedItems[0];
                candidato.setCandidato(int.Parse(item.SubItems[0].Text), item.SubItems[1].Text, item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text, item.SubItems[5].Text);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editarCandidato tela = new editarCandidato();
            this.Close();
            VisualizarCandidatos = new Thread(abrirEditarCandidato);
            VisualizarCandidatos.SetApartmentState(ApartmentState.STA);
            VisualizarCandidatos.Start();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Excluir(candidato);
                conexao.Buscar(viewCandidatos);
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

        

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            this.Close();
            VisualizarCandidatos = new Thread(abrirMenuPrincipal);
            VisualizarCandidatos.SetApartmentState(ApartmentState.STA);
            VisualizarCandidatos.Start();
        }

        private void abrirMenuPrincipal(object obj)
        {
            Application.Run(new Form1());
        }

        private void abrirEditarCandidato(object obj)
        {
            Application.Run(new editarCandidato(candidato));
        }


    }
}
