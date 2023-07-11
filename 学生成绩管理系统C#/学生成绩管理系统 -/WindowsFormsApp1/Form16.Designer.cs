namespace WindowsFormsApp1
{
    partial class Form16
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form16));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DMust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doptional = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dpoint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DName,
            this.DNum,
            this.DMust,
            this.Doptional,
            this.Dpoint});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 30;
            this.dataGridView1.Size = new System.Drawing.Size(820, 307);
            this.dataGridView1.TabIndex = 0;
            // 
            // DName
            // 
            this.DName.HeaderText = "姓名";
            this.DName.MinimumWidth = 8;
            this.DName.Name = "DName";
            this.DName.Width = 150;
            // 
            // DNum
            // 
            this.DNum.HeaderText = "学号";
            this.DNum.MinimumWidth = 8;
            this.DNum.Name = "DNum";
            this.DNum.Width = 150;
            // 
            // DMust
            // 
            this.DMust.HeaderText = "必修课";
            this.DMust.MinimumWidth = 8;
            this.DMust.Name = "DMust";
            this.DMust.Width = 150;
            // 
            // Doptional
            // 
            this.Doptional.HeaderText = "选修课";
            this.Doptional.MinimumWidth = 8;
            this.Doptional.Name = "Doptional";
            this.Doptional.Width = 150;
            // 
            // Dpoint
            // 
            this.Dpoint.HeaderText = "总分";
            this.Dpoint.MinimumWidth = 8;
            this.Dpoint.Name = "Dpoint";
            this.Dpoint.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("宋体", 10F);
            this.label1.Location = new System.Drawing.Point(299, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 1;
            // 
            // checkBtn
            // 
            this.checkBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.checkBtn.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.checkBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBtn.Location = new System.Drawing.Point(330, 203);
            this.checkBtn.Name = "checkBtn";
            this.checkBtn.Size = new System.Drawing.Size(147, 63);
            this.checkBtn.TabIndex = 27;
            this.checkBtn.Text = "确认";
            this.checkBtn.UseVisualStyleBackColor = false;
            this.checkBtn.Click += new System.EventHandler(this.checkBtn_Click);
            // 
            // Form16
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(820, 307);
            this.Controls.Add(this.checkBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form16";
            this.Text = "我的成绩";
            this.Load += new System.EventHandler(this.Form16_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn DMust;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doptional;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dpoint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button checkBtn;
    }
}