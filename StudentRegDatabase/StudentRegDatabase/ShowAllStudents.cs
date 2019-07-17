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
    public partial class ShowAllStudents : Form
    {
        public ShowAllStudents()
        {
            InitializeComponent();
        }

        private void ShowAllStudents_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'studentManSystemDataSet.Student' table. You can move, or remove it, as needed.
            this.studentTableAdapter.Fill(this.studentManSystemDataSet.Student);

        }
    }
}
