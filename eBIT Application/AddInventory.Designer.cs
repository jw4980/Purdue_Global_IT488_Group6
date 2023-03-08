namespace eBIT_Application
{
    partial class AddInventory
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
            System.Windows.Forms.Label category_idLabel;
            System.Windows.Forms.Label item_costLabel;
            System.Windows.Forms.Label item_idLabel;
            System.Windows.Forms.Label item_imageLabel;
            System.Windows.Forms.Label item_quantityLabel;
            System.Windows.Forms.Label list_priceLabel;
            System.Windows.Forms.Label sale_endLabel;
            System.Windows.Forms.Label sale_startLabel;
            System.Windows.Forms.Label item_nameLabel;
            this.category_idTextBox = new System.Windows.Forms.TextBox();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.item_costTextBox = new System.Windows.Forms.TextBox();
            this.item_idTextBox = new System.Windows.Forms.TextBox();
            this.item_imageTextBox = new System.Windows.Forms.TextBox();
            this.item_quantityTextBox = new System.Windows.Forms.TextBox();
            this.list_priceTextBox = new System.Windows.Forms.TextBox();
            this.sale_endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sale_startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.item_nameTextBox = new System.Windows.Forms.TextBox();
            category_idLabel = new System.Windows.Forms.Label();
            item_costLabel = new System.Windows.Forms.Label();
            item_idLabel = new System.Windows.Forms.Label();
            item_imageLabel = new System.Windows.Forms.Label();
            item_quantityLabel = new System.Windows.Forms.Label();
            list_priceLabel = new System.Windows.Forms.Label();
            sale_endLabel = new System.Windows.Forms.Label();
            sale_startLabel = new System.Windows.Forms.Label();
            item_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // category_idLabel
            // 
            category_idLabel.AutoSize = true;
            category_idLabel.Location = new System.Drawing.Point(38, 44);
            category_idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            category_idLabel.Name = "category_idLabel";
            category_idLabel.Size = new System.Drawing.Size(62, 13);
            category_idLabel.TabIndex = 1;
            category_idLabel.Text = "category id:";
            // 
            // item_costLabel
            // 
            item_costLabel.AutoSize = true;
            item_costLabel.Location = new System.Drawing.Point(38, 67);
            item_costLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            item_costLabel.Name = "item_costLabel";
            item_costLabel.Size = new System.Drawing.Size(52, 13);
            item_costLabel.TabIndex = 3;
            item_costLabel.Text = "item cost:";
            // 
            // item_idLabel
            // 
            item_idLabel.AutoSize = true;
            item_idLabel.Location = new System.Drawing.Point(38, 131);
            item_idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            item_idLabel.Name = "item_idLabel";
            item_idLabel.Size = new System.Drawing.Size(40, 13);
            item_idLabel.TabIndex = 7;
            item_idLabel.Text = "item id:";
            // 
            // item_imageLabel
            // 
            item_imageLabel.AutoSize = true;
            item_imageLabel.Location = new System.Drawing.Point(38, 199);
            item_imageLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            item_imageLabel.Name = "item_imageLabel";
            item_imageLabel.Size = new System.Drawing.Size(60, 13);
            item_imageLabel.TabIndex = 9;
            item_imageLabel.Text = "item image:";
            // 
            // item_quantityLabel
            // 
            item_quantityLabel.AutoSize = true;
            item_quantityLabel.Location = new System.Drawing.Point(38, 164);
            item_quantityLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            item_quantityLabel.Name = "item_quantityLabel";
            item_quantityLabel.Size = new System.Drawing.Size(69, 13);
            item_quantityLabel.TabIndex = 11;
            item_quantityLabel.Text = "item quantity:";
            // 
            // list_priceLabel
            // 
            list_priceLabel.AutoSize = true;
            list_priceLabel.Location = new System.Drawing.Point(212, 69);
            list_priceLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            list_priceLabel.Name = "list_priceLabel";
            list_priceLabel.Size = new System.Drawing.Size(48, 13);
            list_priceLabel.TabIndex = 13;
            list_priceLabel.Text = "list price:";
            // 
            // sale_endLabel
            // 
            sale_endLabel.AutoSize = true;
            sale_endLabel.Location = new System.Drawing.Point(299, 251);
            sale_endLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sale_endLabel.Name = "sale_endLabel";
            sale_endLabel.Size = new System.Drawing.Size(50, 13);
            sale_endLabel.TabIndex = 15;
            sale_endLabel.Text = "sale end:";
            // 
            // sale_startLabel
            // 
            sale_startLabel.AutoSize = true;
            sale_startLabel.Location = new System.Drawing.Point(38, 249);
            sale_startLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            sale_startLabel.Name = "sale_startLabel";
            sale_startLabel.Size = new System.Drawing.Size(52, 13);
            sale_startLabel.TabIndex = 17;
            sale_startLabel.Text = "sale start:";
            // 
            // item_nameLabel
            // 
            item_nameLabel.AutoSize = true;
            item_nameLabel.Location = new System.Drawing.Point(37, 96);
            item_nameLabel.Name = "item_nameLabel";
            item_nameLabel.Size = new System.Drawing.Size(58, 13);
            item_nameLabel.TabIndex = 20;
            item_nameLabel.Text = "item name:";
            // 
            // category_idTextBox
            // 
            this.category_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "category_id", true));
            this.category_idTextBox.Location = new System.Drawing.Point(106, 41);
            this.category_idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.category_idTextBox.Name = "category_idTextBox";
            this.category_idTextBox.Size = new System.Drawing.Size(69, 20);
            this.category_idTextBox.TabIndex = 2;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataSource = typeof(eBIT_Application.inventory);
            // 
            // item_costTextBox
            // 
            this.item_costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "item_cost", true));
            this.item_costTextBox.Location = new System.Drawing.Point(106, 67);
            this.item_costTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.item_costTextBox.Name = "item_costTextBox";
            this.item_costTextBox.Size = new System.Drawing.Size(74, 20);
            this.item_costTextBox.TabIndex = 4;
            // 
            // item_idTextBox
            // 
            this.item_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "item_id", true));
            this.item_idTextBox.Location = new System.Drawing.Point(106, 129);
            this.item_idTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.item_idTextBox.Name = "item_idTextBox";
            this.item_idTextBox.Size = new System.Drawing.Size(74, 20);
            this.item_idTextBox.TabIndex = 8;
            // 
            // item_imageTextBox
            // 
            this.item_imageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "item_image", true));
            this.item_imageTextBox.Location = new System.Drawing.Point(112, 196);
            this.item_imageTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.item_imageTextBox.MaximumSize = new System.Drawing.Size(2251, 3000);
            this.item_imageTextBox.Name = "item_imageTextBox";
            this.item_imageTextBox.Size = new System.Drawing.Size(110, 20);
            this.item_imageTextBox.TabIndex = 10;
            // 
            // item_quantityTextBox
            // 
            this.item_quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "item_quantity", true));
            this.item_quantityTextBox.Location = new System.Drawing.Point(106, 164);
            this.item_quantityTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.item_quantityTextBox.Name = "item_quantityTextBox";
            this.item_quantityTextBox.Size = new System.Drawing.Size(74, 20);
            this.item_quantityTextBox.TabIndex = 12;
            // 
            // list_priceTextBox
            // 
            this.list_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "list_price", true));
            this.list_priceTextBox.Location = new System.Drawing.Point(268, 64);
            this.list_priceTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.list_priceTextBox.Name = "list_priceTextBox";
            this.list_priceTextBox.Size = new System.Drawing.Size(151, 20);
            this.list_priceTextBox.TabIndex = 14;
            // 
            // sale_endDateTimePicker
            // 
            this.sale_endDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventoryBindingSource, "sale_end", true));
            this.sale_endDateTimePicker.Location = new System.Drawing.Point(380, 249);
            this.sale_endDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.sale_endDateTimePicker.Name = "sale_endDateTimePicker";
            this.sale_endDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.sale_endDateTimePicker.TabIndex = 16;
            // 
            // sale_startDateTimePicker
            // 
            this.sale_startDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventoryBindingSource, "sale_start", true));
            this.sale_startDateTimePicker.Location = new System.Drawing.Point(106, 246);
            this.sale_startDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.sale_startDateTimePicker.Name = "sale_startDateTimePicker";
            this.sale_startDateTimePicker.Size = new System.Drawing.Size(151, 20);
            this.sale_startDateTimePicker.TabIndex = 18;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(36, 7);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(310, 26);
            this.labelTitle.TabIndex = 19;
            this.labelTitle.Text = "Enter Inventory Data Below:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(40, 285);
            this.buttonAdd.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(56, 19);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Insert";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // item_nameTextBox
            // 
            this.item_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "item_name", true));
            this.item_nameTextBox.Location = new System.Drawing.Point(101, 96);
            this.item_nameTextBox.Name = "item_nameTextBox";
            this.item_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.item_nameTextBox.TabIndex = 21;
            // 
            // AddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(item_nameLabel);
            this.Controls.Add(this.item_nameTextBox);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(category_idLabel);
            this.Controls.Add(this.category_idTextBox);
            this.Controls.Add(item_costLabel);
            this.Controls.Add(this.item_costTextBox);
            this.Controls.Add(item_idLabel);
            this.Controls.Add(this.item_idTextBox);
            this.Controls.Add(item_imageLabel);
            this.Controls.Add(this.item_imageTextBox);
            this.Controls.Add(item_quantityLabel);
            this.Controls.Add(this.item_quantityTextBox);
            this.Controls.Add(list_priceLabel);
            this.Controls.Add(this.list_priceTextBox);
            this.Controls.Add(sale_endLabel);
            this.Controls.Add(this.sale_endDateTimePicker);
            this.Controls.Add(sale_startLabel);
            this.Controls.Add(this.sale_startDateTimePicker);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddInventory";
            this.Text = "Add Inventory";
            this.Load += new System.EventHandler(this.AddInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.TextBox category_idTextBox;
        private System.Windows.Forms.TextBox item_costTextBox;
        private System.Windows.Forms.TextBox item_idTextBox;
        private System.Windows.Forms.TextBox item_imageTextBox;
        private System.Windows.Forms.TextBox item_quantityTextBox;
        private System.Windows.Forms.TextBox list_priceTextBox;
        private System.Windows.Forms.DateTimePicker sale_endDateTimePicker;
        private System.Windows.Forms.DateTimePicker sale_startDateTimePicker;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.TextBox item_nameTextBox;
    }
}

