namespace Lab_4_1
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
            btnUp = new Button();
            btnStep = new Button();
            btnDown = new Button();
            txtOut = new TextBox();
            SuspendLayout();
            // 
            // btnUp
            // 
            btnUp.Location = new Point(155, 90);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(126, 33);
            btnUp.TabIndex = 0;
            btnUp.Text = "วนซ้ำเดินแบบหน้า";
            btnUp.UseVisualStyleBackColor = true;
            btnUp.Click += btnUp_Click;
            // 
            // btnStep
            // 
            btnStep.Location = new Point(155, 299);
            btnStep.Name = "btnStep";
            btnStep.Size = new Size(126, 33);
            btnStep.TabIndex = 1;
            btnStep.Text = "วนซ้ำแบบ Step";
            btnStep.UseVisualStyleBackColor = true;
            btnStep.Click += btnStep_Click;
            // 
            // btnDown
            // 
            btnDown.Location = new Point(155, 187);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(126, 33);
            btnDown.TabIndex = 1;
            btnDown.Text = "วนซ้ำแบบถอยหลัง";
            btnDown.UseVisualStyleBackColor = true;
            btnDown.Click += btnDown_Click;
            // 
            // txtOut
            // 
            txtOut.Location = new Point(359, 65);
            txtOut.Multiline = true;
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(302, 288);
            txtOut.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtOut);
            Controls.Add(btnDown);
            Controls.Add(btnStep);
            Controls.Add(btnUp);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnUp;
        private Button btnStep;
        private Button btnDown;
        private TextBox txtOut;
    }
}
