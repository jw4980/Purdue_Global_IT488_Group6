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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSale));
            this.orderBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.orderBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.txt_customerid = new System.Windows.Forms.TextBox();
            this.txt_orderid = new System.Windows.Forms.TextBox();
            this.txt_orderquantity = new System.Windows.Forms.TextBox();
            this.txt_ordertotal = new System.Windows.Forms.TextBox();
            this.txt_saleprice = new System.Windows.Forms.TextBox();
            this.txt_shipcost = new System.Windows.Forms.TextBox();
            this.txt_tax = new System.Windows.Forms.TextBox();
            this.txt_tracking = new System.Windows.Forms.TextBox();
            this.button_addsale = new System.Windows.Forms.Button();
            customer_idLabel = new System.Windows.Forms.Label();
            order_idLabel = new System.Windows.Forms.Label();
            order_quantityLabel = new System.Windows.Forms.Label();
            order_totalLabel = new System.Windows.Forms.Label();
            sale_priceLabel = new System.Windows.Forms.Label();
            ship_costLabel = new System.Windows.Forms.Label();
            taxLabel = new System.Windows.Forms.Label();
            trackingLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).BeginInit();
            this.orderBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // customer_idLabel
            // 
            customer_idLabel.AutoSize = true;
            customer_idLabel.Location = new System.Drawing.Point(39, 100);
            customer_idLabel.Name = "customer_idLabel";
            customer_idLabel.Size = new System.Drawing.Size(64, 13);
            customer_idLabel.TabIndex = 1;
            customer_idLabel.Text = "customer id:";
            // 
            // order_idLabel
            // 
            order_idLabel.AutoSize = true;
            order_idLabel.Location = new System.Drawing.Point(39, 126);
            order_idLabel.Name = "order_idLabel";
            order_idLabel.Size = new System.Drawing.Size(45, 13);
            order_idLabel.TabIndex = 3;
            order_idLabel.Text = "order id:";
            // 
            // order_quantityLabel
            // 
            order_quantityLabel.AutoSize = true;
            order_quantityLabel.Location = new System.Drawing.Point(39, 152);
            order_quantityLabel.Name = "order_quantityLabel";
            order_quantityLabel.Size = new System.Drawing.Size(74, 13);
            order_quantityLabel.TabIndex = 5;
            order_quantityLabel.Text = "order quantity:";
            // 
            // order_totalLabel
            // 
            order_totalLabel.AutoSize = true;
            order_totalLabel.Location = new System.Drawing.Point(39, 178);
            order_totalLabel.Name = "order_totalLabel";
            order_totalLabel.Size = new System.Drawing.Size(57, 13);
            order_totalLabel.TabIndex = 7;
            order_totalLabel.Text = "order total:";
            // 
            // sale_priceLabel
            // 
            sale_priceLabel.AutoSize = true;
            sale_priceLabel.Location = new System.Drawing.Point(39, 204);
            sale_priceLabel.Name = "sale_priceLabel";
            sale_priceLabel.Size = new System.Drawing.Size(55, 13);
            sale_priceLabel.TabIndex = 9;
            sale_priceLabel.Text = "sale price:";
            // 
            // ship_costLabel
            // 
            ship_costLabel.AutoSize = true;
            ship_costLabel.Location = new System.Drawing.Point(39, 230);
            ship_costLabel.Name = "ship_costLabel";
            ship_costLabel.Size = new System.Drawing.Size(52, 13);
            ship_costLabel.TabIndex = 11;
            ship_costLabel.Text = "ship cost:";
            // 
            // taxLabel
            // 
            taxLabel.AutoSize = true;
            taxLabel.Location = new System.Drawing.Point(39, 256);
            taxLabel.Name = "taxLabel";
            taxLabel.Size = new System.Drawing.Size(24, 13);
            taxLabel.TabIndex = 13;
            taxLabel.Text = "tax:";
            // 
            // trackingLabel
            // 
            trackingLabel.AutoSize = true;
            trackingLabel.Location = new System.Drawing.Point(39, 282);
            trackingLabel.Name = "trackingLabel";
            trackingLabel.Size = new System.Drawing.Size(48, 13);
            trackingLabel.TabIndex = 15;
            trackingLabel.Text = "tracking:";
            // 
            // orderBindingNavigator
            // 
            this.orderBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.orderBindingNavigator.BindingSource = this.orderBindingSource;
            this.orderBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.orderBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.orderBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.orderBindingNavigatorSaveItem});
            this.orderBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.orderBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.orderBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.orderBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.orderBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.orderBindingNavigator.Name = "orderBindingNavigator";
            this.orderBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.orderBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.orderBindingNavigator.TabIndex = 0;
            this.orderBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataSource = typeof(eBIT_Application.order);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // orderBindingNavigatorSaveItem
            // 
            this.orderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.orderBindingNavigatorSaveItem.Enabled = false;
            this.orderBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("orderBindingNavigatorSaveItem.Image")));
            this.orderBindingNavigatorSaveItem.Name = "orderBindingNavigatorSaveItem";
            this.orderBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.orderBindingNavigatorSaveItem.Text = "Save Data";
            // 
            // txt_customerid
            // 
            this.txt_customerid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "customer_id", true));
            this.txt_customerid.Location = new System.Drawing.Point(119, 97);
            this.txt_customerid.Name = "txt_customerid";
            this.txt_customerid.Size = new System.Drawing.Size(100, 20);
            this.txt_customerid.TabIndex = 2;
            // 
            // txt_orderid
            // 
            this.txt_orderid.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "order_id", true));
            this.txt_orderid.Location = new System.Drawing.Point(119, 123);
            this.txt_orderid.Name = "txt_orderid";
            this.txt_orderid.Size = new System.Drawing.Size(100, 20);
            this.txt_orderid.TabIndex = 4;
            // 
            // txt_orderquantity
            // 
            this.txt_orderquantity.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "order_quantity", true));
            this.txt_orderquantity.Location = new System.Drawing.Point(119, 149);
            this.txt_orderquantity.Name = "txt_orderquantity";
            this.txt_orderquantity.Size = new System.Drawing.Size(100, 20);
            this.txt_orderquantity.TabIndex = 6;
            // 
            // txt_ordertotal
            // 
            this.txt_ordertotal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "order_total", true));
            this.txt_ordertotal.Location = new System.Drawing.Point(119, 175);
            this.txt_ordertotal.Name = "txt_ordertotal";
            this.txt_ordertotal.Size = new System.Drawing.Size(100, 20);
            this.txt_ordertotal.TabIndex = 8;
            // 
            // txt_saleprice
            // 
            this.txt_saleprice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "sale_price", true));
            this.txt_saleprice.Location = new System.Drawing.Point(119, 201);
            this.txt_saleprice.Name = "txt_saleprice";
            this.txt_saleprice.Size = new System.Drawing.Size(100, 20);
            this.txt_saleprice.TabIndex = 10;
            // 
            // txt_shipcost
            // 
            this.txt_shipcost.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "ship_cost", true));
            this.txt_shipcost.Location = new System.Drawing.Point(119, 227);
            this.txt_shipcost.Name = "txt_shipcost";
            this.txt_shipcost.Size = new System.Drawing.Size(100, 20);
            this.txt_shipcost.TabIndex = 12;
            // 
            // txt_tax
            // 
            this.txt_tax.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "tax", true));
            this.txt_tax.Location = new System.Drawing.Point(119, 253);
            this.txt_tax.Name = "txt_tax";
            this.txt_tax.Size = new System.Drawing.Size(100, 20);
            this.txt_tax.TabIndex = 14;
            // 
            // txt_tracking
            // 
            this.txt_tracking.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "tracking", true));
            this.txt_tracking.Location = new System.Drawing.Point(119, 279);
            this.txt_tracking.Name = "txt_tracking";
            this.txt_tracking.Size = new System.Drawing.Size(100, 20);
            this.txt_tracking.TabIndex = 16;
            // 
            // button_addsale
            // 
            this.button_addsale.Location = new System.Drawing.Point(38, 348);
            this.button_addsale.Name = "button_addsale";
            this.button_addsale.Size = new System.Drawing.Size(75, 23);
            this.button_addsale.TabIndex = 17;
            this.button_addsale.Text = "Save";
            this.button_addsale.UseVisualStyleBackColor = true;
            this.button_addsale.Click += new System.EventHandler(this.button_addsale_Click);
            // 
            // AddSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_addsale);
            this.Controls.Add(customer_idLabel);
            this.Controls.Add(this.txt_customerid);
            this.Controls.Add(order_idLabel);
            this.Controls.Add(this.txt_orderid);
            this.Controls.Add(order_quantityLabel);
            this.Controls.Add(this.txt_orderquantity);
            this.Controls.Add(order_totalLabel);
            this.Controls.Add(this.txt_ordertotal);
            this.Controls.Add(sale_priceLabel);
            this.Controls.Add(this.txt_saleprice);
            this.Controls.Add(ship_costLabel);
            this.Controls.Add(this.txt_shipcost);
            this.Controls.Add(taxLabel);
            this.Controls.Add(this.txt_tax);
            this.Controls.Add(trackingLabel);
            this.Controls.Add(this.txt_tracking);
            this.Controls.Add(this.orderBindingNavigator);
            this.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.orderBindingSource, "order_id", true));
            this.Name = "AddSale";
            this.Text = "Add Sale";
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingNavigator)).EndInit();
            this.orderBindingNavigator.ResumeLayout(false);
            this.orderBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingNavigator orderBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton orderBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox txt_customerid;
        private System.Windows.Forms.TextBox txt_orderid;
        private System.Windows.Forms.TextBox txt_orderquantity;
        private System.Windows.Forms.TextBox txt_ordertotal;
        private System.Windows.Forms.TextBox txt_saleprice;
        private System.Windows.Forms.TextBox txt_shipcost;
        private System.Windows.Forms.TextBox txt_tax;
        private System.Windows.Forms.TextBox txt_tracking;
        private System.Windows.Forms.Button button_addsale;
    }
}