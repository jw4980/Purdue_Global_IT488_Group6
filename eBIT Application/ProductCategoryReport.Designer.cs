namespace eBIT_Application
{
    partial class ProductCategoryReportForm
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
            this.productcategoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eBITDataSet = new eBIT_Application.eBITDataSet();
            this.ProductCategoryReport = new Microsoft.Reporting.WinForms.ReportViewer();
            this.product_categoryTableAdapter = new eBIT_Application.eBITDataSetTableAdapters.product_categoryTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.productcategoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // productcategoryBindingSource
            // 
            this.productcategoryBindingSource.DataMember = "product_category";
            this.productcategoryBindingSource.DataSource = this.eBITDataSet;
            // 
            // eBITDataSet
            // 
            this.eBITDataSet.DataSetName = "eBITDataSet";
            this.eBITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ProductCategoryReport
            // 
            this.ProductCategoryReport.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "ProductCategoryReport";
            reportDataSource1.Value = this.productcategoryBindingSource;
            this.ProductCategoryReport.LocalReport.DataSources.Add(reportDataSource1);
            this.ProductCategoryReport.LocalReport.ReportEmbeddedResource = "eBIT_Application.ProductCategoryReport.rdlc";
            this.ProductCategoryReport.Location = new System.Drawing.Point(0, 0);
            this.ProductCategoryReport.Name = "ProductCategoryReport";
            this.ProductCategoryReport.ServerReport.BearerToken = null;
            this.ProductCategoryReport.Size = new System.Drawing.Size(800, 450);
            this.ProductCategoryReport.TabIndex = 0;
            this.ProductCategoryReport.Load += new System.EventHandler(this.ProductCategoryReportForm_Load);
            // 
            // product_categoryTableAdapter
            // 
            this.product_categoryTableAdapter.ClearBeforeFill = true;
            // 
            // ProductCategoryReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ProductCategoryReport);
            this.Name = "ProductCategoryReportForm";
            this.Text = "Product Category Report Form";
            this.Load += new System.EventHandler(this.ProductCategoryReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productcategoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer ProductCategoryReport;
        private eBITDataSet eBITDataSet;
        private System.Windows.Forms.BindingSource productcategoryBindingSource;
        private eBITDataSetTableAdapters.product_categoryTableAdapter product_categoryTableAdapter;
    }
}