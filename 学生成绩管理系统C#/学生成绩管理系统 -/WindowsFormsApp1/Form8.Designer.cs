namespace WindowsFormsApp1
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
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
            this.FacultyBox = new System.Windows.Forms.ComboBox();
            this.ProBox = new System.Windows.Forms.ComboBox();
            this.ClassBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.dataGridView1.Location = new System.Drawing.Point(5, 138);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(1689, 735);
            this.dataGridView1.TabIndex = 22;
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
            // FacultyBox
            // 
            this.FacultyBox.FormattingEnabled = true;
            this.FacultyBox.Location = new System.Drawing.Point(135, 46);
            this.FacultyBox.Name = "FacultyBox";
            this.FacultyBox.Size = new System.Drawing.Size(260, 26);
            this.FacultyBox.TabIndex = 23;
            // 
            // ProBox
            // 
            this.ProBox.FormattingEnabled = true;
            this.ProBox.Location = new System.Drawing.Point(552, 46);
            this.ProBox.Name = "ProBox";
            this.ProBox.Size = new System.Drawing.Size(260, 26);
            this.ProBox.TabIndex = 24;
            // 
            // ClassBox
            // 
            this.ClassBox.FormattingEnabled = true;
            this.ClassBox.Location = new System.Drawing.Point(980, 46);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(260, 26);
            this.ClassBox.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(56, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 26;
            this.label3.Text = "学院：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(473, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 21);
            this.label1.TabIndex = 27;
            this.label1.Text = "专业：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(901, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 21);
            this.label2.TabIndex = 28;
            this.label2.Text = "班级：";
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.SearchBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.SearchBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.SearchBtn.Location = new System.Drawing.Point(1328, 23);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(137, 66);
            this.SearchBtn.TabIndex = 29;
            this.SearchBtn.Text = "查询";
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.SteelBlue;
            this.button1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(1494, 23);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 66);
            this.button1.TabIndex = 30;
            this.button1.Text = "导出";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1664, 809);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ClassBox);
            this.Controls.Add(this.ProBox);
            this.Controls.Add(this.FacultyBox);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form8";
            this.Text = "查询学院信息";
            this.Load += new System.EventHandler(this.Form8_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox FacultyBox;
        private System.Windows.Forms.ComboBox ProBox;
        private System.Windows.Forms.ComboBox ClassBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xuhao;
        private System.Windows.Forms.DataGridViewTextBoxColumn DFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dzhuanye;
        private System.Windows.Forms.DataGridViewTextBoxColumn DClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn DName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dsex;
        private System.Windows.Forms.DataGridViewTextBoxColumn DMust;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOptional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dpe;
        private System.Windows.Forms.DataGridViewTextBoxColumn DPoint;
        private System.Windows.Forms.Button button1;
    }
}