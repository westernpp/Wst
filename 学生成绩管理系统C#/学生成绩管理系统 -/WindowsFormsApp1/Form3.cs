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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(string shenfen)//构造函数 用于判断登录该系统的用户的身份，以便给其不同的访问权限
        {

        }
        private void Form3_Load(object sender, EventArgs e)
        {
            toolStripLabel2.Text = "您的身份是：" + Form1.SFen;
            //身份验证
            //信息管理-->用户管理界面只有管理员可以访问
            if (Form1.SFen != "管理员")
            {
                汽车与交通学院ToolStripMenuItem.Visible = false;
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void 信息技术工程学院ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //信息管理-->学生信息
            Form4 form4 = new Form4();
            form4.MdiParent = this;//子窗体
            form4.Show(); 

            //dataGridView1[列，行].value dataGridView1["列名",行].value 当前单元格显示的内容
        }

        private void 汽车与交通学院ToolStripMenuItem_Click(object sender, EventArgs e)
        {

                //信息管理-->用户信息
                Form9 form9 = new Form9();
                form9.MdiParent = this;
                form9.Show();
        }

        private void 学院信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //信息查询-->学院信息
            Form8 form8 = new Form8();
            form8.MdiParent = this;
            form8.Show();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 课程信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            Form12 form100 = new Form12();
            form100.MdiParent = this;
            form100.Show();
        }
    }

    interface LessonPoint
    {
        double Add();
    }
    public class Student : LessonPoint
    {
        public string Faculty;//学院
        public string Pre;//专业
        public string Class;
        public string ID;
        public string Name;
        public string sex;
        public double Must;
        public double Optional;
        public double PE;
        public double All;
        //实现接口
        public double Add()//计算总学分
        {
            All = Must + Optional + PE;
            return All;
        }
        public Student()
        {

        }
        //构造函数 传参
        public Student(string Faculty,string Pre,string Class,string ID,string Name,string sex,double Must,
            double Optional,double Pe)
        {
            this.Faculty = Faculty;
            this.Pre = Pre;
            this.Class = Class;
            this.ID = ID;
            this.Name = Name;
            this.sex = sex;
            this.Must = Must;
            this.Optional = Optional;
            this.PE = Pe;
        }

    }
}
