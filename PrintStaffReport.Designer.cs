namespace PindahFrame
{
    partial class PrintStaffReport
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource3 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.PindahFrameDataSet = new PindahFrame.PindahFrameDataSet();
            this.school_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.school_detailsTableAdapter = new PindahFrame.PindahFrameDataSetTableAdapters.school_detailsTableAdapter();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new PindahFrame.PindahFrameDataSetTableAdapters.staffTableAdapter();
            this.imageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageTableAdapter = new PindahFrame.PindahFrameDataSetTableAdapters.imageTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.PindahFrameDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "Schoolset";
            reportDataSource1.Value = this.school_detailsBindingSource;
            reportDataSource2.Name = "StaffSet";
            reportDataSource2.Value = this.staffBindingSource;
            reportDataSource3.Name = "SchoolmageSet";
            reportDataSource3.Value = this.imageBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PindahFrame.StaffReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.reportViewer1.Size = new System.Drawing.Size(994, 584);
            this.reportViewer1.TabIndex = 5;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // PindahFrameDataSet
            // 
            this.PindahFrameDataSet.DataSetName = "PindahFrameDataSet";
            this.PindahFrameDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // school_detailsBindingSource
            // 
            this.school_detailsBindingSource.DataMember = "school_details";
            this.school_detailsBindingSource.DataSource = this.PindahFrameDataSet;
            // 
            // school_detailsTableAdapter
            // 
            this.school_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "staff";
            this.staffBindingSource.DataSource = this.PindahFrameDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // imageBindingSource
            // 
            this.imageBindingSource.DataMember = "image";
            this.imageBindingSource.DataSource = this.PindahFrameDataSet;
            // 
            // imageTableAdapter
            // 
            this.imageTableAdapter.ClearBeforeFill = true;
            // 
            // PrintStaffReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(994, 584);
            this.Controls.Add(this.reportViewer1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.Name = "PrintStaffReport";
            this.Text = "PrintStaffReport";
            this.Load += new System.EventHandler(this.PrintStaffReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PindahFrameDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource school_detailsBindingSource;
        private PindahFrameDataSet PindahFrameDataSet;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private System.Windows.Forms.BindingSource imageBindingSource;
        private PindahFrameDataSetTableAdapters.school_detailsTableAdapter school_detailsTableAdapter;
        private PindahFrameDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private PindahFrameDataSetTableAdapters.imageTableAdapter imageTableAdapter;
    }
}