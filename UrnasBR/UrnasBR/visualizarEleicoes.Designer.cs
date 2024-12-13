namespace UrnasBR
{
    partial class visualizarEleicoes
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
            btnVoltar = new Button();
            viewEleicoes = new ListView();
            btnVisualizarVotacao = new Button();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Black;
            btnVoltar.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(14, 553);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(86, 31);
            btnVoltar.TabIndex = 6;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // viewEleicoes
            // 
            viewEleicoes.Location = new Point(90, 84);
            viewEleicoes.Margin = new Padding(3, 4, 3, 4);
            viewEleicoes.Name = "viewEleicoes";
            viewEleicoes.Size = new Size(731, 385);
            viewEleicoes.TabIndex = 4;
            viewEleicoes.UseCompatibleStateImageBehavior = false;
            viewEleicoes.SelectedIndexChanged += viewEleicoes_SelectedIndexChanged;
            // 
            // btnVisualizarVotacao
            // 
            btnVisualizarVotacao.BackColor = Color.ForestGreen;
            btnVisualizarVotacao.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnVisualizarVotacao.ForeColor = Color.White;
            btnVisualizarVotacao.Location = new Point(385, 479);
            btnVisualizarVotacao.Margin = new Padding(3, 4, 3, 4);
            btnVisualizarVotacao.Name = "btnVisualizarVotacao";
            btnVisualizarVotacao.Size = new Size(103, 35);
            btnVisualizarVotacao.TabIndex = 8;
            btnVisualizarVotacao.Text = "Visualizar";
            btnVisualizarVotacao.UseVisualStyleBackColor = false;
            btnVisualizarVotacao.Click += btnVisualizarVotacao_Click;
            // 
            // visualizarEleicoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.URNA;
            ClientSize = new Size(914, 600);
            Controls.Add(btnVisualizarVotacao);
            Controls.Add(btnVoltar);
            Controls.Add(viewEleicoes);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "visualizarEleicoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualizar Eleicoes";
            ResumeLayout(false);
        }

        #endregion

        private Button btnVoltar;
        private ListView viewEleicoes;
        private Button btnVisualizarVotacao;
    }
}