namespace Lab_5_3
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
            btnVowels = new Button();
            txtIn = new TextBox();
            SuspendLayout();
            // 
            // btnRun
            // 
            btnRun.Location = new Point(181, 131);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(94, 29);
            btnRun.TabIndex = 0;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // btnVowels
            // 
            btnVowels.Location = new Point(181, 230);
            btnVowels.Name = "btnVowels";
            btnVowels.Size = new Size(94, 29);
            btnVowels.TabIndex = 1;
            btnVowels.Text = "Vowels";
            btnVowels.UseVisualStyleBackColor = true;
            btnVowels.Click += btnVowels_Click;
            // 
            // txtIn
            // 
            txtIn.Location = new Point(369, 175);
            txtIn.Name = "txtIn";
            txtIn.Size = new Size(252, 27);
            txtIn.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtIn);
            Controls.Add(btnVowels);
            Controls.Add(btnRun);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRun;
        private Button btnVowels;
        private TextBox txtIn;
    }
}
