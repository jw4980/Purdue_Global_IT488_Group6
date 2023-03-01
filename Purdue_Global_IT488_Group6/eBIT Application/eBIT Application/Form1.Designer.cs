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
            System.Windows.Forms.Label item_descLabel;
            System.Windows.Forms.Label item_idLabel;
            System.Windows.Forms.Label item_imageLabel;
            System.Windows.Forms.Label item_quantityLabel;
            System.Windows.Forms.Label list_priceLabel;
            System.Windows.Forms.Label sale_endLabel;
            System.Windows.Forms.Label sale_startLabel;
            this.category_idTextBox = new System.Windows.Forms.TextBox();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.item_costTextBox = new System.Windows.Forms.TextBox();
            this.item_descTextBox = new System.Windows.Forms.TextBox();
            this.item_idTextBox = new System.Windows.Forms.TextBox();
            this.item_imageTextBox = new System.Windows.Forms.TextBox();
            this.item_quantityTextBox = new System.Windows.Forms.TextBox();
            this.list_priceTextBox = new System.Windows.Forms.TextBox();
            this.sale_endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.sale_startDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelTitle = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            category_idLabel = new System.Windows.Forms.Label();
            item_costLabel = new System.Windows.Forms.Label();
            item_descLabel = new System.Windows.Forms.Label();
            item_idLabel = new System.Windows.Forms.Label();
            item_imageLabel = new System.Windows.Forms.Label();
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
            category_idLabel.Location = new System.Drawing.Point(51, 54);
            category_idLabel.Name = "category_idLabel";
            category_idLabel.Size = new System.Drawing.Size(77, 16);
            category_idLabel.TabIndex = 1;
            category_idLabel.Text = "category id:";
            // 
            // item_costLabel
            // 
            item_costLabel.AutoSize = true;
            item_costLabel.Location = new System.Drawing.Point(51, 82);
            item_costLabel.Name = "item_costLabel";
            item_costLabel.Size = new System.Drawing.Size(63, 16);
            item_costLabel.TabIndex = 3;
            item_costLabel.Text = "item cost:";
            // 
            // item_descLabel
            // 
            item_descLabel.AutoSize = true;
            item_descLabel.Location = new System.Drawing.Point(51, 110);
            item_descLabel.Name = "item_descLabel";
            item_descLabel.Size = new System.Drawing.Size(68, 16);
            item_descLabel.TabIndex = 5;
            item_descLabel.Text = "item desc:";
            // 
            // item_idLabel
            // 
            item_idLabel.AutoSize = true;
            item_idLabel.Location = new System.Drawing.Point(51, 138);
            item_idLabel.Name = "item_idLabel";
            item_idLabel.Size = new System.Drawing.Size(49, 16);
            item_idLabel.TabIndex = 7;
            item_idLabel.Text = "item id:";
            // 
            // item_imageLabel
            // 
            item_imageLabel.AutoSize = true;
            item_imageLabel.Location = new System.Drawing.Point(51, 221);
            item_imageLabel.Name = "item_imageLabel";
            item_imageLabel.Size = new System.Drawing.Size(76, 16);
            item_imageLabel.TabIndex = 9;
            item_imageLabel.Text = "item image:";
            // 
            // item_quantityLabel
            // 
            item_quantityLabel.AutoSize = true;
            item_quantityLabel.Location = new System.Drawing.Point(51, 179);
            item_quantityLabel.Name = "item_quantityLabel";
            item_quantityLabel.Size = new System.Drawing.Size(84, 16);
            item_quantityLabel.TabIndex = 11;
            item_quantityLabel.Text = "item quantity:";
            // 
            // list_priceLabel
            // 
            list_priceLabel.AutoSize = true;
            list_priceLabel.Location = new System.Drawing.Point(282, 85);
            list_priceLabel.Name = "list_priceLabel";
            list_priceLabel.Size = new System.Drawing.Size(59, 16);
            list_priceLabel.TabIndex = 13;
            list_priceLabel.Text = "list price:";
            // 
            // sale_endLabel
            // 
            sale_endLabel.AutoSize = true;
            sale_endLabel.Location = new System.Drawing.Point(399, 285);
            sale_endLabel.Name = "sale_endLabel";
            sale_endLabel.Size = new System.Drawing.Size(62, 16);
            sale_endLabel.TabIndex = 15;
            sale_endLabel.Text = "sale end:";
            // 
            // sale_startLabel
            // 
            sale_startLabel.AutoSize = true;
            sale_startLabel.Location = new System.Drawing.Point(51, 283);
            sale_startLabel.Name = "sale_startLabel";
            sale_startLabel.Size = new System.Drawing.Size(64, 16);
            sale_startLabel.TabIndex = 17;
            sale_startLabel.Text = "sale start:";
            // 
            // category_idTextBox
            // 
            this.category_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "category_id", true));
            this.category_idTextBox.Location = new System.Drawing.Point(141, 51);
            this.category_idTextBox.Name = "category_idTextBox";
            this.category_idTextBox.Size = new System.Drawing.Size(91, 22);
            this.category_idTextBox.TabIndex = 2;
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataSource = typeof(eBIT_Application.inventory);
            // 
            // item_costTextBox
            // 
            this.item_costTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "item_cost", true));
            this.item_costTextBox.Location = new System.Drawing.Point(141, 79);
            this.item_costTextBox.Name = "item_costTextBox";
            this.item_costTextBox.Size = new System.Drawing.Size(97, 22);
            this.item_costTextBox.TabIndex = 4;
            // 
            // item_descTextBox
            // 
            this.item_descTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "item_desc", true));
            this.item_descTextBox.Location = new System.Drawing.Point(141, 107);
            this.item_descTextBox.Name = "item_descTextBox";
            this.item_descTextBox.Size = new System.Drawing.Size(518, 22);
            this.item_descTextBox.TabIndex = 6;
            // 
            // item_idTextBox
            // 
            this.item_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "item_id", true));
            this.item_idTextBox.Location = new System.Drawing.Point(141, 135);
            this.item_idTextBox.Name = "item_idTextBox";
            this.item_idTextBox.Size = new System.Drawing.Size(97, 22);
            this.item_idTextBox.TabIndex = 8;
            // 
            // item_imageTextBox
            // 
            this.item_imageTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "item_image", true));
            this.item_imageTextBox.Location = new System.Drawing.Point(150, 218);
            this.item_imageTextBox.MaximumSize = new System.Drawing.Size(3000, 3000);
            this.item_imageTextBox.Name = "item_imageTextBox";
            this.item_imageTextBox.Size = new System.Drawing.Size(145, 22);
            this.item_imageTextBox.TabIndex = 10;
            // 
            // item_quantityTextBox
            // 
            this.item_quantityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "item_quantity", true));
            this.item_quantityTextBox.Location = new System.Drawing.Point(141, 179);
            this.item_quantityTextBox.Name = "item_quantityTextBox";
            this.item_quantityTextBox.Size = new System.Drawing.Size(97, 22);
            this.item_quantityTextBox.TabIndex = 12;
            // 
            // list_priceTextBox
            // 
            this.list_priceTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.inventoryBindingSource, "list_price", true));
            this.list_priceTextBox.Location = new System.Drawing.Point(357, 79);
            this.list_priceTextBox.Name = "list_priceTextBox";
            this.list_priceTextBox.Size = new System.Drawing.Size(200, 22);
            this.list_priceTextBox.TabIndex = 14;
            // 
            // sale_endDateTimePicker
            // 
            this.sale_endDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventoryBindingSource, "sale_end", true));
            this.sale_endDateTimePicker.Location = new System.Drawing.Point(506, 283);
            this.sale_endDateTimePicker.Name = "sale_endDateTimePicker";
            this.sale_endDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.sale_endDateTimePicker.TabIndex = 16;
            // 
            // sale_startDateTimePicker
            // 
            this.sale_startDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.inventoryBindingSource, "sale_start", true));
            this.sale_startDateTimePicker.Location = new System.Drawing.Point(141, 279);
            this.sale_startDateTimePicker.Name = "sale_startDateTimePicker";
            this.sale_startDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.sale_startDateTimePicker.TabIndex = 18;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(48, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(392, 32);
            this.labelTitle.TabIndex = 19;
            this.labelTitle.Text = "Enter Inventory Data Below:";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(54, 328);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 20;
            this.buttonAdd.Text = "Insert";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AddInventory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(category_idLabel);
            this.Controls.Add(this.category_idTextBox);
            this.Controls.Add(item_costLabel);
            this.Controls.Add(this.item_costTextBox);
            this.Controls.Add(item_descLabel);
            this.Controls.Add(this.item_descTextBox);
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
        private System.Windows.Forms.TextBox item_descTextBox;
        private System.Windows.Forms.TextBox item_idTextBox;
        private System.Windows.Forms.TextBox item_imageTextBox;
        private System.Windows.Forms.TextBox item_quantityTextBox;
        private System.Windows.Forms.TextBox list_priceTextBox;
        private System.Windows.Forms.DateTimePicker sale_endDateTimePicker;
        private System.Windows.Forms.DateTimePicker sale_startDateTimePicker;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button buttonAdd;
    }
}

