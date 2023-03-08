namespace eBIT_Application
{
    partial class OrderReportForm
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eBITDataSet = new eBIT_Application.eBITDataSet();
            this.OrderReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.ordersTableAdapter = new eBIT_Application.eBITDataSetTableAdapters.ordersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "orders";
            this.ordersBindingSource.DataSource = this.eBITDataSet;
            // 
            // eBITDataSet
            // 
            this.eBITDataSet.DataSetName = "eBITDataSet";
            this.eBITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // OrderReportViewer
            // 
            this.OrderReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "OrdersReport";
            reportDataSource1.Value = this.ordersBindingSource;
            this.OrderReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.OrderReportViewer.LocalReport.ReportEmbeddedResource = "eBIT_Application.OrderReport.rdlc";
            this.OrderReportViewer.Location = new System.Drawing.Point(0, 0);
            this.OrderReportViewer.Name = "OrderReportViewer";
            this.OrderReportViewer.ServerReport.BearerToken = null;
            this.OrderReportViewer.Size = new System.Drawing.Size(800, 450);
            this.OrderReportViewer.TabIndex = 0;
            this.OrderReportViewer.Load += new System.EventHandler(this.OrderReportForm_Load);
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // OrderReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OrderReportViewer);
            this.Name = "OrderReportForm";
            this.Text = "Order Report Form";
            this.Load += new System.EventHandler(this.OrderReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer OrderReportViewer;
        private eBITDataSet eBITDataSet;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private eBITDataSetTableAdapters.ordersTableAdapter ordersTableAdapter;
    }
}