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
    public partial class visualizarEleicoes : Form
    {
        Thread VisualizarEleicoes;
        ConexaoEleicoes conexao = new ConexaoEleicoes();
        Eleicoes eleicoes = new Eleicoes();

        public visualizarEleicoes()
        {
            InitializeComponent();

            //Estes são os componentes estruturais da tabela
            viewEleicoes.View = View.Details;
            viewEleicoes.LabelEdit = true;
            viewEleicoes.AllowColumnReorder = true;
            viewEleicoes.FullRowSelect = true;
            viewEleicoes.GridLines = true;

            //Estas são as colunas com suas legendas
            viewEleicoes.Columns.Add("Código", 243, HorizontalAlignment.Left);
            viewEleicoes.Columns.Add("Nome", 243, HorizontalAlignment.Left);
            viewEleicoes.Columns.Add("Cargo", 243, HorizontalAlignment.Left);

            try
            {
                conexao.Buscar(viewEleicoes);
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

        
        

        private void viewEleicoes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewEleicoes.SelectedItems.Count > 0)
            {
                ListViewItem item = viewEleicoes.SelectedItems[0];
                eleicoes.setEleicoes(int.Parse(item.SubItems[0].Text), item.SubItems[1].Text, item.SubItems[2].Text);
            }
        }

        private void btnVisualizarVotacao_Click(object sender, EventArgs e)
        {
            visualizarEleicao tela = new visualizarEleicao();
            this.Close();
            VisualizarEleicoes = new Thread(abrirVisualizarEleicao);
            VisualizarEleicoes.SetApartmentState(ApartmentState.STA);
            VisualizarEleicoes.Start();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            this.Close();
            VisualizarEleicoes = new Thread(abrirMenuPrincipal);
            VisualizarEleicoes.SetApartmentState(ApartmentState.STA);
            VisualizarEleicoes.Start();
        }

        private void abrirMenuPrincipal(object obj)
        {
            Application.Run(new Form1());
        }

        private void abrirVisualizarEleicao(object obj)
        {
            Application.Run(new visualizarEleicao(eleicoes));
        }
    }
}
