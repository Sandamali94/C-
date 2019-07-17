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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            StudentDBOper sdbo = new StudentDBOper();
            string studentid = txtStuid.Text.Trim();
            string studentname = txtStuname.Text.Trim();
            int studentage = int.Parse(txtStuAge.Text.Trim());
            float studentgpa = float.Parse(txtStugpa.Text.Trim());

            Student student = new Student(studentid, studentname, studentage, studentgpa);

            sdbo.registerStudent(student);

            MessageBox.Show("Student Registration is Successful!!");

        }

        private void btnrest_Click(object sender, EventArgs e)
        {
            txtStuid.Text = "";
            txtStuname.Text = "";
            txtStuAge.Text = "";
            txtStugpa.Text = "";
        }
    }
}
