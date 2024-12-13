namespace UrnasBR
{
    partial class CadastroEleicoes
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
            btnCadastrarEleicao = new Button();
            label5 = new Label();
            nomeEleicao = new TextBox();
            label4 = new Label();
            selectCandidato = new ComboBox();
            btnAddCandidato = new Button();
            label1 = new Label();
            cargoEleicao = new ComboBox();
            viewCandidatos = new ListView();
            btnVoltarMenu = new Button();
            SuspendLayout();
            // 
            // btnVoltarMenu
            // 
            btnVoltarMenu.BackColor = Color.Black;
            btnVoltarMenu.ForeColor = Color.White;
            btnVoltarMenu.Location = new Point(14, 553);
            btnVoltarMenu.Margin = new Padding(3, 4, 3, 4);
            btnVoltarMenu.Name = "btnVoltarMenu";
            btnVoltarMenu.Size = new Size(86, 31);
            btnVoltarMenu.TabIndex = 19;
            btnVoltarMenu.Text = "Voltar";
            btnVoltarMenu.UseVisualStyleBackColor = false;
            btnVoltarMenu.Click += btnVoltarMenu_Click;
            // 
            // btnCadastrarEleicao
            // 
            btnCadastrarEleicao.BackColor = Color.ForestGreen;
            btnCadastrarEleicao.Font = new Font("Candara", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrarEleicao.ForeColor = Color.White;
            btnCadastrarEleicao.Location = new Point(326, 473);
            btnCadastrarEleicao.Margin = new Padding(3, 4, 3, 4);
            btnCadastrarEleicao.Name = "btnCadastrarEleicao";
            btnCadastrarEleicao.Size = new Size(251, 75);
            btnCadastrarEleicao.TabIndex = 15;
            btnCadastrarEleicao.Text = "Cadastrar Eleição";
            btnCadastrarEleicao.UseVisualStyleBackColor = false;
            btnCadastrarEleicao.Click += btnCadastrarEleicao_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(221, 161);
            label5.Name = "label5";
            label5.Size = new Size(143, 22);
            label5.TabIndex = 13;
            label5.Text = "Inserir Candidato";
            // 
            // nomeEleicao
            // 
            nomeEleicao.Location = new Point(221, 41);
            nomeEleicao.Margin = new Padding(3, 4, 3, 4);
            nomeEleicao.Name = "nomeEleicao";
            nomeEleicao.Size = new Size(466, 27);
            nomeEleicao.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(221, 17);
            label4.Name = "label4";
            label4.Size = new Size(115, 22);
            label4.TabIndex = 11;
            label4.Text = "Nome Eleição";
            // 
            // selectCandidato
            // 
            selectCandidato.FormattingEnabled = true;
            selectCandidato.Location = new Point(221, 185);
            selectCandidato.Margin = new Padding(3, 4, 3, 4);
            selectCandidato.Name = "selectCandidato";
            selectCandidato.Size = new Size(356, 28);
            selectCandidato.TabIndex = 16;
            // 
            // btnAddCandidato
            // 
            btnAddCandidato.Location = new Point(584, 185);
            btnAddCandidato.Margin = new Padding(3, 4, 3, 4);
            btnAddCandidato.Name = "btnAddCandidato";
            btnAddCandidato.Size = new Size(103, 31);
            btnAddCandidato.TabIndex = 17;
            btnAddCandidato.Text = "+";
            btnAddCandidato.UseVisualStyleBackColor = true;
            btnAddCandidato.Click += btnAddCandidato_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(221, 91);
            label1.Name = "label1";
            label1.Size = new Size(56, 22);
            label1.TabIndex = 20;
            label1.Text = "Cargo";
            // 
            // cargoEleicao
            // 
            cargoEleicao.FormattingEnabled = true;
            cargoEleicao.Location = new Point(221, 115);
            cargoEleicao.Margin = new Padding(3, 4, 3, 4);
            cargoEleicao.Name = "cargoEleicao";
            cargoEleicao.Size = new Size(466, 28);
            cargoEleicao.TabIndex = 21;
            cargoEleicao.SelectedIndexChanged += cargoEleicao_SelectedIndexChanged;
            // 
            // viewCandidatos
            // 
            viewCandidatos.Location = new Point(221, 224);
            viewCandidatos.Margin = new Padding(3, 4, 3, 4);
            viewCandidatos.Name = "viewCandidatos";
            viewCandidatos.Size = new Size(466, 240);
            viewCandidatos.TabIndex = 22;
            viewCandidatos.UseCompatibleStateImageBehavior = false;
            // 
            // CadastroEleicoes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.URNA;
            ClientSize = new Size(914, 600);
            Controls.Add(viewCandidatos);
            Controls.Add(cargoEleicao);
            Controls.Add(label1);
            Controls.Add(btnVoltarMenu);
            Controls.Add(btnAddCandidato);
            Controls.Add(selectCandidato);
            Controls.Add(btnCadastrarEleicao);
            Controls.Add(label5);
            Controls.Add(nomeEleicao);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroEleicoes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Eleições";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCadastrarEleicao;
        private Label label5;
        private TextBox nomeEleicao;
        private Label label4;
        private ComboBox selectCandidato;
        private Button btnAddCandidato;
        private Label label1;
        private ComboBox cargoEleicao;
        private ListView viewCandidatos;
    }
}