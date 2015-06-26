namespace AluguelVeiculosUTF_Cliente
{
    partial class Principal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alugarCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.criarContaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.devolverCarroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opçoesDeOperaçõesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alugarCarroToolStripMenuItem,
            this.consultarCarroToolStripMenuItem,
            this.criarContaToolStripMenuItem,
            this.devolverCarroToolStripMenuItem,
            this.opçoesDeOperaçõesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(614, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alugarCarroToolStripMenuItem
            // 
            this.alugarCarroToolStripMenuItem.Name = "alugarCarroToolStripMenuItem";
            this.alugarCarroToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.alugarCarroToolStripMenuItem.Text = "Alugar Carro";
            this.alugarCarroToolStripMenuItem.Click += new System.EventHandler(this.alugarCarroToolStripMenuItem_Click);
            // 
            // consultarCarroToolStripMenuItem
            // 
            this.consultarCarroToolStripMenuItem.Name = "consultarCarroToolStripMenuItem";
            this.consultarCarroToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.consultarCarroToolStripMenuItem.Text = "Consultar Carro";
            this.consultarCarroToolStripMenuItem.Click += new System.EventHandler(this.consultarCarroToolStripMenuItem_Click);
            // 
            // criarContaToolStripMenuItem
            // 
            this.criarContaToolStripMenuItem.Name = "criarContaToolStripMenuItem";
            this.criarContaToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.criarContaToolStripMenuItem.Text = "Criar Conta";
            this.criarContaToolStripMenuItem.Click += new System.EventHandler(this.criarContaToolStripMenuItem_Click);
            // 
            // devolverCarroToolStripMenuItem
            // 
            this.devolverCarroToolStripMenuItem.Name = "devolverCarroToolStripMenuItem";
            this.devolverCarroToolStripMenuItem.Size = new System.Drawing.Size(97, 20);
            this.devolverCarroToolStripMenuItem.Text = "Devolver Carro";
            this.devolverCarroToolStripMenuItem.Click += new System.EventHandler(this.devolverCarroToolStripMenuItem_Click);
            // 
            // opçoesDeOperaçõesToolStripMenuItem
            // 
            this.opçoesDeOperaçõesToolStripMenuItem.Name = "opçoesDeOperaçõesToolStripMenuItem";
            this.opçoesDeOperaçõesToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.opçoesDeOperaçõesToolStripMenuItem.Text = "Opçoes de Operações";
            this.opçoesDeOperaçõesToolStripMenuItem.Click += new System.EventHandler(this.opçoesDeOperaçõesToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 431);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alugarCarroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarCarroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem criarContaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem devolverCarroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opçoesDeOperaçõesToolStripMenuItem;
    }
}