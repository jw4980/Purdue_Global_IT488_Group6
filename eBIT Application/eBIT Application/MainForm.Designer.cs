namespace eBIT_Application
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelMain = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnUsers = new System.Windows.Forms.PictureBox();
            this.btnCategories = new System.Windows.Forms.PictureBox();
            this.btnReports = new System.Windows.Forms.PictureBox();
            this.btnCustomers = new System.Windows.Forms.PictureBox();
            this.btnOrders = new System.Windows.Forms.PictureBox();
            this.btnInventory = new System.Windows.Forms.PictureBox();
            this.panelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReports)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrders)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 485);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(607, 19);
            this.panel1.TabIndex = 0;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.SteelBlue;
            this.panelMain.Controls.Add(this.btnUsers);
            this.panelMain.Controls.Add(this.btnCategories);
            this.panelMain.Controls.Add(this.btnReports);
            this.panelMain.Controls.Add(this.btnCustomers);
            this.panelMain.Controls.Add(this.btnOrders);
            this.panelMain.Controls.Add(this.btnInventory);
            this.panelMain.Controls.Add(this.label7);
            this.panelMain.Controls.Add(this.label6);
            this.panelMain.Controls.Add(this.label5);
            this.panelMain.Controls.Add(this.label4);
            this.panelMain.Controls.Add(this.label3);
            this.panelMain.Controls.Add(this.label2);
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(607, 64);
            this.panelMain.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "eBIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(103, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(169, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Orders";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Customers";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(424, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Users";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(352, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Categories";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(293, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Reports";
            // 
            // btnUsers
            // 
            this.btnUsers.Image = global::eBIT_Application.Properties.Resources.icons8_user_30;
            this.btnUsers.Location = new System.Drawing.Point(431, 6);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Size = new System.Drawing.Size(20, 26);
            this.btnUsers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnUsers.TabIndex = 12;
            this.btnUsers.TabStop = false;
            // 
            // btnCategories
            // 
            this.btnCategories.Image = global::eBIT_Application.Properties.Resources.icons8_docket_64;
            this.btnCategories.Location = new System.Drawing.Point(370, 6);
            this.btnCategories.Name = "btnCategories";
            this.btnCategories.Size = new System.Drawing.Size(20, 26);
            this.btnCategories.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCategories.TabIndex = 11;
            this.btnCategories.TabStop = false;
            // 
            // btnReports
            // 
            this.btnReports.Image = global::eBIT_Application.Properties.Resources.icons8_reports_50;
            this.btnReports.Location = new System.Drawing.Point(305, 6);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(20, 26);
            this.btnReports.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnReports.TabIndex = 10;
            this.btnReports.TabStop = false;
            // 
            // btnCustomers
            // 
            this.btnCustomers.Image = global::eBIT_Application.Properties.Resources.icons8_people_48;
            this.btnCustomers.Location = new System.Drawing.Point(240, 6);
            this.btnCustomers.Name = "btnCustomers";
            this.btnCustomers.Size = new System.Drawing.Size(20, 26);
            this.btnCustomers.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCustomers.TabIndex = 9;
            this.btnCustomers.TabStop = false;
            // 
            // btnOrders
            // 
            this.btnOrders.Image = global::eBIT_Application.Properties.Resources.icons8_shopping_cart_30;
            this.btnOrders.Location = new System.Drawing.Point(178, 6);
            this.btnOrders.Name = "btnOrders";
            this.btnOrders.Size = new System.Drawing.Size(20, 26);
            this.btnOrders.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnOrders.TabIndex = 8;
            this.btnOrders.TabStop = false;
            // 
            // btnInventory
            // 
            this.btnInventory.Image = global::eBIT_Application.Properties.Resources.icons8_package_delivery_logistics_24;
            this.btnInventory.Location = new System.Drawing.Point(118, 6);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(20, 26);
            this.btnInventory.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnInventory.TabIndex = 7;
            this.btnInventory.TabStop = false;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 504);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panelMain.ResumeLayout(false);
            this.panelMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnReports)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnOrders)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btnUsers;
        private System.Windows.Forms.PictureBox btnCategories;
        private System.Windows.Forms.PictureBox btnReports;
        private System.Windows.Forms.PictureBox btnCustomers;
        private System.Windows.Forms.PictureBox btnOrders;
        private System.Windows.Forms.PictureBox btnInventory;
    }
}