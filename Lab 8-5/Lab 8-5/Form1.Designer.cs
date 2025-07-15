namespace Lab_8_5
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtNum = new TextBox();
            btnCount = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            lblCount = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 92);
            label1.Name = "label1";
            label1.Size = new Size(152, 20);
            label1.TabIndex = 0;
            label1.Text = "Input Number (1-10) :";
            // 
            // txtNum
            // 
            txtNum.Location = new Point(325, 89);
            txtNum.Name = "txtNum";
            txtNum.Size = new Size(128, 27);
            txtNum.TabIndex = 1;
            // 
            // btnCount
            // 
            btnCount.Location = new Point(275, 197);
            btnCount.Name = "btnCount";
            btnCount.Size = new Size(189, 80);
            btnCount.TabIndex = 2;
            btnCount.UseVisualStyleBackColor = true;
            btnCount.Click += btnCount_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Location = new Point(346, 227);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(0, 20);
            lblCount.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCount);
            Controls.Add(btnCount);
            Controls.Add(txtNum);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNum;
        private Button btnCount;
        private System.Windows.Forms.Timer timer1;
        private Label lblCount;
    }
}
