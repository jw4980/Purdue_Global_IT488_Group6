namespace eBIT_Application
{
    partial class AddCategory
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
            System.Windows.Forms.Label category_descLabel;
            System.Windows.Forms.Label category_idLabel;
            System.Windows.Forms.Label category_nameLabel;
            this.button_addcategory = new System.Windows.Forms.Button();
            this.category_descTextBox = new System.Windows.Forms.TextBox();
            this.product_categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.category_idTextBox = new System.Windows.Forms.TextBox();
            this.category_nameTextBox = new System.Windows.Forms.TextBox();
            category_descLabel = new System.Windows.Forms.Label();
            category_idLabel = new System.Windows.Forms.Label();
            category_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.product_categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // category_descLabel
            // 
            category_descLabel.AutoSize = true;
            category_descLabel.Location = new System.Drawing.Point(45, 122);
            category_descLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            category_descLabel.Name = "category_descLabel";
            category_descLabel.Size = new System.Drawing.Size(77, 13);
            category_descLabel.TabIndex = 5;
            category_descLabel.Text = "category desc:";
            // 
            // category_idLabel
            // 
            category_idLabel.AutoSize = true;
            category_idLabel.Location = new System.Drawing.Point(45, 33);
            category_idLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            category_idLabel.Name = "category_idLabel";
            category_idLabel.Size = new System.Drawing.Size(62, 13);
            category_idLabel.TabIndex = 7;
            category_idLabel.Text = "category id:";
            // 
            // button_addcategory
            // 
            this.button_addcategory.Location = new System.Drawing.Point(29, 190);
            this.button_addcategory.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_addcategory.Name = "button_addcategory";
            this.button_addcategory.Size = new System.Drawing.Size(97, 43);
            this.button_addcategory.TabIndex = 5;
            this.button_addcategory.Text = "Add Category";
            this.button_addcategory.UseVisualStyleBackColor = true;
            this.button_addcategory.Click += new System.EventHandler(this.button_addcategory_Click);
            // 
            // category_descTextBox
            // 
            this.category_descTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_categoryBindingSource, "category_desc", true));
            this.category_descTextBox.Location = new System.Drawing.Point(131, 119);
            this.category_descTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.category_descTextBox.Name = "category_descTextBox";
            this.category_descTextBox.Size = new System.Drawing.Size(76, 20);
            this.category_descTextBox.TabIndex = 6;
            // 
            // product_categoryBindingSource
            // 
            this.product_categoryBindingSource.DataSource = typeof(eBIT_Application.product_category);
            // 
            // category_idTextBox
            // 
            this.category_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_categoryBindingSource, "category_id", true));
            this.category_idTextBox.Location = new System.Drawing.Point(131, 30);
            this.category_idTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.category_idTextBox.Name = "category_idTextBox";
            this.category_idTextBox.Size = new System.Drawing.Size(76, 20);
            this.category_idTextBox.TabIndex = 8;
            // 
            // category_nameLabel
            // 
            category_nameLabel.AutoSize = true;
            category_nameLabel.Location = new System.Drawing.Point(42, 78);
            category_nameLabel.Name = "category_nameLabel";
            category_nameLabel.Size = new System.Drawing.Size(80, 13);
            category_nameLabel.TabIndex = 8;
            category_nameLabel.Text = "category name:";
            // 
            // category_nameTextBox
            // 
            this.category_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_categoryBindingSource, "category_name", true));
            this.category_nameTextBox.Location = new System.Drawing.Point(128, 75);
            this.category_nameTextBox.Name = "category_nameTextBox";
            this.category_nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.category_nameTextBox.TabIndex = 9;
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(category_nameLabel);
            this.Controls.Add(this.category_nameTextBox);
            this.Controls.Add(category_descLabel);
            this.Controls.Add(this.category_descTextBox);
            this.Controls.Add(category_idLabel);
            this.Controls.Add(this.category_idTextBox);
            this.Controls.Add(this.button_addcategory);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddCategory";
            this.Text = "Add Category";
            this.Load += new System.EventHandler(this.AddCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_categoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource product_categoryBindingSource;
        private System.Windows.Forms.Button button_addcategory;
        private System.Windows.Forms.TextBox category_descTextBox;
        private System.Windows.Forms.TextBox category_idTextBox;
        private System.Windows.Forms.TextBox category_nameTextBox;
    }
}