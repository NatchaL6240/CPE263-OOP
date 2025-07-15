namespace Lab_3_2__9_9_24_
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
            rad1 = new RadioButton();
            rad2 = new RadioButton();
            rad3 = new RadioButton();
            btnRun = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // rad1
            // 
            rad1.AutoSize = true;
            rad1.Location = new Point(223, 116);
            rad1.Name = "rad1";
            rad1.Size = new Size(173, 24);
            rad1.TabIndex = 0;
            rad1.TabStop = true;
            rad1.Text = "ภาษา Visual Basic.NET";
            rad1.UseVisualStyleBackColor = true;
            // 
            // rad2
            // 
            rad2.AutoSize = true;
            rad2.Location = new Point(223, 163);
            rad2.Name = "rad2";
            rad2.Size = new Size(157, 24);
            rad2.TabIndex = 1;
            rad2.TabStop = true;
            rad2.Text = "ภาษา Visual C#.NET";
            rad2.UseVisualStyleBackColor = true;
            // 
            // rad3
            // 
            rad3.AutoSize = true;
            rad3.Location = new Point(223, 214);
            rad3.Name = "rad3";
            rad3.Size = new Size(103, 24);
            rad3.TabIndex = 2;
            rad3.TabStop = true;
            rad3.Text = "ภาษาอังกฤษ";
            rad3.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(319, 281);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(94, 29);
            btnRun.TabIndex = 3;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(290, 64);
            label1.Name = "label1";
            label1.Size = new Size(181, 20);
            label1.TabIndex = 4;
            label1.Text = "ภาษาที่ใช้ในการเขียนโปรแกรม";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(btnRun);
            Controls.Add(rad3);
            Controls.Add(rad2);
            Controls.Add(rad1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RadioButton rad1;
        private RadioButton rad2;
        private RadioButton rad3;
        private Button btnRun;
        private Label label1;
    }
}
