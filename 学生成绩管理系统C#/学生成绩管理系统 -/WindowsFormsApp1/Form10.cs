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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("确认删除该课程吗？", "问询提示", MessageBoxButtons.YesNo,
            MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                //确认删除
                //获取用户输入的值
                int num = int.Parse(Del_num.Text);
                Form12.LessonList.RemoveAt(num - 1);//列表的索引从0开始 而行数从1开始
                MessageBox.Show("删除成功！");
            }
        }
    }
}
