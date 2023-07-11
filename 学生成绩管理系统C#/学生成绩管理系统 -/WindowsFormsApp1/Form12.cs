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
    public partial class Form12 : Form
    {
        public static ArrayList LessonList = new ArrayList();
        public Form12()
        {
            InitializeComponent();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form12_Load(object sender, EventArgs e)
        {
            //验证身份 不是管理员 不能对课程信息进行增加删除
            if(Form1.SFen !="管理员")
            {
                addBtn.Visible = false;
                delBtn.Visible = false;
            }

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
            
            if (LessonList.Count != 0)
            {
                int j = 0;
                foreach (Lesson lesson in LessonList)
                {
                    dataGridView1.RowCount++;
                    dataGridView1["xuhao", j].Value = j + 1;
                    dataGridView1["DFaculty", j].Value = lesson.Faculty;
                    dataGridView1["Dzhuanye", j].Value = lesson.Pre;
                    dataGridView1["DName", j].Value = lesson.LessonName;
                    dataGridView1["DTime", j].Value = lesson.Time;
                    dataGridView1["Dpoint", j].Value = lesson.Point;
                    dataGridView1["Dshx", j].Value = lesson.Shx;
                    j++;
                }
            }

        }



        private void addBtn_Click_1(object sender, EventArgs e)
        {
            Form11 form11 = new Form11();
            form11.ShowDialog();
        }

        private void searchBtn_Click_1(object sender, EventArgs e)
        {
            //查询
            string Faculty = (string)FacultyBox.SelectedItem;
            string Pro = (string)ProBox.SelectedItem;
            if (LessonList.Count == 0)
                MessageBox.Show("暂无课程信息！");
            else
            {
                if (Faculty != null && Pro != null)//专业课程
                {
                    //先把当前在表中显示的数据清空
                    dataGridView1.Rows.Clear();
                    int j = 0;
                    //遍历查找列表中属于该学院该专业的课程
                    foreach (Lesson lesson in LessonList)
                    {
                        if (lesson.Faculty == Faculty && lesson.Pre == Pro)
                        {
                            dataGridView1.RowCount++;
                            dataGridView1["xuhao", j].Value = j + 1;
                            dataGridView1["DFaculty", j].Value = lesson.Faculty;
                            dataGridView1["Dzhuanye", j].Value = lesson.Pre;
                            dataGridView1["DName", j].Value = lesson.LessonName;
                            dataGridView1["DTime", j].Value = lesson.Time;
                            dataGridView1["Dpoint", j].Value = lesson.Point;
                            dataGridView1["Dshx", j].Value = lesson.Shx;
                            j++;
                        }
                    }
                }
                else if(Faculty != null && Pro==null)//学院课程
                {
                    //先把当前在表中显示的数据清空
                    dataGridView1.Rows.Clear();
                    int j = 0;
                    //遍历查找列表中属于该学院该专业的课程
                    foreach (Lesson lesson in LessonList)
                    {
                        if (lesson.Faculty == Faculty)
                        {
                            dataGridView1.RowCount++;
                            dataGridView1["xuhao", j].Value = j + 1;
                            dataGridView1["DFaculty", j].Value = lesson.Faculty;
                            dataGridView1["Dzhuanye", j].Value = lesson.Pre;
                            dataGridView1["DName", j].Value = lesson.LessonName;
                            dataGridView1["DTime", j].Value = lesson.Time;
                            dataGridView1["Dpoint", j].Value = lesson.Point;
                            dataGridView1["Dshx", j].Value = lesson.Shx;
                            j++;
                        }
                    }
                }

                else
                {
                    MessageBox.Show("不符合查询条件！");
                }
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            //删除课程
            Form10 form10 = new Form10();
            form10.ShowDialog();
        }
    }

    public class Lesson
    {
        public string Faculty;
        public string Pre;
        public string LessonName;
        public string Time;
        public string Point;
        public string Shx;
        public Lesson(string faculty, string pre, string lessonName, string time, string point, string shx)
        {
            Faculty = faculty;
            Pre = pre;
            LessonName = lessonName;
            Time = time;
            Point = point;
            Shx = shx;
        }
    }
}
