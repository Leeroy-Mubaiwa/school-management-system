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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timeTimer.Start();
            loadData();
        }
        public void loadData()
        {

            // TODO: This line of code loads data into the 'pindahFrameDataSet.security_details' table. You can move, or remove it, as needed.this.security_detailsTableAdapter.Fill(this.pindahFrameDataSet.security_details);
            security_detailsTableAdapter.Fill(this.pindahFrameDataSet.security_details);
        }
        private void btncontinue_Click(object sender, EventArgs e)
        {
            loadData();
            security_detailsBindingSource.Filter = "school_id = '"+nameTextBox.Text+"' AND password = '"+emailaddressTextBox.Text +"'";
            if(security_detailsBindingSource.Count>=1)
            {
                Dashboard dashboard = new Dashboard();
                dashboard.loadSchool(nameTextBox.Text);
                dashboard.Show();
                
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Details, try again", "Incorrect details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timeTimer_Tick(object sender, EventArgs e)
        {
            
                DateTime dateTime = DateTime.Now;
                lbltime.Text = dateTime.ToLongTimeString();

                if (dateTime.TimeOfDay.Hours >= 12 && dateTime.Hour <= 18)
                {
                    lblgreeting.Text = "Good afternoon";
                }
                else
                     if (dateTime.Hour > 18)
                {
                    lblgreeting.Text = "Good evening, hope you had a good day";
                }
                else
                {
                    lblgreeting.Text = "Good morning, hope you ready for day!!";
                }
           

        }

        private void lbltime_Click(object sender, EventArgs e)
        {

        }
        static string code;
        static public void Password(string password)
        {
            code = password;
        }
        private void label1_Click(object sender, EventArgs e)
        {
            Recover_Passwprd recover_Passwprd = new Recover_Passwprd();
            recover_Passwprd.ShowDialog();
            emailaddressTextBox.Text = code;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
           
        }

        private void btncreateaccount_Click(object sender, EventArgs e)
        {
            CreateAccount createAccount = new CreateAccount();
            createAccount.ShowDialog();
            loadData();
        }
    }
}
