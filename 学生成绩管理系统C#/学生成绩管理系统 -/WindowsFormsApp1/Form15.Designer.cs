namespace WindowsFormsApp1
{
    partial class Form15
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form15));
            this.label4 = new System.Windows.Forms.Label();
            this.newKeyTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.oldKeyTxt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.sureTxt = new System.Windows.Forms.TextBox();
            this.tipTxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(155, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 31;
            // 
            // newKeyTxt
            // 
            this.newKeyTxt.Location = new System.Drawing.Point(194, 113);
            this.newKeyTxt.Name = "newKeyTxt";
            this.newKeyTxt.Size = new System.Drawing.Size(221, 28);
            this.newKeyTxt.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(61, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 29;
            this.label2.Text = "新密码：";
            // 
            // oldKeyTxt
            // 
            this.oldKeyTxt.Location = new System.Drawing.Point(194, 64);
            this.oldKeyTxt.Name = "oldKeyTxt";
            this.oldKeyTxt.Size = new System.Drawing.Size(221, 28);
            this.oldKeyTxt.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(61, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 21);
            this.label1.TabIndex = 28;
            this.label1.Text = "原密码：";
            // 
            // checkBtn
            // 
            this.checkBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.checkBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBtn.Location = new System.Drawing.Point(159, 251);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(147, 63);
            this.checkBtn.TabIndex = 26;
            this.checkBtn.Text = "确认";
            this.checkBtn.UseVisualStyleBackColor = false;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(61, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 21);
            this.label3.TabIndex = 32;
            this.label3.Text = "确认密码：";
            // 
            // sureTxt
            // 
            this.sureTxt.Location = new System.Drawing.Point(194, 162);
            this.sureTxt.Name = "sureTxt";
            this.sureTxt.Size = new System.Drawing.Size(221, 28);
            this.sureTxt.TabIndex = 33;
            this.sureTxt.TextChanged += new System.EventHandler(this.sureTxt_TextChanged);
            // 
            // tipTxt
            // 
            this.tipTxt.AutoSize = true;
            this.tipTxt.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tipTxt.ForeColor = System.Drawing.Color.Red;
            this.tipTxt.Location = new System.Drawing.Point(134, 215);
            this.tipTxt.Name = "tipTxt";
            this.tipTxt.Size = new System.Drawing.Size(21, 21);
            this.tipTxt.TabIndex = 34;
            this.tipTxt.Text = " ";
            // 
            // Form15
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(484, 350);
            this.Controls.Add(this.tipTxt);
            this.Controls.Add(this.sureTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.newKeyTxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.oldKeyTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBtn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form15";
            this.Text = "Form15";
            this.Load += new System.EventHandler(this.Form15_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox newKeyTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox oldKeyTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox sureTxt;
        private System.Windows.Forms.Label tipTxt;
    }
}