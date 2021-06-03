namespace PindahFrame
{
    partial class ISBN_Entry_Form
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
            System.Windows.Forms.Label bookIDLabel;
            System.Windows.Forms.Label subjectLabel;
            System.Windows.Forms.Label titleLabel;
            System.Windows.Forms.Label authorLabel;
            System.Windows.Forms.Label publisherLabel;
            System.Windows.Forms.Label copyrightLabel;
            System.Windows.Forms.Label editionLabel;
            System.Windows.Forms.Label pagesLabel;
            System.Windows.Forms.Label iSBNLabel;
            System.Windows.Forms.Label numberOfBooksLabel;
            System.Windows.Forms.Label numberOfAvailbleBooksLabel;
            System.Windows.Forms.Label numberOfBorrowedBooksLabel;
            System.Windows.Forms.Label library_idLabel;
            System.Windows.Forms.Label availbleLabel;
            System.Windows.Forms.Label shelfNoLabel;
            System.Windows.Forms.Label school_idLabel;
            System.Windows.Forms.Label iSBNLabel1;
            this.pindahFrameDataSet = new PindahFrame.PindahFrameDataSet();
            this.school_detailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.school_detailsTableAdapter = new PindahFrame.PindahFrameDataSetTableAdapters.school_detailsTableAdapter();
            this.tableAdapterManager = new PindahFrame.PindahFrameDataSetTableAdapters.TableAdapterManager();
            this.booksTableAdapter = new PindahFrame.PindahFrameDataSetTableAdapters.BooksTableAdapter();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookIDTextBox = new System.Windows.Forms.TextBox();
            this.subjectTextBox = new System.Windows.Forms.TextBox();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.publisherTextBox = new System.Windows.Forms.TextBox();
            this.copyrightTextBox = new System.Windows.Forms.TextBox();
            this.editionTextBox = new System.Windows.Forms.TextBox();
            this.pagesTextBox = new System.Windows.Forms.TextBox();
            this.iSBNTextBox = new System.Windows.Forms.TextBox();
            this.numberOfBooksTextBox = new System.Windows.Forms.TextBox();
            this.numberOfAvailbleBooksTextBox = new System.Windows.Forms.TextBox();
            this.numberOfBorrowedBooksTextBox = new System.Windows.Forms.TextBox();
            this.library_idTextBox = new System.Windows.Forms.TextBox();
            this.availbleCheckBox = new System.Windows.Forms.CheckBox();
            this.shelfNoTextBox = new System.Windows.Forms.TextBox();
            this.school_idTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnsavebook = new System.Windows.Forms.Button();
            this.iSBNTextBox1 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            bookIDLabel = new System.Windows.Forms.Label();
            subjectLabel = new System.Windows.Forms.Label();
            titleLabel = new System.Windows.Forms.Label();
            authorLabel = new System.Windows.Forms.Label();
            publisherLabel = new System.Windows.Forms.Label();
            copyrightLabel = new System.Windows.Forms.Label();
            editionLabel = new System.Windows.Forms.Label();
            pagesLabel = new System.Windows.Forms.Label();
            iSBNLabel = new System.Windows.Forms.Label();
            numberOfBooksLabel = new System.Windows.Forms.Label();
            numberOfAvailbleBooksLabel = new System.Windows.Forms.Label();
            numberOfBorrowedBooksLabel = new System.Windows.Forms.Label();
            library_idLabel = new System.Windows.Forms.Label();
            availbleLabel = new System.Windows.Forms.Label();
            shelfNoLabel = new System.Windows.Forms.Label();
            school_idLabel = new System.Windows.Forms.Label();
            iSBNLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pindahFrameDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_detailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bookIDLabel
            // 
            bookIDLabel.AutoSize = true;
            bookIDLabel.Location = new System.Drawing.Point(20, 8);
            bookIDLabel.Name = "bookIDLabel";
            bookIDLabel.Size = new System.Drawing.Size(60, 19);
            bookIDLabel.TabIndex = 0;
            bookIDLabel.Text = "Book ID:";
            // 
            // subjectLabel
            // 
            subjectLabel.AutoSize = true;
            subjectLabel.Location = new System.Drawing.Point(20, 39);
            subjectLabel.Name = "subjectLabel";
            subjectLabel.Size = new System.Drawing.Size(55, 19);
            subjectLabel.TabIndex = 2;
            subjectLabel.Text = "Subject:";
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new System.Drawing.Point(20, 70);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new System.Drawing.Size(36, 19);
            titleLabel.TabIndex = 4;
            titleLabel.Text = "Title:";
            // 
            // authorLabel
            // 
            authorLabel.AutoSize = true;
            authorLabel.Location = new System.Drawing.Point(20, 101);
            authorLabel.Name = "authorLabel";
            authorLabel.Size = new System.Drawing.Size(55, 19);
            authorLabel.TabIndex = 6;
            authorLabel.Text = "Author:";
            // 
            // publisherLabel
            // 
            publisherLabel.AutoSize = true;
            publisherLabel.Location = new System.Drawing.Point(20, 132);
            publisherLabel.Name = "publisherLabel";
            publisherLabel.Size = new System.Drawing.Size(69, 19);
            publisherLabel.TabIndex = 8;
            publisherLabel.Text = "Publisher:";
            // 
            // copyrightLabel
            // 
            copyrightLabel.AutoSize = true;
            copyrightLabel.Location = new System.Drawing.Point(20, 163);
            copyrightLabel.Name = "copyrightLabel";
            copyrightLabel.Size = new System.Drawing.Size(72, 19);
            copyrightLabel.TabIndex = 10;
            copyrightLabel.Text = "Copyright:";
            // 
            // editionLabel
            // 
            editionLabel.AutoSize = true;
            editionLabel.Location = new System.Drawing.Point(20, 194);
            editionLabel.Name = "editionLabel";
            editionLabel.Size = new System.Drawing.Size(53, 19);
            editionLabel.TabIndex = 12;
            editionLabel.Text = "Edition:";
            // 
            // pagesLabel
            // 
            pagesLabel.AutoSize = true;
            pagesLabel.Location = new System.Drawing.Point(20, 225);
            pagesLabel.Name = "pagesLabel";
            pagesLabel.Size = new System.Drawing.Size(48, 19);
            pagesLabel.TabIndex = 14;
            pagesLabel.Text = "Pages:";
            // 
            // iSBNLabel
            // 
            iSBNLabel.AutoSize = true;
            iSBNLabel.Location = new System.Drawing.Point(20, 256);
            iSBNLabel.Name = "iSBNLabel";
            iSBNLabel.Size = new System.Drawing.Size(40, 19);
            iSBNLabel.TabIndex = 16;
            iSBNLabel.Text = "ISBN:";
            // 
            // numberOfBooksLabel
            // 
            numberOfBooksLabel.AutoSize = true;
            numberOfBooksLabel.Location = new System.Drawing.Point(20, 287);
            numberOfBooksLabel.Name = "numberOfBooksLabel";
            numberOfBooksLabel.Size = new System.Drawing.Size(122, 19);
            numberOfBooksLabel.TabIndex = 18;
            numberOfBooksLabel.Text = "Number Of Books:";
            // 
            // numberOfAvailbleBooksLabel
            // 
            numberOfAvailbleBooksLabel.AutoSize = true;
            numberOfAvailbleBooksLabel.Location = new System.Drawing.Point(20, 318);
            numberOfAvailbleBooksLabel.Name = "numberOfAvailbleBooksLabel";
            numberOfAvailbleBooksLabel.Size = new System.Drawing.Size(173, 19);
            numberOfAvailbleBooksLabel.TabIndex = 20;
            numberOfAvailbleBooksLabel.Text = "Number Of Availble Books:";
            // 
            // numberOfBorrowedBooksLabel
            // 
            numberOfBorrowedBooksLabel.AutoSize = true;
            numberOfBorrowedBooksLabel.Location = new System.Drawing.Point(20, 349);
            numberOfBorrowedBooksLabel.Name = "numberOfBorrowedBooksLabel";
            numberOfBorrowedBooksLabel.Size = new System.Drawing.Size(185, 19);
            numberOfBorrowedBooksLabel.TabIndex = 22;
            numberOfBorrowedBooksLabel.Text = "Number Of Borrowed Books:";
            // 
            // library_idLabel
            // 
            library_idLabel.AutoSize = true;
            library_idLabel.Location = new System.Drawing.Point(20, 380);
            library_idLabel.Name = "library_idLabel";
            library_idLabel.Size = new System.Drawing.Size(70, 19);
            library_idLabel.TabIndex = 24;
            library_idLabel.Text = "Library id:";
            // 
            // availbleLabel
            // 
            availbleLabel.AutoSize = true;
            availbleLabel.Location = new System.Drawing.Point(20, 413);
            availbleLabel.Name = "availbleLabel";
            availbleLabel.Size = new System.Drawing.Size(59, 19);
            availbleLabel.TabIndex = 26;
            availbleLabel.Text = "Availble:";
            // 
            // shelfNoLabel
            // 
            shelfNoLabel.AutoSize = true;
            shelfNoLabel.Location = new System.Drawing.Point(20, 441);
            shelfNoLabel.Name = "shelfNoLabel";
            shelfNoLabel.Size = new System.Drawing.Size(63, 19);
            shelfNoLabel.TabIndex = 28;
            shelfNoLabel.Text = "Shelf No:";
            // 
            // school_idLabel
            // 
            school_idLabel.AutoSize = true;
            school_idLabel.Location = new System.Drawing.Point(20, 472);
            school_idLabel.Name = "school_idLabel";
            school_idLabel.Size = new System.Drawing.Size(66, 19);
            school_idLabel.TabIndex = 30;
            school_idLabel.Text = "school id:";
            // 
            // iSBNLabel1
            // 
            iSBNLabel1.AutoSize = true;
            iSBNLabel1.Location = new System.Drawing.Point(112, 64);
            iSBNLabel1.Name = "iSBNLabel1";
            iSBNLabel1.Size = new System.Drawing.Size(108, 19);
            iSBNLabel1.TabIndex = 71;
            iSBNLabel1.Text = "ISBN for Book :  ";
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
            this.tableAdapterManager.BooksTableAdapter = this.booksTableAdapter;
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
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.pindahFrameDataSet;
            // 
            // bookIDTextBox
            // 
            this.bookIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "BookID", true));
            this.bookIDTextBox.Location = new System.Drawing.Point(211, 5);
            this.bookIDTextBox.Name = "bookIDTextBox";
            this.bookIDTextBox.Size = new System.Drawing.Size(104, 25);
            this.bookIDTextBox.TabIndex = 1;
            // 
            // subjectTextBox
            // 
            this.subjectTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Subject", true));
            this.subjectTextBox.Location = new System.Drawing.Point(211, 36);
            this.subjectTextBox.Name = "subjectTextBox";
            this.subjectTextBox.Size = new System.Drawing.Size(104, 25);
            this.subjectTextBox.TabIndex = 3;
            // 
            // titleTextBox
            // 
            this.titleTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Title", true));
            this.titleTextBox.Location = new System.Drawing.Point(211, 67);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(104, 25);
            this.titleTextBox.TabIndex = 5;
            // 
            // authorTextBox
            // 
            this.authorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Author", true));
            this.authorTextBox.Location = new System.Drawing.Point(211, 98);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(104, 25);
            this.authorTextBox.TabIndex = 7;
            // 
            // publisherTextBox
            // 
            this.publisherTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Publisher", true));
            this.publisherTextBox.Location = new System.Drawing.Point(211, 129);
            this.publisherTextBox.Name = "publisherTextBox";
            this.publisherTextBox.Size = new System.Drawing.Size(104, 25);
            this.publisherTextBox.TabIndex = 9;
            // 
            // copyrightTextBox
            // 
            this.copyrightTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Copyright", true));
            this.copyrightTextBox.Location = new System.Drawing.Point(211, 160);
            this.copyrightTextBox.Name = "copyrightTextBox";
            this.copyrightTextBox.Size = new System.Drawing.Size(104, 25);
            this.copyrightTextBox.TabIndex = 11;
            // 
            // editionTextBox
            // 
            this.editionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Edition", true));
            this.editionTextBox.Location = new System.Drawing.Point(211, 191);
            this.editionTextBox.Name = "editionTextBox";
            this.editionTextBox.Size = new System.Drawing.Size(104, 25);
            this.editionTextBox.TabIndex = 13;
            // 
            // pagesTextBox
            // 
            this.pagesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Pages", true));
            this.pagesTextBox.Location = new System.Drawing.Point(211, 222);
            this.pagesTextBox.Name = "pagesTextBox";
            this.pagesTextBox.Size = new System.Drawing.Size(104, 25);
            this.pagesTextBox.TabIndex = 15;
            // 
            // iSBNTextBox
            // 
            this.iSBNTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "ISBN", true));
            this.iSBNTextBox.Location = new System.Drawing.Point(211, 253);
            this.iSBNTextBox.Name = "iSBNTextBox";
            this.iSBNTextBox.Size = new System.Drawing.Size(104, 25);
            this.iSBNTextBox.TabIndex = 17;
            // 
            // numberOfBooksTextBox
            // 
            this.numberOfBooksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "NumberOfBooks", true));
            this.numberOfBooksTextBox.Location = new System.Drawing.Point(211, 284);
            this.numberOfBooksTextBox.Name = "numberOfBooksTextBox";
            this.numberOfBooksTextBox.Size = new System.Drawing.Size(104, 25);
            this.numberOfBooksTextBox.TabIndex = 19;
            // 
            // numberOfAvailbleBooksTextBox
            // 
            this.numberOfAvailbleBooksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "NumberOfAvailbleBooks", true));
            this.numberOfAvailbleBooksTextBox.Location = new System.Drawing.Point(211, 315);
            this.numberOfAvailbleBooksTextBox.Name = "numberOfAvailbleBooksTextBox";
            this.numberOfAvailbleBooksTextBox.Size = new System.Drawing.Size(104, 25);
            this.numberOfAvailbleBooksTextBox.TabIndex = 21;
            // 
            // numberOfBorrowedBooksTextBox
            // 
            this.numberOfBorrowedBooksTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "NumberOfBorrowedBooks", true));
            this.numberOfBorrowedBooksTextBox.Location = new System.Drawing.Point(211, 346);
            this.numberOfBorrowedBooksTextBox.Name = "numberOfBorrowedBooksTextBox";
            this.numberOfBorrowedBooksTextBox.Size = new System.Drawing.Size(104, 25);
            this.numberOfBorrowedBooksTextBox.TabIndex = 23;
            // 
            // library_idTextBox
            // 
            this.library_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Library_id", true));
            this.library_idTextBox.Location = new System.Drawing.Point(211, 377);
            this.library_idTextBox.Name = "library_idTextBox";
            this.library_idTextBox.Size = new System.Drawing.Size(104, 25);
            this.library_idTextBox.TabIndex = 25;
            // 
            // availbleCheckBox
            // 
            this.availbleCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.booksBindingSource, "Availble", true));
            this.availbleCheckBox.Location = new System.Drawing.Point(211, 408);
            this.availbleCheckBox.Name = "availbleCheckBox";
            this.availbleCheckBox.Size = new System.Drawing.Size(104, 24);
            this.availbleCheckBox.TabIndex = 27;
            this.availbleCheckBox.Text = "checkBox1";
            this.availbleCheckBox.UseVisualStyleBackColor = true;
            // 
            // shelfNoTextBox
            // 
            this.shelfNoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "ShelfNo", true));
            this.shelfNoTextBox.Location = new System.Drawing.Point(211, 438);
            this.shelfNoTextBox.Name = "shelfNoTextBox";
            this.shelfNoTextBox.Size = new System.Drawing.Size(104, 25);
            this.shelfNoTextBox.TabIndex = 29;
            // 
            // school_idTextBox
            // 
            this.school_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "school_id", true));
            this.school_idTextBox.Location = new System.Drawing.Point(211, 469);
            this.school_idTextBox.Name = "school_idTextBox";
            this.school_idTextBox.Size = new System.Drawing.Size(104, 25);
            this.school_idTextBox.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Controls.Add(this.authorTextBox);
            this.panel1.Controls.Add(bookIDLabel);
            this.panel1.Controls.Add(this.school_idTextBox);
            this.panel1.Controls.Add(this.bookIDTextBox);
            this.panel1.Controls.Add(school_idLabel);
            this.panel1.Controls.Add(subjectLabel);
            this.panel1.Controls.Add(this.shelfNoTextBox);
            this.panel1.Controls.Add(this.subjectTextBox);
            this.panel1.Controls.Add(shelfNoLabel);
            this.panel1.Controls.Add(titleLabel);
            this.panel1.Controls.Add(this.availbleCheckBox);
            this.panel1.Controls.Add(this.titleTextBox);
            this.panel1.Controls.Add(availbleLabel);
            this.panel1.Controls.Add(authorLabel);
            this.panel1.Controls.Add(this.library_idTextBox);
            this.panel1.Controls.Add(library_idLabel);
            this.panel1.Controls.Add(publisherLabel);
            this.panel1.Controls.Add(this.numberOfBorrowedBooksTextBox);
            this.panel1.Controls.Add(this.publisherTextBox);
            this.panel1.Controls.Add(numberOfBorrowedBooksLabel);
            this.panel1.Controls.Add(copyrightLabel);
            this.panel1.Controls.Add(this.numberOfAvailbleBooksTextBox);
            this.panel1.Controls.Add(this.copyrightTextBox);
            this.panel1.Controls.Add(numberOfAvailbleBooksLabel);
            this.panel1.Controls.Add(editionLabel);
            this.panel1.Controls.Add(this.numberOfBooksTextBox);
            this.panel1.Controls.Add(this.editionTextBox);
            this.panel1.Controls.Add(numberOfBooksLabel);
            this.panel1.Controls.Add(pagesLabel);
            this.panel1.Controls.Add(this.iSBNTextBox);
            this.panel1.Controls.Add(this.pagesTextBox);
            this.panel1.Controls.Add(iSBNLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(42, 222);
            this.panel1.TabIndex = 32;
            // 
            // btnsavebook
            // 
            this.btnsavebook.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnsavebook.BackColor = System.Drawing.Color.Black;
            this.btnsavebook.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btnsavebook.FlatAppearance.BorderSize = 0;
            this.btnsavebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsavebook.ForeColor = System.Drawing.Color.White;
            this.btnsavebook.Location = new System.Drawing.Point(440, 180);
            this.btnsavebook.Name = "btnsavebook";
            this.btnsavebook.Size = new System.Drawing.Size(91, 30);
            this.btnsavebook.TabIndex = 71;
            this.btnsavebook.Text = "Add Book";
            this.btnsavebook.UseVisualStyleBackColor = false;
            this.btnsavebook.Click += new System.EventHandler(this.btnsavebook_Click);
            // 
            // iSBNTextBox1
            // 
            this.iSBNTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "ISBN", true));
            this.iSBNTextBox1.Location = new System.Drawing.Point(116, 86);
            this.iSBNTextBox1.Multiline = true;
            this.iSBNTextBox1.Name = "iSBNTextBox1";
            this.iSBNTextBox1.Size = new System.Drawing.Size(372, 37);
            this.iSBNTextBox1.TabIndex = 72;
            this.iSBNTextBox1.TextChanged += new System.EventHandler(this.iSBNTextBox1_TextChanged);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Orange;
            this.label1.Location = new System.Drawing.Point(226, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 73;
            this.label1.Text = "0 of 0";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(93)))), ((int)(((byte)(93)))), ((int)(((byte)(93)))));
            this.button1.Location = new System.Drawing.Point(229, 180);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(205, 30);
            this.button1.TabIndex = 74;
            this.button1.Text = "Cancel Adding Books";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // ISBN_Entry_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.ClientSize = new System.Drawing.Size(542, 222);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(iSBNLabel1);
            this.Controls.Add(this.iSBNTextBox1);
            this.Controls.Add(this.btnsavebook);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI Semilight", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ISBN_Entry_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ISBN_Entry_Form";
            this.Load += new System.EventHandler(this.ISBN_Entry_Form_Load);
            this.Shown += new System.EventHandler(this.ISBN_Entry_Form_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.pindahFrameDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.school_detailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PindahFrameDataSet pindahFrameDataSet;
        private System.Windows.Forms.BindingSource school_detailsBindingSource;
        private PindahFrameDataSetTableAdapters.school_detailsTableAdapter school_detailsTableAdapter;
        private PindahFrameDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private PindahFrameDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private System.Windows.Forms.TextBox bookIDTextBox;
        private System.Windows.Forms.TextBox subjectTextBox;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.TextBox publisherTextBox;
        private System.Windows.Forms.TextBox copyrightTextBox;
        private System.Windows.Forms.TextBox editionTextBox;
        private System.Windows.Forms.TextBox pagesTextBox;
        private System.Windows.Forms.TextBox iSBNTextBox;
        private System.Windows.Forms.TextBox numberOfBooksTextBox;
        private System.Windows.Forms.TextBox numberOfAvailbleBooksTextBox;
        private System.Windows.Forms.TextBox numberOfBorrowedBooksTextBox;
        private System.Windows.Forms.TextBox library_idTextBox;
        private System.Windows.Forms.CheckBox availbleCheckBox;
        private System.Windows.Forms.TextBox shelfNoTextBox;
        private System.Windows.Forms.TextBox school_idTextBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnsavebook;
        private System.Windows.Forms.TextBox iSBNTextBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer2;
    }
}