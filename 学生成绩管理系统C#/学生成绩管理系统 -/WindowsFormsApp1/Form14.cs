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
    public partial class Form14 : Form
    {
        public Form14()
        {
            InitializeComponent();
        }
        StudentsUser StudentsUser;
        public Form14(StudentsUser studentsUser)
        {
            InitializeComponent();
            this.StudentsUser = studentsUser;//接收从系统主界面传过来的数据
        }
        private void Form14_Load(object sender, EventArgs e)
        {
            label7.Text = StudentsUser.name + "同学";
            userTxt.Text = StudentsUser.username;
            keyTxt.Text = StudentsUser.password;
            facultyTxt.Text = StudentsUser.Faculty;
            classTxt.Text = StudentsUser.Class;
            idTxt.Text = StudentsUser.ID;
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            //修改密码
            Form15 form15 = new Form15(StudentsUser);
            form15.ShowDialog();
        }
    }
}
