using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form//注册页面
    {
        static public ArrayList arrayList = new ArrayList();//定义一个静态数组列表用于存储用户注册数据
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //学院
            comboBox1.Items.Add("信息技术工程学院");
            comboBox1.Items.Add("汽车与交通学院");
            comboBox1.Items.Add("理学院");
            //班级
            comboBox2.Items.Add("计科2201");
            comboBox2.Items.Add("计科2202");
            comboBox2.Items.Add("城轨2001");
            comboBox2.Items.Add("交通2101");
            comboBox2.Items.Add("物理2101");
            comboBox2.Items.Add("信技2102");

        }

        private void checkBtn_Click(object sender, EventArgs e)
        {
            //注册信息提交 
            //获取用户输入的值 
            string user = userTxt.Text;
            string key = keyTxt.Text;
            string name = nameTxt.Text;
            string id = idTxt.Text;
            string Faculty = (string)comboBox1.SelectedItem;//学院
            string Class = (string)comboBox2.SelectedItem;//班级

            id = "0306" + idTxt.Text;
            if (id == null || Faculty == null || Class == null)//教师信息注册
            {
                StudentsUser teacher = new StudentsUser(user, key, name);
                arrayList.Add(teacher);//把用户的注册信息放入数组列表
            }
            else
            {
                StudentsUser students = new StudentsUser(user, key, Faculty, id, Class,name);
                arrayList.Add(students);
            }
            MessageBox.Show("注册成功！");




            //把数组序列化写入文件
            //string file = Application.StartupPath + @"\..\UserData.dat";//相对路径
            // Stream stream = new FileStream(file, FileMode.OpenOrCreate, FileAccess.Write);
            // BinaryFormatter bf = new BinaryFormatter();//创建序列化对象
            //  bf.Serialize(stream, arrayList);//把列表里的数据序列化写入流

            // stream.Close();


        }

        private void 我是教师ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panelStu.Visible = false;//隐藏学生注册的信息项
            label1.Text = "—— 教师";
        }

        private void 我是学生ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            label1.Text = "—— 学生";
            panelStu.Visible = true;
        }

        private void sureKeyTxt_TextChanged(object sender, EventArgs e)
        {
            //判断两次输入的密码是否一致
            if (keyTxt.Text != sureKeyTxt.Text)
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

        private void button1_Click(object sender, EventArgs e)
        {
            //清空
            userTxt.Text = " ";
            keyTxt.Text = null;
            sureKeyTxt.Text = null;
            nameTxt.Text = " ";
            comboBox1.SelectedItem = null;
            comboBox2.SelectedItem = null;
            idTxt.Text = " ";
            
        }

        private void idTxt_TextChanged(object sender, EventArgs e)
        {
            //判断学号是否重复
            //学号是唯一的
            string id = idTxt.Text;
            if (arrayList.Count > 0)//如果列表里已有用户数据，则需要判断当前学号是否已存在
            {
                foreach (StudentsUser k in arrayList)
                {
                    if (k.ID == id)
                    {
                        MessageBox.Show("该学号已存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        checkBtn.Enabled = false;
                    }
                }
            }
        }
    }
}
