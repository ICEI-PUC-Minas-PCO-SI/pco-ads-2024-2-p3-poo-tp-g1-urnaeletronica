namespace UrnasBR
{
    partial class editarPartido
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
            btnSalvarPartido = new Button();
            siglaPartido = new TextBox();
            label3 = new Label();
            presidPartido = new TextBox();
            label2 = new Label();
            nomePartido = new TextBox();
            label1 = new Label();
            btnVoltarMenu = new Button();
            SuspendLayout();
            // 
            // btnVoltarMenu
            // 
            btnVoltarMenu.BackColor = Color.Black;
            btnVoltarMenu.ForeColor = Color.White;
            btnVoltarMenu.Location = new Point(18, 551);
            btnVoltarMenu.Margin = new Padding(3, 4, 3, 4);
            btnVoltarMenu.Name = "btnVoltarMenu";
            btnVoltarMenu.Size = new Size(86, 31);
            btnVoltarMenu.TabIndex = 15;
            btnVoltarMenu.Text = "Voltar";
            btnVoltarMenu.UseVisualStyleBackColor = false;
            btnVoltarMenu.Click += btnVoltarMenu_Click;
            // 
            // btnSalvarPartido
            // 
            btnSalvarPartido.BackColor = Color.Green;
            btnSalvarPartido.Font = new Font("Candara", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSalvarPartido.ForeColor = Color.White;
            btnSalvarPartido.Location = new Point(328, 415);
            btnSalvarPartido.Margin = new Padding(3, 4, 3, 4);
            btnSalvarPartido.Name = "btnSalvarPartido";
            btnSalvarPartido.Size = new Size(251, 67);
            btnSalvarPartido.TabIndex = 14;
            btnSalvarPartido.Text = "Salvar";
            btnSalvarPartido.UseVisualStyleBackColor = false;
            btnSalvarPartido.Click += btnSalvarPartido_Click;
            // 
            // siglaPartido
            // 
            siglaPartido.Location = new Point(328, 237);
            siglaPartido.Margin = new Padding(3, 4, 3, 4);
            siglaPartido.Name = "siglaPartido";
            siglaPartido.Size = new Size(251, 27);
            siglaPartido.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(328, 213);
            label3.Name = "label3";
            label3.Size = new Size(132, 22);
            label3.TabIndex = 12;
            label3.Text = "Sigla do partido";
            // 
            // presidPartido
            // 
            presidPartido.Location = new Point(328, 317);
            presidPartido.Margin = new Padding(3, 4, 3, 4);
            presidPartido.Name = "presidPartido";
            presidPartido.Size = new Size(251, 27);
            presidPartido.TabIndex = 11;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(328, 293);
            label2.Name = "label2";
            label2.Size = new Size(178, 22);
            label2.TabIndex = 10;
            label2.Text = "Presidente do Partido";
            // 
            // nomePartido
            // 
            nomePartido.Location = new Point(328, 152);
            nomePartido.Margin = new Padding(3, 4, 3, 4);
            nomePartido.Name = "nomePartido";
            nomePartido.Size = new Size(251, 27);
            nomePartido.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(328, 128);
            label1.Name = "label1";
            label1.Size = new Size(141, 22);
            label1.TabIndex = 8;
            label1.Text = "Nome do partido";
            // 
            // editarPartido
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.URNA;
            ClientSize = new Size(914, 600);
            Controls.Add(btnVoltarMenu);
            Controls.Add(btnSalvarPartido);
            Controls.Add(siglaPartido);
            Controls.Add(label3);
            Controls.Add(presidPartido);
            Controls.Add(label2);
            Controls.Add(nomePartido);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "editarPartido";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Partido";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSalvarPartido;
        private TextBox siglaPartido;
        private Label label3;
        private TextBox presidPartido;
        private Label label2;
        private TextBox nomePartido;
        private Label label1;
    }
}