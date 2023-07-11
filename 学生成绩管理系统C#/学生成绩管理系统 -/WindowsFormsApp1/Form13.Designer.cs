namespace WindowsFormsApp1
{
    partial class Form13
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form13));
            this.label1 = new System.Windows.Forms.Label();
            this.MyBtn = new System.Windows.Forms.Button();
            this.ScoreBtn = new System.Windows.Forms.Button();
            this.LessonBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("方正粗黑宋简体", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(41, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(466, 49);
            this.label1.TabIndex = 20;
            this.label1.Text = "TUTE学生成绩管理系统";
            // 
            // MyBtn
            // 
            this.MyBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.MyBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MyBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MyBtn.Location = new System.Drawing.Point(129, 185);
            this.MyBtn.Name = "MyBtn";
            this.MyBtn.Size = new System.Drawing.Size(250, 72);
            this.MyBtn.TabIndex = 18;
            this.MyBtn.Text = "个人中心";
            this.MyBtn.UseVisualStyleBackColor = false;
            this.MyBtn.Click += new System.EventHandler(this.MyBtn_Click);
            // 
            // ScoreBtn
            // 
            this.ScoreBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.ScoreBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ScoreBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ScoreBtn.Location = new System.Drawing.Point(129, 279);
            this.ScoreBtn.Name = "ScoreBtn";
            this.ScoreBtn.Size = new System.Drawing.Size(250, 72);
            this.ScoreBtn.TabIndex = 21;
            this.ScoreBtn.Text = "我的成绩";
            this.ScoreBtn.UseVisualStyleBackColor = false;
            this.ScoreBtn.Click += new System.EventHandler(this.ScoreBtn_Click);
            // 
            // LessonBtn
            // 
            this.LessonBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.LessonBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.LessonBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LessonBtn.Location = new System.Drawing.Point(129, 382);
            this.LessonBtn.Name = "LessonBtn";
            this.LessonBtn.Size = new System.Drawing.Size(250, 72);
            this.LessonBtn.TabIndex = 22;
            this.LessonBtn.Text = "查询课程";
            this.LessonBtn.UseVisualStyleBackColor = false;
            this.LessonBtn.Click += new System.EventHandler(this.LessonBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.exitBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exitBtn.Location = new System.Drawing.Point(129, 488);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(250, 72);
            this.exitBtn.TabIndex = 23;
            this.exitBtn.Text = "退出系统";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // Form13
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(541, 677);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.LessonBtn);
            this.Controls.Add(this.ScoreBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MyBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form13";
            this.Text = "欢迎使用TUTE学生成绩管理系统[学生系统]";
            this.Load += new System.EventHandler(this.Form13_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MyBtn;
        private System.Windows.Forms.Button ScoreBtn;
        private System.Windows.Forms.Button LessonBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}