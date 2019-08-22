namespace SalesApp
{
    partial class Form1
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
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
      this.PeoplecomboBox = new System.Windows.Forms.ComboBox();
      this.salesPersonBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.RegioncomboBox = new System.Windows.Forms.ComboBox();
      this.salesRegionBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.saleBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.saleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
      this.RefreshSalesbutton = new System.Windows.Forms.Button();
      this.salesDataGridView = new System.Windows.Forms.DataGridView();
      this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.updatedByDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
      this.saleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.salesRegionBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource2)).BeginInit();
      this.SuspendLayout();
      // 
      // PeoplecomboBox
      // 
      this.PeoplecomboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.salesPersonBindingSource, "FullName", true));
      this.PeoplecomboBox.DataSource = this.salesPersonBindingSource;
      this.PeoplecomboBox.DisplayMember = "FullName";
      this.PeoplecomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.PeoplecomboBox.FormattingEnabled = true;
      this.PeoplecomboBox.Location = new System.Drawing.Point(242, 27);
      this.PeoplecomboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.PeoplecomboBox.Name = "PeoplecomboBox";
      this.PeoplecomboBox.Size = new System.Drawing.Size(82, 21);
      this.PeoplecomboBox.TabIndex = 0;
      // 
      // salesPersonBindingSource
      // 
      this.salesPersonBindingSource.DataSource = typeof(SalesApp.SalesPerson);
      // 
      // RegioncomboBox
      // 
      this.RegioncomboBox.DataSource = this.salesRegionBindingSource;
      this.RegioncomboBox.DisplayMember = "Name";
      this.RegioncomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.RegioncomboBox.FormattingEnabled = true;
      this.RegioncomboBox.Location = new System.Drawing.Point(488, 27);
      this.RegioncomboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.RegioncomboBox.Name = "RegioncomboBox";
      this.RegioncomboBox.Size = new System.Drawing.Size(82, 21);
      this.RegioncomboBox.TabIndex = 1;
      this.RegioncomboBox.ValueMember = "Id";
      // 
      // salesRegionBindingSource
      // 
      this.salesRegionBindingSource.DataSource = typeof(SalesApp.SalesRegion);
      // 
      // saleBindingSource
      // 
      this.saleBindingSource.DataSource = typeof(SalesApp.Sale);
      // 
      // saleBindingSource1
      // 
      this.saleBindingSource1.DataSource = typeof(SalesApp.Sale);
      // 
      // RefreshSalesbutton
      // 
      this.RefreshSalesbutton.Location = new System.Drawing.Point(617, 25);
      this.RefreshSalesbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.RefreshSalesbutton.Name = "RefreshSalesbutton";
      this.RefreshSalesbutton.Size = new System.Drawing.Size(109, 32);
      this.RefreshSalesbutton.TabIndex = 4;
      this.RefreshSalesbutton.Text = "Refresh";
      this.RefreshSalesbutton.UseVisualStyleBackColor = true;
      this.RefreshSalesbutton.Click += new System.EventHandler(this.RefreshSalesbutton_Click);
      // 
      // salesDataGridView
      // 
      this.salesDataGridView.AllowUserToAddRows = false;
      this.salesDataGridView.AllowUserToDeleteRows = false;
      this.salesDataGridView.AutoGenerateColumns = false;
      this.salesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.salesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.amountDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.updatedByDataGridViewTextBoxColumn});
      this.salesDataGridView.DataSource = this.saleBindingSource2;
      this.salesDataGridView.Location = new System.Drawing.Point(125, 149);
      this.salesDataGridView.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.salesDataGridView.Name = "salesDataGridView";
      this.salesDataGridView.ReadOnly = true;
      this.salesDataGridView.RowHeadersWidth = 62;
      this.salesDataGridView.RowTemplate.Height = 28;
      this.salesDataGridView.Size = new System.Drawing.Size(513, 262);
      this.salesDataGridView.TabIndex = 5;
      // 
      // amountDataGridViewTextBoxColumn
      // 
      this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
      dataGridViewCellStyle3.Format = "C2";
      dataGridViewCellStyle3.NullValue = null;
      this.amountDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle3;
      this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
      this.amountDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
      this.amountDataGridViewTextBoxColumn.ReadOnly = true;
      this.amountDataGridViewTextBoxColumn.Width = 150;
      // 
      // dateDataGridViewTextBoxColumn
      // 
      this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
      dataGridViewCellStyle4.Format = "d";
      dataGridViewCellStyle4.NullValue = null;
      this.dateDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle4;
      this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
      this.dateDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
      this.dateDataGridViewTextBoxColumn.ReadOnly = true;
      this.dateDataGridViewTextBoxColumn.Width = 150;
      // 
      // updatedByDataGridViewTextBoxColumn
      // 
      this.updatedByDataGridViewTextBoxColumn.DataPropertyName = "UpdatedBy";
      this.updatedByDataGridViewTextBoxColumn.HeaderText = "Updated By";
      this.updatedByDataGridViewTextBoxColumn.MinimumWidth = 8;
      this.updatedByDataGridViewTextBoxColumn.Name = "updatedByDataGridViewTextBoxColumn";
      this.updatedByDataGridViewTextBoxColumn.ReadOnly = true;
      this.updatedByDataGridViewTextBoxColumn.Width = 150;
      // 
      // saleBindingSource2
      // 
      this.saleBindingSource2.DataSource = typeof(SalesApp.Sale);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(834, 462);
      this.Controls.Add(this.salesDataGridView);
      this.Controls.Add(this.RefreshSalesbutton);
      this.Controls.Add(this.RegioncomboBox);
      this.Controls.Add(this.PeoplecomboBox);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      ((System.ComponentModel.ISupportInitialize)(this.salesPersonBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.salesRegionBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.salesDataGridView)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.saleBindingSource2)).EndInit();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox PeoplecomboBox;
        private System.Windows.Forms.BindingSource salesPersonBindingSource;
        private System.Windows.Forms.ComboBox RegioncomboBox;
        private System.Windows.Forms.BindingSource salesRegionBindingSource;
        private System.Windows.Forms.BindingSource saleBindingSource;
        private System.Windows.Forms.BindingSource saleBindingSource1;
        private System.Windows.Forms.Button RefreshSalesbutton;
        private System.Windows.Forms.DataGridView salesDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn updatedByDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource saleBindingSource2;
    }
}

