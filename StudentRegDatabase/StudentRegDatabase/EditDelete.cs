using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegDatabase
{
    public partial class EditDelete : Form
    {
        public EditDelete()
        {
            InitializeComponent();
        }

        private void txtStuid_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string studentid = txtStuid.Text.Trim();

            StudentDBOper sdbo = new StudentDBOper();
            Student student = sdbo.findstudent(studentid);

            txtStuname.Text = student.getstudentName();
            txtStuAge.Text = student.getstudentAge().ToString();
            txtStugpa.Text = student.getstudentgpa().ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            StudentDBOper sdbo = new StudentDBOper();
            string studentid = txtStuid.Text.Trim();
            string studentname = txtStuname.Text.Trim();
            int studentage = int.Parse(txtStuAge.Text.Trim());
            float studentgpa = float.Parse(txtStugpa.Text.Trim());

            Student student = new Student(studentid, studentname, studentage, studentgpa);

            sdbo.updatestudent(student);

            MessageBox.Show("Student Details Updated Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btndelete_Click(object sender, EventArgs e)
        {

            StudentDBOper sdbo = new StudentDBOper();

            string studentid = txtStuid.Text.Trim(); 

            sdbo.deletestudent(studentid);

            MessageBox.Show("Student Details Deleted Successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}
