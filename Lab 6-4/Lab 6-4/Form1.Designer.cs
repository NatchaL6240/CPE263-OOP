namespace Lab_6_4
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
            monthCalendar1 = new MonthCalendar();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBox1 = new ComboBox();
            updDate = new NumericUpDown();
            updMonth = new NumericUpDown();
            updYear = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)updDate).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updMonth).BeginInit();
            ((System.ComponentModel.ISupportInitialize)updYear).BeginInit();
            SuspendLayout();
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(82, 59);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(470, 86);
            label1.Name = "label1";
            label1.Size = new Size(25, 20);
            label1.TabIndex = 1;
            label1.Text = "วัน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(470, 158);
            label2.Name = "label2";
            label2.Size = new Size(39, 20);
            label2.TabIndex = 2;
            label2.Text = "เดือน";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(470, 227);
            label3.Name = "label3";
            label3.Size = new Size(18, 20);
            label3.TabIndex = 3;
            label3.Text = "ปี";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 359);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 4;
            label4.Text = "วันแรกของสัปดาห์";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "อาทิตย์", "จันทร์" });
            comboBox1.Location = new Point(557, 356);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(206, 28);
            comboBox1.TabIndex = 5;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // updDate
            // 
            updDate.Location = new Point(557, 84);
            updDate.Maximum = new decimal(new int[] { 31, 0, 0, 0 });
            updDate.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            updDate.Name = "updDate";
            updDate.Size = new Size(150, 27);
            updDate.TabIndex = 6;
            updDate.Value = new decimal(new int[] { 1, 0, 0, 0 });
            updDate.ValueChanged += updDate_ValueChanged;
            // 
            // updMonth
            // 
            updMonth.Location = new Point(557, 156);
            updMonth.Maximum = new decimal(new int[] { 12, 0, 0, 0 });
            updMonth.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            updMonth.Name = "updMonth";
            updMonth.Size = new Size(150, 27);
            updMonth.TabIndex = 7;
            updMonth.Value = new decimal(new int[] { 1, 0, 0, 0 });
            updMonth.ValueChanged += updMonth_ValueChanged;
            // 
            // updYear
            // 
            updYear.Location = new Point(557, 225);
            updYear.Maximum = new decimal(new int[] { 2600, 0, 0, 0 });
            updYear.Name = "updYear";
            updYear.Size = new Size(150, 27);
            updYear.TabIndex = 8;
            updYear.ValueChanged += updYear_ValueChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(updYear);
            Controls.Add(updMonth);
            Controls.Add(updDate);
            Controls.Add(comboBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(monthCalendar1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)updDate).EndInit();
            ((System.ComponentModel.ISupportInitialize)updMonth).EndInit();
            ((System.ComponentModel.ISupportInitialize)updYear).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBox1;
        private NumericUpDown updDate;
        private NumericUpDown updMonth;
        private NumericUpDown updYear;
    }
}
