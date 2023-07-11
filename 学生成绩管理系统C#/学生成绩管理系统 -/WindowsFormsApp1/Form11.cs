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
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form11_Load(object sender, EventArgs e)
        {
            //学院
            FacultyBox.Items.Add("信息技术工程学院");
            FacultyBox.Items.Add("理学院");
            FacultyBox.Items.Add("汽车与交通学院");
            //专业
            ProBox.Items.Add("计算机科学与技术");
            ProBox.Items.Add("大数据与应用");
            ProBox.Items.Add("城市与轨道");
            ProBox.Items.Add("交通技术");
            ProBox.Items.Add("物理");
            ProBox.Items.Add("信息与技术");
        }

        private void subBtn_Click(object sender, EventArgs e)
        {
            //提交
            //获取用户信息
            string Faculty = (string)FacultyBox.SelectedItem;
            string Pro = (string)ProBox.SelectedItem;
            string LessonName = NameTxt.Text;
            string time = timeTxt.Text;
            string point = pointTxt.Text;
            string shx = shxTxt.Text;
            //
            Lesson lesson = new Lesson(Faculty, Pro, LessonName, time, point, shx);
            Form12.LessonList.Add(lesson);
            MessageBox.Show("添加成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            //清空输入的信息
            FacultyBox.SelectedItem = null;
            ProBox.SelectedItem = null;
            NameTxt.Text = " ";
            timeTxt.Text = " ";
            shxTxt.Text = " ";
            pointTxt.Text = " ";
        }
    }
}
