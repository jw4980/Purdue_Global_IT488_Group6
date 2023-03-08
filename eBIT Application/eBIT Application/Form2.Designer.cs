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
            System.Windows.Forms.Label customer_idLabel1;
            System.Windows.Forms.Label sale_priceLabel1;
            System.Windows.Forms.Label order_quantityLabel1;
            System.Windows.Forms.Label taxLabel1;
            System.Windows.Forms.Label ship_costLabel1;
            System.Windows.Forms.Label order_totalLabel1;
            System.Windows.Forms.Label trackingLabel1;
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button_addsale = new System.Windows.Forms.Button();
            this.eBITDataSet = new eBIT_Application.eBITDataSet();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new eBIT_Application.eBITDataSetTableAdapters.ordersTableAdapter();
            this.tableAdapterManager = new eBIT_Application.eBITDataSetTableAdapters.TableAdapterManager();
            this.customer_idTextBox = new System.Windows.Forms.TextBox();
            this.sale_priceTextBox = new System.Windows.Forms.TextBox();
            this.order_quantityTextBox = new System.Windows.Forms.TextBox();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.ship_costTextBox = new System.Windows.Forms.TextBox();
            this.order_totalTextBox = new System.Windows.Forms.TextBox();
            this.trackingTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            customer_idLabel1 = new System.Windows.Forms.Label();
            sale_priceLabel1 = new System.Windows.Forms.Label();
            order_quantityLabel1 = new System.Windows.Forms.Label();
            taxLabel1 = new System.Windows.Forms.Label();
            ship_costLabel1 = new System.Windows.Forms.Label();
            order_totalLabel1 = new System.Windows.Forms.Label();
            trackingLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(eBIT_Application.order);
            // 
            // button_addsale
            // 
            this.button_addsale.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.button_addsale.Location = new System.Drawing.Point(107, 15);
            this.button_addsale.Margin = new System.Windows.Forms.Padding(4);
            this.button_addsale.Name = "button_addsale";
            this.button_addsale.Size = new System.Drawing.Size(100, 28);
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
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.eBITDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
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
            // customer_idLabel1
            // 
            customer_idLabel1.AutoSize = true;
            customer_idLabel1.Location = new System.Drawing.Point(43, 178);
            customer_idLabel1.Name = "customer_idLabel1";
            customer_idLabel1.Size = new System.Drawing.Size(79, 16);
            customer_idLabel1.TabIndex = 19;
            customer_idLabel1.Text = "customer id:";
            // 
            // customer_idTextBox
            // 
            this.customer_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "customer_id", true));
            this.customer_idTextBox.Location = new System.Drawing.Point(140, 175);
            this.customer_idTextBox.Name = "customer_idTextBox";
            this.customer_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.customer_idTextBox.TabIndex = 20;
            // 
            // sale_priceLabel1
            // 
            sale_priceLabel1.AutoSize = true;
            sale_priceLabel1.Location = new System.Drawing.Point(43, 206);
            sale_priceLabel1.Name = "sale_priceLabel1";
            sale_priceLabel1.Size = new System.Drawing.Size(69, 16);
            sale_priceLabel1.TabIndex = 21;
            sale_priceLabel1.Text = "sale price:";
            // 
            // sale_priceTextBox
            // 
            this.sale_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "sale_price", true));
            this.sale_priceTextBox.Location = new System.Drawing.Point(140, 203);
            this.sale_priceTextBox.Name = "sale_priceTextBox";
            this.sale_priceTextBox.Size = new System.Drawing.Size(100, 22);
            this.sale_priceTextBox.TabIndex = 22;
            // 
            // order_quantityLabel1
            // 
            order_quantityLabel1.AutoSize = true;
            order_quantityLabel1.Location = new System.Drawing.Point(43, 234);
            order_quantityLabel1.Name = "order_quantityLabel1";
            order_quantityLabel1.Size = new System.Drawing.Size(91, 16);
            order_quantityLabel1.TabIndex = 23;
            order_quantityLabel1.Text = "order quantity:";
            // 
            // order_quantityTextBox
            // 
            this.order_quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_quantity", true));
            this.order_quantityTextBox.Location = new System.Drawing.Point(140, 231);
            this.order_quantityTextBox.Name = "order_quantityTextBox";
            this.order_quantityTextBox.Size = new System.Drawing.Size(100, 22);
            this.order_quantityTextBox.TabIndex = 24;
            // 
            // taxLabel1
            // 
            taxLabel1.AutoSize = true;
            taxLabel1.Location = new System.Drawing.Point(43, 262);
            taxLabel1.Name = "taxLabel1";
            taxLabel1.Size = new System.Drawing.Size(27, 16);
            taxLabel1.TabIndex = 25;
            taxLabel1.Text = "tax:";
            // 
            // taxTextBox
            // 
            this.taxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "tax", true));
            this.taxTextBox.Location = new System.Drawing.Point(140, 259);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.Size = new System.Drawing.Size(100, 22);
            this.taxTextBox.TabIndex = 26;
            // 
            // ship_costLabel1
            // 
            ship_costLabel1.AutoSize = true;
            ship_costLabel1.Location = new System.Drawing.Point(43, 290);
            ship_costLabel1.Name = "ship_costLabel1";
            ship_costLabel1.Size = new System.Drawing.Size(63, 16);
            ship_costLabel1.TabIndex = 27;
            ship_costLabel1.Text = "ship cost:";
            // 
            // ship_costTextBox
            // 
            this.ship_costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "ship_cost", true));
            this.ship_costTextBox.Location = new System.Drawing.Point(140, 287);
            this.ship_costTextBox.Name = "ship_costTextBox";
            this.ship_costTextBox.Size = new System.Drawing.Size(100, 22);
            this.ship_costTextBox.TabIndex = 28;
            // 
            // order_totalLabel1
            // 
            order_totalLabel1.AutoSize = true;
            order_totalLabel1.Location = new System.Drawing.Point(43, 318);
            order_totalLabel1.Name = "order_totalLabel1";
            order_totalLabel1.Size = new System.Drawing.Size(70, 16);
            order_totalLabel1.TabIndex = 29;
            order_totalLabel1.Text = "order total:";
            // 
            // order_totalTextBox
            // 
            this.order_totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "order_total", true));
            this.order_totalTextBox.Location = new System.Drawing.Point(140, 315);
            this.order_totalTextBox.Name = "order_totalTextBox";
            this.order_totalTextBox.Size = new System.Drawing.Size(100, 22);
            this.order_totalTextBox.TabIndex = 30;
            // 
            // trackingLabel1
            // 
            trackingLabel1.AutoSize = true;
            trackingLabel1.Location = new System.Drawing.Point(43, 346);
            trackingLabel1.Name = "trackingLabel1";
            trackingLabel1.Size = new System.Drawing.Size(57, 16);
            trackingLabel1.TabIndex = 31;
            trackingLabel1.Text = "tracking:";
            // 
            // trackingTextBox
            // 
            this.trackingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ordersBindingSource, "tracking", true));
            this.trackingTextBox.Location = new System.Drawing.Point(140, 343);
            this.trackingTextBox.Name = "trackingTextBox";
            this.trackingTextBox.Size = new System.Drawing.Size(100, 22);
            this.trackingTextBox.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(363, 61);
            this.panel1.TabIndex = 33;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button_addsale);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 411);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(363, 56);
            this.panel2.TabIndex = 34;
            // 
            // AddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 467);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(customer_idLabel1);
            this.Controls.Add(this.customer_idTextBox);
            this.Controls.Add(sale_priceLabel1);
            this.Controls.Add(this.sale_priceTextBox);
            this.Controls.Add(order_quantityLabel1);
            this.Controls.Add(this.order_quantityTextBox);
            this.Controls.Add(taxLabel1);
            this.Controls.Add(this.taxTextBox);
            this.Controls.Add(ship_costLabel1);
            this.Controls.Add(this.ship_costTextBox);
            this.Controls.Add(order_totalLabel1);
            this.Controls.Add(this.order_totalTextBox);
            this.Controls.Add(trackingLabel1);
            this.Controls.Add(this.trackingTextBox);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "order_id", true));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AddSale";
            this.Text = "Add Sale";
            this.Load += new System.EventHandler(this.AddSale_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Button button_addsale;
        private eBITDataSet eBITDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private eBITDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
        private eBITDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox customer_idTextBox;
        private System.Windows.Forms.TextBox sale_priceTextBox;
        private System.Windows.Forms.TextBox order_quantityTextBox;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.TextBox ship_costTextBox;
        private System.Windows.Forms.TextBox order_totalTextBox;
        private System.Windows.Forms.TextBox trackingTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}