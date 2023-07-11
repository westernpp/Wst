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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
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

        private void submitBtn_Click(object sender, EventArgs e)
        {
            //获取用户输入的值
            string Faculty = (string)FacultyBox.SelectedItem;//学院
            string Pre = (string)ProBox.SelectedItem;//专业
            string Class = (string)ClassBox.SelectedItem;
            string ID = "0306"+idTxt.Text;//学号应该是唯一的
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


            Student student = new Student(Faculty,Pre,Class,ID,Name,sex,Must,Optional,PE);//实例化一个学生类
         
            //运用两个窗口间传值的方式把列表传给Form4
            Form4 form4 = new Form4(student);//实例化form4 把要传递的值通过构造函数传递给form4
         


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //清空输入的信息
            FacultyBox.SelectedItem = null;
            ProBox.SelectedItem = null;
            ClassBox.SelectedItem = null;
            idTxt.Text = " ";
            nameTxt.Text = " ";
            boyRadio.Checked = false;
            girlRadio.Checked = false;
            mustTxt.Text = " ";
            optionalTxt.Text = " ";
            peTxt.Text = " ";
        }

        private void idTxt_TextChanged(object sender, EventArgs e)
        {
           

        }
    }
}
