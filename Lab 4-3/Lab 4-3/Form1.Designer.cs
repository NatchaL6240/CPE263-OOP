﻿namespace Lab_4_3
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
            btnTable = new Button();
            btnUp = new Button();
            btnDown = new Button();
            numericUpDown1 = new NumericUpDown();
            textBox1 = new TextBox();
            numericUpDown2 = new NumericUpDown();
            numericUpDown3 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).BeginInit();
            SuspendLayout();
            // 
            // btnTable
            // 
            btnTable.Location = new Point(35, 57);
            btnTable.Name = "btnTable";
            btnTable.Size = new Size(92, 29);
            btnTable.TabIndex = 0;
            btnTable.Text = "วาดตาราง";
            btnTable.UseVisualStyleBackColor = true;
            // 
            // btnUp
            // 
            btnUp.Location = new Point(35, 267);
            btnUp.Name = "btnUp";
            btnUp.Size = new Size(150, 29);
            btnUp.TabIndex = 1;
            btnUp.Text = "วาดสามเหลี่ยม Up";
            btnUp.UseVisualStyleBackColor = true;
            // 
            // btnDown
            // 
            btnDown.Location = new Point(35, 353);
            btnDown.Name = "btnDown";
            btnDown.Size = new Size(150, 29);
            btnDown.TabIndex = 2;
            btnDown.Text = "วาดสามเหลี่ยม Down";
            btnDown.UseVisualStyleBackColor = true;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(268, 35);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(93, 27);
            numericUpDown1.TabIndex = 3;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(446, 83);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(244, 286);
            textBox1.TabIndex = 4;
            // 
            // numericUpDown2
            // 
            numericUpDown2.Location = new Point(268, 84);
            numericUpDown2.Name = "numericUpDown2";
            numericUpDown2.Size = new Size(93, 27);
            numericUpDown2.TabIndex = 5;
            // 
            // numericUpDown3
            // 
            numericUpDown3.Location = new Point(268, 311);
            numericUpDown3.Name = "numericUpDown3";
            numericUpDown3.Size = new Size(93, 27);
            numericUpDown3.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(212, 37);
            label1.Name = "label1";
            label1.Size = new Size(34, 20);
            label1.TabIndex = 7;
            label1.Text = "row";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(212, 86);
            label2.Name = "label2";
            label2.Size = new Size(29, 20);
            label2.TabIndex = 8;
            label2.Text = "col";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 313);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 9;
            label3.Text = "row";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown3);
            Controls.Add(numericUpDown2);
            Controls.Add(textBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(btnDown);
            Controls.Add(btnUp);
            Controls.Add(btnTable);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnTable;
        private Button btnUp;
        private Button btnDown;
        private NumericUpDown numericUpDown1;
        private TextBox textBox1;
        private NumericUpDown numericUpDown2;
        private NumericUpDown numericUpDown3;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
