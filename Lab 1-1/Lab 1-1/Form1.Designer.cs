namespace Lab_1_1
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
            lblText = new Label();
            txtName = new TextBox();
            btnGreeting = new Button();
            btnName = new Button();
            btnEnd = new Button();
            SuspendLayout();
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.ForeColor = Color.Maroon;
            lblText.Location = new Point(358, 129);
            lblText.Name = "lblText";
            lblText.Size = new Size(116, 20);
            lblText.TabIndex = 0;
            lblText.Text = "กรุณาใส่คำทักทาย";
            // 
            // txtName
            // 
            txtName.Location = new Point(522, 122);
            txtName.Name = "txtName";
            txtName.Size = new Size(229, 27);
            txtName.TabIndex = 1;
            txtName.TextChanged += txtName_TextChanged;
            // 
            // btnGreeting
            // 
            btnGreeting.Location = new Point(372, 217);
            btnGreeting.Name = "btnGreeting";
            btnGreeting.Size = new Size(98, 36);
            btnGreeting.TabIndex = 2;
            btnGreeting.Text = "ทักทาย";
            btnGreeting.UseVisualStyleBackColor = true;
            btnGreeting.Click += btnGreeting_Click;
            // 
            // btnName
            // 
            btnName.Location = new Point(552, 217);
            btnName.Name = "btnName";
            btnName.Size = new Size(98, 36);
            btnName.TabIndex = 3;
            btnName.Text = "ชื่อนศ.";
            btnName.UseVisualStyleBackColor = true;
            btnName.Click += btnName_Click;
            // 
            // btnEnd
            // 
            btnEnd.Location = new Point(463, 289);
            btnEnd.Name = "btnEnd";
            btnEnd.Size = new Size(98, 36);
            btnEnd.TabIndex = 4;
            btnEnd.Text = "จบการทำงาน";
            btnEnd.UseVisualStyleBackColor = true;
            btnEnd.Click += btnEnd_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(1032, 603);
            Controls.Add(btnEnd);
            Controls.Add(btnName);
            Controls.Add(btnGreeting);
            Controls.Add(txtName);
            Controls.Add(lblText);
            Name = "Form1";
            Text = "โปรแกรมทดสอบ Label, Textbox, Button และ Message Box";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblText;
        private TextBox txtName;
        private Button btnGreeting;
        private Button btnName;
        private Button btnEnd;
    }
}
