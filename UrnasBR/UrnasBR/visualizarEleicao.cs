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

namespace UrnasBR.Classes
{
    public partial class visualizarEleicao : Form
    {
        Thread VisualizarEleicao;
        ConexaoEleicoes conexao = new ConexaoEleicoes();
        ConexaoCandidatos conexao2 = new ConexaoCandidatos();
        public visualizarEleicao()
        {
            InitializeComponent();
        }

        public visualizarEleicao(Eleicoes eleicao)
        {
            InitializeComponent();

            //Estes são os componentes estruturais da tabela
            viewCandidatos.View = View.Details;
            viewCandidatos.LabelEdit = true;
            viewCandidatos.AllowColumnReorder = true;
            viewCandidatos.FullRowSelect = true;
            viewCandidatos.GridLines = true;

            //Estas são as colunas com suas legendas
            viewCandidatos.Columns.Add("Código", 154, HorizontalAlignment.Left);
            viewCandidatos.Columns.Add("Nome", 154, HorizontalAlignment.Left);
            viewCandidatos.Columns.Add("Partido", 154, HorizontalAlignment.Left);
            viewCandidatos.Columns.Add("Votos", 154, HorizontalAlignment.Left);

            try
            {
                conexao2.BuscarCandidatosEleicao(viewCandidatos,eleicao);
                conexao2.BuscarDadosEleicao(eleito, partidoEleito, votosEleito, eleicao);
                TextBox[] campos = { votosNulos, votosBrancos };
                conexao2.BuscarDadosEleicao(eleicao, campos);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            visualizarEleicoes tela = new visualizarEleicoes();
            this.Close();
            VisualizarEleicao = new Thread(abrirVisualizarEleicoes);
            VisualizarEleicao.SetApartmentState(ApartmentState.STA);
            VisualizarEleicao.Start();
        }

        private void abrirVisualizarEleicoes(object obj)
        {
            Application.Run(new visualizarEleicoes());
        }

        private void viewCandidatos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
