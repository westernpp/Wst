namespace WindowsFormsApp1
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            this.numBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.girlRadio = new System.Windows.Forms.RadioButton();
            this.boyRadio = new System.Windows.Forms.RadioButton();
            this.peTxt = new System.Windows.Forms.TextBox();
            this.optionalTxt = new System.Windows.Forms.TextBox();
            this.mustTxt = new System.Windows.Forms.TextBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.idTxt = new System.Windows.Forms.TextBox();
            this.ProBox = new System.Windows.Forms.ComboBox();
            this.ClassBox = new System.Windows.Forms.ComboBox();
            this.FacultyBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.change_num = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // numBtn
            // 
            this.numBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.numBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.numBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numBtn.Location = new System.Drawing.Point(174, 498);
            this.numBtn.Name = "numBtn";
            this.numBtn.Size = new System.Drawing.Size(137, 66);
            this.numBtn.TabIndex = 22;
            this.numBtn.Text = "确定";
            this.numBtn.UseVisualStyleBackColor = false;
            this.numBtn.Click += new System.EventHandler(this.numBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(24, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 21);
            this.label1.TabIndex = 24;
            this.label1.Text = "输入修改后的信息：";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.AliceBlue;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.numBtn);
            this.panel2.Controls.Add(this.girlRadio);
            this.panel2.Controls.Add(this.boyRadio);
            this.panel2.Controls.Add(this.peTxt);
            this.panel2.Controls.Add(this.optionalTxt);
            this.panel2.Controls.Add(this.mustTxt);
            this.panel2.Controls.Add(this.nameTxt);
            this.panel2.Controls.Add(this.idTxt);
            this.panel2.Controls.Add(this.ProBox);
            this.panel2.Controls.Add(this.ClassBox);
            this.panel2.Controls.Add(this.FacultyBox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Location = new System.Drawing.Point(3, 118);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(529, 730);
            this.panel2.TabIndex = 25;
            // 
            // girlRadio
            // 
            this.girlRadio.AutoSize = true;
            this.girlRadio.Location = new System.Drawing.Point(243, 296);
            this.girlRadio.Name = "girlRadio";
            this.girlRadio.Size = new System.Drawing.Size(51, 22);
            this.girlRadio.TabIndex = 25;
            this.girlRadio.TabStop = true;
            this.girlRadio.Text = "女";
            this.girlRadio.UseVisualStyleBackColor = true;
            // 
            // boyRadio
            // 
            this.boyRadio.AutoSize = true;
            this.boyRadio.Location = new System.Drawing.Point(164, 296);
            this.boyRadio.Name = "boyRadio";
            this.boyRadio.Size = new System.Drawing.Size(51, 22);
            this.boyRadio.TabIndex = 24;
            this.boyRadio.TabStop = true;
            this.boyRadio.Text = "男";
            this.boyRadio.UseVisualStyleBackColor = true;
            // 
            // peTxt
            // 
            this.peTxt.Location = new System.Drawing.Point(164, 431);
            this.peTxt.Name = "peTxt";
            this.peTxt.Size = new System.Drawing.Size(229, 28);
            this.peTxt.TabIndex = 23;
            // 
            // optionalTxt
            // 
            this.optionalTxt.Location = new System.Drawing.Point(164, 383);
            this.optionalTxt.Name = "optionalTxt";
            this.optionalTxt.Size = new System.Drawing.Size(229, 28);
            this.optionalTxt.TabIndex = 22;
            // 
            // mustTxt
            // 
            this.mustTxt.Location = new System.Drawing.Point(164, 336);
            this.mustTxt.Name = "mustTxt";
            this.mustTxt.Size = new System.Drawing.Size(229, 28);
            this.mustTxt.TabIndex = 21;
            // 
            // nameTxt
            // 
            this.nameTxt.Location = new System.Drawing.Point(164, 245);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(229, 28);
            this.nameTxt.TabIndex = 20;
            // 
            // idTxt
            // 
            this.idTxt.Location = new System.Drawing.Point(164, 199);
            this.idTxt.Name = "idTxt";
            this.idTxt.Size = new System.Drawing.Size(229, 28);
            this.idTxt.TabIndex = 19;
            // 
            // ProBox
            // 
            this.ProBox.FormattingEnabled = true;
            this.ProBox.Location = new System.Drawing.Point(164, 111);
            this.ProBox.Name = "ProBox";
            this.ProBox.Size = new System.Drawing.Size(229, 26);
            this.ProBox.TabIndex = 18;
            // 
            // ClassBox
            // 
            this.ClassBox.FormattingEnabled = true;
            this.ClassBox.Location = new System.Drawing.Point(164, 156);
            this.ClassBox.Name = "ClassBox";
            this.ClassBox.Size = new System.Drawing.Size(229, 26);
            this.ClassBox.TabIndex = 17;
            // 
            // FacultyBox
            // 
            this.FacultyBox.FormattingEnabled = true;
            this.FacultyBox.Location = new System.Drawing.Point(164, 70);
            this.FacultyBox.Name = "FacultyBox";
            this.FacultyBox.Size = new System.Drawing.Size(229, 26);
            this.FacultyBox.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(54, 435);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(94, 21);
            this.label10.TabIndex = 13;
            this.label10.Text = "体育课：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(54, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 21);
            this.label8.TabIndex = 11;
            this.label8.Text = "选修课：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(54, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 21);
            this.label7.TabIndex = 10;
            this.label7.Text = "必修课：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(54, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 21);
            this.label6.TabIndex = 9;
            this.label6.Text = "性别：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(54, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "姓名：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(54, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 21);
            this.label4.TabIndex = 7;
            this.label4.Text = "学号：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(54, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 6;
            this.label3.Text = "班级：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.Location = new System.Drawing.Point(54, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 21);
            this.label9.TabIndex = 5;
            this.label9.Text = "专业：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label11.Location = new System.Drawing.Point(54, 70);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 21);
            this.label11.TabIndex = 4;
            this.label11.Text = "学院：";
            // 
            // change_num
            // 
            this.change_num.Location = new System.Drawing.Point(313, 67);
            this.change_num.Name = "change_num";
            this.change_num.Size = new System.Drawing.Size(80, 28);
            this.change_num.TabIndex = 21;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(24, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 21);
            this.label2.TabIndex = 20;
            this.label2.Text = "输入要修改的学生序号：";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.change_num);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(529, 117);
            this.panel1.TabIndex = 23;
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 716);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form7";
            this.Text = "修改学生信息";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button numBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton girlRadio;
        private System.Windows.Forms.RadioButton boyRadio;
        private System.Windows.Forms.TextBox peTxt;
        private System.Windows.Forms.TextBox optionalTxt;
        private System.Windows.Forms.TextBox mustTxt;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox idTxt;
        private System.Windows.Forms.ComboBox ProBox;
        private System.Windows.Forms.ComboBox ClassBox;
        private System.Windows.Forms.ComboBox FacultyBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox change_num;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}