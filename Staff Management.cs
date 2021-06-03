using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PindahFrame
{
    public partial class Staff_Management : Form
    {
        public Staff_Management()
        {
            InitializeComponent();

            
        }
        string school_id;
        public void loadSchool(string schoolID)
        {
            school_id = schoolID;
        }
        private void Staff_Management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pindahFrameDataSet.possessions_table' table. You can move, or remove it, as needed.
            this.possessions_tableTableAdapter.Fill(this.pindahFrameDataSet.possessions_table);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.image' table. You can move, or remove it, as needed.
            this.imageTableAdapter.Fill(this.pindahFrameDataSet.image);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.criminal_offenses_table' table. You can move, or remove it, as needed.
           //d this.criminal_offenses_tableTableAdapter.Fill(this.pindahFrameDataSet.criminal_offenses_table);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.archievements_table' table. You can move, or remove it, as needed.
            this.archievements_tableTableAdapter.Fill(this.pindahFrameDataSet.archievements_table);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.biography' table. You can move, or remove it, as needed.
            this.biographyTableAdapter.Fill(this.pindahFrameDataSet.biography);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.contact_details' table. You can move, or remove it, as needed.
            this.contact_detailsTableAdapter.Fill(this.pindahFrameDataSet.contact_details);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.home_details' table. You can move, or remove it, as needed.
            this.home_detailsTableAdapter.Fill(this.pindahFrameDataSet.home_details);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.classes' table. You can move, or remove it, as needed.
            this.classesTableAdapter.Fill(this.pindahFrameDataSet.classes);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.level_table' table. You can move, or remove it, as needed.
            this.level_tableTableAdapter.Fill(this.pindahFrameDataSet.level_table);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.pindahFrameDataSet.staff);
            // TODO: This line of code loads data into the 'pindahFrameDataSet.school_details' table. You can move, or remove it, as needed.
            this.school_detailsTableAdapter.FillByLoad(this.pindahFrameDataSet.school_details,school_id);
            timerAllStuff.Start();
        }

        private void staff_countLabel_Click(object sender, EventArgs e)
        {
        

        }

        public void calculateStaffID()
        {
           
                ///student id =  schoolID + 
                /// student_count + firstletterofGender
                /// 
                string first_part = school_id;
                string second_part = "T";
                string third_part = staff_countTextBox.Text;
            string fourth_part=null;
            int a = dataGridView2.Rows.Count;
            string firstname=null, lastname=null;
            try
            {
                firstname = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            }
            catch { }
            try { 
               lastname = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            }
            catch { }
            try
            {
                if (firstname.Length > 1 || lastname.Length > 1)
                {
                    try
                    {
                        char adb = firstname.ElementAt(0);
                        char ade = lastname.ElementAt(0);
                        fourth_part = adb.ToString() + ade.ToString();
                    }
                    catch { }
                }
                else
                {

                    fourth_part = "N" + "S";
                }
                string staff_id = first_part + "-" + second_part + "-" + third_part + "-" + fourth_part;
                txtstaff_id.Text = staff_id;

            }
            catch { }

           
        }
        private void student_idLabel_Click(object sender, EventArgs e)
        {
         
        }

        private void timerAllStuff_Tick(object sender, EventArgs e)
        {
            if(biographyBindingSource.Count==1)
            {
                btn.Visible = false;
            }
            lbldate.Text = DateTime.Now.ToLongDateString();
            txtschool_id_staff.Text = school_id;
            calculateStaffID();
            school_idTextBox2.Text = school_id;
            staff_idTextBox1.Text = txtstaff_id.Text ;
            staff_idTextBox2.Text = txtstaff_id.Text;
            staff_idTextBox3.Text = txtstaff_id.Text;
            school_idTextBox3.Text = school_id;
            student_idTextBox.Text = "NULLABLE";
            school_idTextBox4.Text = school_id;
            staff_idTextBox4.Text = txtstaff_id.Text;

        }

        private void btnnew_staff_Click(object sender, EventArgs e)
        {
            staffTableAdapter.Fill(this.pindahFrameDataSet.staff);
            staffBindingSource.AddNew();
           
        }

        private void btnsave_staff_Click(object sender, EventArgs e)
        {
            labelStaff.Text = "Updating please wait....";
         if(dataGridView2.CurrentRow.Cells[0].Value ==null && dataGridView2.CurrentRow.Cells[3] ==null)
            {
                staffBindingSource.RemoveCurrent();
            }
            if (dataGridView2.CurrentRow.Cells[0].Value == null)
            {
                dataGridView2.CurrentRow.Cells[0].Value = "Unknown";
            }
            this.Validate();
            this.staffBindingSource.EndEdit();
            staffTableAdapter.Update(this.pindahFrameDataSet.staff);


            int staff = tableAdapterManager.UpdateAll(pindahFrameDataSet);
            labelStaff.Text = "Last updated " + DateTime.Now.ToLongTimeString();
            //MessageBox.Show("Done. updated");
           
        }

        private void btnselect_class_Click(object sender, EventArgs e)
        {
            dataGridView2.CurrentRow.Cells[9].Value = level_tableComboBox.Text + "___" + classesComboBox.Text;
        }

        private void btnpayroll_Click(object sender, EventArgs e)
        {
            //Payroll payroll = new Payroll();
          //  payroll.loadSchool(school_id);
          //  payroll.ShowDialog();
        }

        private void staff_typeLabel_Click(object sender, EventArgs e)
        {
           //// Ty
        }

        private void txtqualifications_TextChanged(object sender, EventArgs e)
        {

        }
        public void SavetoFile()
        {
            
           int a = dataGridView2.Rows.Count;

           for(int b = 0;b<a;b++)
           {
               string firstcolumn = "-", c = "-", d = "-", l = "-";
               try
               {
                   firstcolumn = dataGridView2.Rows[b].Cells[0].Value.ToString();
                   c = dataGridView2.Rows[b].Cells[1].Value.ToString();
                   d = dataGridView2.Rows[b].Cells[2].Value.ToString();
                   l = dataGridView2.Rows[b].Cells[3].Value.ToString();
               }
               catch { }
               string final = firstcolumn + "\t" + c + "\t" + d+"\t" +l +  "\n";

               //txtqualifications.AppendText(final);
           }

           //print to file

           try
           {
               SaveFileDialog save = new SaveFileDialog();
               save.AddExtension = true;
               save.DefaultExt = ".doc";
               save.FileName = "Staff Details";
               save.ShowDialog();

               string sd = save.FileName;
             //  txtqualifications.SaveFile(sd,RichTextBoxStreamType.RichText);

           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
        }
        private void btnsavetofile_Click(object sender, EventArgs e)
        {
           PrintStaffReport printstaff = new PrintStaffReport();
            printstaff.LoadSchool(school_id);
            printstaff.Show();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            staffTableAdapter.Fill(this.pindahFrameDataSet.staff);
            timerAllStuff.Stop();
            if (txtsearch.Text == "")
            {
                staffBindingSource.RemoveFilter();
                timerAllStuff.Start();
            }
            else
            {
                char[] search = txtsearch.Text.ToCharArray();
                string b = null;
                foreach(char test in search )
                {
                    if (test != ' ')
                    {

                        b += test;
                    }
                }
               //now search for the string without spaces
                {
                   
                   
                    string a = "%" + b + "%";
                    staffBindingSource.Filter = "staff_nationa_id LIKE '" + a + "' OR staff_name_first LIKE '" + a + "' OR staff_name_second LIKE '" + a + "' OR " +
                        " staff_name_others LIKE '" + a + "' OR staff_surname LIKE '" + a + "' OR " +
                        "staff_authorityposition LIKE '" + a + "' OR staff_class_focus LIKE '" + a + "'";
                }
                b = null;
            }

           
        }

        private void staff_name_othersLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void btnnewhome_details_Click(object sender, EventArgs e)
        {
            home_detailsBindingSource.AddNew();
            school_idTextBox.Text = school_id;
            staff_idTextBox.Text = txtstaff_id.Text;
            h_countryTextBox.Text = "Zimbabwe";
            h_townTextBox.Text = "Chitungwiza";
            labelHomeStaff.Text = "Details for " +
                 dataGridView3.CurrentRow.Cells[1].Value + " " +
               dataGridView3.CurrentRow.Cells[0].Value + " ( " + home_detailsBindingSource.Count.ToString() + " )";


        }

        private void btn_save_home_details_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.home_detailsBindingSource.EndEdit();
            this.home_detailsTableAdapter.Update(this.pindahFrameDataSet.home_details);
            tableAdapterManager.UpdateAll(this.pindahFrameDataSet);
            labelStaff.Text = "Last Updated Home details for " + staff_idTextBox.Text + " " + DateTime.Now.ToLongTimeString();
            labelHomeStaff.Text = "Updated Home Details for " +
               dataGridView3.CurrentRow.Cells[1].Value + " " +
               dataGridView3.CurrentRow.Cells[0].Value + " ( "+home_detailsBindingSource.Count.ToString()+ " )" ;
        }

        private void btnupatecontact_Click(object sender, EventArgs e)
        {
            this.Validate();
            contact_detailsBindingSource.EndEdit();
            this.contact_detailsTableAdapter.Update(this.pindahFrameDataSet.contact_details);
            tableAdapterManager.UpdateAll(this.pindahFrameDataSet);
            labelStaff.Text = "Last upated " + DateTime.Now.ToLongTimeString();
            labelContacts.Text = "Updated details for " +
                   dataGridView1.CurrentRow.Cells[1].Value + " " +
               dataGridView1.CurrentRow.Cells[0].Value + " ( " + contact_detailsBindingSource.Count.ToString() + " )";
        }

        private void btn_Click(object sender, EventArgs e)
        {
            biographyBindingSource.AddNew();
        }

        private void saveBio_Click(object sender, EventArgs e)
        {
            this.Validate()
                ;
            this.biographyBindingSource.EndEdit();
            int       
                a = this.biographyTableAdapter.Update(this.pindahFrameDataSet.biography);
           
            
          tableAdapterManager.UpdateAll(this.pindahFrameDataSet);
            {
                lblbiography.Text = "Last upated " + DateTime.Now.ToLongTimeString();
            }
          
        }

        private void school_idTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnadd_archievement_Click(object sender, EventArgs e)
        {
            archievements_tableBindingSource.AddNew();

        }

        private void btnSaveArchievement_Click(object sender, EventArgs e)
        {
            this.Validate();
            archievements_tableBindingSource.EndEdit();
            archievements_tableTableAdapter.Update(this.pindahFrameDataSet.archievements_table);
            tableAdapterManager.UpdateAll(this.pindahFrameDataSet);
        }

        private void btnnewcriminal_Click(object sender, EventArgs e)
        {
            criminal_offenses_tableBindingSource.AddNew();
        }

        private void btnsavecriminal_Click(object sender, EventArgs e)
        {
            this.Validate();
            criminal_offenses_tableBindingSource.EndEdit(); try
            {
                criminal_offenses_tableTableAdapter.Update(pindahFrameDataSet.criminal_offenses_table);
                tableAdapterManager.UpdateAll(this.pindahFrameDataSet);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
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
                descriptionTextBox.Text = "Staff Images";

                imagenameTextBox.Text = imageBindingSource.Count.ToString() + 
                    dataGridView4.CurrentRow.Cells[0].Value + 
                    "_" + DateTime.Now.ToLongTimeString() ;
               
                imagePictureBox.Image = Image.FromFile(opf.FileName);
                // MessageBox.Show("Its here");
            }
            //  catch (Exception pictre)
            {
                //      MessageBox.Show(pictre.Message + " \n \n " + pictre.StackTrace)
                ;
            }
        }

        private void btnupdate_image_Click(object sender, EventArgs e)
        {
            btnpleasewait.Text = "Loading image, please wait";
            this.Validate();
            imageBindingSource.EndEdit();
            imageTableAdapter.Update(this.pindahFrameDataSet.image)
                ;
            tableAdapterManager.UpdateAll(this.pindahFrameDataSet);
            btnpleasewait.Text = "Loaded Image";
        }

        private void dataGridView13_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnimagepossesion_Click(object sender, EventArgs e)
        {
            //  try
            {
                possessions_tableBindingSource.AddNew();
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Logos  (*.png) ;(*.jpg); (*.jpeg);| *.png; *.jpeg; *jpg";
                opf.Title = "Choose a scanned logos or normal image";
                opf.ShowDialog();
              //  string picture = opf.FileName;
               // pathTextBox.Text = picture;
              //  descriptionTextBox.Text = "Staff Images";
                    /* imagenameTextBox.Text = imageBindingSource.Count.ToString() +
                        dataGridView4.CurrentRow.Cells[0].Value +
                        "_" + DateTime.Now.ToLongTimeString();
                    */
                    dataGridView13.CurrentRow.Cells[0].Value = Image.FromFile(opf.FileName);
                //imagePictureBox.Image = Image.FromFile(opf.FileName);
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
