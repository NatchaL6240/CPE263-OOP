namespace Lab_3_5
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
            txt1 = new TextBox();
            txt2 = new TextBox();
            txt3 = new TextBox();
            btnRun = new Button();
            lblAns = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txt1
            // 
            txt1.Location = new Point(180, 99);
            txt1.Name = "txt1";
            txt1.Size = new Size(125, 27);
            txt1.TabIndex = 0;
            // 
            // txt2
            // 
            txt2.Location = new Point(180, 150);
            txt2.Name = "txt2";
            txt2.Size = new Size(125, 27);
            txt2.TabIndex = 1;
            // 
            // txt3
            // 
            txt3.Location = new Point(180, 205);
            txt3.Name = "txt3";
            txt3.Size = new Size(125, 27);
            txt3.TabIndex = 2;
            // 
            // btnRun
            // 
            btnRun.Location = new Point(294, 289);
            btnRun.Name = "btnRun";
            btnRun.Size = new Size(94, 29);
            btnRun.TabIndex = 3;
            btnRun.Text = "Run";
            btnRun.UseVisualStyleBackColor = true;
            btnRun.Click += btnRun_Click;
            // 
            // lblAns
            // 
            lblAns.BorderStyle = BorderStyle.Fixed3D;
            lblAns.Location = new Point(416, 84);
            lblAns.Name = "lblAns";
            lblAns.Size = new Size(208, 166);
            lblAns.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(129, 46);
            label1.Name = "label1";
            label1.Size = new Size(101, 20);
            label1.TabIndex = 5;
            label1.Text = "Input Number";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(lblAns);
            Controls.Add(btnRun);
            Controls.Add(txt3);
            Controls.Add(txt2);
            Controls.Add(txt1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt1;
        private TextBox txt2;
        private TextBox txt3;
        private Button btnRun;
        private Label lblAns;
        private Label label1;
    }
}
