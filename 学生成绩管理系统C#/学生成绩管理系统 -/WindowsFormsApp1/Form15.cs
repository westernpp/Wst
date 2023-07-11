using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace WindowsFormsApp1
{
    public partial class Form15 : Form
    {
        public Form15()
        {
            InitializeComponent();
        }
        StudentsUser StudentsUser;
        public Form15(StudentsUser studentsUser)
        {
            InitializeComponent();
            this.StudentsUser = studentsUser;
        }
        private void Form15_Load(object sender, EventArgs e)
        {

        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            string password = newKeyTxt.Text;
            //判断原密码是否正确
            if(StudentsUser.password == oldKeyTxt.Text)
            {
                //查找表中匹配的用户名
                foreach (StudentsUser k in Form2.arrayList)
                {
                    if (k.username == StudentsUser.username)
                    {
                        //改密码
                        k.password = password;
                        MessageBox.Show("密码修改成功！");
                    }

                }
            }
            else
            {
                MessageBox.Show("密码错误！");
            }
        }

        private void sureTxt_TextChanged(object sender, EventArgs e)
        {
            //判断两次输入密码是否一致
            if (newKeyTxt.Text != sureTxt.Text)
            {
                tipTxt.Text = "两次输入密码不一致！";
                checkBtn.Enabled = false;//不让提交
            }
            else
            {
                tipTxt.Text = " ";
                checkBtn.Enabled = true;
            }
        }
    }
}
