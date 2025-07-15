namespace Lab_8_3
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
            btnRed = new Button();
            btnYellow = new Button();
            btnGreen = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            numRed = new NumericUpDown();
            numYellow = new NumericUpDown();
            numGreen = new NumericUpDown();
            radOn = new RadioButton();
            radOff = new RadioButton();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numYellow).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numGreen).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // btnRed
            // 
            btnRed.BackColor = Color.White;
            btnRed.Location = new Point(69, 27);
            btnRed.Name = "btnRed";
            btnRed.Size = new Size(203, 101);
            btnRed.TabIndex = 0;
            btnRed.UseVisualStyleBackColor = false;
            // 
            // btnYellow
            // 
            btnYellow.BackColor = Color.White;
            btnYellow.Location = new Point(69, 158);
            btnYellow.Name = "btnYellow";
            btnYellow.Size = new Size(203, 101);
            btnYellow.TabIndex = 1;
            btnYellow.UseVisualStyleBackColor = false;
            // 
            // btnGreen
            // 
            btnGreen.BackColor = Color.White;
            btnGreen.Location = new Point(69, 288);
            btnGreen.Name = "btnGreen";
            btnGreen.Size = new Size(203, 101);
            btnGreen.TabIndex = 2;
            btnGreen.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(35, 32);
            label1.Name = "label1";
            label1.Size = new Size(47, 20);
            label1.TabIndex = 3;
            label1.Text = "ไฟแดง";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(35, 90);
            label2.Name = "label2";
            label2.Size = new Size(60, 20);
            label2.TabIndex = 4;
            label2.Text = "ไฟเหลือง";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 149);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 5;
            label3.Text = "ไฟเขียว";
            // 
            // numRed
            // 
            numRed.Location = new Point(101, 30);
            numRed.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numRed.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRed.Name = "numRed";
            numRed.Size = new Size(111, 27);
            numRed.TabIndex = 6;
            numRed.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numYellow
            // 
            numYellow.Location = new Point(101, 88);
            numYellow.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numYellow.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numYellow.Name = "numYellow";
            numYellow.Size = new Size(111, 27);
            numYellow.TabIndex = 7;
            numYellow.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numGreen
            // 
            numGreen.Location = new Point(101, 147);
            numGreen.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            numGreen.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numGreen.Name = "numGreen";
            numGreen.Size = new Size(111, 27);
            numGreen.TabIndex = 8;
            numGreen.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // radOn
            // 
            radOn.AutoSize = true;
            radOn.Location = new Point(65, 25);
            radOn.Name = "radOn";
            radOn.Size = new Size(49, 24);
            radOn.TabIndex = 9;
            radOn.TabStop = true;
            radOn.Text = "On";
            radOn.UseVisualStyleBackColor = true;
            radOn.CheckedChanged += radOn_CheckedChanged;
            // 
            // radOff
            // 
            radOff.AutoSize = true;
            radOff.Location = new Point(150, 25);
            radOff.Name = "radOff";
            radOff.Size = new Size(51, 24);
            radOff.TabIndex = 10;
            radOff.TabStop = true;
            radOff.Text = "Off";
            radOff.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(numGreen);
            groupBox1.Controls.Add(numYellow);
            groupBox1.Controls.Add(numRed);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(373, 27);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(257, 217);
            groupBox1.TabIndex = 11;
            groupBox1.TabStop = false;
            groupBox1.Text = "เวลา (วินาที)";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(radOff);
            groupBox2.Controls.Add(radOn);
            groupBox2.Location = new Point(373, 276);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(258, 78);
            groupBox2.TabIndex = 12;
            groupBox2.TabStop = false;
            groupBox2.Text = "Power";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnGreen);
            Controls.Add(btnYellow);
            Controls.Add(btnRed);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)numYellow).EndInit();
            ((System.ComponentModel.ISupportInitialize)numGreen).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnRed;
        private Button btnYellow;
        private Button btnGreen;
        private Label label1;
        private Label label2;
        private Label label3;
        private NumericUpDown numRed;
        private NumericUpDown numYellow;
        private NumericUpDown numGreen;
        private RadioButton radOn;
        private RadioButton radOff;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private System.Windows.Forms.Timer timer1;
    }
}
