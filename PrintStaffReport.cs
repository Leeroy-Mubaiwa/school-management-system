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
    public partial class PrintStaffReport : Form
    {
        public PrintStaffReport()
        {
            InitializeComponent();
        }
        string school_id;
        public void LoadSchool(string schoolid)
        {
            school_id = schoolid;
        }
        private void PrintStaffReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PindahFrameDataSet.school_details' table. You can move, or remove it, as needed.
            this.school_detailsTableAdapter.FillByLoad(this.PindahFrameDataSet.school_details,school_id);
            // TODO: This line of code loads data into the 'PindahFrameDataSet.staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.PindahFrameDataSet.staff);
            // TODO: This line of code loads data into the 'PindahFrameDataSet.image' table. You can move, or remove it, as needed.
            this.imageTableAdapter.Fill(this.PindahFrameDataSet.image);

        }
    }
}
