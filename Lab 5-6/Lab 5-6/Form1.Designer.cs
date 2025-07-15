namespace Lab_5_6
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
            label1 = new Label();
            txtIn = new TextBox();
            label2 = new Label();
            txtOut = new TextBox();
            btnRun = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(106, 104);
            label1.Name = "label1";
            label1.Size = new Size(202, 20);
            label1.TabIndex = 0;
            label1.Text = "ป้อนข้อความ ตัวพิมพ์ใหญ่ หาตัว I";
            // 
            // txtIn
            // 
            txtIn.Location = new Point(382, 101);
            txtIn.Name = "txtIn";
            txtIn.Size = new Size(325, 27);
            txtIn.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(256, 181);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 2;
            label2.Text = "ผลลัพธ์";
            // 
            // txtOut
            // 
            txtOut.Location = new Point(382, 181);
            txtOut.Multiline = true;
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(325, 160);
            txtOut.TabIndex = 3;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(238, 280);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(94, 29);
            btnRun.TabIndex = 4;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.PaleVioletRed;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRun);
            Controls.Add(txtOut);
            Controls.Add(label2);
            Controls.Add(txtIn);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtIn;
        private Label label2;
        private TextBox txtOut;
        private Button btnRun;
    }
}
