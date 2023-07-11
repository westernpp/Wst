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
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            //遍历存放用户注册数据的列表
            int j = 0;//控制行
            foreach(StudentsUser k in Form2.arrayList)
            {
                dataGridView1.RowCount++;
                dataGridView1["xuhao", j].Value = j + 1;
                dataGridView1["Duser", j].Value = k.username;
                dataGridView1["Dpassword", j].Value = k.password;
                dataGridView1["DName", j].Value = k.name;
                j++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //查询用户信息
            string userName = userNameTxt.Text;
            //删除表中原有的信息
            dataGridView1.Rows.Clear();
            foreach(StudentsUser k in Form2.arrayList)
            {
                if(k.username == userName)
                {
                    dataGridView1["xuhao", 0].Value = 1;
                    dataGridView1["Duser", 0].Value = k.username;
                    dataGridView1["Dpassword", 0].Value = k.password;
                    dataGridView1["DName", 0].Value = k.name;
                }
                else
                {
                    MessageBox.Show("此用户不存在！");
                }
            }
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            //修改用户密码
            string userName = userNameTxt2.Text;
            string password = keyTxt.Text;
            //查找表中匹配的用户名
            foreach(StudentsUser k in Form2.arrayList)
            {
                if(k.username == userName)
                {
                    //改密码
                    k.password = password;
                    MessageBox.Show("密码修改成功！");
                }

            }
        }

        private void keyTxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void userNameTxt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
