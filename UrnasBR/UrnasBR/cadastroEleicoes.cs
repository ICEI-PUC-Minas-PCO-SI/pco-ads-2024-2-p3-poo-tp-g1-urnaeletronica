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
    public partial class CadastroEleicoes : Form
    {
        Thread cadastroEleicao;
        ConexaoEleicoes conexao = new ConexaoEleicoes();
        string cargo;
        public CadastroEleicoes()
        {
            InitializeComponent();
            try
            {
                conexao.Buscar(cargoEleicao);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
            }

            //Estes são os componentes estruturais da tabela
            viewCandidatos.View = View.Details;
            viewCandidatos.LabelEdit = true;
            viewCandidatos.AllowColumnReorder = true;
            viewCandidatos.FullRowSelect = true;
            viewCandidatos.GridLines = true;

            //Estas são as colunas com suas legendas
            viewCandidatos.Columns.Add("Código", 136, HorizontalAlignment.Left);
            viewCandidatos.Columns.Add("Nome", 136, HorizontalAlignment.Left);
            viewCandidatos.Columns.Add("Partido", 136, HorizontalAlignment.Left);
        }

        private void btnCadastrarEleicao_Click(object sender, EventArgs e)
        {
            int[] idCandidatos = new int[0];
            int i = 0;
            //Esta repetição é para armazenar o id dos candidatos
            foreach (ListViewItem view in viewCandidatos.Items)
            {
                Array.Resize(ref idCandidatos, idCandidatos.Length + 1);
                idCandidatos[i] = int.Parse(view.SubItems[0].Text);
                i++;
            }

            Array.Resize(ref idCandidatos, idCandidatos.Length + 2);
            idCandidatos[i] = 1;
            idCandidatos[i + 1] = 2;

            try
            {
                conexao.Inserir(nomeEleicao.Text, cargoEleicao.Text, idCandidatos);
                MessageBox.Show("Eleição cadastrada!");
                nomeEleicao.Text = "";
                cargoEleicao.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
                viewCandidatos.Items.Clear();
            }
        }

        private void btnVoltarMenu_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            this.Close();
            cadastroEleicao = new Thread(abrirMenuPrincipal);
            cadastroEleicao.SetApartmentState(ApartmentState.STA);
            cadastroEleicao.Start();
        }

        private void abrirMenuPrincipal(object obj)
        {
            Application.Run(new Form1());
        }

        //Esta é a função da caixa de seleção dos cargos
        private void cargoEleicao_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                cargo = cargoEleicao.Text;
                selectCandidato.Items.Clear();
                selectCandidato.Text = "";
                conexao.Buscar(selectCandidato, cargoEleicao.Text);
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

        //Esta função adiciona o candidato na lista da eleição
        private void btnAddCandidato_Click(object sender, EventArgs e)
        {
            //Aqui é necessário criar uma execessão para validar que usuário já está lançado
            foreach (ListViewItem view in viewCandidatos.Items)
            {
                if (view.SubItems[1].Text == selectCandidato.Text)
                {
                    MessageBox.Show("Candidato já selecionado!");
                    return;
                }
            }

            cargoEleicao.Enabled = false;

            try
            {
                conexao.Buscar(viewCandidatos, selectCandidato.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conexao.FecharConexao();
                selectCandidato.Text = "";
            }

        }
    }
}
