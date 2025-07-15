namespace Lab_6_1
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
            btnRun = new Button();
            btnCal = new Button();
            btnOddEven = new Button();
            btnGreater = new Button();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Location = new Point(115, 126);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(152, 58);
            btnRun.TabIndex = 0;
            btnRun.Text = "แสดงข้อความ";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btnCal
            // 
            btnCal.Location = new Point(115, 233);
            btnCal.Name = "btnCal";
            btnCal.Size = new Size(154, 58);
            btnCal.TabIndex = 1;
            btnCal.Text = "คำนวณ";
            btnCal.UseVisualStyleBackColor = true;
            btnCal.Click += btnCal_Click;
            // 
            // btnOddEven
            // 
            btnOddEven.Location = new Point(504, 126);
            btnOddEven.Name = "btnOddEven";
            btnOddEven.Size = new Size(154, 58);
            btnOddEven.TabIndex = 2;
            btnOddEven.Text = "เลขคู่-คี่";
            btnOddEven.UseVisualStyleBackColor = true;
            btnOddEven.Click += btnOddEven_Click;
            // 
            // btnGreater
            // 
            btnGreater.Location = new Point(504, 233);
            btnGreater.Name = "btnGreater";
            btnGreater.Size = new Size(154, 58);
            btnGreater.TabIndex = 3;
            btnGreater.Text = "เลขมากกว่า";
            btnGreater.UseVisualStyleBackColor = true;
            btnGreater.Click += btnGreater_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnGreater);
            Controls.Add(btnOddEven);
            Controls.Add(btnCal);
            Controls.Add(btnRun);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnRun;
        private Button btnCal;
        private Button btnOddEven;
        private Button btnGreater;
    }
}
