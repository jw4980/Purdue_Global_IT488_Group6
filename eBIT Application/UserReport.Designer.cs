namespace eBIT_Application
{
    partial class UserReportForm
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
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eBITDataSet = new eBIT_Application.eBITDataSet();
            this.UserReportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.usersTableAdapter = new eBIT_Application.eBITDataSetTableAdapters.usersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.eBITDataSet;
            // 
            // eBITDataSet
            // 
            this.eBITDataSet.DataSetName = "eBITDataSet";
            this.eBITDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // UserReportViewer
            // 
            this.UserReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "UserReport";
            reportDataSource1.Value = this.usersBindingSource;
            this.UserReportViewer.LocalReport.DataSources.Add(reportDataSource1);
            this.UserReportViewer.LocalReport.ReportEmbeddedResource = "eBIT_Application.UserReport.rdlc";
            this.UserReportViewer.Location = new System.Drawing.Point(0, 0);
            this.UserReportViewer.Name = "UserReportViewer";
            this.UserReportViewer.ServerReport.BearerToken = null;
            this.UserReportViewer.Size = new System.Drawing.Size(800, 450);
            this.UserReportViewer.TabIndex = 0;
            this.UserReportViewer.Load += new System.EventHandler(this.UserReportForm_Load);
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // UserReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.UserReportViewer);
            this.Name = "UserReportForm";
            this.Text = "User Report";
            this.Load += new System.EventHandler(this.UserReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eBITDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer UserReportViewer;
        private eBITDataSet eBITDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private eBITDataSetTableAdapters.usersTableAdapter usersTableAdapter;
    }
}