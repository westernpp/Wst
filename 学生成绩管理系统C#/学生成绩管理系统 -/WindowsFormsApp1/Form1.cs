using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        //静态全局字段 用于判断用户身份
        static public string SFen;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //身份           
            comboBox1.Items.Add("学生");
            comboBox1.Items.Add("教师");
            comboBox1.Items.Add("管理员");
            
        }
        
        private void registerBtn_Click(object sender, EventArgs e)
        {
            //注册
            Form2 form2 = new Form2();
            form2.ShowDialog();//弹出注册页面
        }

        private void checkBtn_Click(object sender, EventArgs e)//登录
        {
            //登录
            //获取用户输入的值
            string user = userNameTxt.Text;
            string password = keyTxt.Text;
            string sfen = (string)comboBox1.SelectedItem;//身份
            SFen = sfen;

            //反序列化
            //string file = Application.StartupPath + @"\..\UserData.dat";//相对路径
            //Stream stream = new FileStream(file, FileMode.Open, FileAccess.Read);
            // BinaryFormatter bf = new BinaryFormatter();

            if (sfen == "管理员")//管理员账号是系统分配的，只有一个
            {
                if (user == "admin" && password == "admin")
                {
                    MessageBox.Show("登陆成功！");
                    //进入管理员界面
                    Form3 form3 = new Form3();
                    form3.Show();
                }
            }
            else
            {
                //如果不是管理员登录，则先检索库中是否有用户数据
                if (Form2.arrayList.Count == 0)//当前系统没有用户数据
                {
                    MessageBox.Show("您尚未注册！");
                }
                else
                {
                   //教师
                   if(sfen == "教师")
                    {
                        //开关变量
                        bool temp = false;
                        //遍历列表查询
                        foreach(StudentsUser studentsUser in Form2.arrayList)
                        {
                            if(studentsUser.username == user && studentsUser.password == password)
                            {
                                MessageBox.Show("登陆成功！");
                                Form3 form3 = new Form3();
                                form3.Show();//管理员与教师公用一个界面
                                temp = true;
                                break;
                            }
                        }
                        //如果遍历完整个列表也没有当前用户，则说明该用户不存在
                        if(temp==false)
                        {
                            MessageBox.Show("该用户不存在！","警告",MessageBoxButtons.OK,MessageBoxIcon.Error);
                        }
                    }
                    //学生
                    else if (sfen == "学生")
                    {
                        //开关变量
                        bool temp = false;
                        //遍历列表查询
                        foreach (StudentsUser studentsUser in Form2.arrayList)
                        {
                            if (studentsUser.username == user && studentsUser.password == password)
                            {
                                MessageBox.Show("登陆成功！");
                                
                                Form13 form13 = new Form13(studentsUser);//把当前的用户信息传给学生系统窗口
                                
                                form13.Show();
                                temp = true;
                                break;
                            }
                            else
                            {
                                MessageBox.Show("用户名或密码错误！");
                                break;
                            }
                        }
                        if (temp == false)
                        {
                            MessageBox.Show("该用户不存在！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
             }
         }
       }
    }


    //用户数据类 抽象类
    public abstract class UserDate
    {
        //教师与学生用户共有的部分是用户名，密码，姓名
        public string username;
        public string password;
        public string name;
        public string sfen;
        static int n=0;//注册用户数
        UserDate[] userdate = new UserDate[100];
        //构造函数 传值
        public UserDate(string username,string password,string name=" ")//name是可选参数
        {
            this.username = username;
            this.password = password;
            this.name = name;
            n++;//用户数加1
        }
        // 
        

    }
    //派生类 学生用户数据  
    public class StudentsUser:UserDate
    {
        public string Faculty;//院系
        public string ID;
        public string Class;
        //构造函数 传值 
        public StudentsUser(string username,string password, string Faculty = "", string Id = "", string Class=" ",string name=" ")
         :base(username,password,name)//给基类传值
        {
            this.Faculty = Faculty;
            this.ID = Id;
            this.Class = Class;
            this.username=username;
            this.password=password;
        }
    }

