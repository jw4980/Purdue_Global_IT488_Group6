namespace eBIT_Application
{
    partial class AddUser
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
            System.Windows.Forms.Label user_nameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label first_nameLabel;
            System.Windows.Forms.Label last_nameLabel;
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.eBITDataSet = new eBIT_Application.eBITDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new eBIT_Application.eBITDataSetTableAdapters.usersTableAdapter();
            this.tableAdapterManager = new eBIT_Application.eBITDataSetTableAdapters.TableAdapterManager();
            this.user_nameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.first_nameTextBox = new System.Windows.Forms.TextBox();
            this.last_nameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSubmit = new System.Windows.Forms.Button();
            user_nameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            first_nameLabel = new System.Windows.Forms.Label();
            last_nameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(712, 65);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonSubmit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 301);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(712, 63);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(user_nameLabel);
            this.panel3.Controls.Add(this.user_nameTextBox);
            this.panel3.Controls.Add(emailLabel);
            this.panel3.Controls.Add(this.emailTextBox);
            this.panel3.Controls.Add(passwordLabel);
            this.panel3.Controls.Add(this.passwordTextBox);
            this.panel3.Controls.Add(first_nameLabel);
            this.panel3.Controls.Add(this.first_nameTextBox);
            this.panel3.Controls.Add(last_nameLabel);
            this.panel3.Controls.Add(this.last_nameTextBox);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(712, 236);
            this.panel3.TabIndex = 2;
            // 
            // eBITDataSet
            // 
            this.eBITDataSet.DataSetName = "eBITDataSet";
            this.eBITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.eBITDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.customer_addressTableAdapter = null;
            this.tableAdapterManager.customer_contactTableAdapter = null;
            this.tableAdapterManager.customersTableAdapter = null;
            this.tableAdapterManager.inventoryTableAdapter = null;
            this.tableAdapterManager.ordersTableAdapter = null;
            this.tableAdapterManager.product_categoryTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = eBIT_Application.eBITDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
            // 
            // user_nameLabel
            // 
            user_nameLabel.AutoSize = true;
            user_nameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            user_nameLabel.Location = new System.Drawing.Point(96, 157);
            user_nameLabel.Name = "user_nameLabel";
            user_nameLabel.Size = new System.Drawing.Size(123, 23);
            user_nameLabel.TabIndex = 2;
            user_nameLabel.Text = "User Name:";
            // 
            // user_nameTextBox
            // 
            this.user_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "user_name", true));
            this.user_nameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_nameTextBox.Location = new System.Drawing.Point(227, 154);
            this.user_nameTextBox.Name = "user_nameTextBox";
            this.user_nameTextBox.Size = new System.Drawing.Size(295, 32);
            this.user_nameTextBox.TabIndex = 3;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(151, 113);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(68, 23);
            emailLabel.TabIndex = 4;
            emailLabel.Text = "Email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "email", true));
            this.emailTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailTextBox.Location = new System.Drawing.Point(227, 110);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(295, 32);
            this.emailTextBox.TabIndex = 5;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            passwordLabel.Location = new System.Drawing.Point(113, 201);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(106, 23);
            passwordLabel.TabIndex = 6;
            passwordLabel.Text = "Password:";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "password", true));
            this.passwordTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.Location = new System.Drawing.Point(227, 198);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(295, 32);
            this.passwordTextBox.TabIndex = 7;
            // 
            // first_nameLabel
            // 
            first_nameLabel.AutoSize = true;
            first_nameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            first_nameLabel.Location = new System.Drawing.Point(101, 23);
            first_nameLabel.Name = "first_nameLabel";
            first_nameLabel.Size = new System.Drawing.Size(118, 23);
            first_nameLabel.TabIndex = 8;
            first_nameLabel.Text = "First Name:";
            // 
            // first_nameTextBox
            // 
            this.first_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "first_name", true));
            this.first_nameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.first_nameTextBox.Location = new System.Drawing.Point(227, 20);
            this.first_nameTextBox.Name = "first_nameTextBox";
            this.first_nameTextBox.Size = new System.Drawing.Size(295, 32);
            this.first_nameTextBox.TabIndex = 9;
            // 
            // last_nameLabel
            // 
            last_nameLabel.AutoSize = true;
            last_nameLabel.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            last_nameLabel.Location = new System.Drawing.Point(100, 72);
            last_nameLabel.Name = "last_nameLabel";
            last_nameLabel.Size = new System.Drawing.Size(119, 23);
            last_nameLabel.TabIndex = 10;
            last_nameLabel.Text = "Last Name:";
            // 
            // last_nameTextBox
            // 
            this.last_nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usersBindingSource, "last_name", true));
            this.last_nameTextBox.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.last_nameTextBox.Location = new System.Drawing.Point(227, 69);
            this.last_nameTextBox.Name = "last_nameTextBox";
            this.last_nameTextBox.Size = new System.Drawing.Size(295, 32);
            this.last_nameTextBox.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(82, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(570, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter User Information Below";
            // 
            // buttonSubmit
            // 
            this.buttonSubmit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.buttonSubmit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.buttonSubmit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.buttonSubmit.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSubmit.Location = new System.Drawing.Point(293, 6);
            this.buttonSubmit.Name = "buttonSubmit";
            this.buttonSubmit.Size = new System.Drawing.Size(134, 49);
            this.buttonSubmit.TabIndex = 0;
            this.buttonSubmit.Text = "Submit";
            this.buttonSubmit.UseVisualStyleBackColor = true;
            this.buttonSubmit.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 364);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add User";
            this.Load += new System.EventHandler(this.AddUser_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private eBITDataSet eBITDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private eBITDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private eBITDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSubmit;
        private System.Windows.Forms.TextBox user_nameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox first_nameTextBox;
        private System.Windows.Forms.TextBox last_nameTextBox;
    }
}