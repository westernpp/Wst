using System;
using System.Collections;
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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        public void checkBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认删除该学生信息吗？", "问询提示", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //确认删除
                //获取用户输入的值
                int num = int.Parse(Del_num.Text);
                Form4.StudentList.RemoveAt(num-1);//列表的索引从0开始 而行数从1开始
                MessageBox.Show("删除成功！");
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Del_num_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
