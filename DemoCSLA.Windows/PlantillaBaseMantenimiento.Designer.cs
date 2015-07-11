namespace DemoCSLA.Windows
{
	partial class PlantillaBaseMantenimiento
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
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.toolNew = new System.Windows.Forms.ToolStripButton();
			this.toolEdit = new System.Windows.Forms.ToolStripButton();
			this.toolSave = new System.Windows.Forms.ToolStripButton();
			this.toolCancel = new System.Windows.Forms.ToolStripButton();
			this.toolRefresh = new System.Windows.Forms.ToolStripButton();
			this.toolStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolNew,
            this.toolEdit,
            this.toolSave,
            this.toolCancel,
            this.toolRefresh});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(471, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// toolNew
			// 
			this.toolNew.Image = global::DemoCSLA.Windows.Properties.Resources.nuevo;
			this.toolNew.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolNew.Name = "toolNew";
			this.toolNew.Size = new System.Drawing.Size(62, 22);
			this.toolNew.Text = "&Nuevo";
			// 
			// toolEdit
			// 
			this.toolEdit.Image = global::DemoCSLA.Windows.Properties.Resources.edit;
			this.toolEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolEdit.Name = "toolEdit";
			this.toolEdit.Size = new System.Drawing.Size(57, 22);
			this.toolEdit.Text = "&Editar";
			// 
			// toolSave
			// 
			this.toolSave.Image = global::DemoCSLA.Windows.Properties.Resources.save;
			this.toolSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolSave.Name = "toolSave";
			this.toolSave.Size = new System.Drawing.Size(62, 22);
			this.toolSave.Text = "&Grabar";
			// 
			// toolCancel
			// 
			this.toolCancel.Image = global::DemoCSLA.Windows.Properties.Resources.cancel;
			this.toolCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolCancel.Name = "toolCancel";
			this.toolCancel.Size = new System.Drawing.Size(73, 22);
			this.toolCancel.Text = "&Cancelar";
			// 
			// toolRefresh
			// 
			this.toolRefresh.Image = global::DemoCSLA.Windows.Properties.Resources.refresh;
			this.toolRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolRefresh.Name = "toolRefresh";
			this.toolRefresh.Size = new System.Drawing.Size(75, 22);
			this.toolRefresh.Text = "&Refrescar";
			// 
			// PlantillaBaseMantenimiento
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(471, 348);
			this.Controls.Add(this.toolStrip1);
			this.Name = "PlantillaBaseMantenimiento";
			this.Text = "PlantillaBaseMantenimiento";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton toolNew;
		private System.Windows.Forms.ToolStripButton toolEdit;
		private System.Windows.Forms.ToolStripButton toolSave;
		private System.Windows.Forms.ToolStripButton toolCancel;
		private System.Windows.Forms.ToolStripButton toolRefresh;
	}
}