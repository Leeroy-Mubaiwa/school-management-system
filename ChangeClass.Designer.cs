namespace PindahFrame
{
    partial class ChangeClass
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btntransfer = new System.Windows.Forms.Button();
            this.pindahFrameDataSet = new PindahFrame.PindahFrameDataSet();
            this.school_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.school_detailsTableAdapter = new PindahFrame.PindahFrameDataSetTableAdapters.school_detailsTableAdapter();
            this.tableAdapterManager = new PindahFrame.PindahFrameDataSetTableAdapters.TableAdapterManager();
            this.classesTableAdapter = new PindahFrame.PindahFrameDataSetTableAdapters.classesTableAdapter();
            this.level_tableTableAdapter = new PindahFrame.PindahFrameDataSetTableAdapters.level_tableTableAdapter();
            this.level_tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.level_tableComboBox = new System.Windows.Forms.ComboBox();
            this.classesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.subjectsDataGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblcurrent_class = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblnextclass = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pindahFrameDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.level_tableBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // btntransfer
            // 
            this.btntransfer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btntransfer.BackColor = System.Drawing.Color.Black;
            this.btntransfer.FlatAppearance.BorderSize = 0;
            this.btntransfer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntransfer.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.btntransfer.ForeColor = System.Drawing.Color.White;
            this.btntransfer.Location = new System.Drawing.Point(770, 391);
            this.btntransfer.Name = "btntransfer";
            this.btntransfer.Size = new System.Drawing.Size(102, 33);
            this.btntransfer.TabIndex = 3;
            this.btntransfer.Text = "Transfer";
            this.btntransfer.UseVisualStyleBackColor = false;
            this.btntransfer.Click += new System.EventHandler(this.btntransfer_Click);
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
            this.tableAdapterManager.classesTableAdapter = this.classesTableAdapter;
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
            this.tableAdapterManager.level_tableTableAdapter = this.level_tableTableAdapter;
            this.tableAdapterManager.messagesTableAdapter = null;
            this.tableAdapterManager.mischief_tableTableAdapter = null;
            this.tableAdapterManager.past_results_tableTableAdapter = null;
            this.tableAdapterManager.payrollTableAdapter = null;
            this.tableAdapterManager.possessions_tableTableAdapter = null;
            this.tableAdapterManager.preferences_tableTableAdapter = null;
            this.tableAdapterManager.problemsetsTableAdapter = null;
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
            this.tableAdapterManager.UpdateOrder = PindahFrame.PindahFrameDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // classesTableAdapter
            // 
            this.classesTableAdapter.ClearBeforeFill = true;
            // 
            // level_tableTableAdapter
            // 
            this.level_tableTableAdapter.ClearBeforeFill = true;
            // 
            // level_tableBindingSource
            // 
            this.level_tableBindingSource.DataMember = "FK_Levels_ToSchool";
            this.level_tableBindingSource.DataSource = this.school_detailsBindingSource;
            // 
            // level_tableComboBox
            // 
            this.level_tableComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.level_tableComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.level_tableComboBox.DataSource = this.level_tableBindingSource;
            this.level_tableComboBox.DisplayMember = "title";
            this.level_tableComboBox.FormattingEnabled = true;
            this.level_tableComboBox.Location = new System.Drawing.Point(297, 110);
            this.level_tableComboBox.Name = "level_tableComboBox";
            this.level_tableComboBox.Size = new System.Drawing.Size(300, 25);
            this.level_tableComboBox.TabIndex = 4;
            this.level_tableComboBox.ValueMember = "id";
            // 
            // classesBindingSource
            // 
            this.classesBindingSource.DataMember = "FK_Classes_ToLevel_Table";
            this.classesBindingSource.DataSource = this.level_tableBindingSource;
            // 
            // classesBindingSource1
            // 
            this.classesBindingSource1.DataMember = "FK_Classes_ToLevel_Table";
            this.classesBindingSource1.DataSource = this.level_tableBindingSource;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.classesBindingSource;
            this.comboBox1.DisplayMember = "name";
            this.comboBox1.Enabled = false;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(34, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(325, 25);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.ValueMember = "id";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.classesBindingSource1;
            this.comboBox2.DisplayMember = "name";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(30, 134);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(325, 25);
            this.comboBox2.TabIndex = 6;
            this.comboBox2.ValueMember = "id";
            // 
            // subjectsDataGridView
            // 
            this.subjectsDataGridView.AllowUserToAddRows = false;
            this.subjectsDataGridView.AllowUserToDeleteRows = false;
            this.subjectsDataGridView.AllowUserToResizeColumns = false;
            this.subjectsDataGridView.AllowUserToResizeRows = false;
            this.subjectsDataGridView.AutoGenerateColumns = false;
            this.subjectsDataGridView.BackgroundColor = System.Drawing.Color.Black;
            this.subjectsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.subjectsDataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.subjectsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.subjectsDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.subjectsDataGridView.ColumnHeadersHeight = 30;
            this.subjectsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.subjectsDataGridView.ColumnHeadersVisible = false;
            this.subjectsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.typeDataGridViewTextBoxColumn});
            this.subjectsDataGridView.DataSource = this.school_detailsBindingSource;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.subjectsDataGridView.DefaultCellStyle = dataGridViewCellStyle8;
            this.subjectsDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.subjectsDataGridView.EnableHeadersVisualStyles = false;
            this.subjectsDataGridView.GridColor = System.Drawing.Color.Black;
            this.subjectsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.subjectsDataGridView.Name = "subjectsDataGridView";
            this.subjectsDataGridView.ReadOnly = true;
            this.subjectsDataGridView.RowHeadersVisible = false;
            this.subjectsDataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.subjectsDataGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.subjectsDataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.Black;
            this.subjectsDataGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.subjectsDataGridView.RowTemplate.Height = 30;
            this.subjectsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.subjectsDataGridView.Size = new System.Drawing.Size(884, 33);
            this.subjectsDataGridView.TabIndex = 8;
            this.subjectsDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.subjectsDataGridView_CellContentClick);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.FillWeight = 98.47719F;
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // typeDataGridViewTextBoxColumn
            // 
            this.typeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            this.typeDataGridViewTextBoxColumn.FillWeight = 101.5229F;
            this.typeDataGridViewTextBoxColumn.HeaderText = "Type";
            this.typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            this.typeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Current Stage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Current Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Next Class";
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblcurrent_class);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.ForeColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(12, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(385, 214);
            this.panel1.TabIndex = 12;
            // 
            // lblcurrent_class
            // 
            this.lblcurrent_class.AutoSize = true;
            this.lblcurrent_class.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource, "id", true));
            this.lblcurrent_class.Location = new System.Drawing.Point(30, 175);
            this.lblcurrent_class.Name = "lblcurrent_class";
            this.lblcurrent_class.Size = new System.Drawing.Size(16, 19);
            this.lblcurrent_class.TabIndex = 14;
            this.lblcurrent_class.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PindahFrame.Properties.Resources.to;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 39);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(34, 66);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(325, 25);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.lblnextclass);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.label3);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(487, 155);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 214);
            this.panel2.TabIndex = 13;
            // 
            // lblnextclass
            // 
            this.lblnextclass.AutoSize = true;
            this.lblnextclass.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.classesBindingSource1, "id", true));
            this.lblnextclass.Location = new System.Drawing.Point(26, 175);
            this.lblnextclass.Name = "lblnextclass";
            this.lblnextclass.Size = new System.Drawing.Size(16, 19);
            this.lblnextclass.TabIndex = 15;
            this.lblnextclass.Text = "0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PindahFrame.Properties.Resources.migrate;
            this.pictureBox2.Location = new System.Drawing.Point(3, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.label5.Location = new System.Drawing.Point(26, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Type to search";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(30, 66);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(325, 25);
            this.textBox2.TabIndex = 12;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PindahFrame.Properties.Resources.exit;
            this.pictureBox3.Location = new System.Drawing.Point(392, 236);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 50);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 14;
            this.pictureBox3.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(71, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 19);
            this.label4.TabIndex = 15;
            this.label4.Text = "MOVE FROM";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(78, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "MOVE TO";
            // 
            // ChangeClass
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.subjectsDataGridView);
            this.Controls.Add(this.level_tableComboBox);
            this.Controls.Add(this.btntransfer);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox3);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "ChangeClass";
            this.Text = "Change Member Class";
            this.Load += new System.EventHandler(this.ChangeClass_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pindahFrameDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.level_tableBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classesBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subjectsDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btntransfer;
        private PindahFrameDataSet pindahFrameDataSet;
        private System.Windows.Forms.BindingSource school_detailsBindingSource;
        private PindahFrameDataSetTableAdapters.school_detailsTableAdapter school_detailsTableAdapter;
        private PindahFrameDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private PindahFrameDataSetTableAdapters.level_tableTableAdapter level_tableTableAdapter;
        private System.Windows.Forms.BindingSource level_tableBindingSource;
        private PindahFrameDataSetTableAdapters.classesTableAdapter classesTableAdapter;
        private System.Windows.Forms.ComboBox level_tableComboBox;
        private System.Windows.Forms.BindingSource classesBindingSource;
        private System.Windows.Forms.BindingSource classesBindingSource1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView subjectsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblcurrent_class;
        private System.Windows.Forms.Label lblnextclass;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}