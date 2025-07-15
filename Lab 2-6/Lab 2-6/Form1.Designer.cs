namespace Lab_2_6
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
            txtTemp = new TextBox();
            btnCel = new Button();
            btnFar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 129);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 0;
            label1.Text = "พิมพ์ค่าองศา";
            // 
            // txtTemp
            // 
            txtTemp.Location = new Point(568, 122);
            txtTemp.Name = "txtTemp";
            txtTemp.Size = new Size(125, 27);
            txtTemp.TabIndex = 1;
            // 
            // btnCel
            // 
            btnCel.Location = new Point(350, 221);
            btnCel.Name = "btnCel";
            btnCel.Size = new Size(120, 44);
            btnCel.TabIndex = 2;
            btnCel.Text = "Celcius";
            btnCel.UseVisualStyleBackColor = true;
            btnCel.Click += btnCel_Click;
            // 
            // btnFar
            // 
            btnFar.Location = new Point(568, 221);
            btnFar.Name = "btnFar";
            btnFar.Size = new Size(120, 44);
            btnFar.TabIndex = 3;
            btnFar.Text = "Farhenheit";
            btnFar.UseVisualStyleBackColor = true;
            btnFar.Click += btnFar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1097, 618);
            Controls.Add(btnFar);
            Controls.Add(btnCel);
            Controls.Add(txtTemp);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTemp;
        private Button btnCel;
        private Button btnFar;
    }
}
