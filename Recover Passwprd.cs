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
    public partial class Recover_Passwprd : Form
    {
        public Recover_Passwprd()
        {
            InitializeComponent();
        }

        private void security_detailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.security_detailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pindahFrameDataSet);

        }

        private void Recover_Passwprd_Load(object sender, EventArgs e)
        {
         
        }

        private void btnrecover_Click(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pindahFrameDataSet.security_details' table. You can move, or remove it, as needed.
            this.security_detailsTableAdapter.Fill(this.pindahFrameDataSet.security_details);
            string a = school_idTextBox.Text;
            string b = hint1TextBox.Text;
            string c = hint2TextBox.Text;
            string d = hint3TextBox.Text;
            this.security_detailsBindingSource.Filter = "school_id = '" + a + "' AND (hint1 = '" + b + "' OR hint2 = '" + c + "' OR" +
                " hint3 = '" + d + "') ";
        }

        private void btntakeback_Click(object sender, EventArgs e)
        {
            Login.Password(passwordTextBox.Text);
            this.Close();
        }
    }
}
