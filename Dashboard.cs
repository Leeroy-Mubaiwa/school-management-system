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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnsettings_school_Click(object sender, EventArgs e)
        {




            tabMainDash.SelectedIndex = 0;

        }

        private void imageBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.imageBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.pindahFrameDataSet);

        }
        string schoolID;// = "HAOFTE2INS";
        public void loadSchool(string school_id)
        {
            schoolID = school_id;
        }
        public void getNamePairs()
        {

            school_diary_studentListBox.Items.Clear();
            int a = dataListingStudent.Rows.Count;
            for (int b = 0; b < a; b++)
            {
                try
                {
                    string name = (string)dataListingStudent.Rows[b].Cells[0].Value.ToString();
                    string surname = (string)dataListingStudent.Rows[b].Cells[1].Value.ToString();

                    string full_name = name + "\t" + surname;
                    school_diary_studentListBox.Items.Add(full_name);

                    school_diary_studentListBox.Sorted = true;
                }
                catch { }
            }
        }
        public void MainLoad()
        {
            
           
        
            // TODO: This line of code loads data into the 'pindahFrameDataSet.contact_details' table. You can move, or remove it, as needed.
            this.contact_detailsTableAdapter.Fill(this.pindahFrameDataSet.contact_details);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.home_details' table. You can move, or remove it, as needed.
            this.home_detailsTableAdapter.Fill(this.pindahFrameDataSet.home_details);
            dataGridView2.ContextMenuStrip = menuStudent;
            // TODO: This line of code loads data into the 'pindahFrameDataSet.classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.pindahFrameDataSet.classes);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.school_diary_student' table. You can move, or remove it, as needed.
            this.school_diary_studentTableAdapter.Fill(this.pindahFrameDataSet.school_diary_student);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.pindahFrameDataSet.classes);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.level_table' table. You can move, or remove it, as needed.
            this.level_tableTableAdapter.Fill(this.pindahFrameDataSet.level_table);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.subjects' table. You can move, or remove it, as needed.
            this.subjectsTableAdapter.Fill(this.pindahFrameDataSet.subjects);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.school_details' table. You can move, or remove it, as needed.
            this.school_detailsTableAdapter.FillByLoad(this.pindahFrameDataSet.school_details, schoolID);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.image' table. You can move, or remove it, as needed.
            this.imageTableAdapter.Fill(this.pindahFrameDataSet.image);


            schoolLogo.Image = imagePictureBox.Image;
            timerAllStuff.Start();
            timerPairs.Start();

            pnlwait.Visible = false;
            pnlwait.SendToBack();

        }
        private void Dashboard_Shown(object sender, EventArgs e)
        {
            pnlwait.Visible = true;
            pnlwait.BringToFront();
            MainLoad();
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
           
            
        }

        private void typeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void typeComboBox_Click(object sender, EventArgs e)
        {
            addItemstoComboBox();
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


        private void typeComboBox_Click_1(object sender, EventArgs e)
        {

            typeComboBox.DataSource = null;
            addItemstoComboBox();
            removeKeyWords();
            addItemstoComboBox();
        }

        private void typeComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            typeTextBox.Text = typeComboBox.Text;
        }

        private void btnupdate_school_details_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            school_detailsBindingSource.EndEdit();
            school_detailsTableAdapter.Update(this.pindahFrameDataSet);
            tableAdapterManager.UpdateAll(this.pindahFrameDataSet);
            MessageBox.Show("Done. \n\nData Updated");
        }

        private void btnupdate_subjects_Click(object sender, EventArgs e)
        {

            dateintroducedDateTimePicker.Checked = true;

            this.Validate();
            subjectsBindingSource.EndEdit();
            subjectsTableAdapter.Update(this.pindahFrameDataSet.subjects);
            int b = tableAdapterManager.UpdateAll(this.pindahFrameDataSet);

            if (b == 0)
            {
                labelSaveSubjects.Text = "Last Updated " + DateTime.Now.ToLongTimeString();
                // titleTextBox.Clear();
                //  descriptionTextBox.Clear();

                //subjectsBindingSource.AddNew();

            }
            else
            {
                labelSaveSubjects.Text = "Click UPDATE to save data";
            }


        }

        private void btnaddnew_Click(object sender, EventArgs e)
        {
            subjectsBindingSource.AddNew();
            dateintroducedDateTimePicker.Checked = false;
            dateintroducedDateTimePicker.Value = DateTime.Now;
        }

        private void subjectsDataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        { var result = DialogResult;

            MessageBox.Show("There is some error in your data. Please check the format of your information. \n\nCHECK THAT DATE CORRESPNDS TO THE FORMAT OR JUST USE THE DATE PICKER ABOVE\n\nFormat: DD/MM/YYYY", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (result == DialogResult.OK)
            {
                subjectsDataGridView.CurrentRow.Cells[2].Value = DateTime.Now;
            }
        }

        private void btnAddLevels_Click(object sender, EventArgs e)
        {
            level_tableBindingSource.AddNew();

        }

        private void btnupdate_levels_Click(object sender, EventArgs e)
        {


            this.Validate();
            level_tableBindingSource.EndEdit();
            level_tableTableAdapter.Update(this.pindahFrameDataSet.level_table);
            int b = tableAdapterManager.UpdateAll(this.pindahFrameDataSet);

            if (b == 0)
            {
                labelLevels.Text = "Last Updated " + DateTime.Now.ToLongTimeString();


            }
            else
            {
                labelLevels.Text = "Click UPDATE to save data";
            }
        }

        private void btnAddNewClass_Click(object sender, EventArgs e)
        {
            classesBindingSource.AddNew();
        }

        private void btnUpdateClass_Click(object sender, EventArgs e)
        {
            this.Validate();
            classesBindingSource.EndEdit();
            classesTableAdapter.Update(this.pindahFrameDataSet.classes);
            int b = tableAdapterManager.UpdateAll(this.pindahFrameDataSet);

            if (b == 0)
            {
                labelClass.Text = "Last Updated " + DateTime.Now.ToLongTimeString();


            }
            else
            {
                labelClass.Text = "Click UPDATE to save data";
            }
        }

        private void AutoCalculateStudent_IDThroughGrid(object sender, DataGridViewRowEventArgs e)
        {
            student_schoolid_TextBox.Text = schoolID;
        }

        private void student_idLabel_Click(object sender, EventArgs e)
        {
        }

        private void btnaddclasses_level_Click(object sender, EventArgs e)
        {
            xuiFlatTab1.SelectedIndex = 3;
        }

        private void btnsave_student_Click(object sender, EventArgs e)
        {
            delete_statusCheckBox.Checked = true;
            if (delete_statusCheckBox.Checked == true)
            {


                delete_statusTextBox.Text = "false";

                this.Validate();
                school_diary_studentBindingSource.EndEdit();
                school_diary_studentTableAdapter.Update(this.pindahFrameDataSet.school_diary_student);
                int b = tableAdapterManager.UpdateAll(this.pindahFrameDataSet);
                if (b == 0)
                {
                    labeStudents.Text = "Last Updated " + DateTime.Now.ToLongTimeString();


                }
                else
                {
                    labeStudents.Text = "Click UPDATE to save data, no data saved yet";
                }
            }
            else
            {
                MessageBox.Show("Error. Please check the Check Box Above to 'VALID'");
            }
        }

        public void calculate_Student_ID()
        {
            ///student id =  schoolID + 
            /// student_count + firstletterofGender
            /// 
            string first_part = schoolID;
            string second_part = student_countTextBox.Text;
            string third_part = null;
            if (firstnameTextBox.Text.Length > 1)
            {
                try
                {
                    char adb = firstnameTextBox.Text.ElementAt(0);
                    char ade = lastnameTextBox.Text.ElementAt(0);
                    third_part = adb.ToString() + ade.ToString();
                }
                catch { }
            }
            else
            {

                third_part = "N" + "S";
            }
            string student_id = first_part + "-" + second_part + "-" + third_part;
            student_idTextBox.Text = student_id;



        }
        public void AddNewStudent()
        {
            school_diary_studentTableAdapter.Fill(this.pindahFrameDataSet.school_diary_student);
            school_diary_studentBindingSource.AddNew();
            firstnameTextBox.Text = "N";
            lastnameTextBox.Text = "S";
            //autocalculate student id
            //  calculate_Student_ID();
            timeStudentID.Start();
            //determine schoolAuthCode
            student_schoolid_TextBox.Text = schoolID;

        }
        private void btnaddnew_student_Click(object sender, EventArgs e)
        {
            AddNewStudent();
        }

        private void btnstudents_Click(object sender, EventArgs e)
        {
            tabMainDash.SelectedIndex = 1;


        }

        private void timeStudentID_Tick(object sender, EventArgs e)
        {
            student_schoolid_TextBox.Text = schoolID;
            //autocalculate student id
            calculate_Student_ID();
        }


        private void dataGridView2_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("There is an error in your data. Please, try entering the whole record again");
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.Count == school_diary_studentBindingSource.Count)
            {
                student_schoolid_TextBox.Text = schoolID;
                //  calculate_Student_ID();

                timeStudentID.Start();
            }
        }

        private void timerAllStuff_Tick(object sender, EventArgs e)
        {
            school_idTextBox3.Text = schoolID; 
            lblcurrentstudents.Text = "Viewing " + level_tableComboBox.Text + " " + classesComboBox.Text;
            lbltotalstudent.Text = school_diary_studentBindingSource.Count.ToString();
            lbltotal_2_Students.Text = lbltotalstudent.Text;
            int a = school_diary_studentBindingSource.Position;
            lblcurrentstudent.Text = "At " + (a + 1).ToString() + " out of :";
            // try
            {
                double age = DateTime.Now.Subtract(date_of_birthDateTimePicker.Value).Days / 365;
                student_ageTextBox.Text = Math.Round(age, 0).ToString();
            }
            // catch { student_ageTextBox.Text = "No date of birth selected."; }

            if (tabStudents.SelectedIndex != 1)
            {
                school_diary_studentBindingSource.RemoveFilter();
            }
            else
            {
                school_diary_studentBindingSource.Sort = "lastname";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string str = txt_search_Student.Text;
            string f = "firstname LIKE '%" + str + "%'";
            string l = "lastname LIKE '%" + str + "%'";
            string m = "middlename LIKE '%" + str + "%'";
            string o = "othernames LIKE '%" + str + "%'";
            string id = "student_id LIKE ''%" + str + "%'";
            string or = " OR ";
            string s = "student_school_id_given LIKE ''%" + str + "%'";
            string n = "student_national_id_number LIKE ''%" + str + "%'";
            school_diary_studentBindingSource.Filter = f + or + l + or + m + or + o + or + id + or + s + or + n;
            timerPairs.Start();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void school_diary_studentListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            school_diary_studentBindingSource.RemoveFilter();
            string search = school_diary_studentListBox.SelectedItem.ToString();
            string[] search_2 = search.Split('\t');

            string a = search_2[0];
            string b = search_2[1];

            {
                school_diary_studentBindingSource.Filter = "lastname = '" + a + "' AND firstname = '" + b + "'";

            }

        }
        static string updateclass; static string newclass_code;
        public static void receiveNewClass(string i, string j)
        {
            updateclass = i;
            newclass_code = j;
        }
        private void btnchangeclass_Click(object sender, EventArgs e)
        {
            ChangeClass ccc = new ChangeClass();
            ccc.loadDetails(comboBox2.Text, schoolID);
            ccc.ShowDialog();
            class_idTextBox.Text = newclass_code;
            this.school_diary_studentBindingSource.EndEdit();
            this.school_diary_studentTableAdapter.Update(this.pindahFrameDataSet.school_diary_student);
            this.tableAdapterManager.UpdateAll(this.pindahFrameDataSet);
            timerPairs.Start();
            this.Refresh();
            MessageBox.Show("Student has been transferred to new class:\n\n" + updateclass);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            timerPairs.Start();
        }

        private void timerPairs_Tick(object sender, EventArgs e)
        {
            // school_diary_studentBindingSource.RemoveFilter();
            getNamePairs();
            timerPairs.Stop();
        }

        private void deleteStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = (string)dataListingStudent.CurrentRow.Cells[0].Value.ToString();
            string surname = (string)dataListingStudent.CurrentRow.Cells[1].Value.ToString();
            var result = MessageBox.Show("Are you sure you want to delete:\n\n" + name.ToUpper() + " " + surname.ToUpper() + " ?\n\nIf you made a mistake, remember: First click on the student an then right click the mouse to select", "Confirm delete", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                school_diary_studentBindingSource.EndEdit();
                school_diary_studentBindingSource.RemoveCurrent();
                school_diary_studentTableAdapter.Update(this.pindahFrameDataSet.school_diary_student);
                tableAdapterManager.UpdateAll(this.pindahFrameDataSet);
                labeStudents.Text = "Last Updated " + DateTime.Now.ToLongTimeString();
            }
            else
            {

            }
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabStudents.SelectedIndex = 2;
        }

        private void goToFullViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //view all students for navigation

        }

        private void homeDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabStudents.SelectedIndex = 3;
            school_idTextBox1.Text = schoolID;
        }

        private void contactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabStudents.SelectedIndex = 4;
        }

        private void btnupdateHome_Click(object sender, EventArgs e)
        {
            home_detailsBindingSource.EndEdit();

            home_detailsTableAdapter.Update(this.pindahFrameDataSet.home_details);
            tableAdapterManager.UpdateAll(this.pindahFrameDataSet);
            labeStudents.Text = "Last Updated " + DateTime.Now.ToLongTimeString();
        }

        private void btnnewHome_Click(object sender, EventArgs e)
        {
            home_detailsBindingSource.AddNew();
            if (student_idTextBox2.Text == "")
            {
                lblclick_again_home.Text = "Click Again ";
            }
            else
            {
                lblclick_again_home.Text = "";
                h_countryTextBox.Text = "Zimbabwe";
                school_idTextBox1.Text = schoolID;
            }

        }

        private void student_idTextBox2_TextChanged(object sender, EventArgs e)
        {

        }
        public void searchStudent(string searchparameters)
             {
    
            string str = searchparameters;
    string f = "firstname LIKE '%" + str + "%'";
    string l = "lastname LIKE '%" + str + "%'";
    string m = "middlename LIKE '%" + str + "%'";
    string o = "othernames LIKE '%" + str + "%'";
    string id = "student_id LIKE '%" + str + "%'";
    string or = " OR ";
    string s = "student_school_id_given LIKE '%" + str + "%'";
    string n = "student_national_id_number LIKE '%" + str + "%'";
    school_diary_studentBindingSource.Filter = f + or + l + or + m + or + o + or + id + or + s + or + n;
            timerPairs.Start();
            school_diary_studentBindingSource.Sort = "lastname";

        }
        private void txt_search_student_changed(object sender, EventArgs e)
        {
            searchStudent(txt_search_Student.Text);
        }

        private void txtsearch_home_details_student_changed(object sender, EventArgs e)
        {
            searchStudent(txtsearch_student_home.Text);

        }
       
        private void button2_Click(object sender, EventArgs e)
        {
            contact_detailsBindingSource.AddNew();
         
            if (student_idTextBox3.Text == "")
            {
                lblclick_again_contact.Text = "Click Again ";
            }
            else
            {
                lblclick_again_contact.Text = "";
                
                school_idTextBox2.Text = schoolID;
            }


        }

        private void textContatSearch_TextChanged(object sender, EventArgs e)
        {
            searchStudent(textContatSearch.Text);
        }

        private void btnupdate_contact_details_Student_Click(object sender, EventArgs e)
        {
            this.Validate();
            contact_detailsBindingSource.EndEdit();
            contact_detailsTableAdapter.Update(this.pindahFrameDataSet.contact_details);
            tableAdapterManager.UpdateAll(this.pindahFrameDataSet);
            labeStudents.Text = "Last Updated " + DateTime.Now.ToLongTimeString();
        }

        private void btnfees_Click(object sender, EventArgs e)
        {
            Fee_Management fm = new Fee_Management();
            fm.schoolDetails(schoolID);
            fm.ShowDialog();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Staff_Management staff_ = new Staff_Management();
            staff_.loadSchool(schoolID);
            staff_.ShowDialog();
            MainLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pnlwait.Visible = true;
            pnlwait.BringToFront();
            label4.Text = "\n Enter Authentication Code";
        }

        private void btnsavetofile_Click(object sender, EventArgs e)
        {
            StudentsReportForm reportForm = new StudentsReportForm();
            reportForm.LoadSchool(schoolID);
            reportForm.Show();
        }

       
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnlessons_Click(object sender, EventArgs e)
        {
            Lessons lessons = new Lessons();
            lessons.LoadSchool(schoolID);
            lessons.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            ProblemSets problem = new ProblemSets();
            problem.LoadSchool(schoolID);
           problem.Show();
          
        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {
            if(txtusername.Text == schoolID)
            {
                pnlwait.Visible = false;
                pnlwait.SendToBack();
            }
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            Libray_Control libray_Control = new Libray_Control();
            libray_Control.schoolDetails(schoolID);
            libray_Control.Show();
        }

        private void btnprocesses_Click(object sender, EventArgs e)
        {
            tabMainDash.SelectedIndex = 2;
        }
    }
}
