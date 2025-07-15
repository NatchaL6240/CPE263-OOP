namespace Lab_1_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblName = new Label();
            lblSurname = new Label();
            lblNum = new Label();
            lblGrade = new Label();
            txtName = new TextBox();
            txtSurname = new TextBox();
            txtNum = new TextBox();
            txtGrade = new TextBox();
            btnRun = new Button();
            btnEnd = new Button();
            SuspendLayout();
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.ForeColor = Color.Navy;
            lblName.Location = new Point(377, 116);
            lblName.Name = "lblName";
            lblName.Size = new Size(26, 20);
            lblName.TabIndex = 0;
            lblName.Text = "ชื่อ";
            // 
            // lblSurname
            // 
            lblSurname.AutoSize = true;
            lblSurname.ForeColor = Color.Navy;
            lblSurname.Location = new Point(377, 176);
            lblSurname.Name = "lblSurname";
            lblSurname.Size = new Size(58, 20);
            lblSurname.TabIndex = 1;
            lblSurname.Text = "นามสกุล";
            // 
            // lblNum
            // 
            lblNum.AutoSize = true;
            lblNum.ForeColor = Color.Navy;
            lblNum.Location = new Point(377, 229);
            lblNum.Name = "lblNum";
            lblNum.Size = new Size(32, 20);
            lblNum.TabIndex = 2;
            lblNum.Text = "รหัส";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.ForeColor = Color.Navy;
            lblGrade.Location = new Point(377, 288);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(59, 20);
            lblGrade.TabIndex = 3;
            lblGrade.Text = "เกรด C#";
            // 
            // txtName
            // 
            txtName.Location = new Point(492, 112);
            txtName.Name = "txtName";
            txtName.Size = new Size(185, 27);
            txtName.TabIndex = 4;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(492, 169);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(185, 27);
            txtSurname.TabIndex = 5;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(492, 226);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(185, 27);
            txtNum.TabIndex = 6;
            // 
            // txtGrade
            // 
            txtGrade.Location = new Point(492, 281);
            txtGrade.Name = "txtGrade";
            txtGrade.Size = new Size(185, 27);
            txtGrade.TabIndex = 7;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(393, 350);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(89, 26);
            btnRun.TabIndex = 8;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btnEnd
            // 
            btnEnd.Location = new Point(552, 350);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(89, 26);
            btnEnd.TabIndex = 9;
            btnEnd.Text = "End";
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += btnEnd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 255);
            ClientSize = new Size(1041, 653);
            Controls.Add(btnEnd);
            Controls.Add(btnRun);
            Controls.Add(txtGrade);
            Controls.Add(txtNum);
            Controls.Add(txtSurname);
            Controls.Add(txtName);
            Controls.Add(lblGrade);
            Controls.Add(lblNum);
            Controls.Add(lblSurname);
            Controls.Add(lblName);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblName;
        private Label lblSurname;
        private Label lblNum;
        private Label lblGrade;
        private TextBox txtName;
        private TextBox txtSurname;
        private TextBox txtNum;
        private TextBox txtGrade;
        private Button btnRun;
        private Button btnEnd;
    }
}
