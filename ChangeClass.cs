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
    public partial class ChangeClass : Form
    {
        public ChangeClass()
        {
            InitializeComponent();
        }

        string schoolID, names;
        public void loadDetails(string name, string school_id)
        {
            schoolID = school_id;
            names = name;
        }
       
        private void ChangeClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pindahFrameDataSet.school_details' table. You can move, or remove it, as needed.
            this.school_detailsTableAdapter.FillByLoad(this.pindahFrameDataSet.school_details,schoolID);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.level_table' table. You can move, or remove it, as needed.
            this.level_tableTableAdapter.Fill(this.pindahFrameDataSet.level_table);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.pindahFrameDataSet.classes);
            textBox1.Text = names;
           
        }

        private void subjectsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            classesBindingSource.Filter = "name LIKE '" + textBox1.Text + "%%' ";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            classesBindingSource1.Filter = "name LIKE '" + textBox2.Text + "%%' ";
        }

        private void btntransfer_Click(object sender, EventArgs e)
        {
            string full =level_tableComboBox.Text +" " + comboBox2.Text;
            Dashboard.receiveNewClass(full, lblnextclass.Text);
            this.Close();
        }

        
    }
}
