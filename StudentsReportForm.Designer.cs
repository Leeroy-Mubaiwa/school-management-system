namespace PindahFrame
{
    partial class StudentsReportForm
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
            this.school_diary_studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.PindahFrameDataSet = new PindahFrame.PindahFrameDataSet();
            this.schooldetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.imageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.customeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastupdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imagesDataGridViewImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.customersBindingSource = new System.Windows.Forms.BindingSource(this.components);
          
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
         
            this.school_diary_studentTableAdapter = new PindahFrame.PindahFrameDataSetTableAdapters.school_diary_studentTableAdapter();
            this.school_detailsTableAdapter = new PindahFrame.PindahFrameDataSetTableAdapters.school_detailsTableAdapter();
            this.imageTableAdapter = new PindahFrame.PindahFrameDataSetTableAdapters.imageTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnprintall = new System.Windows.Forms.Button();
            this.btnprintthis = new System.Windows.Forms.Button();
            this.classesComboBox = new System.Windows.Forms.ComboBox();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.level_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.level_tableComboBox = new System.Windows.Forms.ComboBox();
            this.level_tableTableAdapter = new PindahFrame.PindahFrameDataSetTableAdapters.level_tableTableAdapter();
            this.tableAdapterManager1 = new PindahFrame.PindahFrameDataSetTableAdapters.TableAdapterManager();
            this.classesTableAdapter = new PindahFrame.PindahFrameDataSetTableAdapters.classesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.school_diary_studentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PindahFrameDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schooldetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).BeginInit();
           // ((System.ComponentModel.ISupportInitialize)(this.wideOpenDataSet)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level_tableBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // school_diary_studentBindingSource
            // 
            this.school_diary_studentBindingSource.DataMember = "school_diary_student";
            this.school_diary_studentBindingSource.DataSource = this.PindahFrameDataSet;
            // 
            // PindahFrameDataSet
            // 
            this.PindahFrameDataSet.DataSetName = "PindahFrameDataSet";
            this.PindahFrameDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // schooldetailsBindingSource
            // 
            this.schooldetailsBindingSource.DataMember = "school_details";
            this.schooldetailsBindingSource.DataSource = this.PindahFrameDataSet;
            // 
            // imageBindingSource
            // 
            this.imageBindingSource.DataMember = "image";
            this.imageBindingSource.DataSource = this.PindahFrameDataSet;
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.AutoGenerateColumns = false;
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.customeridDataGridViewTextBoxColumn,
            this.storeidDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.addressidDataGridViewTextBoxColumn,
            this.activeDataGridViewTextBoxColumn,
            this.createdateDataGridViewTextBoxColumn,
            this.lastupdateDataGridViewTextBoxColumn,
            this.imagesDataGridViewImageColumn});
            this.customersDataGridView.DataSource = this.customersBindingSource;
            this.customersDataGridView.Location = new System.Drawing.Point(57, 282);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.Size = new System.Drawing.Size(300, 220);
            this.customersDataGridView.TabIndex = 3;
            // 
            // customeridDataGridViewTextBoxColumn
            // 
            this.customeridDataGridViewTextBoxColumn.DataPropertyName = "customer_id";
            this.customeridDataGridViewTextBoxColumn.HeaderText = "customer_id";
            this.customeridDataGridViewTextBoxColumn.Name = "customeridDataGridViewTextBoxColumn";
            // 
            // storeidDataGridViewTextBoxColumn
            // 
            this.storeidDataGridViewTextBoxColumn.DataPropertyName = "store_id";
            this.storeidDataGridViewTextBoxColumn.HeaderText = "store_id";
            this.storeidDataGridViewTextBoxColumn.Name = "storeidDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // addressidDataGridViewTextBoxColumn
            // 
            this.addressidDataGridViewTextBoxColumn.DataPropertyName = "address_id";
            this.addressidDataGridViewTextBoxColumn.HeaderText = "address_id";
            this.addressidDataGridViewTextBoxColumn.Name = "addressidDataGridViewTextBoxColumn";
            // 
            // activeDataGridViewTextBoxColumn
            // 
            this.activeDataGridViewTextBoxColumn.DataPropertyName = "active";
            this.activeDataGridViewTextBoxColumn.HeaderText = "active";
            this.activeDataGridViewTextBoxColumn.Name = "activeDataGridViewTextBoxColumn";
            // 
            // createdateDataGridViewTextBoxColumn
            // 
            this.createdateDataGridViewTextBoxColumn.DataPropertyName = "create_date";
            this.createdateDataGridViewTextBoxColumn.HeaderText = "create_date";
            this.createdateDataGridViewTextBoxColumn.Name = "createdateDataGridViewTextBoxColumn";
            // 
            // lastupdateDataGridViewTextBoxColumn
            // 
            this.lastupdateDataGridViewTextBoxColumn.DataPropertyName = "last_update";
            this.lastupdateDataGridViewTextBoxColumn.HeaderText = "last_update";
            this.lastupdateDataGridViewTextBoxColumn.Name = "lastupdateDataGridViewTextBoxColumn";
            // 
            // imagesDataGridViewImageColumn
            // 
            this.imagesDataGridViewImageColumn.DataPropertyName = "images";
            this.imagesDataGridViewImageColumn.HeaderText = "images";
            this.imagesDataGridViewImageColumn.Name = "imagesDataGridViewImageColumn";
            // 
           
           
            // tableAdapterManager
           
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.reportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "StudentsSet";
            reportDataSource1.Value = this.school_diary_studentBindingSource;
            reportDataSource2.Name = "SchoolSet";
            reportDataSource2.Value = this.schooldetailsBindingSource;
            reportDataSource3.Name = "SchoolImageSet";
            reportDataSource3.Value = this.imageBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource3);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PindahFrame.StudentReport.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 39);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.PageCountMode = Microsoft.Reporting.WinForms.PageCountMode.Actual;
            this.reportViewer1.Size = new System.Drawing.Size(994, 545);
            this.reportViewer1.TabIndex = 4;
            this.reportViewer1.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // TennisReservationSystemBindingSource
            // 
        //    this.TennisReservationSystemBindingSource.DataMember = "TennisReservationSystem";
        //    this.TennisReservationSystemBindingSource.DataSource = this.wideOpenDataSet;
            // 
            // TennisReservationSystemTableAdapter
            // 
        //    this.TennisReservationSystemTableAdapter.ClearBeforeFill = true;
            // 
            // school_diary_studentTableAdapter
            // 
            this.school_diary_studentTableAdapter.ClearBeforeFill = true;
            // 
            // school_detailsTableAdapter
            // 
            this.school_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // imageTableAdapter
            // 
            this.imageTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnprintall);
            this.panel1.Controls.Add(this.btnprintthis);
            this.panel1.Controls.Add(this.classesComboBox);
            this.panel1.Controls.Add(this.level_tableComboBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 39);
            this.panel1.TabIndex = 5;
            // 
            // btnprintall
            // 
            this.btnprintall.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnprintall.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnprintall.FlatAppearance.BorderSize = 0;
            this.btnprintall.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprintall.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnprintall.ForeColor = System.Drawing.Color.Black;
            this.btnprintall.Location = new System.Drawing.Point(866, 5);
            this.btnprintall.Name = "btnprintall";
            this.btnprintall.Size = new System.Drawing.Size(116, 25);
            this.btnprintall.TabIndex = 3;
            this.btnprintall.Text = "Show all data";
            this.btnprintall.UseVisualStyleBackColor = false;
            this.btnprintall.Visible = false;
            this.btnprintall.Click += new System.EventHandler(this.btnprintall_Click);
            // 
            // btnprintthis
            // 
            this.btnprintthis.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnprintthis.FlatAppearance.BorderSize = 0;
            this.btnprintthis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnprintthis.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnprintthis.ForeColor = System.Drawing.Color.Black;
            this.btnprintthis.Location = new System.Drawing.Point(642, 5);
            this.btnprintthis.Name = "btnprintthis";
            this.btnprintthis.Size = new System.Drawing.Size(97, 25);
            this.btnprintthis.TabIndex = 2;
            this.btnprintthis.Text = "Show this only";
            this.btnprintthis.UseVisualStyleBackColor = false;
            this.btnprintthis.Visible = false;
            this.btnprintthis.Click += new System.EventHandler(this.btnprintthis_Click);
            // 
            // classesComboBox
            // 
            this.classesComboBox.DataSource = this.classesBindingSource;
            this.classesComboBox.DisplayMember = "name";
            this.classesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classesComboBox.FormattingEnabled = true;
            this.classesComboBox.Location = new System.Drawing.Point(336, 5);
            this.classesComboBox.Name = "classesComboBox";
            this.classesComboBox.Size = new System.Drawing.Size(300, 25);
            this.classesComboBox.TabIndex = 1;
            this.classesComboBox.ValueMember = "id";
            this.classesComboBox.Visible = false;
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "FK_Classes_ToLevel_Table";
            this.classesBindingSource.DataSource = this.level_tableBindingSource;
            // 
            // level_tableBindingSource
            // 
            this.level_tableBindingSource.DataMember = "FK_Levels_ToSchool";
            this.level_tableBindingSource.DataSource = this.schooldetailsBindingSource;
            // 
            // level_tableComboBox
            // 
            this.level_tableComboBox.DataSource = this.level_tableBindingSource;
            this.level_tableComboBox.DisplayMember = "title";
            this.level_tableComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.level_tableComboBox.FormattingEnabled = true;
            this.level_tableComboBox.Location = new System.Drawing.Point(12, 5);
            this.level_tableComboBox.Name = "level_tableComboBox";
            this.level_tableComboBox.Size = new System.Drawing.Size(300, 25);
            this.level_tableComboBox.TabIndex = 0;
            this.level_tableComboBox.ValueMember = "id";
            this.level_tableComboBox.Visible = false;
            // 
            // level_tableTableAdapter
            // 
            this.level_tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.additionsTableAdapter = null;
            this.tableAdapterManager1.archievements_tableTableAdapter = null;
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.biographyTableAdapter = null;
            this.tableAdapterManager1.BooksTableAdapter = null;
            this.tableAdapterManager1.BorrowTableAdapter = null;
            this.tableAdapterManager1.classesTableAdapter = this.classesTableAdapter;
            this.tableAdapterManager1.contact_detailsTableAdapter = null;
            this.tableAdapterManager1.countryTableAdapter = null;
            this.tableAdapterManager1.criminal_offenses_tableTableAdapter = null;
            this.tableAdapterManager1.deductionsTableAdapter = null;
            this.tableAdapterManager1.deletedstuffTableAdapter = null;
            this.tableAdapterManager1.exam_type_tableTableAdapter = null;
            this.tableAdapterManager1.feesTableAdapter = null;
            this.tableAdapterManager1.financesTableAdapter = null;
            this.tableAdapterManager1.financial_processesTableAdapter = null;
            this.tableAdapterManager1.galleryTableAdapter = null;
            this.tableAdapterManager1.home_detailsTableAdapter = null;
            this.tableAdapterManager1.imageTableAdapter = this.imageTableAdapter;
            this.tableAdapterManager1.ipadressesTableAdapter = null;
            this.tableAdapterManager1.lessons_has_school_diary_studentTableAdapter = null;
            this.tableAdapterManager1.lessonsTableAdapter = null;
            this.tableAdapterManager1.level_tableTableAdapter = this.level_tableTableAdapter;
            this.tableAdapterManager1.messagesTableAdapter = null;
            this.tableAdapterManager1.mischief_tableTableAdapter = null;
            this.tableAdapterManager1.Other_FeesTableAdapter = null;
            this.tableAdapterManager1.past_results_tableTableAdapter = null;
            this.tableAdapterManager1.payrollTableAdapter = null;
            this.tableAdapterManager1.possessions_tableTableAdapter = null;
            this.tableAdapterManager1.preferences_tableTableAdapter = null;
            this.tableAdapterManager1.problemsetsTableAdapter = null;
            this.tableAdapterManager1.recommendationsTableAdapter = null;
            this.tableAdapterManager1.school_detailsTableAdapter = this.school_detailsTableAdapter;
            this.tableAdapterManager1.school_diary_studentTableAdapter = this.school_diary_studentTableAdapter;
            this.tableAdapterManager1.school_historyTableAdapter = null;
            this.tableAdapterManager1.school_shop_table_has_school_diary_studentTableAdapter = null;
            this.tableAdapterManager1.school_shop_tableTableAdapter = null;
            this.tableAdapterManager1.security_detailsTableAdapter = null;
            this.tableAdapterManager1.social_networksTableAdapter = null;
            this.tableAdapterManager1.staff_has_lessonsTableAdapter = null;
            this.tableAdapterManager1.staff_hassubjectsTableAdapter = null;
            this.tableAdapterManager1.staffTableAdapter = null;
            this.tableAdapterManager1.stock_brandTableAdapter = null;
            this.tableAdapterManager1.stock_item_categoryTableAdapter = null;
            this.tableAdapterManager1.stock_itemgroupTableAdapter = null;
            this.tableAdapterManager1.stock_productTableAdapter = null;
            this.tableAdapterManager1.stock_purchase_order_lineTableAdapter = null;
            this.tableAdapterManager1.stock_siteTableAdapter = null;
            this.tableAdapterManager1.stock_supplierTableAdapter = null;
            this.tableAdapterManager1.stock_warehouseTableAdapter = null;
            this.tableAdapterManager1.student_hassubjectTableAdapter = null;
            this.tableAdapterManager1.subjectsTableAdapter = null;
            this.tableAdapterManager1.teacher_s_childrenTableAdapter = null;
            this.tableAdapterManager1.Total_feesTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = PindahFrame.PindahFrameDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // StudentsReportForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(994, 584);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.customersDataGridView);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.Name = "StudentsReportForm";
            this.Text = "StudentsReportForm";
            this.Load += new System.EventHandler(this.StudentsReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.school_diary_studentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PindahFrameDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schooldetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customersBindingSource)).EndInit();
            //((System.ComponentModel.ISupportInitialize)(this.wideOpenDataSet)).EndInit();
              this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level_tableBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView customersDataGridView;
       
        private System.Windows.Forms.BindingSource customersBindingSource;
       
        private System.Windows.Forms.DataGridViewTextBoxColumn customeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn activeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastupdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewImageColumn imagesDataGridViewImageColumn;
        private System.Windows.Forms.Timer timer1;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TennisReservationSystemBindingSource;
        private System.Windows.Forms.BindingSource school_diary_studentBindingSource;
        private PindahFrameDataSet PindahFrameDataSet;
       
        private PindahFrameDataSetTableAdapters.school_diary_studentTableAdapter school_diary_studentTableAdapter;
        private System.Windows.Forms.BindingSource schooldetailsBindingSource;
        private PindahFrameDataSetTableAdapters.school_detailsTableAdapter school_detailsTableAdapter;
        private System.Windows.Forms.BindingSource imageBindingSource;
        private PindahFrameDataSetTableAdapters.imageTableAdapter imageTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource level_tableBindingSource;
        private PindahFrameDataSetTableAdapters.level_tableTableAdapter level_tableTableAdapter;
        private PindahFrameDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.ComboBox level_tableComboBox;
        private PindahFrameDataSetTableAdapters.classesTableAdapter classesTableAdapter;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private System.Windows.Forms.ComboBox classesComboBox;
        private System.Windows.Forms.Button btnprintthis;
        private System.Windows.Forms.Button btnprintall;
    }
}