namespace Lab_2_4
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
            txtRadius = new TextBox();
            txtAns = new TextBox();
            btnCir1 = new Button();
            btnCir2 = new Button();
            btnCir3 = new Button();
            btnCir4 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(292, 102);
            label1.Name = "label1";
            label1.Size = new Size(76, 20);
            label1.TabIndex = 0;
            label1.Text = "พิมพ์ค่ารัศมี";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(292, 206);
            label2.Name = "label2";
            label2.Size = new Size(52, 20);
            label2.TabIndex = 1;
            label2.Text = "ผลลัพธ์";
            // 
            // txtRadius
            // 
            txtRadius.Location = new Point(503, 102);
            txtRadius.Name = "txtRadius";
            txtRadius.Size = new Size(125, 27);
            txtRadius.TabIndex = 2;
            // 
            // txtAns
            // 
            txtAns.Location = new Point(503, 199);
            txtAns.Name = "txtAns";
            txtAns.Size = new Size(125, 27);
            txtAns.TabIndex = 3;
            // 
            // btnCir1
            // 
            btnCir1.Location = new Point(316, 289);
            btnCir1.Name = "btnCir1";
            btnCir1.Size = new Size(109, 43);
            btnCir1.TabIndex = 4;
            btnCir1.Text = "เส้นรอบวงกลม";
            btnCir1.UseVisualStyleBackColor = true;
            btnCir1.Click += btnCir1_Click;
            // 
            // btnCir2
            // 
            btnCir2.Location = new Point(483, 289);
            btnCir2.Name = "btnCir2";
            btnCir2.Size = new Size(109, 43);
            btnCir2.TabIndex = 5;
            btnCir2.Text = "พื้นที่วงกลม";
            btnCir2.UseVisualStyleBackColor = true;
            btnCir2.Click += btnCir2_Click;
            // 
            // btnCir3
            // 
            btnCir3.Location = new Point(316, 377);
            btnCir3.Name = "btnCir3";
            btnCir3.Size = new Size(109, 43);
            btnCir3.TabIndex = 6;
            btnCir3.Text = "พื้นที่ผิวทรงกลม";
            btnCir3.UseVisualStyleBackColor = true;
            btnCir3.Click += btnCir3_Click;
            // 
            // btnCir4
            // 
            btnCir4.Location = new Point(483, 377);
            btnCir4.Name = "btnCir4";
            btnCir4.Size = new Size(109, 43);
            btnCir4.TabIndex = 7;
            btnCir4.Text = "ปริมาตรทรงกลม";
            btnCir4.UseVisualStyleBackColor = true;
            btnCir4.Click += btnCir4_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 224, 192);
            ClientSize = new Size(1022, 591);
            Controls.Add(btnCir4);
            Controls.Add(btnCir3);
            Controls.Add(btnCir2);
            Controls.Add(btnCir1);
            Controls.Add(txtAns);
            Controls.Add(txtRadius);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtRadius;
        private TextBox txtAns;
        private Button btnCir1;
        private Button btnCir2;
        private Button btnCir3;
        private Button btnCir4;
    }
}
