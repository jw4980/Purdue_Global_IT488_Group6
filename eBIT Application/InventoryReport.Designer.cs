namespace eBIT_Application
{
    partial class InventoryReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.inventoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eBITDataSet = new eBIT_Application.eBITDataSet();
            this.InventoryReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.inventoryTableAdapter = new eBIT_Application.eBITDataSetTableAdapters.inventoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // inventoryBindingSource
            // 
            this.inventoryBindingSource.DataMember = "inventory";
            this.inventoryBindingSource.DataSource = this.eBITDataSet;
            // 
            // eBITDataSet
            // 
            this.eBITDataSet.DataSetName = "eBITDataSet";
            this.eBITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // InventoryReportViewer
            // 
            this.InventoryReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource2.Name = "InventoryReport";
            reportDataSource2.Value = this.inventoryBindingSource;
            this.InventoryReportViewer.LocalReport.DataSources.Add(reportDataSource2);
            this.InventoryReportViewer.LocalReport.ReportEmbeddedResource = "eBIT_Application.InventoryReport.rdlc";
            this.InventoryReportViewer.Location = new System.Drawing.Point(0, 0);
            this.InventoryReportViewer.Name = "InventoryReportViewer";
            this.InventoryReportViewer.ServerReport.BearerToken = null;
            this.InventoryReportViewer.Size = new System.Drawing.Size(800, 450);
            this.InventoryReportViewer.TabIndex = 0;
            this.InventoryReportViewer.Load += new System.EventHandler(this.InventoryReportForm_Load);
            // 
            // inventoryTableAdapter
            // 
            this.inventoryTableAdapter.ClearBeforeFill = true;
            // 
            // InventoryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.InventoryReportViewer);
            this.Name = "InventoryReport";
            this.Text = "Inventory Report Form";
            this.Load += new System.EventHandler(this.InventoryReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inventoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer InventoryReportViewer;
        private eBITDataSet eBITDataSet;
        private System.Windows.Forms.BindingSource inventoryBindingSource;
        private eBITDataSetTableAdapters.inventoryTableAdapter inventoryTableAdapter;
    }
}