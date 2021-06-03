namespace PindahFrame
{
    partial class ProblemSets
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
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label worktypeLabel;
            System.Windows.Forms.Label tutorresponsibleLabel;
            System.Windows.Forms.Label total_expectedLabel;
            System.Windows.Forms.Label averagemarkLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label worktitleLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pindahFrameDataSet = new PindahFrame.PindahFrameDataSet();
            this.school_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.school_detailsTableAdapter = new PindahFrame.PindahFrameDataSetTableAdapters.school_detailsTableAdapter();
            this.tableAdapterManager = new PindahFrame.PindahFrameDataSetTableAdapters.TableAdapterManager();
            this.problemsetsTableAdapter = new PindahFrame.PindahFrameDataSetTableAdapters.problemsetsTableAdapter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.level_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.level_tableComboBox = new System.Windows.Forms.ComboBox();
            this.btnaddnewlesson = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnupdatelessons = new System.Windows.Forms.Button();
            this.gridLessons = new System.Windows.Forms.DataGridView();
            this.workcodeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worktitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.worktypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tutorresponsibleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalExpectedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averagemarkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.problemsetsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pnllesson = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.staffComboBox = new System.Windows.Forms.ComboBox();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.worktypeTextBox = new System.Windows.Forms.TextBox();
            this.tutorresponsibleTextBox = new System.Windows.Forms.TextBox();
            this.total_expectedTextBox = new System.Windows.Forms.TextBox();
            this.averagemarkTextBox = new System.Windows.Forms.TextBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.worktitleTextBox = new System.Windows.Forms.TextBox();
            this.workcodeTextBox = new System.Windows.Forms.TextBox();
            this.school_idTextBox = new System.Windows.Forms.TextBox();
            this.level_idTextBox = new System.Windows.Forms.TextBox();
            this.btnclosepanel = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.level_tableTableAdapter = new PindahFrame.PindahFrameDataSetTableAdapters.level_tableTableAdapter();
            this.staffTableAdapter = new PindahFrame.PindahFrameDataSetTableAdapters.staffTableAdapter();
            this.btnpreview = new System.Windows.Forms.Button();
            dateLabel = new System.Windows.Forms.Label();
            worktypeLabel = new System.Windows.Forms.Label();
            tutorresponsibleLabel = new System.Windows.Forms.Label();
            total_expectedLabel = new System.Windows.Forms.Label();
            averagemarkLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            worktitleLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pindahFrameDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_detailsBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.level_tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLessons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.problemsetsBindingSource)).BeginInit();
            this.pnllesson.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Location = new System.Drawing.Point(15, 33);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(30, 13);
            dateLabel.TabIndex = 231;
            dateLabel.Text = "date:";
            // 
            // worktypeLabel
            // 
            worktypeLabel.AutoSize = true;
            worktypeLabel.Location = new System.Drawing.Point(15, 60);
            worktypeLabel.Name = "worktypeLabel";
            worktypeLabel.Size = new System.Drawing.Size(52, 13);
            worktypeLabel.TabIndex = 233;
            worktypeLabel.Text = "worktype:";
            // 
            // tutorresponsibleLabel
            // 
            tutorresponsibleLabel.AutoSize = true;
            tutorresponsibleLabel.Location = new System.Drawing.Point(15, 119);
            tutorresponsibleLabel.Name = "tutorresponsibleLabel";
            tutorresponsibleLabel.Size = new System.Drawing.Size(26, 13);
            tutorresponsibleLabel.TabIndex = 235;
            tutorresponsibleLabel.Text = "staff";
            // 
            // total_expectedLabel
            // 
            total_expectedLabel.AutoSize = true;
            total_expectedLabel.Location = new System.Drawing.Point(15, 147);
            total_expectedLabel.Name = "total_expectedLabel";
            total_expectedLabel.Size = new System.Drawing.Size(75, 13);
            total_expectedLabel.TabIndex = 237;
            total_expectedLabel.Text = "total expected:";
            // 
            // averagemarkLabel
            // 
            averagemarkLabel.AutoSize = true;
            averagemarkLabel.Location = new System.Drawing.Point(15, 175);
            averagemarkLabel.Name = "averagemarkLabel";
            averagemarkLabel.Size = new System.Drawing.Size(72, 13);
            averagemarkLabel.TabIndex = 239;
            averagemarkLabel.Text = "averagemark:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(15, 203);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(59, 13);
            descriptionLabel.TabIndex = 241;
            descriptionLabel.Text = "description:";
            // 
            // worktitleLabel
            // 
            worktitleLabel.AutoSize = true;
            worktitleLabel.Location = new System.Drawing.Point(15, 88);
            worktitleLabel.Name = "worktitleLabel";
            worktitleLabel.Size = new System.Drawing.Size(48, 13);
            worktitleLabel.TabIndex = 245;
            worktitleLabel.Text = "worktitle:";
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(715, 15);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(17, 13);
            idLabel.TabIndex = 228;
            idLabel.Text = "id:";
            // 
            // pindahFrameDataSet
            // 
            this.pindahFrameDataSet.DataSetName = "PindahFrameDataSet";
            this.pindahFrameDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // school_detailsBindingSource
            // 
            this.school_detailsBindingSource.DataMember = "school_details";
            this.school_detailsBindingSource.DataSource = this.pindahFrameDataSet;
            // 
            // school_detailsTableAdapter
            // 
            this.school_detailsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.additionsTableAdapter = null;
            this.tableAdapterManager.archievements_tableTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.biographyTableAdapter = null;
            this.tableAdapterManager.BooksTableAdapter = null;
            this.tableAdapterManager.BorrowTableAdapter = null;
            this.tableAdapterManager.classesTableAdapter = null;
            this.tableAdapterManager.contact_detailsTableAdapter = null;
            this.tableAdapterManager.countryTableAdapter = null;
            this.tableAdapterManager.criminal_offenses_tableTableAdapter = null;
            this.tableAdapterManager.deductionsTableAdapter = null;
            this.tableAdapterManager.deletedstuffTableAdapter = null;
            this.tableAdapterManager.exam_type_tableTableAdapter = null;
            this.tableAdapterManager.feesTableAdapter = null;
            this.tableAdapterManager.financesTableAdapter = null;
            this.tableAdapterManager.financial_processesTableAdapter = null;
            this.tableAdapterManager.galleryTableAdapter = null;
            this.tableAdapterManager.home_detailsTableAdapter = null;
            this.tableAdapterManager.imageTableAdapter = null;
            this.tableAdapterManager.ipadressesTableAdapter = null;
            this.tableAdapterManager.lessons_has_school_diary_studentTableAdapter = null;
            this.tableAdapterManager.lessonsTableAdapter = null;
            this.tableAdapterManager.level_tableTableAdapter = null;
            this.tableAdapterManager.LibraryTableAdapter = null;
            this.tableAdapterManager.messagesTableAdapter = null;
            this.tableAdapterManager.mischief_tableTableAdapter = null;
            this.tableAdapterManager.Other_FeesTableAdapter = null;
            this.tableAdapterManager.past_results_tableTableAdapter = null;
            this.tableAdapterManager.payrollTableAdapter = null;
            this.tableAdapterManager.possessions_tableTableAdapter = null;
            this.tableAdapterManager.preferences_tableTableAdapter = null;
            this.tableAdapterManager.problemsetsTableAdapter = this.problemsetsTableAdapter;
            this.tableAdapterManager.recommendationsTableAdapter = null;
            this.tableAdapterManager.school_detailsTableAdapter = this.school_detailsTableAdapter;
            this.tableAdapterManager.school_diary_studentTableAdapter = null;
            this.tableAdapterManager.school_historyTableAdapter = null;
            this.tableAdapterManager.school_shop_table_has_school_diary_studentTableAdapter = null;
            this.tableAdapterManager.school_shop_tableTableAdapter = null;
            this.tableAdapterManager.security_detailsTableAdapter = null;
            this.tableAdapterManager.social_networksTableAdapter = null;
            this.tableAdapterManager.staff_has_lessonsTableAdapter = null;
            this.tableAdapterManager.staff_hassubjectsTableAdapter = null;
            this.tableAdapterManager.staffTableAdapter = null;
            this.tableAdapterManager.stock_brandTableAdapter = null;
            this.tableAdapterManager.stock_item_categoryTableAdapter = null;
            this.tableAdapterManager.stock_itemgroupTableAdapter = null;
            this.tableAdapterManager.stock_productTableAdapter = null;
            this.tableAdapterManager.stock_purchase_order_lineTableAdapter = null;
            this.tableAdapterManager.stock_siteTableAdapter = null;
            this.tableAdapterManager.stock_supplierTableAdapter = null;
            this.tableAdapterManager.stock_warehouseTableAdapter = null;
            this.tableAdapterManager.student_hassubjectTableAdapter = null;
            this.tableAdapterManager.subjectsTableAdapter = null;
            this.tableAdapterManager.teacher_s_childrenTableAdapter = null;
            this.tableAdapterManager.Total_feesTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PindahFrame.PindahFrameDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // problemsetsTableAdapter
            // 
            this.problemsetsTableAdapter.ClearBeforeFill = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(idLabel);
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.level_tableComboBox);
            this.panel1.Controls.Add(this.btnaddnewlesson);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 64);
            this.panel1.TabIndex = 0;
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.level_tableBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(738, 11);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.ReadOnly = true;
            this.idTextBox.Size = new System.Drawing.Size(100, 22);
            this.idTextBox.TabIndex = 229;
            // 
            // level_tableBindingSource
            // 
            this.level_tableBindingSource.DataMember = "FK_Levels_ToSchool";
            this.level_tableBindingSource.DataSource = this.school_detailsBindingSource;
            // 
            // level_tableComboBox
            // 
            this.level_tableComboBox.DataSource = this.level_tableBindingSource;
            this.level_tableComboBox.DisplayMember = "title";
            this.level_tableComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.level_tableComboBox.FormattingEnabled = true;
            this.level_tableComboBox.Location = new System.Drawing.Point(382, 12);
            this.level_tableComboBox.Name = "level_tableComboBox";
            this.level_tableComboBox.Size = new System.Drawing.Size(300, 21);
            this.level_tableComboBox.TabIndex = 228;
            this.level_tableComboBox.ValueMember = "id";
            // 
            // btnaddnewlesson
            // 
            this.btnaddnewlesson.BackColor = System.Drawing.Color.Black;
            this.btnaddnewlesson.FlatAppearance.BorderSize = 0;
            this.btnaddnewlesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnaddnewlesson.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnaddnewlesson.ForeColor = System.Drawing.Color.White;
            this.btnaddnewlesson.Location = new System.Drawing.Point(61, 12);
            this.btnaddnewlesson.Name = "btnaddnewlesson";
            this.btnaddnewlesson.Size = new System.Drawing.Size(102, 30);
            this.btnaddnewlesson.TabIndex = 228;
            this.btnaddnewlesson.Text = "Create new";
            this.btnaddnewlesson.UseVisualStyleBackColor = false;
            this.btnaddnewlesson.Click += new System.EventHandler(this.btnaddnewlesson_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 225;
            this.label1.Text = "Select the class to ease your additions";
            // 
            // btndelete
            // 
            this.btndelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btndelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btndelete.FlatAppearance.BorderSize = 0;
            this.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndelete.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btndelete.ForeColor = System.Drawing.Color.Black;
            this.btndelete.Location = new System.Drawing.Point(897, 61);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(102, 30);
            this.btndelete.TabIndex = 220;
            this.btndelete.Text = "Delete";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdatelessons
            // 
            this.btnupdatelessons.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnupdatelessons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnupdatelessons.FlatAppearance.BorderSize = 0;
            this.btnupdatelessons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnupdatelessons.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnupdatelessons.ForeColor = System.Drawing.Color.Black;
            this.btnupdatelessons.Location = new System.Drawing.Point(897, 97);
            this.btnupdatelessons.Name = "btnupdatelessons";
            this.btnupdatelessons.Size = new System.Drawing.Size(102, 30);
            this.btnupdatelessons.TabIndex = 219;
            this.btnupdatelessons.Text = "Update";
            this.btnupdatelessons.UseVisualStyleBackColor = false;
            this.btnupdatelessons.Click += new System.EventHandler(this.button1_Click);
            // 
            // gridLessons
            // 
            this.gridLessons.AllowUserToAddRows = false;
            this.gridLessons.AllowUserToDeleteRows = false;
            this.gridLessons.AllowUserToResizeColumns = false;
            this.gridLessons.AllowUserToResizeRows = false;
            this.gridLessons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridLessons.AutoGenerateColumns = false;
            this.gridLessons.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gridLessons.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridLessons.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gridLessons.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLessons.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridLessons.ColumnHeadersHeight = 30;
            this.gridLessons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridLessons.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.workcodeDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.worktitleDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.worktypeDataGridViewTextBoxColumn,
            this.tutorresponsibleDataGridViewTextBoxColumn,
            this.totalExpectedDataGridViewTextBoxColumn,
            this.averagemarkDataGridViewTextBoxColumn});
            this.gridLessons.DataSource = this.problemsetsBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridLessons.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridLessons.EnableHeadersVisualStyles = false;
            this.gridLessons.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.gridLessons.Location = new System.Drawing.Point(81, 179);
            this.gridLessons.Name = "gridLessons";
            this.gridLessons.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridLessons.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridLessons.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.gridLessons.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.gridLessons.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.gridLessons.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.gridLessons.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.gridLessons.RowTemplate.DividerHeight = 5;
            this.gridLessons.RowTemplate.Height = 40;
            this.gridLessons.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridLessons.Size = new System.Drawing.Size(918, 407);
            this.gridLessons.TabIndex = 218;
            // 
            // workcodeDataGridViewTextBoxColumn
            // 
            this.workcodeDataGridViewTextBoxColumn.DataPropertyName = "workcode";
            this.workcodeDataGridViewTextBoxColumn.HeaderText = "_";
            this.workcodeDataGridViewTextBoxColumn.Name = "workcodeDataGridViewTextBoxColumn";
            this.workcodeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // worktitleDataGridViewTextBoxColumn
            // 
            this.worktitleDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.worktitleDataGridViewTextBoxColumn.DataPropertyName = "worktitle";
            this.worktitleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.worktitleDataGridViewTextBoxColumn.Name = "worktitleDataGridViewTextBoxColumn";
            this.worktitleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // worktypeDataGridViewTextBoxColumn
            // 
            this.worktypeDataGridViewTextBoxColumn.DataPropertyName = "worktype";
            this.worktypeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.worktypeDataGridViewTextBoxColumn.Name = "worktypeDataGridViewTextBoxColumn";
            this.worktypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tutorresponsibleDataGridViewTextBoxColumn
            // 
            this.tutorresponsibleDataGridViewTextBoxColumn.DataPropertyName = "tutorresponsible";
            this.tutorresponsibleDataGridViewTextBoxColumn.HeaderText = "Staff";
            this.tutorresponsibleDataGridViewTextBoxColumn.Name = "tutorresponsibleDataGridViewTextBoxColumn";
            this.tutorresponsibleDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalExpectedDataGridViewTextBoxColumn
            // 
            this.totalExpectedDataGridViewTextBoxColumn.DataPropertyName = "total expected";
            this.totalExpectedDataGridViewTextBoxColumn.HeaderText = "Ex.Total";
            this.totalExpectedDataGridViewTextBoxColumn.Name = "totalExpectedDataGridViewTextBoxColumn";
            this.totalExpectedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // averagemarkDataGridViewTextBoxColumn
            // 
            this.averagemarkDataGridViewTextBoxColumn.DataPropertyName = "averagemark";
            this.averagemarkDataGridViewTextBoxColumn.HeaderText = "Av.Mark";
            this.averagemarkDataGridViewTextBoxColumn.Name = "averagemarkDataGridViewTextBoxColumn";
            this.averagemarkDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // problemsetsBindingSource
            // 
            this.problemsetsBindingSource.DataMember = "FK_Level_toProblemSet";
            this.problemsetsBindingSource.DataSource = this.level_tableBindingSource;
            // 
            // pnllesson
            // 
            this.pnllesson.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnllesson.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.pnllesson.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnllesson.Controls.Add(this.comboBox1);
            this.pnllesson.Controls.Add(this.textBox1);
            this.pnllesson.Controls.Add(this.staffComboBox);
            this.pnllesson.Controls.Add(dateLabel);
            this.pnllesson.Controls.Add(this.dateDateTimePicker);
            this.pnllesson.Controls.Add(worktypeLabel);
            this.pnllesson.Controls.Add(this.worktypeTextBox);
            this.pnllesson.Controls.Add(tutorresponsibleLabel);
            this.pnllesson.Controls.Add(this.tutorresponsibleTextBox);
            this.pnllesson.Controls.Add(total_expectedLabel);
            this.pnllesson.Controls.Add(this.total_expectedTextBox);
            this.pnllesson.Controls.Add(averagemarkLabel);
            this.pnllesson.Controls.Add(this.averagemarkTextBox);
            this.pnllesson.Controls.Add(descriptionLabel);
            this.pnllesson.Controls.Add(this.descriptionTextBox);
            this.pnllesson.Controls.Add(worktitleLabel);
            this.pnllesson.Controls.Add(this.worktitleTextBox);
            this.pnllesson.Controls.Add(this.workcodeTextBox);
            this.pnllesson.Controls.Add(this.school_idTextBox);
            this.pnllesson.Controls.Add(this.level_idTextBox);
            this.pnllesson.Controls.Add(this.btnclosepanel);
            this.pnllesson.Controls.Add(this.label6);
            this.pnllesson.Controls.Add(this.button1);
            this.pnllesson.Location = new System.Drawing.Point(103, 70);
            this.pnllesson.Name = "pnllesson";
            this.pnllesson.Size = new System.Drawing.Size(896, 493);
            this.pnllesson.TabIndex = 231;
            this.pnllesson.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.White;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Exercise",
            "Test",
            "Examination",
            "Quiz",
            "Assignment"});
            this.comboBox1.Location = new System.Drawing.Point(104, 58);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(251, 21);
            this.comboBox1.TabIndex = 256;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(311, 114);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(299, 22);
            this.textBox1.TabIndex = 255;
            this.textBox1.Text = "Type to search";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // staffComboBox
            // 
            this.staffComboBox.DataSource = this.staffBindingSource;
            this.staffComboBox.DisplayMember = "staff_surname";
            this.staffComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.staffComboBox.FormattingEnabled = true;
            this.staffComboBox.Location = new System.Drawing.Point(310, 139);
            this.staffComboBox.Name = "staffComboBox";
            this.staffComboBox.Size = new System.Drawing.Size(300, 21);
            this.staffComboBox.TabIndex = 254;
            this.staffComboBox.ValueMember = "staff_id";
            this.staffComboBox.SelectedIndexChanged += new System.EventHandler(this.staffComboBox_SelectedIndexChanged);
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "FK_Staff_ToSchool";
            this.staffBindingSource.DataSource = this.school_detailsBindingSource;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.problemsetsBindingSource, "date", true));
            this.dateDateTimePicker.Location = new System.Drawing.Point(104, 29);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(200, 22);
            this.dateDateTimePicker.TabIndex = 232;
            // 
            // worktypeTextBox
            // 
            this.worktypeTextBox.BackColor = System.Drawing.Color.White;
            this.worktypeTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.worktypeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.problemsetsBindingSource, "worktype", true));
            this.worktypeTextBox.Location = new System.Drawing.Point(104, 57);
            this.worktypeTextBox.Multiline = true;
            this.worktypeTextBox.Name = "worktypeTextBox";
            this.worktypeTextBox.Size = new System.Drawing.Size(106, 22);
            this.worktypeTextBox.TabIndex = 234;
            // 
            // tutorresponsibleTextBox
            // 
            this.tutorresponsibleTextBox.BackColor = System.Drawing.Color.White;
            this.tutorresponsibleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tutorresponsibleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.problemsetsBindingSource, "tutorresponsible", true));
            this.tutorresponsibleTextBox.Location = new System.Drawing.Point(104, 116);
            this.tutorresponsibleTextBox.Name = "tutorresponsibleTextBox";
            this.tutorresponsibleTextBox.Size = new System.Drawing.Size(200, 22);
            this.tutorresponsibleTextBox.TabIndex = 236;
            // 
            // total_expectedTextBox
            // 
            this.total_expectedTextBox.BackColor = System.Drawing.Color.White;
            this.total_expectedTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total_expectedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.problemsetsBindingSource, "total expected", true));
            this.total_expectedTextBox.Location = new System.Drawing.Point(104, 144);
            this.total_expectedTextBox.Name = "total_expectedTextBox";
            this.total_expectedTextBox.Size = new System.Drawing.Size(83, 22);
            this.total_expectedTextBox.TabIndex = 238;
            // 
            // averagemarkTextBox
            // 
            this.averagemarkTextBox.BackColor = System.Drawing.Color.White;
            this.averagemarkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averagemarkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.problemsetsBindingSource, "averagemark", true));
            this.averagemarkTextBox.Location = new System.Drawing.Point(104, 172);
            this.averagemarkTextBox.Name = "averagemarkTextBox";
            this.averagemarkTextBox.Size = new System.Drawing.Size(83, 22);
            this.averagemarkTextBox.TabIndex = 240;
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.BackColor = System.Drawing.Color.White;
            this.descriptionTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.problemsetsBindingSource, "description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(104, 200);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(493, 140);
            this.descriptionTextBox.TabIndex = 242;
            // 
            // worktitleTextBox
            // 
            this.worktitleTextBox.BackColor = System.Drawing.Color.White;
            this.worktitleTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.worktitleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.problemsetsBindingSource, "worktitle", true));
            this.worktitleTextBox.Location = new System.Drawing.Point(104, 85);
            this.worktitleTextBox.Name = "worktitleTextBox";
            this.worktitleTextBox.Size = new System.Drawing.Size(493, 22);
            this.worktitleTextBox.TabIndex = 246;
            // 
            // workcodeTextBox
            // 
            this.workcodeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.workcodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.problemsetsBindingSource, "workcode", true));
            this.workcodeTextBox.Location = new System.Drawing.Point(104, 1);
            this.workcodeTextBox.Name = "workcodeTextBox";
            this.workcodeTextBox.ReadOnly = true;
            this.workcodeTextBox.Size = new System.Drawing.Size(42, 22);
            this.workcodeTextBox.TabIndex = 248;
            // 
            // school_idTextBox
            // 
            this.school_idTextBox.BackColor = System.Drawing.Color.White;
            this.school_idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.school_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.problemsetsBindingSource, "school_id", true));
            this.school_idTextBox.Location = new System.Drawing.Point(817, 114);
            this.school_idTextBox.Name = "school_idTextBox";
            this.school_idTextBox.ReadOnly = true;
            this.school_idTextBox.Size = new System.Drawing.Size(60, 22);
            this.school_idTextBox.TabIndex = 250;
            // 
            // level_idTextBox
            // 
            this.level_idTextBox.BackColor = System.Drawing.Color.White;
            this.level_idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.level_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.problemsetsBindingSource, "level_id", true));
            this.level_idTextBox.Location = new System.Drawing.Point(817, 170);
            this.level_idTextBox.Name = "level_idTextBox";
            this.level_idTextBox.ReadOnly = true;
            this.level_idTextBox.Size = new System.Drawing.Size(60, 22);
            this.level_idTextBox.TabIndex = 254;
            // 
            // btnclosepanel
            // 
            this.btnclosepanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclosepanel.Location = new System.Drawing.Point(802, 3);
            this.btnclosepanel.Name = "btnclosepanel";
            this.btnclosepanel.Size = new System.Drawing.Size(75, 23);
            this.btnclosepanel.TabIndex = 231;
            this.btnclosepanel.Text = "Close";
            this.btnclosepanel.UseVisualStyleBackColor = true;
            this.btnclosepanel.Click += new System.EventHandler(this.btnclosepanel_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI Light", 11F);
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(8, 4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 230;
            this.label6.Text = "Set details";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(786, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 30);
            this.button1.TabIndex = 216;
            this.button1.Text = "Update";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // level_tableTableAdapter
            // 
            this.level_tableTableAdapter.ClearBeforeFill = true;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // btnpreview
            // 
            this.btnpreview.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.btnpreview.FlatAppearance.BorderSize = 0;
            this.btnpreview.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnpreview.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.btnpreview.ForeColor = System.Drawing.Color.Black;
            this.btnpreview.Location = new System.Drawing.Point(81, 137);
            this.btnpreview.Name = "btnpreview";
            this.btnpreview.Size = new System.Drawing.Size(102, 30);
            this.btnpreview.TabIndex = 221;
            this.btnpreview.Text = "Preview Data";
            this.btnpreview.UseVisualStyleBackColor = false;
            this.btnpreview.Click += new System.EventHandler(this.btnpreview_Click);
            // 
            // ProblemSets
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(1080, 589);
            this.Controls.Add(this.pnllesson);
            this.Controls.Add(this.btnpreview);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdatelessons);
            this.Controls.Add(this.gridLessons);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 8.25F);
            this.ForeColor = System.Drawing.Color.Black;
            this.KeyPreview = true;
            this.Name = "ProblemSets";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ProblemSets";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProblemSets_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pindahFrameDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_detailsBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.level_tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLessons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.problemsetsBindingSource)).EndInit();
            this.pnllesson.ResumeLayout(false);
            this.pnllesson.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PindahFrameDataSet pindahFrameDataSet;
        private System.Windows.Forms.BindingSource school_detailsBindingSource;
        private PindahFrameDataSetTableAdapters.school_detailsTableAdapter school_detailsTableAdapter;
        private PindahFrameDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnupdatelessons;
        private System.Windows.Forms.DataGridView gridLessons;
        private PindahFrameDataSetTableAdapters.problemsetsTableAdapter problemsetsTableAdapter;
        private System.Windows.Forms.Button btnaddnewlesson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnllesson;
        private System.Windows.Forms.Button btnclosepanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource level_tableBindingSource;
        private PindahFrameDataSetTableAdapters.level_tableTableAdapter level_tableTableAdapter;
        private System.Windows.Forms.ComboBox level_tableComboBox;
        private System.Windows.Forms.DateTimePicker dateDateTimePicker;
        private System.Windows.Forms.BindingSource problemsetsBindingSource;
        private System.Windows.Forms.TextBox worktypeTextBox;
        private System.Windows.Forms.TextBox tutorresponsibleTextBox;
        private System.Windows.Forms.TextBox total_expectedTextBox;
        private System.Windows.Forms.TextBox averagemarkTextBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox worktitleTextBox;
        private System.Windows.Forms.TextBox workcodeTextBox;
        private System.Windows.Forms.TextBox school_idTextBox;
        private System.Windows.Forms.TextBox level_idTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn workcodeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn worktitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn worktypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutorresponsibleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalExpectedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averagemarkDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.BindingSource staffBindingSource;
        private PindahFrameDataSetTableAdapters.staffTableAdapter staffTableAdapter;
        private System.Windows.Forms.ComboBox staffComboBox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnpreview;
    }
}