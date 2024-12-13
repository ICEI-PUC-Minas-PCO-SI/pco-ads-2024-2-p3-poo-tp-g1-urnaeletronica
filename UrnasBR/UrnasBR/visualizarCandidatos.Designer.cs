namespace UrnasBR
{
    partial class visualizarCandidatos
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
            components = new System.ComponentModel.Container();
            btnVoltar = new Button();
            btnExcluir = new Button();
            viewCandidatos = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ExcluirCandidatoMouse = new ToolStripMenuItem();
            btnEditar = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnVoltar
            // 
            btnVoltar.BackColor = Color.Black;
            btnVoltar.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnVoltar.ForeColor = Color.White;
            btnVoltar.Location = new Point(14, 544);
            btnVoltar.Margin = new Padding(3, 4, 3, 4);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(89, 40);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Crimson;
            btnExcluir.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(236, 487);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(90, 37);
            btnExcluir.TabIndex = 4;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // viewCandidatos
            // 
            viewCandidatos.Location = new Point(74, 92);
            viewCandidatos.Margin = new Padding(3, 4, 3, 4);
            viewCandidatos.Name = "viewCandidatos";
            viewCandidatos.Size = new Size(773, 385);
            viewCandidatos.TabIndex = 3;
            viewCandidatos.UseCompatibleStateImageBehavior = false;
            viewCandidatos.SelectedIndexChanged += viewCandidatos_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { ExcluirCandidatoMouse });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(195, 28);
            // 
            // ExcluirCandidatoMouse
            // 
            ExcluirCandidatoMouse.Name = "ExcluirCandidatoMouse";
            ExcluirCandidatoMouse.Size = new Size(194, 24);
            ExcluirCandidatoMouse.Text = "Excluir Candidato";
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.Green;
            btnEditar.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditar.ForeColor = Color.White;
            btnEditar.Location = new Point(581, 487);
            btnEditar.Margin = new Padding(3, 4, 3, 4);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(89, 37);
            btnEditar.TabIndex = 6;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // visualizarCandidatos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.URNA;
            ClientSize = new Size(914, 600);
            Controls.Add(btnEditar);
            Controls.Add(btnVoltar);
            Controls.Add(btnExcluir);
            Controls.Add(viewCandidatos);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "visualizarCandidatos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualizar Candidatos";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnVoltar;
        private Button btnExcluir;
        private ListView viewCandidatos;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ExcluirCandidatoMouse;
        private Button btnEditar;
    }
}