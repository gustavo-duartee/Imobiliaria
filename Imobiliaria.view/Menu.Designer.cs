using Imobiliaria.view;

namespace Imobiliaria.view
{
    partial class Imobiliaria
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Imobiliaria));
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.corretorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarImovelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarImóvelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reservarImóvelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agendarVisitasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.corretorToolStripMenuItem,
            this.clienteToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1350, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // corretorToolStripMenuItem
            // 
            this.corretorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lToolStripMenuItem,
            this.cadastrarImovelToolStripMenuItem,
            this.cadastrarImóvelToolStripMenuItem});
            this.corretorToolStripMenuItem.Name = "corretorToolStripMenuItem";
            this.corretorToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.corretorToolStripMenuItem.Text = "&Corretor";
            // 
            // lToolStripMenuItem
            // 
            this.lToolStripMenuItem.Name = "lToolStripMenuItem";
            this.lToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.lToolStripMenuItem.Text = "Cadastrar Cliente";
            this.lToolStripMenuItem.Click += new System.EventHandler(this.lToolStripMenuItem_Click);
            // 
            // cadastrarImovelToolStripMenuItem
            // 
            this.cadastrarImovelToolStripMenuItem.Name = "cadastrarImovelToolStripMenuItem";
            this.cadastrarImovelToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cadastrarImovelToolStripMenuItem.Text = "Cadastrar Corretor";
            this.cadastrarImovelToolStripMenuItem.Click += new System.EventHandler(this.cadastrarImovelToolStripMenuItem_Click);
            // 
            // cadastrarImóvelToolStripMenuItem
            // 
            this.cadastrarImóvelToolStripMenuItem.Name = "cadastrarImóvelToolStripMenuItem";
            this.cadastrarImóvelToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.cadastrarImóvelToolStripMenuItem.Text = "Cadastrar Imóvel";
            this.cadastrarImóvelToolStripMenuItem.Click += new System.EventHandler(this.cadastrarImóvelToolStripMenuItem_Click);
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reservarImóvelToolStripMenuItem,
            this.agendarVisitasToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.clienteToolStripMenuItem.Text = "&Cliente";
            // 
            // reservarImóvelToolStripMenuItem
            // 
            this.reservarImóvelToolStripMenuItem.Name = "reservarImóvelToolStripMenuItem";
            this.reservarImóvelToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.reservarImóvelToolStripMenuItem.Text = "Reservar Imóvel";
            this.reservarImóvelToolStripMenuItem.Click += new System.EventHandler(this.reservarImóvelToolStripMenuItem_Click);
            // 
            // agendarVisitasToolStripMenuItem
            // 
            this.agendarVisitasToolStripMenuItem.Name = "agendarVisitasToolStripMenuItem";
            this.agendarVisitasToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.agendarVisitasToolStripMenuItem.Text = "Agendar Visitas";
            this.agendarVisitasToolStripMenuItem.Click += new System.EventHandler(this.agendarVisitasToolStripMenuItem_Click);
            // 
            // Imobiliaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OliveDrab;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "Imobiliaria";
            this.Text = "IMOBILIARIA ";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem corretorToolStripMenuItem;
        private ToolStripMenuItem lToolStripMenuItem;
        private ToolStripMenuItem cadastrarImovelToolStripMenuItem;
        private ToolStripMenuItem cadastrarImóvelToolStripMenuItem;
        private ToolStripMenuItem clienteToolStripMenuItem;
        private ToolStripMenuItem reservarImóvelToolStripMenuItem;
        private ToolStripMenuItem agendarVisitasToolStripMenuItem;
    }
}