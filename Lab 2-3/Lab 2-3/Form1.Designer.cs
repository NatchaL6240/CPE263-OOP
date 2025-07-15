namespace Lab_2_3
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
            label3 = new Label();
            txtParallel1 = new TextBox();
            txtParallel2 = new TextBox();
            txtHigh = new TextBox();
            btnRun = new Button();
            btnEnd = new Button();
            lblAns = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(419, 117);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "เส้นขนาน 1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(419, 210);
            label2.Name = "label2";
            label2.Size = new Size(76, 20);
            label2.TabIndex = 1;
            label2.Text = "เส้นขนาน 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(419, 300);
            label3.Name = "label3";
            label3.Size = new Size(54, 20);
            label3.TabIndex = 2;
            label3.Text = "ความสูง";
            // 
            // txtParallel1
            // 
            txtParallel1.Location = new Point(605, 114);
            txtParallel1.Name = "txtParallel1";
            txtParallel1.Size = new Size(125, 27);
            txtParallel1.TabIndex = 3;
            // 
            // txtParallel2
            // 
            txtParallel2.Location = new Point(605, 203);
            txtParallel2.Name = "txtParallel2";
            txtParallel2.Size = new Size(125, 27);
            txtParallel2.TabIndex = 4;
            // 
            // txtHigh
            // 
            txtHigh.Location = new Point(605, 293);
            txtHigh.Name = "txtHigh";
            txtHigh.Size = new Size(125, 27);
            txtHigh.TabIndex = 5;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(411, 385);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(110, 34);
            btnRun.TabIndex = 6;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btnEnd
            // 
            btnEnd.Location = new Point(411, 455);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(110, 34);
            btnEnd.TabIndex = 7;
            btnEnd.Text = "End";
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += btnEnd_Click;
            // 
            // lblAns
            // 
            lblAns.BorderStyle = BorderStyle.Fixed3D;
            lblAns.Location = new Point(605, 385);
            lblAns.Name = "lblAns";
            lblAns.Size = new Size(164, 104);
            lblAns.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 255, 192);
            ClientSize = new Size(1215, 629);
            Controls.Add(lblAns);
            Controls.Add(btnEnd);
            Controls.Add(btnRun);
            Controls.Add(txtHigh);
            Controls.Add(txtParallel2);
            Controls.Add(txtParallel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtParallel1;
        private TextBox txtParallel2;
        private TextBox txtHigh;
        private Button btnRun;
        private Button btnEnd;
        private Label lblAns;
    }
}
