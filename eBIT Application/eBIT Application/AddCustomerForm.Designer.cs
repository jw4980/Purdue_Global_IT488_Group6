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
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.ebayUserBox = new System.Windows.Forms.TextBox();
            this.address1Box = new System.Windows.Forms.TextBox();
            this.address2Box = new System.Windows.Forms.TextBox();
            this.cityBox = new System.Windows.Forms.TextBox();
            this.zipBox = new System.Windows.Forms.TextBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.btnAddCust = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.eBITCustomerDataSet = new eBIT_Customers.eBITCustomerDataSet();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersTableAdapter = new eBIT_Customers.eBITCustomerDataSetTableAdapters.customersTableAdapter();
            this.customeraddressBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_addressTableAdapter = new eBIT_Customers.eBITCustomerDataSetTableAdapters.customer_addressTableAdapter();
            this.customercontactBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customer_contactTableAdapter = new eBIT_Customers.eBITCustomerDataSetTableAdapters.customer_contactTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.eBITCustomerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customeraddressBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customercontactBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameBox
            // 
            this.firstNameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "first_name", true));
            this.firstNameBox.Location = new System.Drawing.Point(160, 50);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(148, 22);
            this.firstNameBox.TabIndex = 0;
            // 
            // lastNameBox
            // 
            this.lastNameBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "last_name", true));
            this.lastNameBox.Location = new System.Drawing.Point(502, 50);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(148, 22);
            this.lastNameBox.TabIndex = 1;
            // 
            // ebayUserBox
            // 
            this.ebayUserBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customersBindingSource, "ebay_username", true));
            this.ebayUserBox.Location = new System.Drawing.Point(160, 99);
            this.ebayUserBox.Name = "ebayUserBox";
            this.ebayUserBox.Size = new System.Drawing.Size(148, 22);
            this.ebayUserBox.TabIndex = 2;
            // 
            // address1Box
            // 
            this.address1Box.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customeraddressBindingSource, "address_line_1", true));
            this.address1Box.Location = new System.Drawing.Point(160, 153);
            this.address1Box.Name = "address1Box";
            this.address1Box.Size = new System.Drawing.Size(490, 22);
            this.address1Box.TabIndex = 3;
            // 
            // address2Box
            // 
            this.address2Box.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customeraddressBindingSource, "address_line_2", true));
            this.address2Box.Location = new System.Drawing.Point(160, 204);
            this.address2Box.Name = "address2Box";
            this.address2Box.Size = new System.Drawing.Size(490, 22);
            this.address2Box.TabIndex = 4;
            // 
            // cityBox
            // 
            this.cityBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customeraddressBindingSource, "city", true));
            this.cityBox.Location = new System.Drawing.Point(160, 254);
            this.cityBox.Name = "cityBox";
            this.cityBox.Size = new System.Drawing.Size(148, 22);
            this.cityBox.TabIndex = 5;
            // 
            // zipBox
            // 
            this.zipBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customeraddressBindingSource, "zip", true));
            this.zipBox.Location = new System.Drawing.Point(550, 254);
            this.zipBox.Name = "zipBox";
            this.zipBox.Size = new System.Drawing.Size(100, 22);
            this.zipBox.TabIndex = 7;
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "",
            "AL",
            "AK",
            "AZ",
            "AR",
            "CA",
            "CO",
            "CT",
            "DE",
            "FL",
            "GA",
            "HI",
            "ID",
            "IL",
            "IN",
            "IA",
            "KS",
            "KY",
            "LA",
            "ME",
            "MD",
            "MA",
            "MI",
            "MN",
            "MS",
            "MO",
            "MT",
            "NE",
            "NV",
            "NH",
            "NJ",
            "NM",
            "NY",
            "NC",
            "ND",
            "OH",
            "OK",
            "OR",
            "PA",
            "RI",
            "SC",
            "SD",
            "TN",
            "TX",
            "UT",
            "VT",
            "VA",
            "WA",
            "WV",
            "WI",
            "WY"});
            this.stateComboBox.Location = new System.Drawing.Point(427, 254);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(47, 24);
            this.stateComboBox.TabIndex = 6;
            // 
            // emailBox
            // 
            this.emailBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customercontactBindingSource, "email", true));
            this.emailBox.Location = new System.Drawing.Point(160, 303);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(148, 22);
            this.emailBox.TabIndex = 8;
            // 
            // phoneBox
            // 
            this.phoneBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customercontactBindingSource, "phone", true));
            this.phoneBox.Location = new System.Drawing.Point(502, 303);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(148, 22);
            this.phoneBox.TabIndex = 9;
            // 
            // btnAddCust
            // 
            this.btnAddCust.Location = new System.Drawing.Point(353, 376);
            this.btnAddCust.Name = "btnAddCust";
            this.btnAddCust.Size = new System.Drawing.Size(100, 23);
            this.btnAddCust.TabIndex = 10;
            this.btnAddCust.Text = "Add";
            this.btnAddCust.UseVisualStyleBackColor = true;
            this.btnAddCust.Click += new System.EventHandler(this.btnAddCust_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 11;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(424, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 12;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 16);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ebay Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 16);
            this.label4.TabIndex = 14;
            this.label4.Text = "Address Line 1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 15;
            this.label5.Text = "Address Line 2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(125, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 16);
            this.label6.TabIndex = 16;
            this.label6.Text = "City";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(383, 254);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 16);
            this.label7.TabIndex = 17;
            this.label7.Text = "State";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(518, 254);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 16);
            this.label8.TabIndex = 18;
            this.label8.Text = "Zip";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(113, 302);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 16);
            this.label9.TabIndex = 19;
            this.label9.Text = "Email";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(445, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 16);
            this.label10.TabIndex = 20;
            this.label10.Text = "Phone";
            // 
            // eBITCustomerDataSet
            // 
            this.eBITCustomerDataSet.DataSetName = "eBITCustomerDataSet";
            this.eBITCustomerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "customers";
            this.customersBindingSource.DataSource = this.eBITCustomerDataSet;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // customeraddressBindingSource
            // 
            this.customeraddressBindingSource.DataMember = "customer_address";
            this.customeraddressBindingSource.DataSource = this.eBITCustomerDataSet;
            // 
            // customer_addressTableAdapter
            // 
            this.customer_addressTableAdapter.ClearBeforeFill = true;
            // 
            // customercontactBindingSource
            // 
            this.customercontactBindingSource.DataMember = "customer_contact";
            this.customercontactBindingSource.DataSource = this.eBITCustomerDataSet;
            // 
            // customer_contactTableAdapter
            // 
            this.customer_contactTableAdapter.ClearBeforeFill = true;
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddCust);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.zipBox);
            this.Controls.Add(this.cityBox);
            this.Controls.Add(this.address2Box);
            this.Controls.Add(this.address1Box);
            this.Controls.Add(this.ebayUserBox);
            this.Controls.Add(this.lastNameBox);
            this.Controls.Add(this.firstNameBox);
            this.Name = "AddCustomer";
            this.Text = "Add a New Customer";
            this.Load += new System.EventHandler(this.AddCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eBITCustomerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customeraddressBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customercontactBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox ebayUserBox;
        private System.Windows.Forms.TextBox address1Box;
        private System.Windows.Forms.TextBox address2Box;
        private System.Windows.Forms.TextBox cityBox;
        private System.Windows.Forms.TextBox zipBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Button btnAddCust;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private eBITCustomerDataSet eBITCustomerDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private eBITCustomerDataSetTableAdapters.customersTableAdapter customersTableAdapter;
        private System.Windows.Forms.BindingSource customeraddressBindingSource;
        private eBITCustomerDataSetTableAdapters.customer_addressTableAdapter customer_addressTableAdapter;
        private System.Windows.Forms.BindingSource customercontactBindingSource;
        private eBITCustomerDataSetTableAdapters.customer_contactTableAdapter customer_contactTableAdapter;
    }
}