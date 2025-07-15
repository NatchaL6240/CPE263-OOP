namespace Lab_3_1
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
            pictureBox1 = new PictureBox();
            btnNuang = new Button();
            btnCellbit = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(480, 61);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(510, 383);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // btnNuang
            // 
            btnNuang.Location = new Point(178, 294);
            btnNuang.Name = "btnNuang";
            btnNuang.Size = new Size(136, 54);
            btnNuang.TabIndex = 2;
            btnNuang.Text = "Nuang";
            btnNuang.UseVisualStyleBackColor = true;
            btnNuang.Click += btnNuang_Click;
            // 
            // btnCellbit
            // 
            btnCellbit.Location = new Point(178, 112);
            btnCellbit.Name = "btnCellbit";
            btnCellbit.Size = new Size(136, 54);
            btnCellbit.TabIndex = 3;
            btnCellbit.Text = "Cellbit";
            btnCellbit.UseVisualStyleBackColor = true;
            btnCellbit.Click += btnCellbit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1017, 492);
            Controls.Add(btnCellbit);
            Controls.Add(btnNuang);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button button1;
        private Button btnNuang;
        private Button btnCellbit;
    }
}
