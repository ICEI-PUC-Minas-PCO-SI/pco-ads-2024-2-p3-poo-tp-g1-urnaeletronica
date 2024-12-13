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
    public partial class editarPartido : Form
    {
        Thread EditarPartido;
        Partido Partido = new Partido();
        ConexaoPartidos conexao = new ConexaoPartidos();
        public editarPartido(Partido partido)
        {
            InitializeComponent();

            nomePartido.Text = partido.getNomePartido();
            siglaPartido.Text = partido.getSigla();
            presidPartido.Text = partido.getPresidente();

            Partido = partido;
        }

        public editarPartido()
        {
            InitializeComponent();
        }

        private void btnSalvarPartido_Click(object sender, EventArgs e)
        {
            try
            {
                conexao.Editar(Partido,nomePartido.Text,siglaPartido.Text,presidPartido.Text);
                MessageBox.Show("Partido Alterado!");
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
                EditarPartido = new Thread(abrirVisualizarPartidos);
                EditarPartido.SetApartmentState(ApartmentState.STA);
                EditarPartido.Start();
            }

        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            visualizarCandidatos tela = new visualizarCandidatos();
            this.Close();
            EditarPartido = new Thread(abrirVisualizarPartidos);
            EditarPartido.SetApartmentState(ApartmentState.STA);
            EditarPartido.Start();
        }

        private void abrirVisualizarPartidos(object obj)
        {
            Application.Run(new visualizarPartidos());
        }
    }
}
