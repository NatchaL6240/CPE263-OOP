namespace Lab_5_5
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
            txtIn = new TextBox();
            btnRun = new Button();
            btnRun_Num = new Button();
            SuspendLayout();
            // 
            // txtIn
            // 
            txtIn.Location = new Point(282, 130);
            txtIn.Name = "txtIn";
            txtIn.Size = new Size(216, 27);
            txtIn.TabIndex = 0;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(285, 193);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(97, 32);
            btnRun.TabIndex = 1;
            btnRun.Text = "Run_ASCII";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btnRun_Num
            // 
            btnRun_Num.Location = new Point(405, 193);
            btnRun_Num.Name = "btnRun_Num";
            btnRun_Num.Size = new Size(93, 32);
            btnRun_Num.TabIndex = 2;
            btnRun_Num.Text = "Run_Num";
            btnRun_Num.UseVisualStyleBackColor = true;
            btnRun_Num.Click += btnRun_Num_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRun_Num);
            Controls.Add(btnRun);
            Controls.Add(txtIn);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtIn;
        private Button btnRun;
        private Button btnRun_Num;
    }
}
