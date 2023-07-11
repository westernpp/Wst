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
    
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            
        }
        static public ArrayList StudentList = new ArrayList();//静态成员 以便再次打开当前窗体时，存储的数据不会释放
        //构造函数 用于窗体间传递值
        public Form4(Student student)
        {
            StudentList.Add(student);//把studnt添加到列表 ok 
            if (StudentList.Count!=0)
            {
                MessageBox.Show("添加成功！");
            }
            else
            {
                MessageBox.Show("添加失败！");
            }
        }
        public void Form4_Load(object sender, EventArgs e)
        {
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            //添加学生信息
            Form5 form5 = new Form5();
            form5.ShowDialog();

        }

        private void showBtn_Click(object sender, EventArgs e)
        {
            if(StudentList.Count==0)
            {
                MessageBox.Show("暂无数据！");
                dataGridView1["xuhao", 0].Value = null;
                dataGridView1["DFaculty", 0].Value = null;
                dataGridView1["Dzhuanye", 0].Value = null;
                dataGridView1["DClass", 0].Value = null;
                dataGridView1["Dnum", 0].Value = null;
                dataGridView1["DName", 0].Value = null;
                dataGridView1["DSex", 0].Value = null;
                dataGridView1["DMust", 0].Value = null;
                dataGridView1["DOptional", 0].Value = null;
                dataGridView1["Dpe", 0].Value = null;
                dataGridView1["DPoint", 0].Value = null;

            }
            int j = 0;//控制行
            for (int i = 0; i < StudentList.Count; i++)//遍历当前数组列表中的数据，在表格中输出
            {
                dataGridView1.RowCount = StudentList.Count;
                Student student = (Student)StudentList[i];
                dataGridView1["xuhao", j].Value = j + 1;
                dataGridView1["DFaculty", j].Value = student.Faculty;
                dataGridView1["Dzhuanye", j].Value = student.Pre;
                dataGridView1["DClass", j].Value = student.Class;
                dataGridView1["Dnum", j].Value = student.ID;
                dataGridView1["DName", j].Value = student.Name;
                dataGridView1["DSex", j].Value = student.sex;
                dataGridView1["DMust", j].Value = student.Must;
                dataGridView1["DOptional", j].Value = student.Optional;
                dataGridView1["Dpe", j].Value = student.PE;
                double point = student.Add();
                dataGridView1["DPoint", j].Value = point;
                j++;
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            //删除学生信息
            Form6 form6 = new Form6();
            form6.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void changeBtn_Click(object sender, EventArgs e)
        {
            //修改学生信息
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {
            //查询学生信息
        }
    }
}
