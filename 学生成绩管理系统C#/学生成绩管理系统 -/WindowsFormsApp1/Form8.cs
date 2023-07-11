using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
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
            //访问列表 找出


        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

            //多重条件查找
            if (FacultyBox.SelectedItem != null && ProBox.SelectedItem != null && ClassBox.SelectedItem != null)
            {
                string Faculty = (string)FacultyBox.SelectedItem;
                string zhuanye = (string)ProBox.SelectedItem;
                string Class = (string)ClassBox.SelectedItem;
                dataGridView1.Rows.Clear();
                //遍历列表查找
                int j = 0;//控制行
                foreach (Student student in Form4.StudentList)
                {
                    if (student.Class == Class && student.Pre == zhuanye && student.Faculty == Faculty)
                    {
                        dataGridView1.RowCount++;
                        dataGridView1["xuhao", j].Value = j + 1;
                        dataGridView1["DFaculty", j].Value = student.Faculty;
                        dataGridView1["Dzhuanye", j].Value = student.Pre;
                        dataGridView1["DClass", j].Value = student.Class;
                        dataGridView1["Dnum", j].Value = student.ID;
                        dataGridView1["DName", j].Value = student.Name;
                        dataGridView1["DSex", j].Value = student.sex;
                        dataGridView1["DMust", j].Value = student.Must;
                        dataGridView1["DOptional", j].Value = student.Must;
                        dataGridView1["Dpe", j].Value = student.PE;
                        double point = student.Add();
                        dataGridView1["DPoint", j].Value = point;
                        j++;
                    }
                }
            }


            if (FacultyBox.SelectedItem != null)//查找学院
            {

                dataGridView1.Rows.Clear();
                //获取用户选择的学院
                string Faculty = (string)FacultyBox.SelectedItem;
                //遍历列表查找
                int j = 0;//控制行
                foreach (Student student in Form4.StudentList)
                {
                    if(student.Faculty == Faculty)
                    {

                        dataGridView1.RowCount++;
                        dataGridView1["xuhao", j].Value = j + 1;
                        dataGridView1["DFaculty", j].Value = student.Faculty;
                        dataGridView1["Dzhuanye", j].Value = student.Pre;
                        dataGridView1["DClass", j].Value = student.Class;
                        dataGridView1["Dnum", j].Value = student.ID;
                        dataGridView1["DName", j].Value = student.Name;
                        dataGridView1["DSex", j].Value = student.sex;
                        dataGridView1["DMust", j].Value = student.Must;
                        dataGridView1["DOptional", j].Value = student.Must;
                        dataGridView1["Dpe", j].Value = student.PE;
                        double point = student.Add();
                        dataGridView1["DPoint", j].Value = point;
                        j++;
                    }
                }
            }
            if(ProBox.SelectedItem != null)
            {

                dataGridView1.Rows.Clear();
                //获取用户选择的专业
                string zhuanye = (string)ProBox.SelectedItem;
                //遍历列表查找
                int j = 0;//控制行
                foreach (Student student in Form4.StudentList)
                {
                    if (student.Pre == zhuanye)
                    {
                        dataGridView1.RowCount++;
                        dataGridView1["xuhao", j].Value = j + 1;
                        dataGridView1["DFaculty", j].Value = student.Faculty;
                        dataGridView1["Dzhuanye", j].Value = student.Pre;
                        dataGridView1["DClass", j].Value = student.Class;
                        dataGridView1["Dnum", j].Value = student.ID;
                        dataGridView1["DName", j].Value = student.Name;
                        dataGridView1["DSex", j].Value = student.sex;
                        dataGridView1["DMust", j].Value = student.Must;
                        dataGridView1["DOptional", j].Value = student.Must;
                        dataGridView1["Dpe", j].Value = student.PE;
                        double point = student.Add();
                        dataGridView1["DPoint", j].Value = point;
                        j++;
                    }
                }
            }
            if(ClassBox.SelectedItem != null)
            {
                dataGridView1.Rows.Clear();
                //获取用户选择的班级
                string CLass = (string)ClassBox.SelectedItem;
                //遍历列表查找
                int j = 0;//控制行
                foreach (Student student in Form4.StudentList)
                {
                    if (student.Class == CLass)
                    {
                        dataGridView1.RowCount++;
                        dataGridView1["xuhao", j].Value = j + 1;
                        dataGridView1["DFaculty", j].Value = student.Faculty;
                        dataGridView1["Dzhuanye", j].Value = student.Pre;
                        dataGridView1["DClass", j].Value = student.Class;
                        dataGridView1["Dnum", j].Value = student.ID;
                        dataGridView1["DName", j].Value = student.Name;
                        dataGridView1["DSex", j].Value = student.sex;
                        dataGridView1["DMust", j].Value = student.Must;
                        dataGridView1["DOptional", j].Value = student.Must;
                        dataGridView1["Dpe", j].Value = student.PE;
                        double point = student.Add();
                        dataGridView1["DPoint", j].Value = point;
                        j++;
                    }
                }

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
         
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //导出文件
            SaveFileDialog kk = new SaveFileDialog();
            kk.Title = "保存EXECL文件";
            kk.Filter = "EXECL文件(*.xls) |*.xls |所有文件(*.*) |*.*";
            kk.FilterIndex = 1;
            if (kk.ShowDialog() == DialogResult.OK)
            {
                string FileName = kk.FileName;// + ".xls";
                if (File.Exists(FileName))
                    File.Delete(FileName);

                FileStream objFileStream;
                StreamWriter objStreamWriter;
                string strLine = "";//临时变量 用于存放每一行当前要显示的数据
                objFileStream = new FileStream(FileName, FileMode.OpenOrCreate, FileAccess.Write);
                objStreamWriter = new StreamWriter(objFileStream, System.Text.Encoding.Unicode);
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    if (dataGridView1.Columns[i].Visible == true)
                    {
                        strLine = strLine + dataGridView1.Columns[i].HeaderText.ToString()+Convert.ToChar(9);//输出表头
                    }
                }
                objStreamWriter.WriteLine(strLine);
                strLine = "";
                for (int i = 0; i < dataGridView1.Rows.Count; i++)//i 控制行
                {

                    for (int j = 0; j <dataGridView1.Columns.Count; j++)//j 控制列
                    {
                        if (dataGridView1.Columns[j].Visible == true)
                        {
                            if (dataGridView1.Rows[i].Cells[j].Value == null)
                                strLine = strLine + " " + Convert.ToChar(9);
                            else
                            {
                                string rowstr = "";
                                rowstr = dataGridView1.Rows[i].Cells[j].Value.ToString();
                                strLine = strLine + rowstr + Convert.ToChar(9);
                            }
                        }
                    }
                    objStreamWriter.WriteLine(strLine);
                    strLine = "";

                }

                objStreamWriter.Close();
                objFileStream.Close();

                MessageBox.Show(this, "保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
