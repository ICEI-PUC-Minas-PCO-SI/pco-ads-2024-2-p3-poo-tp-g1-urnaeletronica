namespace UrnasBR
{
    partial class visualizarPartidos
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
            viewPartidos = new ListView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            ExcluirMouse = new ToolStripMenuItem();
            btnExcluir = new Button();
            btnVoltar = new Button();
            btnEditarPartido = new Button();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // viewPartidos
            // 
            viewPartidos.ContextMenuStrip = contextMenuStrip1;
            viewPartidos.Location = new Point(134, 95);
            viewPartidos.Margin = new Padding(3, 4, 3, 4);
            viewPartidos.Name = "viewPartidos";
            viewPartidos.Size = new Size(662, 385);
            viewPartidos.TabIndex = 0;
            viewPartidos.UseCompatibleStateImageBehavior = false;
            viewPartidos.SelectedIndexChanged += viewPartidos_SelectedIndexChanged;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { ExcluirMouse });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(173, 28);
            // 
            // ExcluirMouse
            // 
            ExcluirMouse.Name = "ExcluirMouse";
            ExcluirMouse.Size = new Size(172, 24);
            ExcluirMouse.Text = "Excluir Partido";
            ExcluirMouse.Click += ExcluirMouse_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.BackColor = Color.Crimson;
            btnExcluir.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnExcluir.ForeColor = Color.White;
            btnExcluir.Location = new Point(274, 489);
            btnExcluir.Margin = new Padding(3, 4, 3, 4);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(98, 44);
            btnExcluir.TabIndex = 1;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = false;
            btnExcluir.Click += btnExcluir_Click;
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
            btnVoltar.TabIndex = 2;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = false;
            btnVoltar.Click += btnVoltar_Click;
            // 
            // btnEditarPartido
            // 
            btnEditarPartido.BackColor = Color.ForestGreen;
            btnEditarPartido.Font = new Font("Candara", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            btnEditarPartido.ForeColor = Color.White;
            btnEditarPartido.Location = new Point(557, 489);
            btnEditarPartido.Margin = new Padding(3, 4, 3, 4);
            btnEditarPartido.Name = "btnEditarPartido";
            btnEditarPartido.Size = new Size(98, 44);
            btnEditarPartido.TabIndex = 3;
            btnEditarPartido.Text = "Editar";
            btnEditarPartido.UseVisualStyleBackColor = false;
            btnEditarPartido.Click += btnEditarPartido_Click;
            // 
            // visualizarPartidos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = Properties.Resources.URNA;
            ClientSize = new Size(914, 600);
            Controls.Add(btnEditarPartido);
            Controls.Add(btnVoltar);
            Controls.Add(btnExcluir);
            Controls.Add(viewPartidos);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "visualizarPartidos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Visualizar Partidos";
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ListView viewPartidos;
        private Button btnExcluir;
        private Button btnVoltar;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem ExcluirMouse;
        private Button btnEditarPartido;
    }
}