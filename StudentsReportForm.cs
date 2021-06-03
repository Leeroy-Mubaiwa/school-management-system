using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PindahFrame
{
    public partial class StudentsReportForm : Form
    {
        public StudentsReportForm()
        {
            InitializeComponent();
           
        }
        public void text()
        {
            //richTextBox1.AppendText("I love GOD");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

            text();


        }
        private void button1_Click(object sender, EventArgs e)
        {


        }
        string school_id;
        public void LoadSchool(string schoolid)
        {
            school_id = schoolid;
        }
        public void loadAllThings()
        {

            // TODO: This line of code loads data into the 'PindahFrameDataSet.classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.PindahFrameDataSet.classes);
            // TODO: This line of code loads data into the 'PindahFrameDataSet.level_table' table. You can move, or remove it, as needed.
            this.level_tableTableAdapter.Fill(this.PindahFrameDataSet.level_table);
            // TODO: This line of code loads data into the 'PindahFrameDataSet.image' table. You can move, or remove it, as needed.
            this.imageTableAdapter.Fill(this.PindahFrameDataSet.image);
            // TODO: This line of code loads data into the 'PindahFrameDataSet.school_details' table. You can move, or remove it, as needed.
            this.school_detailsTableAdapter.FillByLoad(this.PindahFrameDataSet.school_details, school_id);

            // TODO: This line of code loads data into the 'wideOpenDataSet.TennisReservationSystem' table. You can move, or remove it, as needed.
            //   this.TennisReservationSystemTableAdapter.Fill(this.wideOpenDataSet.TennisReservationSystem);
            // TODO: This line of code loads data into the 'PindahFrameDataSet.school_diary_student' table. You can move, or remove it, as needed.
            this.school_diary_studentTableAdapter.Fill(this.PindahFrameDataSet.school_diary_student);
         
            // timer1.Start();

            Invoke(new Action(() =>
            {
                this.reportViewer1.RefreshReport();
            }));
        }
        private void StudentsReportForm_Load(object sender, EventArgs e)
        {
            loadAllThings();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*   int a = customersDataGridView.Columns.Count;
               int b = customersBindingSource.Count;
               int p = 255,m=0;
             for(int y=0;y<b;y++)
               {
                   m++;
                   p--;
                   string row = y.ToString();
                   for(int u =0; u<a;u++)
                   {
                       row += ("____" + customersDataGridView.Rows[y].Cells[u].Value);
                       richTextBox1.AppendText("_");
                   }
                   richTextBox1.AppendText("\n"+row+"\n");

               }*/

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.DefaultExt = "*.png";
            openFileDialog.AddExtension = true;
            openFileDialog.ShowDialog();
            int a = customersDataGridView.ColumnCount;
            try
            {
                customersDataGridView.CurrentRow.Cells[a - 1].Value = Image.FromFile(openFileDialog.FileName);
                customersBindingSource.EndEdit();
               // customersTableAdapter.Update(this.wideOpenDataSet.Customers);
              //  tableAdapterManager.UpdateAll(this.wideOpenDataSet);
            }
            catch { }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

      

        private void timer1_Tick(object sender, EventArgs e)
        {
            int b;
            b = customersDataGridView.ColumnCount;
            string profile = "";
            for (int y = 0; y < b; y++)
            {
                try
                {
                    var image = customersDataGridView.CurrentRow.Cells[b - 1].Value;
                    if (y == b - 2)
                    {
                        try
                        {
                            profile += customersDataGridView.CurrentRow.Cells[y].Value.ToString();
                        //    richTextBox1.Rtf = image + profile;
                        }
                        catch { }
                    }



                }
                catch { }
            }
        }

        int level, classchosen;
        public void reloadReport()
        {

         
            Invoke(new Action(() =>
            {

                try
                {


                    // TODO: This line of code loads data into the 'PindahFrameDataSet.classes' table. You can move, or remove it, as needed.
                    this.classesTableAdapter.FillByPrint(this.PindahFrameDataSet.classes, school_id, level, classchosen);
                    // TODO: This line of code loads data into the 'PindahFrameDataSet.level_table' table. You can move, or remove it, as needed.
                    this.level_tableTableAdapter.FillByPrint(this.PindahFrameDataSet.level_table, school_id, classchosen);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);//"No data loaded. For now you can print the whole list of students");
                }
            }));


            Invoke(new Action(() =>
            {
                this.reportViewer1.RefreshReport();
            }));
        }
        private void btnprintthis_Click(object sender, EventArgs e)
        {
         //   Thread thread = new Thread(reloadReport);
           // thread.Start();
          

        }

        private void btnprintall_Click(object sender, EventArgs e)
        {

         //   level = Int32.Parse(level_tableComboBox.ValueMember);
           // classchosen = Int32.Parse(classesComboBox.ValueMember);
            //Thread thread = new Thread(loadAllThings);
            //thread.Start();

           
        }
    } }
