namespace eBIT_Customers
{
    partial class AddCustomerForm
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
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label zipLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label address_line_2Label;
            System.Windows.Forms.Label address_line_1Label;
            System.Windows.Forms.Label ebay_usernameLabel;
            System.Windows.Forms.Label last_nameLabel;
            System.Windows.Forms.Label first_nameLabel;
            this.btnAddCust = new System.Windows.Forms.Button();
            this.eBITDataSet = new eBIT_Application.eBITDataSet();
            this.customersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new eBIT_Application.eBITDataSetTableAdapters.customersTableAdapter();
            this.tableAdapterManager = new eBIT_Application.eBITDataSetTableAdapters.TableAdapterManager();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.address_line_2TextBox = new System.Windows.Forms.TextBox();
            this.address_line_1TextBox = new System.Windows.Forms.TextBox();
            this.ebay_usernameTextBox = new System.Windows.Forms.TextBox();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            emailLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            zipLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            address_line_2Label = new System.Windows.Forms.Label();
            address_line_1Label = new System.Windows.Forms.Label();
            ebay_usernameLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(306, 264);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 30;
            emailLabel.Text = "email:";
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(31, 264);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(40, 13);
            phoneLabel.TabIndex = 28;
            phoneLabel.Text = "phone:";
            // 
            // zipLabel
            // 
            zipLabel.AutoSize = true;
            zipLabel.Location = new System.Drawing.Point(34, 222);
            zipLabel.Name = "zipLabel";
            zipLabel.Size = new System.Drawing.Size(23, 13);
            zipLabel.TabIndex = 26;
            zipLabel.Text = "zip:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(362, 186);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(33, 13);
            stateLabel.TabIndex = 24;
            stateLabel.Text = "state:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(31, 186);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(26, 13);
            cityLabel.TabIndex = 22;
            cityLabel.Text = "city:";
            // 
            // address_line_2Label
            // 
            address_line_2Label.AutoSize = true;
            address_line_2Label.Location = new System.Drawing.Point(19, 160);
            address_line_2Label.Name = "address_line_2Label";
            address_line_2Label.Size = new System.Drawing.Size(75, 13);
            address_line_2Label.TabIndex = 20;
            address_line_2Label.Text = "address line 2:";
            // 
            // address_line_1Label
            // 
            address_line_1Label.AutoSize = true;
            address_line_1Label.Location = new System.Drawing.Point(19, 130);
            address_line_1Label.Name = "address_line_1Label";
            address_line_1Label.Size = new System.Drawing.Size(75, 13);
            address_line_1Label.TabIndex = 18;
            address_line_1Label.Text = "address line 1:";
            // 
            // ebay_usernameLabel
            // 
            ebay_usernameLabel.AutoSize = true;
            ebay_usernameLabel.Location = new System.Drawing.Point(19, 80);
            ebay_usernameLabel.Name = "ebay_usernameLabel";
            ebay_usernameLabel.Size = new System.Drawing.Size(82, 13);
            ebay_usernameLabel.TabIndex = 16;
            ebay_usernameLabel.Text = "ebay username:";
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Location = new System.Drawing.Point(262, 31);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(55, 13);
            last_nameLabel.TabIndex = 14;
            last_nameLabel.Text = "last name:";
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Location = new System.Drawing.Point(16, 31);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(55, 13);
            first_nameLabel.TabIndex = 12;
            first_nameLabel.Text = "first name:";
            // 
            // btnAddCust
            // 
            this.btnAddCust.Location = new System.Drawing.Point(265, 306);
            this.btnAddCust.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(75, 19);
            this.btnAddCust.TabIndex = 10;
            this.btnAddCust.Text = "Add";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // eBITDataSet
            // 
            this.eBITDataSet.DataSetName = "eBITDataSet";
            this.eBITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource1
            // 
            this.customersBindingSource1.DataMember = "customers";
            this.customersBindingSource1.DataSource = this.eBITDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customersTableAdapter = this.customersTableAdapter;
            this.tableAdapterManager.inventoryTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.product_categoryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = eBIT_Application.eBITDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = null;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(346, 264);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(100, 20);
            this.emailTextBox.TabIndex = 31;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(119, 261);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(100, 20);
            this.phoneTextBox.TabIndex = 29;
            // 
            // zipTextBox
            // 
            this.zipTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "zip", true));
            this.zipTextBox.Location = new System.Drawing.Point(119, 219);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(100, 20);
            this.zipTextBox.TabIndex = 27;
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "state", true));
            this.stateTextBox.Location = new System.Drawing.Point(401, 183);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(100, 20);
            this.stateTextBox.TabIndex = 25;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "city", true));
            this.cityTextBox.Location = new System.Drawing.Point(119, 183);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(221, 20);
            this.cityTextBox.TabIndex = 23;
            // 
            // address_line_2TextBox
            // 
            this.address_line_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "address_line_2", true));
            this.address_line_2TextBox.Location = new System.Drawing.Point(119, 157);
            this.address_line_2TextBox.Name = "address_line_2TextBox";
            this.address_line_2TextBox.Size = new System.Drawing.Size(346, 20);
            this.address_line_2TextBox.TabIndex = 21;
            // 
            // address_line_1TextBox
            // 
            this.address_line_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "address_line_1", true));
            this.address_line_1TextBox.Location = new System.Drawing.Point(119, 128);
            this.address_line_1TextBox.Name = "address_line_1TextBox";
            this.address_line_1TextBox.Size = new System.Drawing.Size(346, 20);
            this.address_line_1TextBox.TabIndex = 19;
            // 
            // ebay_usernameTextBox
            // 
            this.ebay_usernameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "ebay_username", true));
            this.ebay_usernameTextBox.Location = new System.Drawing.Point(119, 78);
            this.ebay_usernameTextBox.Name = "ebay_usernameTextBox";
            this.ebay_usernameTextBox.Size = new System.Drawing.Size(158, 20);
            this.ebay_usernameTextBox.TabIndex = 17;
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "last_name", true));
            this.last_nameTextBox.Location = new System.Drawing.Point(323, 31);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(221, 20);
            this.last_nameTextBox.TabIndex = 15;
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource1, "first_name", true));
            this.first_nameTextBox.Location = new System.Drawing.Point(77, 31);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(167, 20);
            this.first_nameTextBox.TabIndex = 13;
            // 
            // AddCustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 409);
            this.Controls.Add(first_nameLabel);
            this.Controls.Add(this.first_nameTextBox);
            this.Controls.Add(last_nameLabel);
            this.Controls.Add(this.last_nameTextBox);
            this.Controls.Add(ebay_usernameLabel);
            this.Controls.Add(this.ebay_usernameTextBox);
            this.Controls.Add(address_line_1Label);
            this.Controls.Add(this.address_line_1TextBox);
            this.Controls.Add(address_line_2Label);
            this.Controls.Add(this.address_line_2TextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(zipLabel);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(this.btnAddCust);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AddCustomerForm";
            this.Text = "Add a New Customer";
            this.Load += new System.EventHandler(this.AddCustomerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAddCust;
        private eBIT_Application.eBITDataSet eBITDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource1;
        private eBIT_Application.eBITDataSetTableAdapters.customersTableAdapter customersTableAdapter;
        private eBIT_Application.eBITDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox address_line_2TextBox;
        private System.Windows.Forms.TextBox address_line_1TextBox;
        private System.Windows.Forms.TextBox ebay_usernameTextBox;
        private System.Windows.Forms.TextBox last_nameTextBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
    }
}