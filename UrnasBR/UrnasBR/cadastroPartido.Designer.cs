namespace UrnasBR
{
    partial class CadastroPartido
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
            nomePartido = new TextBox();
            presidPartido = new TextBox();
            label2 = new Label();
            siglaPartido = new TextBox();
            label3 = new Label();
            btnCadastrarPartido = new Button();
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
            btnVoltarMenu.TabIndex = 7;
            btnVoltarMenu.Text = "Voltar";
            btnVoltarMenu.UseVisualStyleBackColor = false;
            btnVoltarMenu.Click += btnVoltarMenu_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(323, 131);
            label1.Name = "label1";
            label1.Size = new Size(141, 22);
            label1.TabIndex = 0;
            label1.Text = "Nome do partido";
            // 
            // nomePartido
            // 
            nomePartido.Location = new Point(323, 155);
            nomePartido.Margin = new Padding(3, 4, 3, 4);
            nomePartido.Name = "nomePartido";
            nomePartido.Size = new Size(251, 27);
            nomePartido.TabIndex = 1;
            // 
            // presidPartido
            // 
            presidPartido.Location = new Point(323, 320);
            presidPartido.Margin = new Padding(3, 4, 3, 4);
            presidPartido.Name = "presidPartido";
            presidPartido.Size = new Size(251, 27);
            presidPartido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(323, 296);
            label2.Name = "label2";
            label2.Size = new Size(178, 22);
            label2.TabIndex = 2;
            label2.Text = "Presidente do Partido";
            // 
            // siglaPartido
            // 
            siglaPartido.Location = new Point(323, 240);
            siglaPartido.Margin = new Padding(3, 4, 3, 4);
            siglaPartido.Name = "siglaPartido";
            siglaPartido.Size = new Size(251, 27);
            siglaPartido.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(323, 216);
            label3.Name = "label3";
            label3.Size = new Size(132, 22);
            label3.TabIndex = 4;
            label3.Text = "Sigla do partido";
            // 
            // btnCadastrarPartido
            // 
            btnCadastrarPartido.BackColor = Color.ForestGreen;
            btnCadastrarPartido.Font = new Font("Candara", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnCadastrarPartido.ForeColor = Color.White;
            btnCadastrarPartido.Location = new Point(323, 417);
            btnCadastrarPartido.Margin = new Padding(3, 4, 3, 4);
            btnCadastrarPartido.Name = "btnCadastrarPartido";
            btnCadastrarPartido.Size = new Size(251, 67);
            btnCadastrarPartido.TabIndex = 6;
            btnCadastrarPartido.Text = "Cadastrar Partido";
            btnCadastrarPartido.UseVisualStyleBackColor = false;
            btnCadastrarPartido.Click += btnCadastrarPartido_Click;
            // 
            // CadastroPartido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.URNA;
            ClientSize = new Size(914, 600);
            Controls.Add(btnVoltarMenu);
            Controls.Add(btnCadastrarPartido);
            Controls.Add(siglaPartido);
            Controls.Add(label3);
            Controls.Add(presidPartido);
            Controls.Add(label2);
            Controls.Add(nomePartido);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CadastroPartido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Partido";
            Load += CadastroPartido_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox nomePartido;
        private TextBox presidPartido;
        private Label label2;
        private TextBox siglaPartido;
        private Label label3;
        private Button btnCadastrarPartido;
    }
}