namespace Lab_4_2
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
            txtNumber = new TextBox();
            radUp = new RadioButton();
            radDown = new RadioButton();
            btnRun = new Button();
            txtOut = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(239, 77);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "ให้นับครั้งละ";
            // 
            // txtNumber
            // 
            txtNumber.Location = new Point(373, 74);
            txtNumber.Name = "txtNumber";
            txtNumber.Size = new Size(130, 27);
            txtNumber.TabIndex = 1;
            // 
            // radUp
            // 
            radUp.AutoSize = true;
            radUp.Location = new Point(253, 158);
            radUp.Name = "radUp";
            radUp.Size = new Size(66, 24);
            radUp.TabIndex = 2;
            radUp.TabStop = true;
            radUp.Text = "นับขึ้น";
            radUp.UseVisualStyleBackColor = true;
            // 
            // radDown
            // 
            radDown.AutoSize = true;
            radDown.Location = new Point(253, 214);
            radDown.Name = "radDown";
            radDown.Size = new Size(62, 24);
            radDown.TabIndex = 3;
            radDown.TabStop = true;
            radDown.Text = "นับลง";
            radDown.UseVisualStyleBackColor = true;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(239, 273);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(86, 36);
            btnRun.TabIndex = 4;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // txtOut
            // 
            txtOut.Location = new Point(373, 128);
            txtOut.Multiline = true;
            txtOut.Name = "txtOut";
            txtOut.Size = new Size(188, 216);
            txtOut.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LemonChiffon;
            ClientSize = new Size(800, 450);
            Controls.Add(txtOut);
            Controls.Add(btnRun);
            Controls.Add(radDown);
            Controls.Add(radUp);
            Controls.Add(txtNumber);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumber;
        private RadioButton radUp;
        private RadioButton radDown;
        private Button btnRun;
        private TextBox txtOut;
    }
}
