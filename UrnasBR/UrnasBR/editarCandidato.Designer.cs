namespace UrnasBR
{
    partial class editarCandidato
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
            Button btnVoltar;
            selectCargo = new ComboBox();
            selectPartido = new ComboBox();
            btnEditarCandidato = new Button();
            label5 = new Label();
            label4 = new Label();
            naturCandidato = new TextBox();
            label3 = new Label();
            cpfCandidato = new TextBox();
            label2 = new Label();
            nomeCandidato = new TextBox();
            label1 = new Label();
            btnVoltar = new Button();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Black;
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(32, 545);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(86, 31);
            btnVoltar.TabIndex = 23;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // selectCargo
            // 
            selectCargo.FormattingEnabled = true;
            selectCargo.Items.AddRange(new object[] { "Presidente", "Governador", "Prefeito", "Deputado Estadual", "Deputado Federal", "Vereador" });
            selectCargo.Location = new Point(346, 384);
            selectCargo.Margin = new Padding(3, 4, 3, 4);
            selectCargo.Name = "selectCargo";
            selectCargo.Size = new Size(251, 28);
            selectCargo.TabIndex = 25;
            // 
            // selectPartido
            // 
            selectPartido.FormattingEnabled = true;
            selectPartido.Location = new Point(346, 297);
            selectPartido.Margin = new Padding(3, 4, 3, 4);
            selectPartido.Name = "selectPartido";
            selectPartido.Size = new Size(251, 28);
            selectPartido.TabIndex = 24;
            // 
            // btnEditarCandidato
            // 
            btnEditarCandidato.BackColor = Color.Crimson;
            btnEditarCandidato.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            btnEditarCandidato.ForeColor = Color.White;
            btnEditarCandidato.Location = new Point(346, 441);
            btnEditarCandidato.Margin = new Padding(3, 4, 3, 4);
            btnEditarCandidato.Name = "btnEditarCandidato";
            btnEditarCandidato.Size = new Size(251, 75);
            btnEditarCandidato.TabIndex = 22;
            btnEditarCandidato.Text = "Editar Candidato";
            btnEditarCandidato.UseVisualStyleBackColor = false;
            btnEditarCandidato.Click += btnEditarCandidato_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(346, 360);
            label5.Name = "label5";
            label5.Size = new Size(118, 22);
            label5.TabIndex = 21;
            label5.Text = "Cargo Político";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(346, 273);
            label4.Name = "label4";
            label4.Size = new Size(67, 22);
            label4.TabIndex = 20;
            label4.Text = "Partido";
            // 
            // naturCandidato
            // 
            naturCandidato.Location = new Point(346, 221);
            naturCandidato.Margin = new Padding(3, 4, 3, 4);
            naturCandidato.Name = "naturCandidato";
            naturCandidato.Size = new Size(251, 27);
            naturCandidato.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(346, 197);
            label3.Name = "label3";
            label3.Size = new Size(111, 22);
            label3.TabIndex = 18;
            label3.Text = "Naturalidade";
            // 
            // cpfCandidato
            // 
            cpfCandidato.Location = new Point(346, 141);
            cpfCandidato.Margin = new Padding(3, 4, 3, 4);
            cpfCandidato.Name = "cpfCandidato";
            cpfCandidato.PlaceholderText = "Somente numeros";
            cpfCandidato.Size = new Size(251, 27);
            cpfCandidato.TabIndex = 17;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(346, 117);
            label2.Name = "label2";
            label2.Size = new Size(39, 22);
            label2.TabIndex = 16;
            label2.Text = "CPF";
            // 
            // nomeCandidato
            // 
            nomeCandidato.Location = new Point(346, 63);
            nomeCandidato.Margin = new Padding(3, 4, 3, 4);
            nomeCandidato.Name = "nomeCandidato";
            nomeCandidato.Size = new Size(251, 27);
            nomeCandidato.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(346, 39);
            label1.Name = "label1";
            label1.Size = new Size(56, 22);
            label1.TabIndex = 14;
            label1.Text = "Nome";
            // 
            // editarCandidato
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.URNA;
            ClientSize = new Size(914, 600);
            Controls.Add(selectCargo);
            Controls.Add(selectPartido);
            Controls.Add(btnVoltar);
            Controls.Add(btnEditarCandidato);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(naturCandidato);
            Controls.Add(label3);
            Controls.Add(cpfCandidato);
            Controls.Add(label2);
            Controls.Add(nomeCandidato);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "editarCandidato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Candidato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox selectCargo;
        private ComboBox selectPartido;
        private Button btnEditarCandidato;
        private Label label5;
        private Label label4;
        private TextBox naturCandidato;
        private Label label3;
        private TextBox cpfCandidato;
        private Label label2;
        private TextBox nomeCandidato;
        private Label label1;
    }
}