namespace Lab_4_6
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
            btnAns1 = new Button();
            btnAns2 = new Button();
            btnAns3 = new Button();
            btnAns4 = new Button();
            SuspendLayout();
            // 
            // btnAns1
            // 
            btnAns1.Location = new Point(173, 112);
            btnAns1.Name = "btnAns1";
            btnAns1.Size = new Size(101, 36);
            btnAns1.TabIndex = 0;
            btnAns1.Text = "ข้อ ก.";
            btnAns1.UseVisualStyleBackColor = true;
            btnAns1.Click += btnAns1_Click;
            // 
            // btnAns2
            // 
            btnAns2.Location = new Point(484, 112);
            btnAns2.Name = "btnAns2";
            btnAns2.Size = new Size(101, 36);
            btnAns2.TabIndex = 1;
            btnAns2.Text = "ข้อ ข.";
            btnAns2.UseVisualStyleBackColor = true;
            btnAns2.Click += btnAns2_Click;
            // 
            // btnAns3
            // 
            btnAns3.Location = new Point(173, 276);
            btnAns3.Name = "btnAns3";
            btnAns3.Size = new Size(101, 36);
            btnAns3.TabIndex = 2;
            btnAns3.Text = "ข้อ ค.";
            btnAns3.UseVisualStyleBackColor = true;
            btnAns3.Click += btnAns3_Click;
            // 
            // btnAns4
            // 
            btnAns4.Location = new Point(484, 276);
            btnAns4.Name = "btnAns4";
            btnAns4.Size = new Size(101, 36);
            btnAns4.TabIndex = 3;
            btnAns4.Text = "ข้อ ง.";
            btnAns4.UseVisualStyleBackColor = true;
            btnAns4.Click += btnAns4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAns4);
            Controls.Add(btnAns3);
            Controls.Add(btnAns2);
            Controls.Add(btnAns1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAns1;
        private Button btnAns2;
        private Button btnAns3;
        private Button btnAns4;
    }
}
