namespace Lab_6_3
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
            txtInput = new TextBox();
            btnRun = new Button();
            SuspendLayout();
            // 
            // txtInput
            // 
            txtInput.Location = new Point(282, 142);
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(220, 27);
            txtInput.TabIndex = 0;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(333, 210);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(122, 44);
            btnRun.TabIndex = 1;
            btnRun.Text = "Vat 7%";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRun);
            Controls.Add(txtInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtInput;
        private Button btnRun;
    }
}
