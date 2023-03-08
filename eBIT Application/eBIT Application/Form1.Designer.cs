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
            System.Windows.Forms.Label item_quantityLabel;
            System.Windows.Forms.Label list_priceLabel;
            System.Windows.Forms.Label sale_endLabel;
            System.Windows.Forms.Label sale_startLabel;
            this.item_descLabel = new System.Windows.Forms.Label();
            this.item_costTextBox = new System.Windows.Forms.TextBox();
            this.item_descTextBox = new System.Windows.Forms.TextBox();
            this.item_idTextBox = new System.Windows.Forms.TextBox();
            this.item_quantityTextBox = new System.Windows.Forms.TextBox();
            this.list_priceTextBox = new System.Windows.Forms.TextBox();
            this.sale_endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sale_startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            category_idLabel = new System.Windows.Forms.Label();
            item_costLabel = new System.Windows.Forms.Label();
            item_idLabel = new System.Windows.Forms.Label();
            item_quantityLabel = new System.Windows.Forms.Label();
            list_priceLabel = new System.Windows.Forms.Label();
            sale_endLabel = new System.Windows.Forms.Label();
            sale_startLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // category_idLabel
            // 
            category_idLabel.AutoSize = true;
            category_idLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            category_idLabel.Location = new System.Drawing.Point(347, 90);
            category_idLabel.Name = "category_idLabel";
            category_idLabel.Size = new System.Drawing.Size(108, 23);
            category_idLabel.TabIndex = 1;
            category_idLabel.Text = "Category:";
            // 
            // item_costLabel
            // 
            item_costLabel.AutoSize = true;
            item_costLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            item_costLabel.Location = new System.Drawing.Point(15, 210);
            item_costLabel.Name = "item_costLabel";
            item_costLabel.Size = new System.Drawing.Size(59, 23);
            item_costLabel.TabIndex = 3;
            item_costLabel.Text = "Cost:";
            // 
            // item_descLabel
            // 
            this.item_descLabel.AutoSize = true;
            this.item_descLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_descLabel.Location = new System.Drawing.Point(15, 150);
            this.item_descLabel.Name = "item_descLabel";
            this.item_descLabel.Size = new System.Drawing.Size(122, 23);
            this.item_descLabel.TabIndex = 5;
            this.item_descLabel.Text = "Description:";
            // 
            // item_idLabel
            // 
            item_idLabel.AutoSize = true;
            item_idLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            item_idLabel.Location = new System.Drawing.Point(15, 90);
            item_idLabel.Name = "item_idLabel";
            item_idLabel.Size = new System.Drawing.Size(85, 23);
            item_idLabel.TabIndex = 7;
            item_idLabel.Text = "Item ID:";
            // 
            // item_quantityLabel
            // 
            item_quantityLabel.AutoSize = true;
            item_quantityLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            item_quantityLabel.Location = new System.Drawing.Point(435, 210);
            item_quantityLabel.Name = "item_quantityLabel";
            item_quantityLabel.Size = new System.Drawing.Size(98, 23);
            item_quantityLabel.TabIndex = 11;
            item_quantityLabel.Text = "Quantity:";
            // 
            // list_priceLabel
            // 
            list_priceLabel.AutoSize = true;
            list_priceLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            list_priceLabel.Location = new System.Drawing.Point(194, 210);
            list_priceLabel.Name = "list_priceLabel";
            list_priceLabel.Size = new System.Drawing.Size(101, 23);
            list_priceLabel.TabIndex = 13;
            list_priceLabel.Text = "Sell Price:";
            // 
            // sale_endLabel
            // 
            sale_endLabel.AutoSize = true;
            sale_endLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sale_endLabel.Location = new System.Drawing.Point(93, 320);
            sale_endLabel.Name = "sale_endLabel";
            sale_endLabel.Size = new System.Drawing.Size(100, 23);
            sale_endLabel.TabIndex = 15;
            sale_endLabel.Text = "Sale End:";
            // 
            // sale_startLabel
            // 
            sale_startLabel.AutoSize = true;
            sale_startLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            sale_startLabel.Location = new System.Drawing.Point(93, 272);
            sale_startLabel.Name = "sale_startLabel";
            sale_startLabel.Size = new System.Drawing.Size(107, 23);
            sale_startLabel.TabIndex = 17;
            sale_startLabel.Text = "Sale Start:";
            // 
            // item_costTextBox
            // 
            this.item_costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "item_cost", true));
            this.item_costTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_costTextBox.Location = new System.Drawing.Point(80, 207);
            this.item_costTextBox.Name = "item_costTextBox";
            this.item_costTextBox.Size = new System.Drawing.Size(93, 32);
            this.item_costTextBox.TabIndex = 4;
            // 
            // item_descTextBox
            // 
            this.item_descTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "item_name", true));
            this.item_descTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_descTextBox.Location = new System.Drawing.Point(140, 141);
            this.item_descTextBox.Name = "item_descTextBox";
            this.item_descTextBox.Size = new System.Drawing.Size(477, 32);
            this.item_descTextBox.TabIndex = 6;
            // 
            // item_idTextBox
            // 
            this.item_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "item_id", true));
            this.item_idTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_idTextBox.Location = new System.Drawing.Point(106, 87);
            this.item_idTextBox.Name = "item_idTextBox";
            this.item_idTextBox.Size = new System.Drawing.Size(151, 32);
            this.item_idTextBox.TabIndex = 8;
            // 
            // item_quantityTextBox
            // 
            this.item_quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "item_quantity", true));
            this.item_quantityTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.item_quantityTextBox.Location = new System.Drawing.Point(548, 207);
            this.item_quantityTextBox.Name = "item_quantityTextBox";
            this.item_quantityTextBox.Size = new System.Drawing.Size(69, 32);
            this.item_quantityTextBox.TabIndex = 12;
            // 
            // list_priceTextBox
            // 
            this.list_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "list_price", true));
            this.list_priceTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_priceTextBox.Location = new System.Drawing.Point(310, 207);
            this.list_priceTextBox.Name = "list_priceTextBox";
            this.list_priceTextBox.Size = new System.Drawing.Size(101, 32);
            this.list_priceTextBox.TabIndex = 14;
            // 
            // sale_endDateTimePicker
            // 
            this.sale_endDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventoryBindingSource, "sale_end", true));
            this.sale_endDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_endDateTimePicker.Location = new System.Drawing.Point(219, 316);
            this.sale_endDateTimePicker.Name = "sale_endDateTimePicker";
            this.sale_endDateTimePicker.Size = new System.Drawing.Size(299, 28);
            this.sale_endDateTimePicker.TabIndex = 16;
            // 
            // sale_startDateTimePicker
            // 
            this.sale_startDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventoryBindingSource, "sale_start", true));
            this.sale_startDateTimePicker.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sale_startDateTimePicker.Location = new System.Drawing.Point(219, 268);
            this.sale_startDateTimePicker.Name = "sale_startDateTimePicker";
            this.sale_startDateTimePicker.Size = new System.Drawing.Size(299, 28);
            this.sale_startDateTimePicker.TabIndex = 18;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(125, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(378, 34);
            this.labelTitle.TabIndex = 19;
            this.labelTitle.Text = "Enter Inventory Data Below";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonAdd.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdd.Location = new System.Drawing.Point(272, 368);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(81, 43);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Insert";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataSource = typeof(eBIT_Application.inventory);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.inventoryBindingSource;
            this.comboBox1.DisplayMember = "product_category";
            this.comboBox1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(461, 87);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(154, 31);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.ValueMember = "product_category";
            // 
            // AddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 435);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(category_idLabel);
            this.Controls.Add(item_costLabel);
            this.Controls.Add(this.item_costTextBox);
            this.Controls.Add(this.item_descLabel);
            this.Controls.Add(this.item_descTextBox);
            this.Controls.Add(item_idLabel);
            this.Controls.Add(this.item_idTextBox);
            this.Controls.Add(item_quantityLabel);
            this.Controls.Add(this.item_quantityTextBox);
            this.Controls.Add(list_priceLabel);
            this.Controls.Add(this.list_priceTextBox);
            this.Controls.Add(sale_endLabel);
            this.Controls.Add(this.sale_endDateTimePicker);
            this.Controls.Add(sale_startLabel);
            this.Controls.Add(this.sale_startDateTimePicker);
            this.Name = "AddInventory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Inventory";
            this.Load += new System.EventHandler(this.AddInventory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private System.Windows.Forms.TextBox item_costTextBox;
        private System.Windows.Forms.TextBox item_descTextBox;
        private System.Windows.Forms.TextBox item_idTextBox;
        private System.Windows.Forms.TextBox item_quantityTextBox;
        private System.Windows.Forms.TextBox list_priceTextBox;
        private System.Windows.Forms.DateTimePicker sale_endDateTimePicker;
        private System.Windows.Forms.DateTimePicker sale_startDateTimePicker;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label item_descLabel;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

