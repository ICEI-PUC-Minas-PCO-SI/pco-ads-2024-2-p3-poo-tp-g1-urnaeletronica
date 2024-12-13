namespace UrnasBR
{
    partial class inserirVotos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textArquivo = new TextBox();
            label1 = new Label();
            btnSelecionar = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnVoltar = new Button();
            btnVisualizarEleicoes = new Button();
            SuspendLayout();
            // 
            // textArquivo
            // 
            textArquivo.Location = new Point(67, 105);
            textArquivo.Margin = new Padding(3, 4, 3, 4);
            textArquivo.Name = "textArquivo";
            textArquivo.Size = new Size(372, 27);
            textArquivo.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(186, 49);
            label1.Name = "label1";
            label1.Size = new Size(132, 22);
            label1.TabIndex = 0;
            label1.Text = "Insira o Arquivo";
            // 
            // btnSelecionar
            // 
            btnSelecionar.BackColor = Color.ForestGreen;
            btnSelecionar.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnSelecionar.ForeColor = Color.White;
            btnSelecionar.Location = new Point(146, 182);
            btnSelecionar.Margin = new Padding(3, 4, 3, 4);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(106, 60);
            btnSelecionar.TabIndex = 3;
            btnSelecionar.Text = "Selecionar Arquivo";
            btnSelecionar.UseVisualStyleBackColor = false;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Black;
            btnVoltar.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(54, 319);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(100, 38);
            btnVoltar.TabIndex = 4;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnVisualizarEleicoes
            // 
            btnVisualizarEleicoes.BackColor = Color.Crimson;
            btnVisualizarEleicoes.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnVisualizarEleicoes.ForeColor = Color.White;
            btnVisualizarEleicoes.Location = new Point(258, 182);
            btnVisualizarEleicoes.Margin = new Padding(3, 4, 3, 4);
            btnVisualizarEleicoes.Name = "btnVisualizarEleicoes";
            btnVisualizarEleicoes.Size = new Size(106, 60);
            btnVisualizarEleicoes.TabIndex = 5;
            btnVisualizarEleicoes.Text = "Visualizar Eleições";
            btnVisualizarEleicoes.UseVisualStyleBackColor = false;
            btnVisualizarEleicoes.Click += btnVisualizarEleicoes_Click;
            // 
            // inserirVotos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.Imagem_do_WhatsApp_de_2024_12_12_à_s__13_50_50_95d9a21f;
            ClientSize = new Size(829, 421);
            Controls.Add(btnVisualizarEleicoes);
            Controls.Add(btnVoltar);
            Controls.Add(btnSelecionar);
            Controls.Add(textArquivo);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "inserirVotos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inserir Votos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox textArquivo;
        private Label label1;
        private Button btnSelecionar;
        private OpenFileDialog openFileDialog1;
        private Button btnVoltar;
        private Button btnVisualizarEleicoes;
    }
}