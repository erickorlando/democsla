namespace DemoCSLA.Windows
{
	partial class MainForm
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
			this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.productosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.operacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem,
            this.operacionesToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(555, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// mantenimientosToolStripMenuItem
			// 
			this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.productosToolStripMenuItem,
            this.toolStripMenuItem1,
            this.salirToolStripMenuItem});
			this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
			this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
			this.mantenimientosToolStripMenuItem.Text = "&Mantenimientos";
			// 
			// clientesToolStripMenuItem
			// 
			this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
			this.clientesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.clientesToolStripMenuItem.Text = "&Clientes";
			this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
			// 
			// productosToolStripMenuItem
			// 
			this.productosToolStripMenuItem.Name = "productosToolStripMenuItem";
			this.productosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.productosToolStripMenuItem.Text = "&Productos";
			this.productosToolStripMenuItem.Click += new System.EventHandler(this.productosToolStripMenuItem_Click);
			// 
			// operacionesToolStripMenuItem
			// 
			this.operacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.facturasToolStripMenuItem});
			this.operacionesToolStripMenuItem.Name = "operacionesToolStripMenuItem";
			this.operacionesToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
			this.operacionesToolStripMenuItem.Text = "&Operaciones";
			// 
			// facturasToolStripMenuItem
			// 
			this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
			this.facturasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.facturasToolStripMenuItem.Text = "&Facturas";
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
			// 
			// salirToolStripMenuItem
			// 
			this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
			this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
			this.salirToolStripMenuItem.Text = "&Salir";
			this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(555, 383);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Demo Básica de CSLA .NET";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem productosToolStripMenuItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem operacionesToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
	}
}