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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
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
            //班级
            ClassBox.Items.Add("计科2201");
            ClassBox.Items.Add("计科2202");
            ClassBox.Items.Add("城轨2001");
            ClassBox.Items.Add("交通2101");
            ClassBox.Items.Add("物理2101");
            ClassBox.Items.Add("信技2102");
        }

        private void numBtn_Click(object sender, EventArgs e)
        {
            int num = int.Parse(change_num.Text);
            //找到要修改的学生序号 在列表中对应的索引号
            int change = num-1;//索引号
            Student student = (Student)Form4.StudentList[change];//异常
            //获取用户输入的值
            string Faculty = (string)FacultyBox.SelectedItem;//学院
            string Pre = (string)ProBox.SelectedItem;//专业
            string Class = (string)ClassBox.SelectedItem;
            string ID = idTxt.Text;
            string Name = nameTxt.Text;
            string sex = " ";
            double Must = 0;
            Must = Convert.ToDouble(mustTxt.Text);
            double Optional = 0;
            Optional = Convert.ToDouble(optionalTxt.Text);
            double PE = 0;
            PE = Convert.ToDouble(peTxt.Text);
            if (boyRadio.Checked)
                sex = "男";
            else if (girlRadio.Checked)
                sex = "女";
            student = new Student(Faculty, Pre, Class, ID, Name, sex, Must, Optional, PE);
            //删除原来的
            Form4.StudentList.RemoveAt(change);
            //把修改后的数据 即当前的学生类 插入列表
            Form4.StudentList.Insert(change, student);
            MessageBox.Show("修改成功！");
        }
    }
}
