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
            System.Windows.Forms.Label order_idLabel;
            System.Windows.Forms.Label order_quantityLabel;
            System.Windows.Forms.Label order_totalLabel;
            System.Windows.Forms.Label sale_priceLabel;
            System.Windows.Forms.Label ship_costLabel;
            System.Windows.Forms.Label taxLabel;
            System.Windows.Forms.Label trackingLabel;
            this.button_addsale = new System.Windows.Forms.Button();
            this.customer_idTextBox = new System.Windows.Forms.TextBox();
            this.order_idTextBox = new System.Windows.Forms.TextBox();
            this.order_quantityTextBox = new System.Windows.Forms.TextBox();
            this.order_totalTextBox = new System.Windows.Forms.TextBox();
            this.sale_priceTextBox = new System.Windows.Forms.TextBox();
            this.ship_costTextBox = new System.Windows.Forms.TextBox();
            this.taxTextBox = new System.Windows.Forms.TextBox();
            this.trackingTextBox = new System.Windows.Forms.TextBox();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            customer_idLabel = new System.Windows.Forms.Label();
            order_idLabel = new System.Windows.Forms.Label();
            order_quantityLabel = new System.Windows.Forms.Label();
            order_totalLabel = new System.Windows.Forms.Label();
            sale_priceLabel = new System.Windows.Forms.Label();
            ship_costLabel = new System.Windows.Forms.Label();
            taxLabel = new System.Windows.Forms.Label();
            trackingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_idLabel
            // 
            customer_idLabel.AutoSize = true;
            customer_idLabel.Location = new System.Drawing.Point(94, 94);
            customer_idLabel.Name = "customer_idLabel";
            customer_idLabel.Size = new System.Drawing.Size(79, 16);
            customer_idLabel.TabIndex = 17;
            customer_idLabel.Text = "customer id:";
            // 
            // order_idLabel
            // 
            order_idLabel.AutoSize = true;
            order_idLabel.Location = new System.Drawing.Point(94, 122);
            order_idLabel.Name = "order_idLabel";
            order_idLabel.Size = new System.Drawing.Size(56, 16);
            order_idLabel.TabIndex = 19;
            order_idLabel.Text = "order id:";
            // 
            // order_quantityLabel
            // 
            order_quantityLabel.AutoSize = true;
            order_quantityLabel.Location = new System.Drawing.Point(94, 150);
            order_quantityLabel.Name = "order_quantityLabel";
            order_quantityLabel.Size = new System.Drawing.Size(91, 16);
            order_quantityLabel.TabIndex = 21;
            order_quantityLabel.Text = "order quantity:";
            // 
            // order_totalLabel
            // 
            order_totalLabel.AutoSize = true;
            order_totalLabel.Location = new System.Drawing.Point(94, 178);
            order_totalLabel.Name = "order_totalLabel";
            order_totalLabel.Size = new System.Drawing.Size(70, 16);
            order_totalLabel.TabIndex = 23;
            order_totalLabel.Text = "order total:";
            // 
            // sale_priceLabel
            // 
            sale_priceLabel.AutoSize = true;
            sale_priceLabel.Location = new System.Drawing.Point(94, 206);
            sale_priceLabel.Name = "sale_priceLabel";
            sale_priceLabel.Size = new System.Drawing.Size(69, 16);
            sale_priceLabel.TabIndex = 25;
            sale_priceLabel.Text = "sale price:";
            // 
            // ship_costLabel
            // 
            ship_costLabel.AutoSize = true;
            ship_costLabel.Location = new System.Drawing.Point(94, 234);
            ship_costLabel.Name = "ship_costLabel";
            ship_costLabel.Size = new System.Drawing.Size(63, 16);
            ship_costLabel.TabIndex = 27;
            ship_costLabel.Text = "ship cost:";
            // 
            // taxLabel
            // 
            taxLabel.AutoSize = true;
            taxLabel.Location = new System.Drawing.Point(94, 262);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new System.Drawing.Size(27, 16);
            taxLabel.TabIndex = 29;
            taxLabel.Text = "tax:";
            // 
            // trackingLabel
            // 
            trackingLabel.AutoSize = true;
            trackingLabel.Location = new System.Drawing.Point(94, 290);
            trackingLabel.Name = "trackingLabel";
            trackingLabel.Size = new System.Drawing.Size(57, 16);
            trackingLabel.TabIndex = 31;
            trackingLabel.Text = "tracking:";
            // 
            // button_addsale
            // 
            this.button_addsale.Location = new System.Drawing.Point(51, 428);
            this.button_addsale.Margin = new System.Windows.Forms.Padding(4);
            this.button_addsale.Name = "button_addsale";
            this.button_addsale.Size = new System.Drawing.Size(100, 28);
            this.button_addsale.TabIndex = 17;
            this.button_addsale.Text = "Save";
            this.button_addsale.UseVisualStyleBackColor = true;
            this.button_addsale.Click += new System.EventHandler(this.button_addsale_Click);
            // 
            // customer_idTextBox
            // 
            this.customer_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "customer_id", true));
            this.customer_idTextBox.Location = new System.Drawing.Point(191, 91);
            this.customer_idTextBox.Name = "customer_idTextBox";
            this.customer_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.customer_idTextBox.TabIndex = 18;
            // 
            // order_idTextBox
            // 
            this.order_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "order_id", true));
            this.order_idTextBox.Location = new System.Drawing.Point(191, 119);
            this.order_idTextBox.Name = "order_idTextBox";
            this.order_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.order_idTextBox.TabIndex = 20;
            // 
            // order_quantityTextBox
            // 
            this.order_quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "order_quantity", true));
            this.order_quantityTextBox.Location = new System.Drawing.Point(191, 147);
            this.order_quantityTextBox.Name = "order_quantityTextBox";
            this.order_quantityTextBox.Size = new System.Drawing.Size(100, 22);
            this.order_quantityTextBox.TabIndex = 22;
            // 
            // order_totalTextBox
            // 
            this.order_totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "order_total", true));
            this.order_totalTextBox.Location = new System.Drawing.Point(191, 175);
            this.order_totalTextBox.Name = "order_totalTextBox";
            this.order_totalTextBox.Size = new System.Drawing.Size(100, 22);
            this.order_totalTextBox.TabIndex = 24;
            // 
            // sale_priceTextBox
            // 
            this.sale_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "sale_price", true));
            this.sale_priceTextBox.Location = new System.Drawing.Point(191, 203);
            this.sale_priceTextBox.Name = "sale_priceTextBox";
            this.sale_priceTextBox.Size = new System.Drawing.Size(100, 22);
            this.sale_priceTextBox.TabIndex = 26;
            // 
            // ship_costTextBox
            // 
            this.ship_costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "ship_cost", true));
            this.ship_costTextBox.Location = new System.Drawing.Point(191, 231);
            this.ship_costTextBox.Name = "ship_costTextBox";
            this.ship_costTextBox.Size = new System.Drawing.Size(100, 22);
            this.ship_costTextBox.TabIndex = 28;
            // 
            // taxTextBox
            // 
            this.taxTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "tax", true));
            this.taxTextBox.Location = new System.Drawing.Point(191, 259);
            this.taxTextBox.Name = "taxTextBox";
            this.taxTextBox.Size = new System.Drawing.Size(100, 22);
            this.taxTextBox.TabIndex = 30;
            // 
            // trackingTextBox
            // 
            this.trackingTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "tracking", true));
            this.trackingTextBox.Location = new System.Drawing.Point(191, 287);
            this.trackingTextBox.Name = "trackingTextBox";
            this.trackingTextBox.Size = new System.Drawing.Size(100, 22);
            this.trackingTextBox.TabIndex = 32;
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(eBIT_Application.order);
            // 
            // AddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(customer_idLabel);
            this.Controls.Add(this.customer_idTextBox);
            this.Controls.Add(order_idLabel);
            this.Controls.Add(this.order_idTextBox);
            this.Controls.Add(order_quantityLabel);
            this.Controls.Add(this.order_quantityTextBox);
            this.Controls.Add(order_totalLabel);
            this.Controls.Add(this.order_totalTextBox);
            this.Controls.Add(sale_priceLabel);
            this.Controls.Add(this.sale_priceTextBox);
            this.Controls.Add(ship_costLabel);
            this.Controls.Add(this.ship_costTextBox);
            this.Controls.Add(taxLabel);
            this.Controls.Add(this.taxTextBox);
            this.Controls.Add(trackingLabel);
            this.Controls.Add(this.trackingTextBox);
            this.Controls.Add(this.button_addsale);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "order_id", true));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddSale";
            this.Text = "Add Sale";
            this.Load += new System.EventHandler(this.AddSale_Load);
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.Button button_addsale;
        private System.Windows.Forms.TextBox customer_idTextBox;
        private System.Windows.Forms.TextBox order_idTextBox;
        private System.Windows.Forms.TextBox order_quantityTextBox;
        private System.Windows.Forms.TextBox order_totalTextBox;
        private System.Windows.Forms.TextBox sale_priceTextBox;
        private System.Windows.Forms.TextBox ship_costTextBox;
        private System.Windows.Forms.TextBox taxTextBox;
        private System.Windows.Forms.TextBox trackingTextBox;
    }
}