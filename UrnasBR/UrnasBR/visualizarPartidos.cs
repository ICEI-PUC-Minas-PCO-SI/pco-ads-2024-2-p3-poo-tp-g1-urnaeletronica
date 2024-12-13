using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UrnasBR.Classes.ClassesConexaoBanco;

namespace UrnasBR
{
    public partial class visualizarPartidos : Form
    {
        Thread VisualizarPartidos;
        ConexaoPartidos conexao = new ConexaoPartidos();
        Partido partido = new Partido();
        public visualizarPartidos()
        {
            InitializeComponent();

            //Estes são os componentes estruturais da tabela
            viewPartidos.View = View.Details;
            viewPartidos.LabelEdit = true;
            viewPartidos.AllowColumnReorder = true;
            viewPartidos.FullRowSelect = true;
            viewPartidos.GridLines = true;

            //Estas são as colunas com suas legendas
            viewPartidos.Columns.Add("Código", 145, HorizontalAlignment.Left);
            viewPartidos.Columns.Add("Nome", 145, HorizontalAlignment.Left);
            viewPartidos.Columns.Add("Sigla", 145, HorizontalAlignment.Left);
            viewPartidos.Columns.Add("Presidente", 145, HorizontalAlignment.Left);

            try
            {
                conexao.Buscar(viewPartidos);
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

        //Esta função é pra identificar qual item está selecionado na lista
        private void viewPartidos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (viewPartidos.SelectedItems.Count > 0)
            {
                ListViewItem item = viewPartidos.SelectedItems[0];
                partido.setPartido(int.Parse(item.SubItems[0].Text),item.SubItems[1].Text,item.SubItems[2].Text,item.SubItems[3].Text);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Excluir(partido);
                conexao.Buscar(viewPartidos);
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

        private void ExcluirMouse_Click(object sender, EventArgs e)
        {
            //Ignorar esta função. NÃO APAGAR
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            this.Close();
            VisualizarPartidos = new Thread(abrirMenuPrincipal);
            VisualizarPartidos.SetApartmentState(ApartmentState.STA);
            VisualizarPartidos.Start();
        }

        private void btnEditarPartido_Click(object sender, EventArgs e)
        {
            editarPartido tela = new editarPartido();
            this.Close();
            VisualizarPartidos = new Thread(abrirEditarPartido);
            VisualizarPartidos.SetApartmentState(ApartmentState.STA);
            VisualizarPartidos.Start();
        }

        private void abrirMenuPrincipal(object obj)
        {
            Application.Run(new Form1());
        }

        private void abrirEditarPartido(object obj)
        {
            Application.Run(new editarPartido(partido));
        }
    }
}
