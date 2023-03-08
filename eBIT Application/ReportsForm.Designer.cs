namespace eBIT_Application
{
    partial class ReportsForm
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
            this.userreportbutton = new System.Windows.Forms.Button();
            this.inventoryreportbutton = new System.Windows.Forms.Button();
            this.orderreportbutton = new System.Windows.Forms.Button();
            this.customerreportbutton = new System.Windows.Forms.Button();
            this.productcategoryreportbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userreportbutton
            // 
            this.userreportbutton.Location = new System.Drawing.Point(50, 82);
            this.userreportbutton.Name = "userreportbutton";
            this.userreportbutton.Size = new System.Drawing.Size(133, 23);
            this.userreportbutton.TabIndex = 0;
            this.userreportbutton.Text = "User Report";
            this.userreportbutton.UseVisualStyleBackColor = true;
            this.userreportbutton.Click += new System.EventHandler(this.Userreportbutton_Click);
            // 
            // inventoryreportbutton
            // 
            this.inventoryreportbutton.Location = new System.Drawing.Point(50, 123);
            this.inventoryreportbutton.Name = "inventoryreportbutton";
            this.inventoryreportbutton.Size = new System.Drawing.Size(133, 23);
            this.inventoryreportbutton.TabIndex = 1;
            this.inventoryreportbutton.Text = "Inventory Report";
            this.inventoryreportbutton.UseVisualStyleBackColor = true;
            this.inventoryreportbutton.Click += new System.EventHandler(this.inventoryreportbutton_Click);
            // 
            // orderreportbutton
            // 
            this.orderreportbutton.Location = new System.Drawing.Point(50, 167);
            this.orderreportbutton.Name = "orderreportbutton";
            this.orderreportbutton.Size = new System.Drawing.Size(133, 23);
            this.orderreportbutton.TabIndex = 2;
            this.orderreportbutton.Text = "Order Report";
            this.orderreportbutton.UseVisualStyleBackColor = true;
            this.orderreportbutton.Click += new System.EventHandler(this.orderreportbutton_Click);
            // 
            // customerreportbutton
            // 
            this.customerreportbutton.Location = new System.Drawing.Point(50, 209);
            this.customerreportbutton.Name = "customerreportbutton";
            this.customerreportbutton.Size = new System.Drawing.Size(133, 23);
            this.customerreportbutton.TabIndex = 3;
            this.customerreportbutton.Text = "Customer Report";
            this.customerreportbutton.UseVisualStyleBackColor = true;
            this.customerreportbutton.Click += new System.EventHandler(this.customerreportbutton_Click);
            // 
            // productcategoryreportbutton
            // 
            this.productcategoryreportbutton.Location = new System.Drawing.Point(50, 250);
            this.productcategoryreportbutton.Name = "productcategoryreportbutton";
            this.productcategoryreportbutton.Size = new System.Drawing.Size(133, 23);
            this.productcategoryreportbutton.TabIndex = 4;
            this.productcategoryreportbutton.Text = "Product Category Report";
            this.productcategoryreportbutton.UseVisualStyleBackColor = true;
            this.productcategoryreportbutton.Click += new System.EventHandler(this.productcategoryreportbutton_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 450);
            this.Controls.Add(this.productcategoryreportbutton);
            this.Controls.Add(this.customerreportbutton);
            this.Controls.Add(this.orderreportbutton);
            this.Controls.Add(this.inventoryreportbutton);
            this.Controls.Add(this.userreportbutton);
            this.Name = "ReportsForm";
            this.Text = "ReportsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button userreportbutton;
        private System.Windows.Forms.Button inventoryreportbutton;
        private System.Windows.Forms.Button orderreportbutton;
        private System.Windows.Forms.Button customerreportbutton;
        private System.Windows.Forms.Button productcategoryreportbutton;
    }
}