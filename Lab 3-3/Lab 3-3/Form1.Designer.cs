namespace Lab_3_3
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
            chk1 = new CheckBox();
            chk2 = new CheckBox();
            chk3 = new CheckBox();
            btnRun = new Button();
            txtAns = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(298, 48);
            label1.Name = "label1";
            label1.Size = new Size(186, 20);
            label1.TabIndex = 0;
            label1.Text = "เหตุผลที่เลือกมหาวิทยาลัยรังสิต";
            // 
            // chk1
            // 
            chk1.AutoSize = true;
            chk1.Location = new Point(198, 194);
            chk1.Name = "chk1";
            chk1.Size = new Size(82, 24);
            chk1.TabIndex = 1;
            chk1.Text = "มีชื่อเสียง";
            chk1.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            chk2.AutoSize = true;
            chk2.Location = new Point(198, 241);
            chk2.Name = "chk2";
            chk2.Size = new Size(110, 24);
            chk2.TabIndex = 2;
            chk2.Text = "มีนศ.หน้าตาดี";
            chk2.UseVisualStyleBackColor = true;
            // 
            // chk3
            // 
            chk3.AutoSize = true;
            chk3.Location = new Point(198, 286);
            chk3.Name = "chk3";
            chk3.Size = new Size(79, 24);
            chk3.TabIndex = 3;
            chk3.Text = "ใกล้บ้าน";
            chk3.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(521, 236);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(94, 29);
            btnRun.TabIndex = 6;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // txtAns
            // 
            txtAns.Location = new Point(267, 89);
            txtAns.Multiline = true;
            txtAns.Name = "txtAns";
            txtAns.ScrollBars = ScrollBars.Vertical;
            txtAns.Size = new Size(252, 77);
            txtAns.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 255);
            ClientSize = new Size(800, 450);
            Controls.Add(txtAns);
            Controls.Add(btnRun);
            Controls.Add(chk3);
            Controls.Add(chk2);
            Controls.Add(chk1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private CheckBox chk1;
        private CheckBox chk2;
        private CheckBox chk3;
        private Button btnRun;
        private TextBox txtAns;
    }
}
