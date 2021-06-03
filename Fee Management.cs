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
    public partial class Fee_Management : Form
    {
        public Fee_Management()
        {
            InitializeComponent();
        }
        string school_id;
        public void schoolDetails(string id)
        {
            school_id = id;
        }
        private void Fee_Management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pindahFrameDataSet.Total_fees' table. You can move, or remove it, as needed.
            this.total_feesTableAdapter.Fill(this.pindahFrameDataSet.Total_fees);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.Other_Fees' table. You can move, or remove it, as needed.
            this.other_FeesTableAdapter.Fill(this.pindahFrameDataSet.Other_Fees);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.fees' table. You can move, or remove it, as needed.
            this.feesTableAdapter.Fill(this.pindahFrameDataSet.fees);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.pindahFrameDataSet.classes);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.level_table' table. You can move, or remove it, as needed.
            this.level_tableTableAdapter.Fill(this.pindahFrameDataSet.level_table);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.school_details' table. You can move, or remove it, as needed.
            this.school_detailsTableAdapter.FillByLoad(this.pindahFrameDataSet.school_details,school_id);
            timerSchoolID.Start();
        }

        private void btnaddothers_Click(object sender, EventArgs e)
        {
            other_FeesBindingSource.AddNew();
            dateDateTimePicker.Value = DateTime.Now;

        }
        public void TotalFirst(double tx)
        {

        }
       
        char[] vs = new char[100];
    
        double bm = 0, tx = 0;
        char[] validNumber=null;
        bool inserted = false;
        public void zeroValue(TextBox cho,string text)
        {
            validNumber = text.ToCharArray();
            try
            {
               
                bm = double.Parse(text);
                tx += bm;
                
            }
            catch
            {
                inserted = false;
                cho.Clear();
                foreach(char i in validNumber)
                {
                    if ((i == '0' || i == '5' || i == '4' || i == '3' || i == '2' || i == '1' ||
                        i == '6' || i == '7' || i == '8' || i == '9' || i == '.') && inserted == false)
                    {
                     
                        cho.Text +=i;
                    }
                    
                }
                inserted = true;

            }
        }
        private void timerSchoolID_Tick(object sender, EventArgs e)
        {
            //progressbar
            if (progressagain == true)
            {
                if (progressBarMain.Value > 100)
                {
                    progressBarMain.Maximum += 10;
                    progress += 10;
                    progressBarMain.Value = progress;
                    //progressBarMain.PerformStep();
                    progressBarMain.Update();
                }
            }
            if (feesBindingSource.Count > 1)
            {
                btnaddfees.Visible = false;
            }
            else
            {
                btnaddfees.Visible = true;
            }
            school_idTextBoxFEES_MAIN.Text = school_id;
            school_idTextBoxOTHERFEES.Text = school_id;
                  ////add data in default items
                 zeroValue(feesTextBox, feesTextBox.Text);
                  zeroValue(levyTextBox, levyTextBox.Text);
                  zeroValue(uniformsTextBox,uniformsTextBox.Text);
                  zeroValue(sportsTextBox,sportsTextBox.Text);
                 zeroValue(clubsTextBox,clubsTextBox.Text);

            int ab = dataGridView1.Rows.Count;
            double tx1 = 0;
            try
            {
                for (int g = 0; g < ab; g++)
                {
                    tx1 += (double)dataGridView1.Rows[g].Cells[1].Value;
                }
            }
            catch { }
            double total = tx1 + tx;
            txttotal.Text = Math.Round(total,2).ToString();
            total = 0;
            tx = 0;
            tx1 = 0;
            bm = 0;

          
        }
        public void UpdateAll()
        {
            tableAdapterManager.UpdateAll(this.pindahFrameDataSet);
        }
        bool progressagain = false;
        int progress=10;
        private void btnsave_Click(object sender, EventArgs e)
        {
            progressagain = true;
            progressBarMain.Visible = true;
            this.Validate();
            feesBindingSource.EndEdit();
            feesTableAdapter.Update(this.pindahFrameDataSet.fees);
            UpdateAll();
            this.Validate();
            other_FeesBindingSource.EndEdit();
            int b=   other_FeesTableAdapter.Update(this.pindahFrameDataSet.Other_Fees);
            UpdateAll();


            ///finally add to totals table
            ///
            string total = txttotal.Text;
            txttotal.Text = total;
            this.Validate();
            total_feesBindingSource.EndEdit();

            total_feesTableAdapter.Update(this.pindahFrameDataSet.Total_fees);
            UpdateAll();
            MessageBox.Show("Good, all your data has been updated. ", "Data updated");
            lbllastupdate.Text = "Last Updated " + DateTime.Now.ToLongTimeString();

            if (b==0)
            {
                progressagain = false;
                progressBarMain.Visible = false;
            }

        }
        public void addTotalFeeDetails()
        {
            class_idTextBox1.Text = class_idTextBox.Text;
            school_idTextBox.Text = school_idTextBoxFEES_MAIN.Text;
            fee_idTextBox.Text = counterTextBox.Text;
            
        }
        private void btnaddfees_Click(object sender, EventArgs e)
        {
            feesBindingSource.AddNew();
            dateDateTimePicker.Value = DateTime.Now;
            total_feesBindingSource.AddNew();
            addTotalFeeDetails();
        }

        private void feesTextBox_TextChanged(object sender, EventArgs e)
        {
          
           
        }
    }
}
