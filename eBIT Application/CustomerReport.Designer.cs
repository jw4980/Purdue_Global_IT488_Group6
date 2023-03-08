namespace eBIT_Application
{
    partial class CustomerReportForm
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
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eBITDataSet = new eBIT_Application.eBITDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.CustomerReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.customersTableAdapter = new eBIT_Application.eBITDataSetTableAdapters.customersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // customersBindingSource
            // 
            this.customersBindingSource.DataMember = "customers";
            this.customersBindingSource.DataSource = this.eBITDataSet;
            // 
            // eBITDataSet
            // 
            this.eBITDataSet.DataSetName = "eBITDataSet";
            this.eBITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "eBIT_Application.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(396, 246);
            this.reportViewer1.TabIndex = 0;
            // 
            // CustomerReportViewer
            // 
            this.CustomerReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "CustomerReport";
            reportDataSource1.Value = this.customersBindingSource;
            this.CustomerReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.CustomerReportViewer.LocalReport.ReportEmbeddedResource = "eBIT_Application.CustomerReport.rdlc";
            this.CustomerReportViewer.Location = new System.Drawing.Point(0, 0);
            this.CustomerReportViewer.Name = "CustomerReportViewer";
            this.CustomerReportViewer.ServerReport.BearerToken = null;
            this.CustomerReportViewer.Size = new System.Drawing.Size(800, 450);
            this.CustomerReportViewer.TabIndex = 1;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // CustomerReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CustomerReportViewer);
            this.Controls.Add(this.reportViewer1);
            this.Name = "CustomerReportForm";
            this.Text = "CustomerReportForm";
            this.Load += new System.EventHandler(this.CustomerReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Microsoft.Reporting.WinForms.ReportViewer CustomerReportViewer;
        private eBITDataSet eBITDataSet;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private eBITDataSetTableAdapters.customersTableAdapter customersTableAdapter;
    }
}