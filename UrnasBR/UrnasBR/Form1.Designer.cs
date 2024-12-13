namespace UrnasBR
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnCadastroEleicoes = new Button();
            btnCadastroPartido = new Button();
            btnCadastroCandidato = new Button();
            btnInserirVotos = new Button();
            btnVisualizarEleicoes = new Button();
            btnVisualizarPartidos = new Button();
            btnVisualizarCandidatos = new Button();
            btnRelatorio = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            SuspendLayout();
            // 
            // btnCadastroEleicoes
            // 
            btnCadastroEleicoes.BackColor = Color.RoyalBlue;
            btnCadastroEleicoes.Font = new Font("Candara", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastroEleicoes.ForeColor = Color.White;
            btnCadastroEleicoes.Location = new Point(479, 80);
            btnCadastroEleicoes.Margin = new Padding(3, 4, 3, 4);
            btnCadastroEleicoes.Name = "btnCadastroEleicoes";
            btnCadastroEleicoes.Size = new Size(205, 159);
            btnCadastroEleicoes.TabIndex = 0;
            btnCadastroEleicoes.Text = "Cadastrar Eleições";
            btnCadastroEleicoes.UseVisualStyleBackColor = false;
            btnCadastroEleicoes.Click += btnCadastroEleicoes_Click;
            // 
            // btnCadastroPartido
            // 
            btnCadastroPartido.BackColor = Color.RoyalBlue;
            btnCadastroPartido.Font = new Font("Candara", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastroPartido.ForeColor = Color.White;
            btnCadastroPartido.Location = new Point(37, 80);
            btnCadastroPartido.Margin = new Padding(3, 4, 3, 4);
            btnCadastroPartido.Name = "btnCadastroPartido";
            btnCadastroPartido.Size = new Size(215, 159);
            btnCadastroPartido.TabIndex = 1;
            btnCadastroPartido.Text = "Cadastrar Partido";
            btnCadastroPartido.UseVisualStyleBackColor = false;
            btnCadastroPartido.Click += btnCadastroPartido_Click;
            // 
            // btnCadastroCandidato
            // 
            btnCadastroCandidato.BackColor = Color.RoyalBlue;
            btnCadastroCandidato.Font = new Font("Candara", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastroCandidato.ForeColor = Color.White;
            btnCadastroCandidato.Location = new Point(258, 80);
            btnCadastroCandidato.Margin = new Padding(3, 4, 3, 4);
            btnCadastroCandidato.Name = "btnCadastroCandidato";
            btnCadastroCandidato.Size = new Size(215, 159);
            btnCadastroCandidato.TabIndex = 2;
            btnCadastroCandidato.Text = "Cadastrar Candidato";
            btnCadastroCandidato.UseVisualStyleBackColor = false;
            btnCadastroCandidato.Click += btnCadastroCandidato_Click;
            // 
            // btnInserirVotos
            // 
            btnInserirVotos.BackColor = Color.ForestGreen;
            btnInserirVotos.Font = new Font("Candara", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnInserirVotos.ForeColor = Color.White;
            btnInserirVotos.Location = new Point(690, 80);
            btnInserirVotos.Margin = new Padding(3, 4, 3, 4);
            btnInserirVotos.Name = "btnInserirVotos";
            btnInserirVotos.Size = new Size(227, 159);
            btnInserirVotos.TabIndex = 3;
            btnInserirVotos.Text = "Inserir Votos";
            btnInserirVotos.UseVisualStyleBackColor = false;
            btnInserirVotos.Click += btnInserirVotos_Click;
            // 
            // btnVisualizarEleicoes
            // 
            btnVisualizarEleicoes.BackColor = Color.RoyalBlue;
            btnVisualizarEleicoes.Font = new Font("Candara", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnVisualizarEleicoes.ForeColor = Color.White;
            btnVisualizarEleicoes.Location = new Point(37, 333);
            btnVisualizarEleicoes.Margin = new Padding(3, 4, 3, 4);
            btnVisualizarEleicoes.Name = "btnVisualizarEleicoes";
            btnVisualizarEleicoes.Size = new Size(205, 159);
            btnVisualizarEleicoes.TabIndex = 4;
            btnVisualizarEleicoes.Text = "Visualizar Eleições";
            btnVisualizarEleicoes.UseVisualStyleBackColor = false;
            btnVisualizarEleicoes.Click += btnVisualizarEleicoes_Click;
            // 
            // btnVisualizarPartidos
            // 
            btnVisualizarPartidos.BackColor = Color.RoyalBlue;
            btnVisualizarPartidos.Font = new Font("Candara", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnVisualizarPartidos.ForeColor = Color.White;
            btnVisualizarPartidos.Location = new Point(248, 333);
            btnVisualizarPartidos.Margin = new Padding(3, 4, 3, 4);
            btnVisualizarPartidos.Name = "btnVisualizarPartidos";
            btnVisualizarPartidos.Size = new Size(215, 159);
            btnVisualizarPartidos.TabIndex = 5;
            btnVisualizarPartidos.Text = "Visualizar Partidos";
            btnVisualizarPartidos.UseVisualStyleBackColor = false;
            btnVisualizarPartidos.Click += btnVisualizarPartidos_Click;
            // 
            // btnVisualizarCandidatos
            // 
            btnVisualizarCandidatos.BackColor = Color.RoyalBlue;
            btnVisualizarCandidatos.Font = new Font("Candara", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnVisualizarCandidatos.ForeColor = Color.White;
            btnVisualizarCandidatos.Location = new Point(469, 333);
            btnVisualizarCandidatos.Margin = new Padding(3, 4, 3, 4);
            btnVisualizarCandidatos.Name = "btnVisualizarCandidatos";
            btnVisualizarCandidatos.Size = new Size(215, 159);
            btnVisualizarCandidatos.TabIndex = 6;
            btnVisualizarCandidatos.Text = "Visualizar Candidatos";
            btnVisualizarCandidatos.UseVisualStyleBackColor = false;
            btnVisualizarCandidatos.Click += btnVisualizarCandidatos_Click;
            // 
            // btnRelatorio
            // 
            btnRelatorio.BackColor = Color.Gold;
            btnRelatorio.Font = new Font("Candara", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            btnRelatorio.ForeColor = Color.White;
            btnRelatorio.Location = new Point(690, 333);
            btnRelatorio.Margin = new Padding(3, 4, 3, 4);
            btnRelatorio.Name = "btnRelatorio";
            btnRelatorio.Size = new Size(227, 159);
            btnRelatorio.TabIndex = 7;
            btnRelatorio.Text = "Relatório Eleições";
            btnRelatorio.UseVisualStyleBackColor = false;
            btnRelatorio.Click += btnRelatorio_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.URNA;
            ClientSize = new Size(961, 601);
            Controls.Add(btnRelatorio);
            Controls.Add(btnVisualizarCandidatos);
            Controls.Add(btnVisualizarPartidos);
            Controls.Add(btnVisualizarEleicoes);
            Controls.Add(btnInserirVotos);
            Controls.Add(btnCadastroCandidato);
            Controls.Add(btnCadastroPartido);
            Controls.Add(btnCadastroEleicoes);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Principal";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastroEleicoes;
        private Button btnCadastroPartido;
        private Button btnCadastroCandidato;
        private Button btnInserirVotos;
        private Button btnVisualizarEleicoes;
        private Button btnVisualizarPartidos;
        private Button btnVisualizarCandidatos;
        private Button btnRelatorio;
        private FolderBrowserDialog folderBrowserDialog1;
    }
}