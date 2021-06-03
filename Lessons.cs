using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PindahFrame
{
    public partial class Lessons : Form
    {
        public Lessons()
        {
            InitializeComponent();
        }

        private void school_detailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.school_detailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pindahFrameDataSet);

        }
        string school_id;//= "HAOFTE2INS";
        public void LoadSchool(string schoolid)
        {
            school_id = schoolid;
        }
        private void Lessons_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pindahFrameDataSet.lessons' table. You can move, or remove it, as needed.
            this.lessonsTableAdapter.Fill(this.pindahFrameDataSet.lessons);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.pindahFrameDataSet.classes);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.level_table' table. You can move, or remove it, as needed.
            this.level_tableTableAdapter.Fill(this.pindahFrameDataSet.level_table);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.school_details' table. You can move, or remove it, as needed.
            this.school_detailsTableAdapter.FillByLoad(this.pindahFrameDataSet.school_details, school_id);
            timerSave.Interval = 200;
            timerSave.Start();
            dateSearch.Value = DateTime.Now;
            timeSearch.Value = DateTime.Now;
        }
        int a = 0;
        int c = 0;
        public void SaveLesson()
        {

            //  Invoke(new Action(() =>
            {
                lblpreview.Text = "Saving your data";
            }//));

            this.Validate();
            lessonsBindingSource.EndEdit();
            lessonsTableAdapter.Update(this.pindahFrameDataSet.lessons);
            tableAdapterManager.UpdateAll(this.pindahFrameDataSet);


            //  Invoke(new Action(() =>
            {
                lblpreview.Text = "Last saved 1 minute ago";
            }//));
            timerSave.Start();

        }
        private void timerSave_Tick(object sender, EventArgs e)
        {

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            
            lessonsBindingSource.RemoveCurrent();
            lessonsTableAdapter.Update(this.pindahFrameDataSet.lessons);
            tableAdapterManager.UpdateAll(this.pindahFrameDataSet);
        }

        private void btnupdatelessons_Click(object sender, EventArgs e)
        {
           
            if (subjectTextBox.Text == "" && titleTextBox.Text == "")
            {
                lessonsBindingSource.RemoveCurrent();
            }
            else
            {
                if (subjectTextBox.Text == "")
                {
                    subjectTextBox.Text = "No Subject selected";
                }
                try
                {
                    this.Validate();
                    lessonsBindingSource.EndEdit();
                    lessonsTableAdapter.Update(this.pindahFrameDataSet.lessons);
                    tableAdapterManager.UpdateAll(this.pindahFrameDataSet);

                }
                catch
                {
                    MessageBox.Show("You tried entering a lesson without a subject. Please click close and try again");
                    lessonsBindingSource.RemoveCurrent();
                }
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnaddnewlesson_Click(object sender, EventArgs e)
        {
            lessonsBindingSource.AddNew();
            pnllesson.Visible = true;
           
            dateDateTimePicker.Value = DateTime.Now;
            timestartDateTimePicker.Value = DateTime.Now;
            timefinishDateTimePicker.Value = DateTime.Now;

            gridLessons.Visible = false;
        }

        private void btnclosepanel_Click(object sender, EventArgs e)
        {
            pnllesson.Visible = false;
            gridLessons.Visible = true;
        }

        private void lblpreview_Click(object sender, EventArgs e)
        {
            pnllesson.Visible = true;
            gridLessons.Visible = false;
        }

        private void btnsearchlesson_Click(object sender, EventArgs e)
        {
            DateTime dateTimes = dateSearch.Value;
            DateTime time = timeSearch.Value;
           string a =  String.Format("{0:yyyy-MM-dd}", dateTimes);
          string b =   String.Format(" {00:00:00}", time.ToShortTimeString());
            string title = "null";
            try
            {
               
                title = txtsearchlesson.Text;
            }
            catch { }
            lessonsBindingSource.Filter = "date = '" + a + "' OR timestart = '" + b + "' OR " + "timefinish = '" + b + "' OR title like '%" + title + "%' OR " +
                " subject like '%" + title + "%'";
        }

        private void btnshowall_Click(object sender, EventArgs e)
        {
            lessonsBindingSource.RemoveFilter();
        }

        private void btnloadfromfile_Click(object sender, EventArgs e)
        {
          /*  OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PDF files and Word Documents (*.pdf) ;(*.doc); (*.docx); (*.rtf); (*.txt);| *.pdf;*.doc;*.docx;*.rtf;*.txt";
            openFileDialog.Title = "Choose the document which contains the information. You can choose to leave it blank";
            openFileDialog.Multiselect = false;
            openFileDialog.ShowDialog();
            try
            {
                pdf_copy_locationTextBox.Text = openFileDialog.FileName;
                pdfTextBox.Text = openFileDialog.SafeFileName;

                byte[] pdf;
                     FileStream file;
                BinaryReader binary = mew Binary
                file.BeginRead(pdf,0,openFileDialog.)
            }
            catch
            {
                MessageBox.Show("No file selected");
            }*/
        }
    }
}