using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

            #region Windows Form Designer generated code

            /// <summary>
            /// Required method for Designer support - do not modify
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            this.addBtn = new System.Windows.Forms.Button();
            this.showBtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.xuhao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DFaculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dzhuanye = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dsex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DMust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DOptional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dpe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DPoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delBtn = new System.Windows.Forms.Button();
            this.changeBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.addBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.addBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addBtn.Location = new System.Drawing.Point(547, 693);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(183, 66);
            this.addBtn.TabIndex = 18;
            this.addBtn.Text = "录入学生信息";
            this.addBtn.UseVisualStyleBackColor = false;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.showBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.showBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.showBtn.Location = new System.Drawing.Point(180, 693);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(183, 66);
            this.showBtn.TabIndex = 19;
            this.showBtn.Text = "显示学生信息";
            this.showBtn.UseVisualStyleBackColor = false;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.xuhao,
            this.DFaculty,
            this.Dzhuanye,
            this.DClass,
            this.Dnum,
            this.DName,
            this.Dsex,
            this.DMust,
            this.DOptional,
            this.Dpe,
            this.DPoint});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1686, 865);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // xuhao
            // 
            this.xuhao.HeaderText = "序号";
            this.xuhao.MinimumWidth = 8;
            this.xuhao.Name = "xuhao";
            // 
            // DFaculty
            // 
            this.DFaculty.HeaderText = "学院";
            this.DFaculty.MinimumWidth = 8;
            this.DFaculty.Name = "DFaculty";
            // 
            // Dzhuanye
            // 
            this.Dzhuanye.HeaderText = "专业";
            this.Dzhuanye.MinimumWidth = 8;
            this.Dzhuanye.Name = "Dzhuanye";
            // 
            // DClass
            // 
            this.DClass.HeaderText = "班级";
            this.DClass.MinimumWidth = 8;
            this.DClass.Name = "DClass";
            // 
            // Dnum
            // 
            this.Dnum.HeaderText = "学号";
            this.Dnum.MinimumWidth = 8;
            this.Dnum.Name = "Dnum";
            // 
            // DName
            // 
            this.DName.HeaderText = "姓名";
            this.DName.MinimumWidth = 8;
            this.DName.Name = "DName";
            // 
            // Dsex
            // 
            this.Dsex.HeaderText = "性别";
            this.Dsex.MinimumWidth = 8;
            this.Dsex.Name = "Dsex";
            // 
            // DMust
            // 
            this.DMust.HeaderText = "必修课";
            this.DMust.MinimumWidth = 8;
            this.DMust.Name = "DMust";
            // 
            // DOptional
            // 
            this.DOptional.HeaderText = "选修课";
            this.DOptional.MinimumWidth = 8;
            this.DOptional.Name = "DOptional";
            // 
            // Dpe
            // 
            this.Dpe.HeaderText = "体育课";
            this.Dpe.MinimumWidth = 8;
            this.Dpe.Name = "Dpe";
            // 
            // DPoint
            // 
            this.DPoint.HeaderText = "总学分";
            this.DPoint.MinimumWidth = 8;
            this.DPoint.Name = "DPoint";
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.delBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.delBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.delBtn.Location = new System.Drawing.Point(917, 693);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(183, 66);
            this.delBtn.TabIndex = 22;
            this.delBtn.Text = "删除学生信息";
            this.delBtn.UseVisualStyleBackColor = false;
            this.delBtn.Click += new System.EventHandler(this.delBtn_Click);
            // 
            // changeBtn
            // 
            this.changeBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.changeBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.changeBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.changeBtn.Location = new System.Drawing.Point(1289, 693);
            this.changeBtn.Name = "changeBtn";
            this.changeBtn.Size = new System.Drawing.Size(183, 66);
            this.changeBtn.TabIndex = 23;
            this.changeBtn.Text = "修改学生信息";
            this.changeBtn.UseVisualStyleBackColor = false;
            this.changeBtn.Click += new System.EventHandler(this.changeBtn_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1686, 865);
            this.Controls.Add(this.changeBtn);
            this.Controls.Add(this.delBtn);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form4";
            this.Text = "学生信息";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion
        private System.Windows.Forms.Button addBtn; 
        private System.Windows.Forms.Button showBtn;
        private DataGridView dataGridView1;
        private Button delBtn;
        private Button changeBtn;
        private DataGridViewTextBoxColumn xuhao;
        private DataGridViewTextBoxColumn DFaculty;
        private DataGridViewTextBoxColumn Dzhuanye;
        private DataGridViewTextBoxColumn DClass;
        private DataGridViewTextBoxColumn Dnum;
        private DataGridViewTextBoxColumn DName;
        private DataGridViewTextBoxColumn Dsex;
        private DataGridViewTextBoxColumn DMust;
        private DataGridViewTextBoxColumn DOptional;
        private DataGridViewTextBoxColumn Dpe;
        private DataGridViewTextBoxColumn DPoint;
        //public System.Windows.Forms.DataGridView dataGridView;
    }
}