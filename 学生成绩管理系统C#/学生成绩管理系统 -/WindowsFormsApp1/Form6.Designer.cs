namespace WindowsFormsApp1
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.checkBtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Del_num = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // checkBtn
            // 
            this.checkBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.checkBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBtn.Location = new System.Drawing.Point(138, 142);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(137, 66);
            this.checkBtn.TabIndex = 18;
            this.checkBtn.Text = "确定";
            this.checkBtn.UseVisualStyleBackColor = false;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(40, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 21);
            this.label2.TabIndex = 19;
            this.label2.Text = "输入要删除的学生序号：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Del_num
            // 
            this.Del_num.Location = new System.Drawing.Point(295, 70);
            this.Del_num.Name = "Del_num";
            this.Del_num.Size = new System.Drawing.Size(80, 28);
            this.Del_num.TabIndex = 20;
            this.Del_num.TextChanged += new System.EventHandler(this.Del_num_TextChanged);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 259);
            this.Controls.Add(this.Del_num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form6";
            this.Text = "删除学生信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Del_num;
    }
}