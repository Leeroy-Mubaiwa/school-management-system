using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PindahFrame
{
    public partial class ISBN_Entry_Form : Form
    {
        public ISBN_Entry_Form()
        {
            InitializeComponent();
        }
        string school_id;//= "HAOFTE2INS";
        public void schoolDetails(string id)
        {
            school_id = id;
        }
        public void libray_id(string librayID)
        {
            library_id = librayID;
        }
        string library_id;
        private void ISBN_Entry_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pindahFrameDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.pindahFrameDataSet.Books);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.school_details' table. You can move, or remove it, as needed.
            this.school_detailsTableAdapter.FillByLoad(this.pindahFrameDataSet.school_details,school_id);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.school_diary_student' table. You can move, or remove it, as needed.
            timer1.Start();
            timer2.Start();
            btnsavebook.Text = library_id;

        }
        int Id, counting;
        string Subject, Title, Author, Publisher, Copyright, Edition, Pages, ISBn, NOB, NOAB, NOBB, Library_id,Shelf;

        private void timer2_Tick(object sender, EventArgs e)
        {
            library_idTextBox.Text = library_id;
        }

        private void iSBNTextBox1_TextChanged(object sender, EventArgs e)
        {
            iSBNTextBox.Text = iSBNTextBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool send = false;
            Libray_Control.bookAdd(false);
        }

        private void btnsavebook_Click(object sender, EventArgs e)
        {
            library_idTextBox.Text = this.Text;
            try
            {
                this.Validate();
                booksBindingSource.EndEdit();
                booksTableAdapter.Update(this.pindahFrameDataSet.Books);
                tableAdapterManager.UpdateAll(this.pindahFrameDataSet);
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = (counting) + " out of " + NOB;
        }

        bool Avail;
        public void Details( int Counting,int id, string subject, string title, string author, string publisher, string copyright, string edition, string pages,
           string ISBN, string numberofbooks, string numberofavailablebooks, string numberofborrowedbooks, string library_id, bool available,string shelf, string School_id)
        {
            counting = Counting;
            Id = id;
            Subject = subject;
            Title = title;
            Author = author;
            Publisher = publisher;
            Copyright = copyright;
            Edition = edition;
           Pages = pages;
            ISBn = ISBN;
            NOB = numberofbooks;
            NOAB = numberofavailablebooks;
            NOBB = numberofborrowedbooks;
           Library_id = library_id;
            Avail = available;
            Shelf = shelf;
            school_idTextBox.Text = school_id;
        }
        private void school_detailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
          
        }

        private void ISBN_Entry_Form_Shown(object sender, EventArgs e)
        {
            booksBindingSource.AddNew();

            bookIDTextBox.Text = Id.ToString();
            subjectTextBox.Text = Subject;
            titleTextBox.Text = Title;
            authorTextBox.Text = Author;
            publisherTextBox.Text = Publisher;
            copyrightTextBox.Text = Copyright;
            editionTextBox.Text = Edition;
            pagesTextBox.Text = Pages;
            iSBNTextBox.Text = ISBn;
            numberOfBooksTextBox.Text = NOB;
            numberOfAvailbleBooksTextBox.Text = NOAB;
            numberOfBorrowedBooksTextBox.Text = NOBB;
            library_idTextBox.Text = Library_id;
            shelfNoTextBox.Text = Shelf;
            if (Avail == true)
            {
                availbleCheckBox.CheckState = CheckState.Checked;
            }
            else
            {
                availbleCheckBox.CheckState = CheckState.Unchecked;
            }
            school_idTextBox.Text = school_id;
        }
    }
}
