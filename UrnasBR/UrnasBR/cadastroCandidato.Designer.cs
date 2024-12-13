namespace UrnasBR
{
    partial class cadastroCandidato
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
            Button btnVoltarMenu;
            label1 = new Label();
            nomeCandidato = new TextBox();
            cpfCandidato = new TextBox();
            label2 = new Label();
            naturCandidato = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            btnCadastrarCandidato = new Button();
            selectPartido = new ComboBox();
            selectCargo = new ComboBox();
            btnVoltarMenu = new Button();
            SuspendLayout();
            // 
            // btnVoltarMenu
            // 
            btnVoltarMenu.BackColor = Color.Black;
            btnVoltarMenu.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltarMenu.ForeColor = Color.White;
            btnVoltarMenu.Location = new Point(14, 544);
            btnVoltarMenu.Margin = new Padding(3, 4, 3, 4);
            btnVoltarMenu.Name = "btnVoltarMenu";
            btnVoltarMenu.Size = new Size(91, 40);
            btnVoltarMenu.TabIndex = 11;
            btnVoltarMenu.Text = "Voltar";
            btnVoltarMenu.UseVisualStyleBackColor = false;
            btnVoltarMenu.Click += btnVoltarMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(328, 47);
            label1.Name = "label1";
            label1.Size = new Size(56, 22);
            label1.TabIndex = 0;
            label1.Text = "Nome";
            // 
            // nomeCandidato
            // 
            nomeCandidato.Location = new Point(328, 71);
            nomeCandidato.Margin = new Padding(3, 4, 3, 4);
            nomeCandidato.Name = "nomeCandidato";
            nomeCandidato.Size = new Size(251, 27);
            nomeCandidato.TabIndex = 1;
            // 
            // cpfCandidato
            // 
            cpfCandidato.Location = new Point(328, 149);
            cpfCandidato.Margin = new Padding(3, 4, 3, 4);
            cpfCandidato.Name = "cpfCandidato";
            cpfCandidato.PlaceholderText = "Somente numeros";
            cpfCandidato.Size = new Size(251, 27);
            cpfCandidato.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(328, 125);
            label2.Name = "label2";
            label2.Size = new Size(39, 22);
            label2.TabIndex = 2;
            label2.Text = "CPF";
            // 
            // naturCandidato
            // 
            naturCandidato.Location = new Point(328, 229);
            naturCandidato.Margin = new Padding(3, 4, 3, 4);
            naturCandidato.Name = "naturCandidato";
            naturCandidato.Size = new Size(251, 27);
            naturCandidato.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(328, 205);
            label3.Name = "label3";
            label3.Size = new Size(111, 22);
            label3.TabIndex = 4;
            label3.Text = "Naturalidade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(328, 281);
            label4.Name = "label4";
            label4.Size = new Size(67, 22);
            label4.TabIndex = 6;
            label4.Text = "Partido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(328, 368);
            label5.Name = "label5";
            label5.Size = new Size(118, 22);
            label5.TabIndex = 8;
            label5.Text = "Cargo Político";
            // 
            // btnCadastrarCandidato
            // 
            btnCadastrarCandidato.BackColor = Color.ForestGreen;
            btnCadastrarCandidato.Font = new Font("Candara", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrarCandidato.ForeColor = Color.White;
            btnCadastrarCandidato.Location = new Point(328, 449);
            btnCadastrarCandidato.Margin = new Padding(3, 4, 3, 4);
            btnCadastrarCandidato.Name = "btnCadastrarCandidato";
            btnCadastrarCandidato.Size = new Size(251, 75);
            btnCadastrarCandidato.TabIndex = 10;
            btnCadastrarCandidato.Text = "Cadastrar Candidato";
            btnCadastrarCandidato.UseVisualStyleBackColor = false;
            btnCadastrarCandidato.Click += btnCadastrarCandidato_Click;
            // 
            // selectPartido
            // 
            selectPartido.FormattingEnabled = true;
            selectPartido.Location = new Point(328, 305);
            selectPartido.Margin = new Padding(3, 4, 3, 4);
            selectPartido.Name = "selectPartido";
            selectPartido.Size = new Size(251, 28);
            selectPartido.TabIndex = 12;
            // 
            // selectCargo
            // 
            selectCargo.FormattingEnabled = true;
            selectCargo.Items.AddRange(new object[] { "Presidente", "Governador", "Prefeito", "Deputado Estadual", "Deputado Federal", "Vereador" });
            selectCargo.Location = new Point(328, 392);
            selectCargo.Margin = new Padding(3, 4, 3, 4);
            selectCargo.Name = "selectCargo";
            selectCargo.Size = new Size(251, 28);
            selectCargo.TabIndex = 13;
            // 
            // cadastroCandidato
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.URNA;
            ClientSize = new Size(914, 600);
            Controls.Add(selectCargo);
            Controls.Add(selectPartido);
            Controls.Add(btnVoltarMenu);
            Controls.Add(btnCadastrarCandidato);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(naturCandidato);
            Controls.Add(label3);
            Controls.Add(cpfCandidato);
            Controls.Add(label2);
            Controls.Add(nomeCandidato);
            Controls.Add(label1);
            ForeColor = SystemColors.ControlText;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "cadastroCandidato";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Candidato";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nomeCandidato;
        private TextBox cpfCandidato;
        private Label label2;
        private TextBox naturCandidato;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button btnCadastrarCandidato;
        private ComboBox selectPartido;
        private ComboBox selectCargo;
    }
}