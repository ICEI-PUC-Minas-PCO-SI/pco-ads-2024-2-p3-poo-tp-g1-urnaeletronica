namespace UrnasBR.Classes
{
    partial class visualizarEleicao
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
            eleito = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Partido = new Label();
            partidoEleito = new TextBox();
            votosEleito = new TextBox();
            label3 = new Label();
            votosNulos = new TextBox();
            label4 = new Label();
            votosBrancos = new TextBox();
            viewCandidatos = new ListView();
            label5 = new Label();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // eleito
            // 
            eleito.Enabled = false;
            eleito.Location = new Point(149, 63);
            eleito.Margin = new Padding(3, 4, 3, 4);
            eleito.Name = "eleito";
            eleito.Size = new Size(181, 27);
            eleito.TabIndex = 0;
            eleito.TextAlign = HorizontalAlignment.Center;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(186, 39);
            label1.Name = "label1";
            label1.Size = new Size(138, 22);
            label1.TabIndex = 2;
            label1.Text = "Candidato Eleito";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(622, 39);
            label2.Name = "label2";
            label2.Size = new Size(137, 22);
            label2.TabIndex = 3;
            label2.Text = "Votos Recebidos";
            // 
            // Partido
            // 
            Partido.AutoSize = true;
            Partido.BackColor = Color.Transparent;
            Partido.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            Partido.Location = new Point(434, 39);
            Partido.Name = "Partido";
            Partido.Size = new Size(67, 22);
            Partido.TabIndex = 5;
            Partido.Text = "Partido";
            // 
            // partidoEleito
            // 
            partidoEleito.Enabled = false;
            partidoEleito.Location = new Point(369, 63);
            partidoEleito.Margin = new Padding(3, 4, 3, 4);
            partidoEleito.Name = "partidoEleito";
            partidoEleito.Size = new Size(181, 27);
            partidoEleito.TabIndex = 4;
            partidoEleito.TextAlign = HorizontalAlignment.Center;
            // 
            // votosEleito
            // 
            votosEleito.Enabled = false;
            votosEleito.Location = new Point(584, 63);
            votosEleito.Margin = new Padding(3, 4, 3, 4);
            votosEleito.Name = "votosEleito";
            votosEleito.Size = new Size(181, 27);
            votosEleito.TabIndex = 6;
            votosEleito.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(296, 136);
            label3.Name = "label3";
            label3.Size = new Size(103, 22);
            label3.TabIndex = 8;
            label3.Text = "Votos Nulos";
            // 
            // votosNulos
            // 
            votosNulos.Enabled = false;
            votosNulos.Location = new Point(249, 160);
            votosNulos.Margin = new Padding(3, 4, 3, 4);
            votosNulos.Name = "votosNulos";
            votosNulos.Size = new Size(181, 27);
            votosNulos.TabIndex = 7;
            votosNulos.TextAlign = HorizontalAlignment.Center;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(511, 136);
            label4.Name = "label4";
            label4.Size = new Size(141, 22);
            label4.TabIndex = 10;
            label4.Text = "Votos em Branco";
            // 
            // votosBrancos
            // 
            votosBrancos.Enabled = false;
            votosBrancos.Location = new Point(482, 160);
            votosBrancos.Margin = new Padding(3, 4, 3, 4);
            votosBrancos.Name = "votosBrancos";
            votosBrancos.Size = new Size(181, 27);
            votosBrancos.TabIndex = 9;
            votosBrancos.TextAlign = HorizontalAlignment.Center;
            // 
            // viewCandidatos
            // 
            viewCandidatos.Location = new Point(149, 281);
            viewCandidatos.Margin = new Padding(3, 4, 3, 4);
            viewCandidatos.Name = "viewCandidatos";
            viewCandidatos.Size = new Size(617, 232);
            viewCandidatos.TabIndex = 11;
            viewCandidatos.UseCompatibleStateImageBehavior = false;
            viewCandidatos.SelectedIndexChanged += viewCandidatos_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(409, 257);
            label5.Name = "label5";
            label5.Size = new Size(97, 22);
            label5.TabIndex = 12;
            label5.Text = "Candidatos";
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Black;
            btnVoltar.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(14, 545);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(86, 39);
            btnVoltar.TabIndex = 13;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // visualizarEleicao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.URNA;
            ClientSize = new Size(914, 600);
            Controls.Add(btnVoltar);
            Controls.Add(label5);
            Controls.Add(viewCandidatos);
            Controls.Add(label4);
            Controls.Add(votosBrancos);
            Controls.Add(label3);
            Controls.Add(votosNulos);
            Controls.Add(votosEleito);
            Controls.Add(Partido);
            Controls.Add(partidoEleito);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(eleito);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "visualizarEleicao";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualizar Eleicao";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox eleito;
        private Label label1;
        private Label label2;
        private Label Partido;
        private TextBox partidoEleito;
        private TextBox votosEleito;
        private Label label3;
        private TextBox votosNulos;
        private Label label4;
        private TextBox votosBrancos;
        private ListView viewCandidatos;
        private Label label5;
        private Button btnVoltar;
    }
}