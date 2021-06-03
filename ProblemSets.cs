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
    public partial class ProblemSets : Form
    {
        public ProblemSets()
        {
            InitializeComponent();
        }
        string school_id;
        public void LoadSchool(string schoolid)
        {
            school_id = schoolid;
        }
        private void ProblemSets_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pindahFrameDataSet.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.pindahFrameDataSet.staff);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.level_table' table. You can move, or remove it, as needed.
            this.level_tableTableAdapter.Fill(this.pindahFrameDataSet.level_table);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.problemsets' table. You can move, or remove it, as needed.
            this.problemsetsTableAdapter.Fill(this.pindahFrameDataSet.problemsets);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.problemsets' table. You can move, or remove it, as needed.
            this.problemsetsTableAdapter.Fill(this.pindahFrameDataSet.problemsets);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.school_details' table. You can move, or remove it, as needed.
            this.school_detailsTableAdapter.FillByLoad(this.pindahFrameDataSet.school_details,school_id);

        }

        private void btnclosepanel_Click(object sender, EventArgs e)
        {
            pnllesson.Visible = false;
            gridLessons.Visible = true;
            btnpreview.Visible = false;

        }

        private void btnaddnewlesson_Click(object sender, EventArgs e)
        {
            pnllesson.Visible = true;
            problemsetsBindingSource.AddNew();
            dateDateTimePicker.Value = DateTime.Now;
            gridLessons.Visible = false;
            school_idTextBox.Text = school_id;
            level_idTextBox.Text = idTextBox.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (worktitleTextBox.Text == "" || worktypeTextBox.Text == "")
            {
                MessageBox.Show("Set title and Type are required");
                this.problemsetsBindingSource.RemoveCurrent();
            }
            else
            {
                this.Validate();
                problemsetsBindingSource.EndEdit();
                problemsetsTableAdapter.Update(this.pindahFrameDataSet.problemsets);
                tableAdapterManager.UpdateAll(this.pindahFrameDataSet);
                MessageBox.Show("Saved", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnpreview.Visible = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            staffBindingSource.Filter = "staff_surname like '%"+textBox1.Text +"%'";
          
            
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            this.Validate();
            problemsetsBindingSource.RemoveCurrent();
            this.problemsetsTableAdapter.Update(this.pindahFrameDataSet.problemsets);
            this.tableAdapterManager.UpdateAll(this.pindahFrameDataSet);
            MessageBox.Show("Deleted Set that was done on " + dateDateTimePicker.Value.ToShortDateString() + " ");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            worktypeTextBox.Text = comboBox1.Text;
        }

        private void btnpreview_Click(object sender, EventArgs e)
        {
            pnllesson.Visible = true;
            pnllesson.BringToFront();
            gridLessons.Visible = false;
            btnpreview.Visible = false;

        }

        private void staffComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tutorresponsibleTextBox.Text = staffComboBox.Text;
        }
    }
}
