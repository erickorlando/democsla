namespace DemoCSLA.Windows
{
	partial class CustomerEditForm
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
			System.Windows.Forms.Label nameLabel;
			System.Windows.Forms.Label rUCLabel;
			System.Windows.Forms.Label phoneLabel;
			System.Windows.Forms.Label emailLabel;
			this.nameTextBox = new System.Windows.Forms.TextBox();
			this.customerEditBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.rUCTextBox = new System.Windows.Forms.TextBox();
			this.phoneTextBox = new System.Windows.Forms.TextBox();
			this.emailTextBox = new System.Windows.Forms.TextBox();
			this.customerInfoListBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.customerInfoListDataGridView = new System.Windows.Forms.DataGridView();
			this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			nameLabel = new System.Windows.Forms.Label();
			rUCLabel = new System.Windows.Forms.Label();
			phoneLabel = new System.Windows.Forms.Label();
			emailLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.customerEditBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerInfoListBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.customerInfoListDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// nameLabel
			// 
			nameLabel.AutoSize = true;
			nameLabel.Location = new System.Drawing.Point(12, 32);
			nameLabel.Name = "nameLabel";
			nameLabel.Size = new System.Drawing.Size(38, 13);
			nameLabel.TabIndex = 1;
			nameLabel.Text = "Name:";
			// 
			// rUCLabel
			// 
			rUCLabel.AutoSize = true;
			rUCLabel.Location = new System.Drawing.Point(12, 58);
			rUCLabel.Name = "rUCLabel";
			rUCLabel.Size = new System.Drawing.Size(32, 13);
			rUCLabel.TabIndex = 3;
			rUCLabel.Text = "RUC:";
			// 
			// phoneLabel
			// 
			phoneLabel.AutoSize = true;
			phoneLabel.Location = new System.Drawing.Point(12, 84);
			phoneLabel.Name = "phoneLabel";
			phoneLabel.Size = new System.Drawing.Size(41, 13);
			phoneLabel.TabIndex = 5;
			phoneLabel.Text = "Phone:";
			// 
			// emailLabel
			// 
			emailLabel.AutoSize = true;
			emailLabel.Location = new System.Drawing.Point(12, 110);
			emailLabel.Name = "emailLabel";
			emailLabel.Size = new System.Drawing.Size(35, 13);
			emailLabel.TabIndex = 7;
			emailLabel.Text = "Email:";
			// 
			// nameTextBox
			// 
			this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerEditBindingSource, "Name", true));
			this.nameTextBox.Location = new System.Drawing.Point(68, 29);
			this.nameTextBox.Name = "nameTextBox";
			this.nameTextBox.Size = new System.Drawing.Size(213, 21);
			this.nameTextBox.TabIndex = 0;
			// 
			// customerEditBindingSource
			// 
			this.customerEditBindingSource.DataSource = typeof(DemoCSLA.Negocio.Editables.CustomerEdit);
			// 
			// rUCTextBox
			// 
			this.rUCTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerEditBindingSource, "RUC", true));
			this.rUCTextBox.Location = new System.Drawing.Point(68, 55);
			this.rUCTextBox.Name = "rUCTextBox";
			this.rUCTextBox.Size = new System.Drawing.Size(213, 21);
			this.rUCTextBox.TabIndex = 1;
			// 
			// phoneTextBox
			// 
			this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerEditBindingSource, "Phone", true));
			this.phoneTextBox.Location = new System.Drawing.Point(68, 81);
			this.phoneTextBox.Name = "phoneTextBox";
			this.phoneTextBox.Size = new System.Drawing.Size(213, 21);
			this.phoneTextBox.TabIndex = 2;
			// 
			// emailTextBox
			// 
			this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerEditBindingSource, "Email", true));
			this.emailTextBox.Location = new System.Drawing.Point(68, 107);
			this.emailTextBox.Name = "emailTextBox";
			this.emailTextBox.Size = new System.Drawing.Size(213, 21);
			this.emailTextBox.TabIndex = 3;
			// 
			// customerInfoListBindingSource
			// 
			this.customerInfoListBindingSource.DataSource = typeof(DemoCSLA.Negocio.ReadOnly.CustomerInfo);
			// 
			// customerInfoListDataGridView
			// 
			this.customerInfoListDataGridView.AllowUserToAddRows = false;
			this.customerInfoListDataGridView.AllowUserToDeleteRows = false;
			this.customerInfoListDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.customerInfoListDataGridView.AutoGenerateColumns = false;
			this.customerInfoListDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.customerInfoListDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
			this.customerInfoListDataGridView.DataSource = this.customerInfoListBindingSource;
			this.customerInfoListDataGridView.Location = new System.Drawing.Point(12, 151);
			this.customerInfoListDataGridView.Name = "customerInfoListDataGridView";
			this.customerInfoListDataGridView.ReadOnly = true;
			this.customerInfoListDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.customerInfoListDataGridView.Size = new System.Drawing.Size(547, 243);
			this.customerInfoListDataGridView.TabIndex = 8;
			// 
			// dataGridViewTextBoxColumn2
			// 
			this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
			this.dataGridViewTextBoxColumn2.HeaderText = "Name";
			this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
			this.dataGridViewTextBoxColumn2.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn3
			// 
			this.dataGridViewTextBoxColumn3.DataPropertyName = "RUC";
			this.dataGridViewTextBoxColumn3.HeaderText = "RUC";
			this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
			this.dataGridViewTextBoxColumn3.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn4
			// 
			this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone";
			this.dataGridViewTextBoxColumn4.HeaderText = "Phone";
			this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
			this.dataGridViewTextBoxColumn4.ReadOnly = true;
			// 
			// dataGridViewTextBoxColumn5
			// 
			this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
			this.dataGridViewTextBoxColumn5.HeaderText = "Email";
			this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
			this.dataGridViewTextBoxColumn5.ReadOnly = true;
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			this.errorProvider1.DataSource = this.customerEditBindingSource;
			// 
			// CustomerEditForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(571, 406);
			this.Controls.Add(this.customerInfoListDataGridView);
			this.Controls.Add(emailLabel);
			this.Controls.Add(this.emailTextBox);
			this.Controls.Add(phoneLabel);
			this.Controls.Add(this.phoneTextBox);
			this.Controls.Add(rUCLabel);
			this.Controls.Add(this.rUCTextBox);
			this.Controls.Add(nameLabel);
			this.Controls.Add(this.nameTextBox);
			this.Name = "CustomerEditForm";
			this.Text = "Clientes";
			this.Controls.SetChildIndex(this.nameTextBox, 0);
			this.Controls.SetChildIndex(nameLabel, 0);
			this.Controls.SetChildIndex(this.rUCTextBox, 0);
			this.Controls.SetChildIndex(rUCLabel, 0);
			this.Controls.SetChildIndex(this.phoneTextBox, 0);
			this.Controls.SetChildIndex(phoneLabel, 0);
			this.Controls.SetChildIndex(this.emailTextBox, 0);
			this.Controls.SetChildIndex(emailLabel, 0);
			this.Controls.SetChildIndex(this.customerInfoListDataGridView, 0);
			((System.ComponentModel.ISupportInitialize)(this.customerEditBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customerInfoListBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.customerInfoListDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.BindingSource customerEditBindingSource;
		private System.Windows.Forms.TextBox nameTextBox;
		private System.Windows.Forms.TextBox rUCTextBox;
		private System.Windows.Forms.TextBox phoneTextBox;
		private System.Windows.Forms.TextBox emailTextBox;
		private System.Windows.Forms.BindingSource customerInfoListBindingSource;
		private System.Windows.Forms.DataGridView customerInfoListDataGridView;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
		private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}

