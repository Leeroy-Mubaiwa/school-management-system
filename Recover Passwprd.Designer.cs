namespace PindahFrame
{
    partial class Recover_Passwprd
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
            System.Windows.Forms.Label passwordLabel;
            System.Windows.Forms.Label hint1Label;
            System.Windows.Forms.Label hint2Label;
            System.Windows.Forms.Label hint3Label;
            System.Windows.Forms.Label school_idLabel;
            System.Windows.Forms.Label label1;
            this.pindahFrameDataSet = new PindahFrame.PindahFrameDataSet();
            this.security_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.security_detailsTableAdapter = new PindahFrame.PindahFrameDataSetTableAdapters.security_detailsTableAdapter();
            this.tableAdapterManager = new PindahFrame.PindahFrameDataSetTableAdapters.TableAdapterManager();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.hint1TextBox = new System.Windows.Forms.TextBox();
            this.hint2TextBox = new System.Windows.Forms.TextBox();
            this.hint3TextBox = new System.Windows.Forms.TextBox();
            this.school_idTextBox = new System.Windows.Forms.TextBox();
            this.btnrecover = new System.Windows.Forms.Button();
            this.btntakeback = new System.Windows.Forms.Button();
            passwordLabel = new System.Windows.Forms.Label();
            hint1Label = new System.Windows.Forms.Label();
            hint2Label = new System.Windows.Forms.Label();
            hint3Label = new System.Windows.Forms.Label();
            school_idLabel = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pindahFrameDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.security_detailsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pindahFrameDataSet
            // 
            this.pindahFrameDataSet.DataSetName = "PindahFrameDataSet";
            this.pindahFrameDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // security_detailsBindingSource
            // 
            this.security_detailsBindingSource.DataMember = "security_details";
            this.security_detailsBindingSource.DataSource = this.pindahFrameDataSet;
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
            this.tableAdapterManager.messagesTableAdapter = null;
            this.tableAdapterManager.mischief_tableTableAdapter = null;
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
            this.tableAdapterManager.UpdateOrder = PindahFrame.PindahFrameDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new System.Drawing.Point(95, 463);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(112, 19);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Your password is";
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.security_detailsBindingSource, "password", true));
            this.passwordTextBox.Location = new System.Drawing.Point(213, 460);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.ReadOnly = true;
            this.passwordTextBox.Size = new System.Drawing.Size(455, 25);
            this.passwordTextBox.TabIndex = 4;
            // 
            // hint1Label
            // 
            hint1Label.AutoSize = true;
            hint1Label.Location = new System.Drawing.Point(95, 240);
            hint1Label.Name = "hint1Label";
            hint1Label.Size = new System.Drawing.Size(43, 19);
            hint1Label.TabIndex = 5;
            hint1Label.Text = "Hint 1";
            // 
            // hint1TextBox
            // 
            this.hint1TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.hint1TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hint1TextBox.Location = new System.Drawing.Point(171, 237);
            this.hint1TextBox.Name = "hint1TextBox";
            this.hint1TextBox.Size = new System.Drawing.Size(497, 25);
            this.hint1TextBox.TabIndex = 6;
            // 
            // hint2Label
            // 
            hint2Label.AutoSize = true;
            hint2Label.Location = new System.Drawing.Point(95, 271);
            hint2Label.Name = "hint2Label";
            hint2Label.Size = new System.Drawing.Size(45, 19);
            hint2Label.TabIndex = 7;
            hint2Label.Text = "Hint 2";
            // 
            // hint2TextBox
            // 
            this.hint2TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.hint2TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hint2TextBox.Location = new System.Drawing.Point(171, 268);
            this.hint2TextBox.Name = "hint2TextBox";
            this.hint2TextBox.Size = new System.Drawing.Size(497, 25);
            this.hint2TextBox.TabIndex = 8;
            // 
            // hint3Label
            // 
            hint3Label.AutoSize = true;
            hint3Label.Location = new System.Drawing.Point(95, 302);
            hint3Label.Name = "hint3Label";
            hint3Label.Size = new System.Drawing.Size(45, 19);
            hint3Label.TabIndex = 9;
            hint3Label.Text = "Hint 3";
            // 
            // hint3TextBox
            // 
            this.hint3TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.hint3TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.hint3TextBox.Location = new System.Drawing.Point(171, 299);
            this.hint3TextBox.Name = "hint3TextBox";
            this.hint3TextBox.Size = new System.Drawing.Size(497, 25);
            this.hint3TextBox.TabIndex = 10;
            // 
            // school_idLabel
            // 
            school_idLabel.AutoSize = true;
            school_idLabel.Location = new System.Drawing.Point(95, 157);
            school_idLabel.Name = "school_idLabel";
            school_idLabel.Size = new System.Drawing.Size(132, 19);
            school_idLabel.TabIndex = 11;
            school_idLabel.Text = "Authentication Code";
            // 
            // school_idTextBox
            // 
            this.school_idTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.school_idTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.school_idTextBox.Location = new System.Drawing.Point(233, 154);
            this.school_idTextBox.Name = "school_idTextBox";
            this.school_idTextBox.Size = new System.Drawing.Size(435, 25);
            this.school_idTextBox.TabIndex = 12;
            // 
            // btnrecover
            // 
            this.btnrecover.BackColor = System.Drawing.Color.Black;
            this.btnrecover.FlatAppearance.BorderSize = 0;
            this.btnrecover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnrecover.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrecover.ForeColor = System.Drawing.Color.White;
            this.btnrecover.Location = new System.Drawing.Point(566, 330);
            this.btnrecover.Name = "btnrecover";
            this.btnrecover.Size = new System.Drawing.Size(102, 33);
            this.btnrecover.TabIndex = 50;
            this.btnrecover.Text = "Recover";
            this.btnrecover.UseVisualStyleBackColor = false;
            this.btnrecover.Click += new System.EventHandler(this.btnrecover_Click);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(95, 205);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(503, 19);
            label1.TabIndex = 51;
            label1.Text = "Put in a least one of the Password Hints you entered when setting up this account" +
    "";
            // 
            // btntakeback
            // 
            this.btntakeback.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btntakeback.FlatAppearance.BorderSize = 0;
            this.btntakeback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btntakeback.Font = new System.Drawing.Font("Quicksand", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntakeback.ForeColor = System.Drawing.Color.White;
            this.btntakeback.Location = new System.Drawing.Point(566, 491);
            this.btntakeback.Name = "btntakeback";
            this.btntakeback.Size = new System.Drawing.Size(102, 33);
            this.btntakeback.TabIndex = 52;
            this.btntakeback.Text = "Take Back";
            this.btntakeback.UseVisualStyleBackColor = false;
            this.btntakeback.Click += new System.EventHandler(this.btntakeback_Click);
            // 
            // Recover_Passwprd
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.btntakeback);
            this.Controls.Add(label1);
            this.Controls.Add(this.btnrecover);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(hint1Label);
            this.Controls.Add(this.hint1TextBox);
            this.Controls.Add(hint2Label);
            this.Controls.Add(this.hint2TextBox);
            this.Controls.Add(hint3Label);
            this.Controls.Add(this.hint3TextBox);
            this.Controls.Add(school_idLabel);
            this.Controls.Add(this.school_idTextBox);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.Name = "Recover_Passwprd";
            this.Text = "Recover Password";
            this.Load += new System.EventHandler(this.Recover_Passwprd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pindahFrameDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.security_detailsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PindahFrameDataSet pindahFrameDataSet;
        private System.Windows.Forms.BindingSource security_detailsBindingSource;
        private PindahFrameDataSetTableAdapters.security_detailsTableAdapter security_detailsTableAdapter;
        private PindahFrameDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox hint1TextBox;
        private System.Windows.Forms.TextBox hint2TextBox;
        private System.Windows.Forms.TextBox hint3TextBox;
        private System.Windows.Forms.TextBox school_idTextBox;
        private System.Windows.Forms.Button btnrecover;
        private System.Windows.Forms.Button btntakeback;
    }
}