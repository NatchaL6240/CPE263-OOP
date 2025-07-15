namespace Lab_6_2
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
            txtNum = new TextBox();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Location = new Point(300, 246);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(157, 52);
            btnRun.TabIndex = 0;
            btnRun.Text = "จำนวนเต็ม";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // txtNum
            // 
            txtNum.Location = new Point(272, 137);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(206, 27);
            txtNum.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtNum);
            Controls.Add(btnRun);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRun;
        private TextBox txtNum;
    }
}
