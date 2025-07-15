namespace Lab_2_2
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
            label2 = new Label();
            txtBase = new TextBox();
            txtHigh = new TextBox();
            lblAns = new Label();
            btnRun = new Button();
            btnEnd = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(322, 131);
            label1.Name = "label1";
            label1.Size = new Size(159, 20);
            label1.TabIndex = 0;
            label1.Text = "พิมพ์ค่าความยาวมาตรฐาน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(322, 206);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 1;
            label2.Text = "พิมพ์ค่าความสูง";
            // 
            // txtBase
            // 
            txtBase.Location = new Point(589, 124);
            txtBase.Name = "txtBase";
            txtBase.Size = new Size(125, 27);
            txtBase.TabIndex = 2;
            // 
            // txtHigh
            // 
            txtHigh.Location = new Point(589, 206);
            txtHigh.Name = "txtHigh";
            txtHigh.Size = new Size(125, 27);
            txtHigh.TabIndex = 3;
            // 
            // lblAns
            // 
            lblAns.BorderStyle = BorderStyle.Fixed3D;
            lblAns.Location = new Point(558, 313);
            lblAns.Name = "lblAns";
            lblAns.Size = new Size(179, 89);
            lblAns.TabIndex = 4;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(338, 313);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(101, 29);
            btnRun.TabIndex = 5;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btnEnd
            // 
            btnEnd.Location = new Point(338, 371);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(101, 29);
            btnEnd.TabIndex = 6;
            btnEnd.Text = "End";
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += btnEnd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1165, 631);
            Controls.Add(btnEnd);
            Controls.Add(btnRun);
            Controls.Add(lblAns);
            Controls.Add(txtHigh);
            Controls.Add(txtBase);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "โปรแกรมคำนวณพื้นที่สามเหลี่ยมมุมฉาก";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtBase;
        private TextBox txtHigh;
        private Label lblAns;
        private Button btnRun;
        private Button btnEnd;
    }
}
