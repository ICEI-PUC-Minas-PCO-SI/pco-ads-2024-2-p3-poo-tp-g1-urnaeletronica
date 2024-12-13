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
    public partial class inserirVotos : Form
    {
        Thread InserirVotos;
        ConexaoEleicoes conexao = new ConexaoEleicoes();
        public inserirVotos()
        {
            InitializeComponent();
            textArquivo.ReadOnly = true;
        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                InitialDirectory = "c:\\",
                Filter = "All files (*.*)|*.*|Text files (*.txt)|*.txt",
                FilterIndex = 1,
                RestoreDirectory = true
            };

            // Se o usuário selecionar um arquivo e clicar em OK
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtém o caminho do arquivo selecionado
                string filePath = openFileDialog.FileName;

                // Exibe o caminho do arquivo no TextBox
                textArquivo.Text = filePath;

                string linha;
                StreamReader sr = new StreamReader(filePath);
                linha = sr.ReadLine();
                int idEleicao = int.Parse(linha);
                int idCandidato = 0, quantVotos;
                //Se o modificador for 1 ele vai pegar o id do candidato, se for 2 vai pegar a quantidade de votos
                int modificador = 0;
                try
                {
                    while (linha != null)
                    {
                        linha = sr.ReadLine();
                        if (linha == "CANDIDATO")
                        {
                            modificador = 1;
                            continue;
                        }
                        if (linha == "VOTOS")
                        {
                            modificador = 2;
                            continue;
                        }
                        if (modificador == 1)
                        {
                            idCandidato = int.Parse(linha);
                            continue;
                        }
                        if (modificador == 2)
                        {
                            quantVotos = int.Parse(linha);
                            try
                            {
                                conexao.InserirVotos(idEleicao, idCandidato, quantVotos);
                                modificador = 0;
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
                    }

                    sr.Close();
                    MessageBox.Show("Votos Inseridos com sucesso!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            this.Close();
            InserirVotos = new Thread(abrirMenuPrincipal);
            InserirVotos.SetApartmentState(ApartmentState.STA);
            InserirVotos.Start();
        }

        private void abrirMenuPrincipal(object obj)
        {
            Application.Run(new Form1());
        }

        private void btnVisualizarEleicoes_Click(object sender, EventArgs e)
        {
            visualizarEleicoes tela = new visualizarEleicoes();
            this.Close();
            InserirVotos = new Thread(abrirVisualizarEleicoes);
            InserirVotos.SetApartmentState(ApartmentState.STA);
            InserirVotos.Start();
        }

        private void abrirVisualizarEleicoes(object obj)
        {
            Application.Run(new visualizarEleicoes());
        }
    }
}
