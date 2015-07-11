namespace DemoCSLA.Windows
{
	partial class ProductEditForm
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.Label codigoLabel;
			System.Windows.Forms.Label descripcionLabel;
			System.Windows.Forms.Label precioUnitarioLabel;
			this.productEditBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.codigoTextBox = new System.Windows.Forms.TextBox();
			this.descripcionTextBox = new System.Windows.Forms.TextBox();
			this.precioUnitarioTextBox = new System.Windows.Forms.TextBox();
			this.productInfoListBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productInfoListDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			codigoLabel = new System.Windows.Forms.Label();
			descripcionLabel = new System.Windows.Forms.Label();
			precioUnitarioLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.productEditBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productInfoListBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productInfoListDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// codigoLabel
			// 
			codigoLabel.AutoSize = true;
			codigoLabel.Location = new System.Drawing.Point(8, 45);
			codigoLabel.Name = "codigoLabel";
			codigoLabel.Size = new System.Drawing.Size(44, 13);
			codigoLabel.TabIndex = 2;
			codigoLabel.Text = "Codigo:";
			// 
			// descripcionLabel
			// 
			descripcionLabel.AutoSize = true;
			descripcionLabel.Location = new System.Drawing.Point(8, 72);
			descripcionLabel.Name = "descripcionLabel";
			descripcionLabel.Size = new System.Drawing.Size(65, 13);
			descripcionLabel.TabIndex = 3;
			descripcionLabel.Text = "Descripcion:";
			// 
			// precioUnitarioLabel
			// 
			precioUnitarioLabel.AutoSize = true;
			precioUnitarioLabel.Location = new System.Drawing.Point(8, 99);
			precioUnitarioLabel.Name = "precioUnitarioLabel";
			precioUnitarioLabel.Size = new System.Drawing.Size(80, 13);
			precioUnitarioLabel.TabIndex = 5;
			precioUnitarioLabel.Text = "Precio Unitario:";
			// 
			// productEditBindingSource
			// 
			this.productEditBindingSource.DataSource = typeof(DemoCSLA.Negocio.Editables.ProductEdit);
			// 
			// codigoTextBox
			// 
			this.codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEditBindingSource, "Codigo", true));
			this.codigoTextBox.Location = new System.Drawing.Point(90, 45);
			this.codigoTextBox.Name = "codigoTextBox";
			this.codigoTextBox.Size = new System.Drawing.Size(100, 21);
			this.codigoTextBox.TabIndex = 3;
			// 
			// descripcionTextBox
			// 
			this.descripcionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEditBindingSource, "Descripcion", true));
			this.descripcionTextBox.Location = new System.Drawing.Point(90, 69);
			this.descripcionTextBox.Name = "descripcionTextBox";
			this.descripcionTextBox.Size = new System.Drawing.Size(189, 21);
			this.descripcionTextBox.TabIndex = 4;
			// 
			// precioUnitarioTextBox
			// 
			this.precioUnitarioTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productEditBindingSource, "PrecioUnitario", true));
			this.precioUnitarioTextBox.Location = new System.Drawing.Point(90, 96);
			this.precioUnitarioTextBox.Name = "precioUnitarioTextBox";
			this.precioUnitarioTextBox.Size = new System.Drawing.Size(100, 21);
			this.precioUnitarioTextBox.TabIndex = 6;
			// 
			// productInfoListBindingSource
			// 
			this.productInfoListBindingSource.DataSource = typeof(DemoCSLA.Negocio.ReadOnly.ProductInfo);
			// 
			// productInfoListDataGridView
			// 
			this.productInfoListDataGridView.AllowUserToAddRows = false;
			this.productInfoListDataGridView.AllowUserToDeleteRows = false;
			this.productInfoListDataGridView.AutoGenerateColumns = false;
			this.productInfoListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.productInfoListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
			this.productInfoListDataGridView.DataSource = this.productInfoListBindingSource;
			this.productInfoListDataGridView.Location = new System.Drawing.Point(11, 125);
			this.productInfoListDataGridView.Name = "productInfoListDataGridView";
			this.productInfoListDataGridView.ReadOnly = true;
			this.productInfoListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.productInfoListDataGridView.Size = new System.Drawing.Size(498, 220);
			this.productInfoListDataGridView.TabIndex = 7;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Codigo";
			this.dataGridViewTextBoxColumn2.HeaderText = "Codigo";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "Descripcion";
			this.dataGridViewTextBoxColumn3.HeaderText = "Descripcion";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "PrecioUnitario";
			this.dataGridViewTextBoxColumn4.HeaderText = "PrecioUnitario";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			this.errorProvider1.DataSource = this.productEditBindingSource;
			// 
			// ProductEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(539, 369);
			this.Controls.Add(this.productInfoListDataGridView);
			this.Controls.Add(precioUnitarioLabel);
			this.Controls.Add(this.precioUnitarioTextBox);
			this.Controls.Add(descripcionLabel);
			this.Controls.Add(this.descripcionTextBox);
			this.Controls.Add(codigoLabel);
			this.Controls.Add(this.codigoTextBox);
			this.Name = "ProductEditForm";
			this.Text = "Productos";
			this.Controls.SetChildIndex(this.codigoTextBox, 0);
			this.Controls.SetChildIndex(codigoLabel, 0);
			this.Controls.SetChildIndex(this.descripcionTextBox, 0);
			this.Controls.SetChildIndex(descripcionLabel, 0);
			this.Controls.SetChildIndex(this.precioUnitarioTextBox, 0);
			this.Controls.SetChildIndex(precioUnitarioLabel, 0);
			this.Controls.SetChildIndex(this.productInfoListDataGridView, 0);
			((System.ComponentModel.ISupportInitialize)(this.productEditBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productInfoListBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productInfoListDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource productEditBindingSource;
		private System.Windows.Forms.TextBox codigoTextBox;
		private System.Windows.Forms.TextBox descripcionTextBox;
		private System.Windows.Forms.TextBox precioUnitarioTextBox;
		private System.Windows.Forms.BindingSource productInfoListBindingSource;
		private System.Windows.Forms.DataGridView productInfoListDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}