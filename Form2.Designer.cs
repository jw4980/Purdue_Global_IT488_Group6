namespace eBIT_Application
{
    partial class AddSale
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
            System.Windows.Forms.Label customer_idLabel;
            System.Windows.Forms.Label sale_priceLabel;
            System.Windows.Forms.Label order_quantityLabel;
            System.Windows.Forms.Label taxLabel;
            System.Windows.Forms.Label ship_costLabel;
            System.Windows.Forms.Label order_totalLabel;
            System.Windows.Forms.Label trackingLabel;
            this.button_addsale = new System.Windows.Forms.Button();
            this.eBITDataSet = new eBIT_Application.eBITDataSet();
            this.tableAdapterManager = new eBIT_Application.eBITDataSetTableAdapters.TableAdapterManager();
            this.ordersTableAdapter = new eBIT_Application.eBITDataSetTableAdapters.ordersTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_idTextBox = new System.Windows.Forms.TextBox();
            this.sale_priceTextBox = new System.Windows.Forms.TextBox();
            this.order_quantityTextBox = new System.Windows.Forms.TextBox();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.ship_costTextBox = new System.Windows.Forms.TextBox();
            this.order_totalTextBox = new System.Windows.Forms.TextBox();
            this.trackingTextBox = new System.Windows.Forms.TextBox();
            customer_idLabel = new System.Windows.Forms.Label();
            sale_priceLabel = new System.Windows.Forms.Label();
            order_quantityLabel = new System.Windows.Forms.Label();
            taxLabel = new System.Windows.Forms.Label();
            ship_costLabel = new System.Windows.Forms.Label();
            order_totalLabel = new System.Windows.Forms.Label();
            trackingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_idLabel
            // 
            customer_idLabel.AutoSize = true;
            customer_idLabel.Location = new System.Drawing.Point(19, 84);
            customer_idLabel.Name = "customer_idLabel";
            customer_idLabel.Size = new System.Drawing.Size(64, 13);
            customer_idLabel.TabIndex = 72;
            customer_idLabel.Text = "customer id:";
            // 
            // sale_priceLabel
            // 
            sale_priceLabel.AutoSize = true;
            sale_priceLabel.Location = new System.Drawing.Point(19, 110);
            sale_priceLabel.Name = "sale_priceLabel";
            sale_priceLabel.Size = new System.Drawing.Size(55, 13);
            sale_priceLabel.TabIndex = 74;
            sale_priceLabel.Text = "sale price:";
            // 
            // order_quantityLabel
            // 
            order_quantityLabel.AutoSize = true;
            order_quantityLabel.Location = new System.Drawing.Point(19, 136);
            order_quantityLabel.Name = "order_quantityLabel";
            order_quantityLabel.Size = new System.Drawing.Size(74, 13);
            order_quantityLabel.TabIndex = 76;
            order_quantityLabel.Text = "order quantity:";
            // 
            // taxLabel
            // 
            taxLabel.AutoSize = true;
            taxLabel.Location = new System.Drawing.Point(19, 162);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new System.Drawing.Size(24, 13);
            taxLabel.TabIndex = 78;
            taxLabel.Text = "tax:";
            // 
            // ship_costLabel
            // 
            ship_costLabel.AutoSize = true;
            ship_costLabel.Location = new System.Drawing.Point(19, 188);
            ship_costLabel.Name = "ship_costLabel";
            ship_costLabel.Size = new System.Drawing.Size(52, 13);
            ship_costLabel.TabIndex = 80;
            ship_costLabel.Text = "ship cost:";
            // 
            // order_totalLabel
            // 
            order_totalLabel.AutoSize = true;
            order_totalLabel.Location = new System.Drawing.Point(19, 214);
            order_totalLabel.Name = "order_totalLabel";
            order_totalLabel.Size = new System.Drawing.Size(57, 13);
            order_totalLabel.TabIndex = 82;
            order_totalLabel.Text = "order total:";
            // 
            // trackingLabel
            // 
            trackingLabel.AutoSize = true;
            trackingLabel.Location = new System.Drawing.Point(19, 240);
            trackingLabel.Name = "trackingLabel";
            trackingLabel.Size = new System.Drawing.Size(48, 13);
            trackingLabel.TabIndex = 84;
            trackingLabel.Text = "tracking:";
            // 
            // button_addsale
            // 
            this.button_addsale.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_addsale.Location = new System.Drawing.Point(160, 12);
            this.button_addsale.Name = "button_addsale";
            this.button_addsale.Size = new System.Drawing.Size(75, 23);
            this.button_addsale.TabIndex = 17;
            this.button_addsale.Text = "Save";
            this.button_addsale.UseVisualStyleBackColor = true;
            this.button_addsale.Click += new System.EventHandler(this.button_addsale_Click);
            // 
            // eBITDataSet
            // 
            this.eBITDataSet.DataSetName = "eBITDataSet";
            this.eBITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.inventoryTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.product_categoryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = eBIT_Application.eBITDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(433, 50);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_addsale);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 312);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 46);
            this.panel2.TabIndex = 34;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.eBITDataSet;
            // 
            // customer_idTextBox
            // 
            this.customer_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "customer_id", true));
            this.customer_idTextBox.Location = new System.Drawing.Point(99, 81);
            this.customer_idTextBox.Name = "customer_idTextBox";
            this.customer_idTextBox.Size = new System.Drawing.Size(100, 20);
            this.customer_idTextBox.TabIndex = 73;
            // 
            // sale_priceTextBox
            // 
            this.sale_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "sale_price", true));
            this.sale_priceTextBox.Location = new System.Drawing.Point(99, 107);
            this.sale_priceTextBox.Name = "sale_priceTextBox";
            this.sale_priceTextBox.Size = new System.Drawing.Size(100, 20);
            this.sale_priceTextBox.TabIndex = 75;
            // 
            // order_quantityTextBox
            // 
            this.order_quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_quantity", true));
            this.order_quantityTextBox.Location = new System.Drawing.Point(99, 133);
            this.order_quantityTextBox.Name = "order_quantityTextBox";
            this.order_quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.order_quantityTextBox.TabIndex = 77;
            // 
            // taxTextBox
            // 
            this.taxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "tax", true));
            this.taxTextBox.Location = new System.Drawing.Point(99, 159);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.Size = new System.Drawing.Size(100, 20);
            this.taxTextBox.TabIndex = 79;
            // 
            // ship_costTextBox
            // 
            this.ship_costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_cost", true));
            this.ship_costTextBox.Location = new System.Drawing.Point(99, 185);
            this.ship_costTextBox.Name = "ship_costTextBox";
            this.ship_costTextBox.Size = new System.Drawing.Size(100, 20);
            this.ship_costTextBox.TabIndex = 81;
            // 
            // order_totalTextBox
            // 
            this.order_totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_total", true));
            this.order_totalTextBox.Location = new System.Drawing.Point(99, 211);
            this.order_totalTextBox.Name = "order_totalTextBox";
            this.order_totalTextBox.Size = new System.Drawing.Size(100, 20);
            this.order_totalTextBox.TabIndex = 83;
            // 
            // trackingTextBox
            // 
            this.trackingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "tracking", true));
            this.trackingTextBox.Location = new System.Drawing.Point(99, 237);
            this.trackingTextBox.Name = "trackingTextBox";
            this.trackingTextBox.Size = new System.Drawing.Size(100, 20);
            this.trackingTextBox.TabIndex = 85;
            // 
            // AddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 358);
            this.Controls.Add(customer_idLabel);
            this.Controls.Add(this.customer_idTextBox);
            this.Controls.Add(sale_priceLabel);
            this.Controls.Add(this.sale_priceTextBox);
            this.Controls.Add(order_quantityLabel);
            this.Controls.Add(this.order_quantityTextBox);
            this.Controls.Add(taxLabel);
            this.Controls.Add(this.taxTextBox);
            this.Controls.Add(ship_costLabel);
            this.Controls.Add(this.ship_costTextBox);
            this.Controls.Add(order_totalLabel);
            this.Controls.Add(this.order_totalTextBox);
            this.Controls.Add(trackingLabel);
            this.Controls.Add(this.trackingTextBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddSale";
            this.Text = "Add Sale";
            this.Load += new System.EventHandler(this.AddSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_addsale;
        private eBITDataSet eBITDataSet;
        private eBITDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private eBITDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.TextBox customer_idTextBox;
        private System.Windows.Forms.TextBox sale_priceTextBox;
        private System.Windows.Forms.TextBox order_quantityTextBox;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.TextBox ship_costTextBox;
        private System.Windows.Forms.TextBox order_totalTextBox;
        private System.Windows.Forms.TextBox trackingTextBox;
    }
}