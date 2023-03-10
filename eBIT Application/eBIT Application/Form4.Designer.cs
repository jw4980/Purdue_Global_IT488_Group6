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
            this.category_idTextBox = new System.Windows.Forms.TextBox();
            this.category_nameTextBox = new System.Windows.Forms.TextBox();
            this.product_categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            category_descLabel = new System.Windows.Forms.Label();
            category_idLabel = new System.Windows.Forms.Label();
            category_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.product_categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // category_descLabel
            // 
            category_descLabel.AutoSize = true;
            category_descLabel.Location = new System.Drawing.Point(60, 150);
            category_descLabel.Name = "category_descLabel";
            category_descLabel.Size = new System.Drawing.Size(96, 16);
            category_descLabel.TabIndex = 5;
            category_descLabel.Text = "category desc:";
            // 
            // category_idLabel
            // 
            category_idLabel.AutoSize = true;
            category_idLabel.Location = new System.Drawing.Point(60, 41);
            category_idLabel.Name = "category_idLabel";
            category_idLabel.Size = new System.Drawing.Size(77, 16);
            category_idLabel.TabIndex = 7;
            category_idLabel.Text = "category id:";
            // 
            // category_nameLabel
            // 
            category_nameLabel.AutoSize = true;
            category_nameLabel.Location = new System.Drawing.Point(56, 96);
            category_nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            category_nameLabel.Name = "category_nameLabel";
            category_nameLabel.Size = new System.Drawing.Size(100, 16);
            category_nameLabel.TabIndex = 8;
            category_nameLabel.Text = "category name:";
            // 
            // button_addcategory
            // 
            this.button_addcategory.Location = new System.Drawing.Point(39, 234);
            this.button_addcategory.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_addcategory.Name = "button_addcategory";
            this.button_addcategory.Size = new System.Drawing.Size(129, 53);
            this.button_addcategory.TabIndex = 5;
            this.button_addcategory.Text = "Add Category";
            this.button_addcategory.UseVisualStyleBackColor = true;
            this.button_addcategory.Click += new System.EventHandler(this.button_addcategory_Click);
            // 
            // category_descTextBox
            // 
            this.category_descTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_categoryBindingSource, "category_desc", true));
            this.category_descTextBox.Location = new System.Drawing.Point(175, 146);
            this.category_descTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.category_descTextBox.Name = "category_descTextBox";
            this.category_descTextBox.Size = new System.Drawing.Size(100, 22);
            this.category_descTextBox.TabIndex = 6;
            // 
            // category_idTextBox
            // 
            this.category_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_categoryBindingSource, "category_id", true));
            this.category_idTextBox.Location = new System.Drawing.Point(175, 37);
            this.category_idTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.category_idTextBox.Name = "category_idTextBox";
            this.category_idTextBox.Size = new System.Drawing.Size(100, 22);
            this.category_idTextBox.TabIndex = 8;
            // 
            // category_nameTextBox
            // 
            this.category_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.product_categoryBindingSource, "category_name", true));
            this.category_nameTextBox.Location = new System.Drawing.Point(171, 92);
            this.category_nameTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.category_nameTextBox.Name = "category_nameTextBox";
            this.category_nameTextBox.Size = new System.Drawing.Size(132, 22);
            this.category_nameTextBox.TabIndex = 9;
            // 
            // product_categoryBindingSource
            // 
            this.product_categoryBindingSource.DataSource = typeof(eBIT_Application.product_category);
            // 
            // AddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 309);
            this.Controls.Add(category_nameLabel);
            this.Controls.Add(this.category_nameTextBox);
            this.Controls.Add(category_descLabel);
            this.Controls.Add(this.category_descTextBox);
            this.Controls.Add(category_idLabel);
            this.Controls.Add(this.category_idTextBox);
            this.Controls.Add(this.button_addcategory);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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