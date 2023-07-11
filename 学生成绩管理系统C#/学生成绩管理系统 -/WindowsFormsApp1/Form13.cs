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
    public partial class Form13 : Form
    {
        public Form13()
        {
            
        }
        StudentsUser studentUser;
        public Form13(StudentsUser studentsUser)
        {
            InitializeComponent();
            this.studentUser = studentsUser;
        }
        private void MyBtn_Click(object sender, EventArgs e)
        {
            //个人中心
            Form14 form14 = new Form14(studentUser);
            form14.Show();
        }

        private void Form13_Load(object sender, EventArgs e)
        {
            
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ScoreBtn_Click(object sender, EventArgs e)
        {
            //我的成绩
            Form16 form16 = new Form16(studentUser);
            form16.Show();
        }

        private void LessonBtn_Click(object sender, EventArgs e)
        {
            //查询课程
            Form12 form12 = new Form12();
            form12.Show();
        }
    }
}
