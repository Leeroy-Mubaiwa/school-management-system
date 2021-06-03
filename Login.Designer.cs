namespace PindahFrame
{
    partial class Login
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
            System.Windows.Forms.Label emailaddressLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label btncreateaccount;
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblgreeting = new System.Windows.Forms.Label();
            this.lbltime = new System.Windows.Forms.Label();
            this.btncontinue = new System.Windows.Forms.Button();
            this.emailaddressTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.security_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pindahFrameDataSet = new PindahFrame.PindahFrameDataSet();
            this.security_detailsTableAdapter = new PindahFrame.PindahFrameDataSetTableAdapters.security_detailsTableAdapter();
            this.tableAdapterManager = new PindahFrame.PindahFrameDataSetTableAdapters.TableAdapterManager();
            this.timeTimer = new System.Windows.Forms.Timer(this.components);
            emailaddressLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            btncreateaccount = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.security_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pindahFrameDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // emailaddressLabel
            // 
            emailaddressLabel.AutoSize = true;
            emailaddressLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            emailaddressLabel.Location = new System.Drawing.Point(21, 209);
            emailaddressLabel.Name = "emailaddressLabel";
            emailaddressLabel.Size = new System.Drawing.Size(57, 15);
            emailaddressLabel.TabIndex = 45;
            emailaddressLabel.Text = "Password";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Font = new System.Drawing.Font("Segoe UI", 9F);
            nameLabel.Location = new System.Drawing.Point(21, 145);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(117, 15);
            nameLabel.TabIndex = 40;
            nameLabel.Text = "Authentication Code";
            // 
            // label1
            // 
            label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            label1.AutoSize = true;
            label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            label1.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            label1.ForeColor = System.Drawing.Color.White;
            label1.Location = new System.Drawing.Point(529, 479);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(97, 19);
            label1.TabIndex = 41;
            label1.Text = "Forgot details?";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btncreateaccount
            // 
            btncreateaccount.Anchor = System.Windows.Forms.AnchorStyles.None;
            btncreateaccount.AutoSize = true;
            btncreateaccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btncreateaccount.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            btncreateaccount.ForeColor = System.Drawing.Color.White;
            btncreateaccount.Location = new System.Drawing.Point(425, 479);
            btncreateaccount.Name = "btncreateaccount";
            btncreateaccount.Size = new System.Drawing.Size(108, 19);
            btncreateaccount.TabIndex = 42;
            btncreateaccount.Text = "Create Account |";
            btncreateaccount.Click += new System.EventHandler(this.btncreateaccount_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.lblgreeting);
            this.panel1.Controls.Add(this.lbltime);
            this.panel1.Controls.Add(this.btncontinue);
            this.panel1.Controls.Add(emailaddressLabel);
            this.panel1.Controls.Add(this.emailaddressTextBox);
            this.panel1.Controls.Add(nameLabel);
            this.panel1.Controls.Add(this.nameTextBox);
            this.panel1.Location = new System.Drawing.Point(175, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 344);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PindahFrame.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(25, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(400, 42);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 54;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblgreeting
            // 
            this.lblgreeting.AutoSize = true;
            this.lblgreeting.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.lblgreeting.ForeColor = System.Drawing.Color.Black;
            this.lblgreeting.Location = new System.Drawing.Point(21, 61);
            this.lblgreeting.Name = "lblgreeting";
            this.lblgreeting.Size = new System.Drawing.Size(21, 19);
            this.lblgreeting.TabIndex = 53;
            this.lblgreeting.Text = "--";
            // 
            // lbltime
            // 
            this.lbltime.AutoSize = true;
            this.lbltime.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.lbltime.ForeColor = System.Drawing.Color.Black;
            this.lbltime.Location = new System.Drawing.Point(21, 88);
            this.lbltime.Name = "lbltime";
            this.lbltime.Size = new System.Drawing.Size(49, 19);
            this.lbltime.TabIndex = 52;
            this.lbltime.Text = "lbltime";
            // 
            // btncontinue
            // 
            this.btncontinue.BackColor = System.Drawing.Color.Black;
            this.btncontinue.FlatAppearance.BorderSize = 0;
            this.btncontinue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncontinue.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncontinue.ForeColor = System.Drawing.Color.White;
            this.btncontinue.Location = new System.Drawing.Point(323, 291);
            this.btncontinue.Name = "btncontinue";
            this.btncontinue.Size = new System.Drawing.Size(102, 33);
            this.btncontinue.TabIndex = 49;
            this.btncontinue.Text = "Login";
            this.btncontinue.UseVisualStyleBackColor = false;
            this.btncontinue.Click += new System.EventHandler(this.btncontinue_Click);
            // 
            // emailaddressTextBox
            // 
            this.emailaddressTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.emailaddressTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.emailaddressTextBox.Font = new System.Drawing.Font("Quicksand", 10F);
            this.emailaddressTextBox.Location = new System.Drawing.Point(25, 236);
            this.emailaddressTextBox.Name = "emailaddressTextBox";
            this.emailaddressTextBox.Size = new System.Drawing.Size(400, 24);
            this.emailaddressTextBox.TabIndex = 47;
            this.emailaddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.emailaddressTextBox.UseSystemPasswordChar = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.nameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nameTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nameTextBox.Font = new System.Drawing.Font("Quicksand", 10F, System.Drawing.FontStyle.Bold);
            this.nameTextBox.Location = new System.Drawing.Point(25, 173);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(400, 24);
            this.nameTextBox.TabIndex = 41;
            this.nameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // security_detailsBindingSource
            // 
            this.security_detailsBindingSource.DataMember = "security_details";
            this.security_detailsBindingSource.DataSource = this.pindahFrameDataSet;
            // 
            // pindahFrameDataSet
            // 
            this.pindahFrameDataSet.DataSetName = "PindahFrameDataSet";
            this.pindahFrameDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // security_detailsTableAdapter
            // 
            this.security_detailsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.problemsetsTableAdapter = null;
            this.tableAdapterManager.recommendationsTableAdapter = null;
            this.tableAdapterManager.school_detailsTableAdapter = null;
            this.tableAdapterManager.school_diary_studentTableAdapter = null;
            this.tableAdapterManager.school_historyTableAdapter = null;
            this.tableAdapterManager.school_shop_table_has_school_diary_studentTableAdapter = null;
            this.tableAdapterManager.school_shop_tableTableAdapter = null;
            this.tableAdapterManager.security_detailsTableAdapter = this.security_detailsTableAdapter;
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
            // timeTimer
            // 
            this.timeTimer.Tick += new System.EventHandler(this.timeTimer_Tick);
            // 
            // Login
            // 
            this.AcceptButton = this.btncontinue;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(btncreateaccount);
            this.Controls.Add(label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 9F);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Login";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.security_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pindahFrameDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btncontinue;
        private System.Windows.Forms.TextBox emailaddressTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private PindahFrameDataSet pindahFrameDataSet;
        private System.Windows.Forms.BindingSource security_detailsBindingSource;
        private PindahFrameDataSetTableAdapters.security_detailsTableAdapter security_detailsTableAdapter;
        private PindahFrameDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Timer timeTimer;
        private System.Windows.Forms.Label lbltime;
        private System.Windows.Forms.Label lblgreeting;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}