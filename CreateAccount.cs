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
    public partial class CreateAccount : Form
    {
        public CreateAccount()
        {
            InitializeComponent();
        }
        int newCount = 0;
        public void loadSchools()
        {
           
            Invoke(new Action(() =>
           {
               
            }));
        }
        private void CreateAccount_Load(object sender, EventArgs e)
        {
          
            // TODO: This line of code loads data into the 'pindahFrameDataSet.school_details' table. You can move, or remove it, as needed.
            this.school_detailsTableAdapter.Fill(this.pindahFrameDataSet.school_details);
            newCount = school_detailsBindingSource.Count;
            school_detailsBindingSource.AddNew();
            timerRemoveKeyWords.Start();
            addItemstoComboBox();
        }

        private void school_detailsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.school_detailsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pindahFrameDataSet);

        }
        string[] arry =  { "Creche .","Kindergarten .","Primary School",
                "Middle School","Junior School", "Secondary School","Senior School", "High School", "University .", "College .", "Institute ." };

        public void addItemstoComboBox()
        {
            typeComboBox.Items.Clear();
            foreach (string s in arry)
            {
                typeComboBox.Items.Add(s);
            }

        }
        string schoolid_name;
        public void removeKeyWords()
        {
            ErrorProvider errorProvider = new ErrorProvider();
            errorProvider.SetError(nameTextBox, "");
            errorProvider.Clear();
            cityTextBox.Clear();
            if (nameTextBox.Focused == false)
            {
                try
                {
                    string gh = null;
                    string[] found = new string[10];
                    string str = nameTextBox.Text;
                    string[] splitter = str.Split();
                    //   countryTextBox.Text = splitter[1];
                    foreach (string type in arry)
                    {
                        string[] splitter_arry = type.Split(' ');
                        string a1 = splitter_arry[0];
                        //     zoneTextBox.Text = a1;

                        string a2 = splitter_arry[1];
                        //     districtTextBox.Text = a2;
                        int iteration = 0;
                        foreach (string text in splitter)
                        {


                            if (text == (a1) || text == (a2) || text == (a1).ToUpper() || text == (a2).ToUpper()
                               || text == (a1).ToLower() || text == (a2).ToLower())
                            {
                                found[iteration] = text;

                                gh = null;
                                for (int yu = 0; yu < found.Length; yu++)
                                {
                                    if (found[yu] != null)
                                    {
                                        gh += " " + found[yu];
                                    }
                                }
                                // cityTextBox.Text = "Found" + " " + gh;

                                splitter[iteration] = "";
                            }
                            iteration++;
                        }
                    }
                    if (gh.Length > 5)
                    {
                        nameTextBox.Clear();

                        errorProvider.SetError(nameTextBox, "The software removed keywords \"" + gh + "\" because you will need to enter the again.\n\n " +
                            "This reduces data duplication");
                        //  errorProvider.GetError(zoneTextBox);

                        foreach (string ppp in splitter)
                        {
                          
                            nameTextBox.Text += ppp + ' ';
                           
                        }
                       
                    }
                }
                catch { }
            }

          
        }
        public void schoolCoding()
        {
            try { 
            //put the code for school id
            string[] schoolidname = nameTextBox.Text.Split();
            schoolid_name = "";
            foreach (string ggg in schoolidname)
            {
                if (ggg.Length > 2)
                {
                    schoolid_name += ggg.Remove(2);
                }
                else
                {
                    schoolid_name += ggg;
                }

            }
            //put the code for school counte
            schoolid_name += countTextBox.Text;
            //put the code for school type code
            string[] schooltype = typeComboBox.Text.Split();
            foreach (string ooo in schooltype)
            {
                schoolid_name += ooo.Remove(3);
            }
        }catch{}
           school_idTextBox.Text = schoolid_name;
        }
        string[] tryer = new string[20];
        private void timerRemoveKeyWords_Tick(object sender, EventArgs e)
        {
            countTextBox.Text = (newCount+1).ToString();

            schoolCoding();
            school_idTextBox1.Text = schoolid_name;
        }


        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeKeyWords();
        }

        private void typeComboBox_Click(object sender, EventArgs e)
        {
            addItemstoComboBox();
        }

        private void school_idLabel_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {


























        }

        private void nameLabel_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btncontinue_Click(object sender, EventArgs e)
        {
            xuiFlatTab1.SelectedIndex = 1;
        }
        int a = 0;int b;
        private void timerAnimation_Tick(object sender, EventArgs e)
        {

           
        }

        private void btnprevious_Click(object sender, EventArgs e)
        {
            xuiFlatTab1.SelectedIndex = 0;
        }

        private void btncontinue_2_Click(object sender, EventArgs e)
        {
            xuiFlatTab1.SelectedIndex = 2;
        }

        private void btnprevios_2_Click(object sender, EventArgs e)
        {
            xuiFlatTab1.SelectedIndex = 1;
        }

        private void btncreateaccount_Click(object sender, EventArgs e)
        {
            //try
            {
                countTextBox.Text = (newCount + 1).ToString();
                this.Validate();
                school_detailsBindingSource.EndEdit();
                school_detailsTableAdapter.Update(this.pindahFrameDataSet.school_details);
                tableAdapterManager.UpdateAll(this.pindahFrameDataSet);
            }
         //   catch
            {
           //     MessageBox.Show("An error occured. Contact Pindah Frame.", "Ooops");
            }
            // TODO: This line of code loads data into the 'pindahFrameDataSet.security_details' table. You can move, or remove it, as needed.
            this.security_detailsTableAdapter.Fill(this.pindahFrameDataSet.security_details);
            security_detailsBindingSource.AddNew();
          
            xuiFlatTab1.SelectedIndex = 3;
            school_idTextBox1.Text = schoolid_name.ToUpper();
        }

        private void btnbegincreating_Click(object sender, EventArgs e)
        {
            loadSchools();
           school_detailsBindingSource.AddNew();
           timerRemoveKeyWords.Start();

           
        }

        private void login_click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == textBox1.Text)
            {
                try
                {
                    this.Validate();
                    security_detailsBindingSource.EndEdit();
                    security_detailsTableAdapter.Update(this.pindahFrameDataSet.security_details);
                    tableAdapterManager.UpdateAll(this.pindahFrameDataSet);
                    MessageBox.Show("Complete. Welcome to Frame", "Done", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                   // Dashboard dashboard = new Dashboard();
                    //dashboard.loadSchool(schoolid_name);
                    //dashboard.Show();
                    this.Hide();
                }
                catch
                {
                    MessageBox.Show("Password Cannot be empty. You need it for security");
                }
            }
            else
            {
                MessageBox.Show("Passwords must match", "Not Done", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        char[] password = new char[15];

        int h;
        char[] validation = new char[15];
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            label5.Text = "";
            h = passwordTextBox.Text.Length;
            //length
            initial_length = h;

            //adding stuff to array and validation
            if (h > 0)
            {
                //p = passwordTextBox.Text.ElementAt(h - 1);

                //takes the text and puts it to array
                password = passwordTextBox.Text.ToCharArray();

                //just a test to be deleted
                foreach (char x in password)
                {

                    label5.Text += x;
                }
            }
            else
            {
                numCheck.Checked = false;
                capsCheck.Checked = false;
                lowercaseCheck.Checked = false;
                countCheck.Checked = false;
            }
            if (h >= 8)
            {
                countCheck.Checked = true;
            }
            //calling the validation method for casing
            checkPassword(password, h);
        }
        int initial_length;
        public void checkPassword(char[] password, int length)
        {


            foreach (char pass in password)
            {
                //check if its upper case
                if (pass >= 65 && pass <= 90)
                {
                    capsCheck.Checked = true;
                    //   password[a] = pass;
                    //  label5.Text += password[a];
                    validation[h] = 'C';
                }
                //check for small letter
                if (pass >= 97 && pass <= 122)
                {
                    lowercaseCheck.Checked = true;
                    //  password[a] = pass;
                    //  label5.Text += password[a];
                    validation[h] = 'L';
                }
                //check for number
                if (pass >= 48 && pass <= 57)
                {
                    numCheck.Checked = true;
                    //   password[a] = pass;
                    //   label5.Text += password[a];
                    validation[h] = 'N';
                }


            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            xuiFlatTab1.SelectedIndex = 2;
        }

        private void btncontinue_image_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                imageBindingSource.EndEdit();
                imageTableAdapter.Update(this.pindahFrameDataSet.image);
                tableAdapterManager.UpdateAll(this.pindahFrameDataSet);
                xuiFlatTab1.SelectedIndex = 4;
            }
            catch { }
        }

        private void btnloadimage_Click(object sender, EventArgs e)
        {
            //save data
            // TODO: This line of code loads data into the 'pindahFrameDataSet.image' table. You can move, or remove it, as needed.
            this.imageTableAdapter.Fill(this.pindahFrameDataSet.image);
            imageBindingSource.AddNew();

          //  try
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Logos  (*.png) ;(*.jpg); (*.jpeg);| *.png; *.jpeg; *jpg";
                opf.Title = "Choose a scanned logos or normal logo";
                opf.ShowDialog();
                string picture = opf.FileName;
                pathTextBox.Text = picture;
                descriptionTextBox.Text = "School Logo";
               
                imagenameTextBox.Text = opf.SafeFileName;
                school_idTextBox2.Text = schoolid_name.ToUpper();
                imagePictureBox.Image = Image.FromFile(opf.FileName);
               // MessageBox.Show("Its here");
            }
          //  catch (Exception pictre)
            {
          //      MessageBox.Show(pictre.Message + " \n \n " + pictre.StackTrace)
;
            }
        }
    }
}
