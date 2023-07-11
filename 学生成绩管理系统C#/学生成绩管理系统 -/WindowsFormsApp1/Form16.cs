using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        StudentsUser studentsUser;
        public Form16(StudentsUser studentsUser)//接收从主界面传递过来的数据
        {
            InitializeComponent();
            this.studentsUser = studentsUser;
        }
        private void Form16_Load(object sender, EventArgs e)
        {
            if (Form4.StudentList != null)
            {
                //查找学生信息列表中与当前学生学号匹配的项
                foreach (Student student in Form4.StudentList)
                {
                    if (student.ID == studentsUser.ID)
                    {
                        dataGridView1[0, 0].Value = student.Name;
                        dataGridView1[1, 0].Value = student.ID;
                        dataGridView1[2, 0].Value = student.Must;
                        dataGridView1[3, 0].Value = student.Optional;
                        double all = student.Add();
                        dataGridView1[4, 0].Value = all;
                        break;
                    }


                }
            }
            else
            {
                label1.Text = "尚未录入成绩！";
            }

        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
