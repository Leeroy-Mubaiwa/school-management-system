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
    public partial class Libray_Control : Form
    {
        public Libray_Control()
        {
            InitializeComponent();
        }
        string school_id;//= "HAOFTE2INS";
        public void schoolDetails(string id)
        {
            school_id = id;
        }

        private void Libray_Control_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pindahFrameDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.pindahFrameDataSet.Books);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.pindahFrameDataSet.subjects);
            this.school_detailsTableAdapter.FillByLoad(this.pindahFrameDataSet.school_details, school_id);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.Library' table. You can move, or remove it, as needed.
            this.libraryTableAdapter.Fill(this.pindahFrameDataSet.Library);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.school_diary_student' table. You can move, or remove it, as needed.
            this.school_diary_studentTableAdapter.Fill(this.pindahFrameDataSet.school_diary_student);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.Borrow' table. You can move, or remove it, as needed.
            this.borrowTableAdapter.Fill(this.pindahFrameDataSet.Borrow);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.Borrow' table. You can move, or remove it, as needed.
            this.borrowTableAdapter.Fill(this.pindahFrameDataSet.Borrow);
            if (libraryBindingSource.Count == 0)
            {
                panel5.Visible = true;
                libraryBindingSource.AddNew();
            }
            else
            {
                panel5.Visible = false;
            }
            timer1.Start();
        }


        private void btnsavelibrary_Click(object sender, EventArgs e)
        {
            libraryBindingSource.EndEdit();
            libraryTableAdapter.Update(this.pindahFrameDataSet.Library);
            tableAdapterManager.UpdateAll(this.pindahFrameDataSet);
            MessageBox.Show("Library added. Now you can start adding books to your library. \a");
          //  pnlnewLibrary.Visible = false;
            panel5.Visible = false;
        }

        private void btncancel_adding_library_Click(object sender, EventArgs e)
        {
            panel5.Visible = false;
            libraryBindingSource.RemoveCurrent();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            school_idTextBox.Text = school_id;
            school_idTextBox1.Text = school_id;
            school_idTextBox2.Text = school_id;
            if(booksBindingSource.Count == 0)
                {
                lblfound.Visible = true;
            }
            else
            {
                lblfound.Visible = false;
            }
                
                
            if(notification_message<10)
            {
                pnlsaved.Visible = true;
                notification_message++;
            }
            else
            {
                pnlsaved.Visible = false;
            }
            try
            {
                day_to_returnDateTimePicker.Value = day_BorrowedDateTimePicker.Value.AddDays(double.Parse(days_to_borrowTextBox.Text));
            }
            catch { }
            
           // iSBNTextBox.Text = ISBN;
            //calcualte due date
            try
            {
                int a = (int)day_ReturnDateTimePicker.Value.Subtract(day_BorrowedDateTimePicker.Value).TotalDays;
                if (a > Int32.Parse(days_to_borrowTextBox.Text))
                {
                    dueTextBox.Text = a.ToString();
                }
                else
                {
                    dueTextBox.Text = "0";
                }
            }
            catch { }

            if (student_school_id_givenTextBox.Text == "")
            {
                if (student_national_id_numberTextBox.Text == "")
                {
                    if (student_birthentry_numberTextBox.Text == "")
                    {
                        student_idTextBox.Text = student_idTextBox1.Text;
                    }
                    else
                    {
                        student_idTextBox.Text = student_birthentry_numberTextBox.Text;
                    }
                }
                else
                {
                    student_idTextBox.Text = student_national_id_numberTextBox.Text;
                }
            }
            else
            {
                student_idTextBox.Text = student_school_id_givenTextBox.Text;
            }
            book_idTextBox.Text = bookIDTextBox.Text;
        }

        int notification_message = 100;
        private void btnsavebook_Click(object sender, EventArgs e)
        {
            if (numberOfAvailbleBooksTextBox.Text == "" || numberOfBorrowedBooksTextBox.Text == "")
            {
                numberOfAvailbleBooksTextBox.Text = numberOfBooksTextBox.Text;
                numberOfBorrowedBooksTextBox.Text = "0";
            }
            subjectTextBox.Text = subjectsComboBox.Text;
            if(copyrightTextBox.Text == "")
            {
                copyrightTextBox.Text = "0000";
            }
            if (iSBNTextBox.Text == "")
            {
                MessageBox.Show("ISBN is required. It allows the book to be identified");
            }
            else
            {
                if (Int32.Parse(numberOfAvailbleBooksTextBox.Text) + Int32.Parse(numberOfBorrowedBooksTextBox.Text) != Int32.Parse(numberOfBooksTextBox.Text))
                {
                    MessageBox.Show("The number of available books and borrowed books of a copy should add up to the total  in the Number of Books field. So, if no book has been borrowed," +
                        "just put a \n0\n in the borrowed books field ");
                }
                else
                {
                    
                    int start = booksBindingSource.Count;
                    for (int t = 1; t <= Int32.Parse(numberOfBooksTextBox.Text) ;t++)
                    {
                        start++;
                        PutData(t,  start);
                        if(Stop== false)
                        {
                            Stop = true;
                            break;
                        }
                        else
                        {
                            Stop = true;
                        }
                        notification_message = 0;
                    }

                }
            }
           
        }
        static bool Stop = true;
        public static void bookAdd(bool stop)
        {

            Stop = stop;
            
        }
        public void PutData(int counting, int counter)
        {
            ISBN_Entry_Form iSBN_Entry_Form = new ISBN_Entry_Form();
            iSBN_Entry_Form.schoolDetails(school_id);
            iSBN_Entry_Form.libray_id(library_idTextBox.Text);
          
            bool a;
            if(availbleCheckBox.CheckState == CheckState.Checked)
            {
                a = true;
            }
            else
            {
                a = false;
            }
           
            school_idTextBox.Text = school_id;
            iSBN_Entry_Form.Details (counting, counter, subjectTextBox.Text, titleTextBox.Text, authorTextBox.Text,            publisherTextBox.Text,
            copyrightTextBox.Text,            editionTextBox.Text,            pagesTextBox.Text,            iSBNTextBox.Text,
            numberOfBooksTextBox.Text,            numberOfAvailbleBooksTextBox.Text,            numberOfBorrowedBooksTextBox.Text,
            library_idTextBox.Text, a,shelfNoTextBox.Text, school_id);
            iSBN_Entry_Form.ShowDialog();
        }
        private void subjectsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            subjectTextBox.Text = subjectsComboBox.Text;
        }

        private void btnnewlibrary_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
           // panel5.BringToFront();
            libraryBindingSource.AddNew();
        }

        private void Libray_Control_Shown(object sender, EventArgs e)
        {
           
           
        }

        private void btnnewbook_Click(object sender, EventArgs e)
        {
            try
            {
                booksBindingSource.AddNew();
                availbleCheckBox.CheckState = CheckState.Checked;
            }
            catch
            {
                MessageBox.Show("Try again.\n\nError Occured");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       public void searchBook()
        {
            string search = " like '%" + txtsearch_book.Text + "%' OR ";
            string search_2 = " = " + txtsearch_book.Text + " OR ";
            booksBindingSource.Filter = "" +
                "Subject" + search +
                "Title" + search +
                "Author" + search +
                "Publisher" + search +
                //   "Copyright" + search_2 +
                //  "Edition" + search_2 +
                //    "Pages" + search_2 +
                "ISBN like '%" + txtsearch_book.Text + "%'";
              // "ShelfNo = " + txtsearch_book.Text  ;
        }
        private void btnsearch_book_Click(object sender, EventArgs e)
        {
            

        }

        private void txtsearch_book_TextChanged(object sender, EventArgs e)
        {
            searchBook();
        }

        private void btnlendbook_Click(object sender, EventArgs e)
        {
          
            borrowBindingSource.AddNew();
            day_BorrowedDateTimePicker.Value = DateTime.Now;
            xuiFlatTab2.SelectedIndex = 2;
        }

        private void txtsearchstudent_TextChanged(object sender, EventArgs e)
        {
            string a = txtsearchstudent.Text;
            school_diary_studentBindingSource.Filter = "firstname like '%" + a + "%' OR " +
                "                                       lastname like '%" + a + "%' OR "
                                                        + " middlename like '%" + a + "%' OR " +
                                                        "student_school_id_given like '%" + a + "%' OR" +
                                                        " student_id like '%" + a + "%' OR " +
                                                        " student_national_id_number like '%" + a + "%' ";
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            booksBindingSource.Filter = "ISBN like '%" + textBox14.Text + "%'";
            string ISBN = iSBNTextBox.Text;
            book_ISBNTextBox.Text = ISBN;

        }

        private void btnsavelendingdetails_Click(object sender, EventArgs e)
        {
            //validate borrowed to available
            //change borrowed status to unavailable
            booksBindingSource.Filter = "ISBN like '%" + book_ISBNTextBox.Text + "%'";
            availbleCheckBox.CheckState = CheckState.Unchecked;
            try
            {
                numberOfAvailbleBooksTextBox.Text = (Int32.Parse(numberOfAvailbleBooksTextBox.Text) - 1).ToString();
                numberOfBorrowedBooksTextBox.Text = (Int32.Parse(numberOfBorrowedBooksTextBox.Text) + 1).ToString();
            }
            catch { }
            if ((Int32.Parse(numberOfAvailbleBooksTextBox.Text) - 1) == 0)
            {
                MessageBox.Show("Cannot lend more books. All books under this name have been borrowed. Check to see the ones which are due");
            }
            else
            {
                booksBindingSource.EndEdit();
                booksTableAdapter.Update(this.pindahFrameDataSet.Books);

                this.Validate();
                borrowBindingSource.EndEdit();
                borrowTableAdapter.Update(this.pindahFrameDataSet.Borrow);
                this.tableAdapterManager.UpdateAll(this.pindahFrameDataSet);
                MessageBox.Show("Book Lent to student. Now you can come back and keep track of the dues of the book");
            }
        }

        private void btnlendbook_2_Click(object sender, EventArgs e)
        {
            borrowBindingSource.AddNew();
          
            day_BorrowedDateTimePicker.Value = DateTime.Now;
        }

        private void book_idTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
