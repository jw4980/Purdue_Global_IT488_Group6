namespace eBIT_Application
{
    partial class ProductForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.inventoryDataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.eBITDataSet = new eBIT_Application.eBITDataSet();
            this.inventoryTableAdapter = new eBIT_Application.eBITDataSetTableAdapters.inventoryTableAdapter();
            this.tableAdapterManager = new eBIT_Application.eBITDataSetTableAdapters.TableAdapterManager();
            this.inventoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eBITDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.itemidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemdescDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemquantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemcostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemimageDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.salestartDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saleendDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.inventoryDataGridView);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 534);
            this.panel1.TabIndex = 0;
            // 
            // inventoryDataGridView
            // 
            this.inventoryDataGridView.AllowUserToAddRows = false;
            this.inventoryDataGridView.AutoGenerateColumns = false;
            this.inventoryDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.inventoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.inventoryDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.inventoryDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.inventoryDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.inventoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inventoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemidDataGridViewTextBoxColumn,
            this.itemdescDataGridViewTextBoxColumn,
            this.itemquantityDataGridViewTextBoxColumn,
            this.categoryidDataGridViewTextBoxColumn,
            this.listpriceDataGridViewTextBoxColumn,
            this.itemcostDataGridViewTextBoxColumn,
            this.itemimageDataGridViewImageColumn,
            this.salestartDataGridViewTextBoxColumn,
            this.saleendDataGridViewTextBoxColumn});
            this.inventoryDataGridView.DataSource = this.inventoryBindingSource2;
            this.inventoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryDataGridView.Location = new System.Drawing.Point(0, 0);
            this.inventoryDataGridView.Name = "inventoryDataGridView";
            this.inventoryDataGridView.RowHeadersWidth = 51;
            this.inventoryDataGridView.RowTemplate.Height = 24;
            this.inventoryDataGridView.Size = new System.Drawing.Size(1225, 492);
            this.inventoryDataGridView.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 492);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1225, 42);
            this.panel2.TabIndex = 0;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1139, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1179, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(34, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Inventory";
            // 
            // eBITDataSet
            // 
            this.eBITDataSet.DataSetName = "eBITDataSet";
            this.eBITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.inventoryTableAdapter = this.inventoryTableAdapter;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.product_categoryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = eBIT_Application.eBITDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // inventoryBindingSource1
            // 
            this.inventoryBindingSource1.DataSource = typeof(eBIT_Application.inventory);
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataSource = typeof(eBIT_Application.inventory);
            // 
            // eBITDataSetBindingSource
            // 
            this.eBITDataSetBindingSource.DataSource = this.eBITDataSet;
            this.eBITDataSetBindingSource.Position = 0;
            // 
            // inventoryBindingSource2
            // 
            this.inventoryBindingSource2.DataMember = "inventory";
            this.inventoryBindingSource2.DataSource = this.eBITDataSet;
            // 
            // itemidDataGridViewTextBoxColumn
            // 
            this.itemidDataGridViewTextBoxColumn.DataPropertyName = "item_id";
            this.itemidDataGridViewTextBoxColumn.HeaderText = "item_id";
            this.itemidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemidDataGridViewTextBoxColumn.Name = "itemidDataGridViewTextBoxColumn";
            this.itemidDataGridViewTextBoxColumn.ReadOnly = true;
            this.itemidDataGridViewTextBoxColumn.Width = 102;
            // 
            // itemdescDataGridViewTextBoxColumn
            // 
            this.itemdescDataGridViewTextBoxColumn.DataPropertyName = "item_desc";
            this.itemdescDataGridViewTextBoxColumn.HeaderText = "item_desc";
            this.itemdescDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemdescDataGridViewTextBoxColumn.Name = "itemdescDataGridViewTextBoxColumn";
            this.itemdescDataGridViewTextBoxColumn.Width = 130;
            // 
            // itemquantityDataGridViewTextBoxColumn
            // 
            this.itemquantityDataGridViewTextBoxColumn.DataPropertyName = "item_quantity";
            this.itemquantityDataGridViewTextBoxColumn.HeaderText = "item_quantity";
            this.itemquantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemquantityDataGridViewTextBoxColumn.Name = "itemquantityDataGridViewTextBoxColumn";
            this.itemquantityDataGridViewTextBoxColumn.Width = 156;
            // 
            // categoryidDataGridViewTextBoxColumn
            // 
            this.categoryidDataGridViewTextBoxColumn.DataPropertyName = "category_id";
            this.categoryidDataGridViewTextBoxColumn.HeaderText = "category_id";
            this.categoryidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.categoryidDataGridViewTextBoxColumn.Name = "categoryidDataGridViewTextBoxColumn";
            this.categoryidDataGridViewTextBoxColumn.Width = 145;
            // 
            // listpriceDataGridViewTextBoxColumn
            // 
            this.listpriceDataGridViewTextBoxColumn.DataPropertyName = "list_price";
            this.listpriceDataGridViewTextBoxColumn.HeaderText = "list_price";
            this.listpriceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.listpriceDataGridViewTextBoxColumn.Name = "listpriceDataGridViewTextBoxColumn";
            this.listpriceDataGridViewTextBoxColumn.Width = 115;
            // 
            // itemcostDataGridViewTextBoxColumn
            // 
            this.itemcostDataGridViewTextBoxColumn.DataPropertyName = "item_cost";
            this.itemcostDataGridViewTextBoxColumn.HeaderText = "item_cost";
            this.itemcostDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.itemcostDataGridViewTextBoxColumn.Name = "itemcostDataGridViewTextBoxColumn";
            this.itemcostDataGridViewTextBoxColumn.Width = 123;
            // 
            // itemimageDataGridViewImageColumn
            // 
            this.itemimageDataGridViewImageColumn.DataPropertyName = "item_image";
            this.itemimageDataGridViewImageColumn.HeaderText = "item_image";
            this.itemimageDataGridViewImageColumn.MinimumWidth = 6;
            this.itemimageDataGridViewImageColumn.Name = "itemimageDataGridViewImageColumn";
            this.itemimageDataGridViewImageColumn.Width = 120;
            // 
            // salestartDataGridViewTextBoxColumn
            // 
            this.salestartDataGridViewTextBoxColumn.DataPropertyName = "sale_start";
            this.salestartDataGridViewTextBoxColumn.HeaderText = "sale_start";
            this.salestartDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.salestartDataGridViewTextBoxColumn.Name = "salestartDataGridViewTextBoxColumn";
            this.salestartDataGridViewTextBoxColumn.Width = 120;
            // 
            // saleendDataGridViewTextBoxColumn
            // 
            this.saleendDataGridViewTextBoxColumn.DataPropertyName = "sale_end";
            this.saleendDataGridViewTextBoxColumn.HeaderText = "sale_end";
            this.saleendDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saleendDataGridViewTextBoxColumn.Name = "saleendDataGridViewTextBoxColumn";
            this.saleendDataGridViewTextBoxColumn.Width = 119;
            // 
            // ProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1225, 534);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ProductForm";
            this.Load += new System.EventHandler(this.ProductForm_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private eBITDataSet eBITDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private eBITDataSetTableAdapters.inventoryTableAdapter inventoryTableAdapter;
        private eBITDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource inventoryBindingSource1;
        private System.Windows.Forms.DataGridView inventoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemdescDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemquantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn listpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemcostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn itemimageDataGridViewImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn salestartDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saleendDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource inventoryBindingSource2;
        private System.Windows.Forms.BindingSource eBITDataSetBindingSource;
    }
}