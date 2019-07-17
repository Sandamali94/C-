using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentRegDatabase
{
    class StudentDBOper
    {
        SqlConnection conn = null;

        public StudentDBOper()
        {
            conn = DBConnection.getConnection();
        }

        public void registerStudent(Student student)
        {
            string sid = student.getstudentID();
            string sname = student.getstudentName();
            int sage = student.getstudentAge();
            float sgpa = student.getstudentgpa();

            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into Student values ('"+sid+"', '"+ sname + "','" + sage + "','" + sgpa + "')", conn);
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public Student findstudent(string studentid)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand("select * from Student where studentid = '"+studentid+"'", conn);

            SqlDataReader rd = cmd.ExecuteReader();

            Student student = null;

            while (rd.Read())
            {
                string stuid = rd[0].ToString();
                string stuname = rd[1].ToString();
                int stuage = int.Parse(rd[2].ToString());
                float stugpa = float.Parse(rd[3].ToString());

                student = new Student(stuid, stuname, stuage, stugpa);
            }
            conn.Close();
            return student;
            
        }
        public void updatestudent(Student student)
        {
            string sid = student.getstudentID();
            string sname = student.getstudentName();
            int sage = student.getstudentAge();
            float sgpa = student.getstudentgpa();

            conn.Open();

            SqlCommand cmd = new SqlCommand("UPDATE Student SET StudentID='" + sid + "', StudentName='" + sname + "', StudentAge='" + sage + "',StudentGpa='" + sgpa + "' WHERE StudentID = '"+sid+"'", conn);
      
            cmd.ExecuteNonQuery();

            conn.Close();        
            
        }
        public void deletestudent(string studentid)
        {
            
            conn.Open();


            SqlCommand cmd = new SqlCommand("DELETE FROM Student WHERE StudentID = '"+ studentid + "'", conn);

            cmd.ExecuteNonQuery();

            conn.Close();

        }
        public void showallstudent()
        {

        }
    }
}
