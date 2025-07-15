namespace Lab_4_5
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
            txtGuess = new TextBox();
            btnGuess = new Button();
            txtAns = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(254, 69);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "ทายตัวเลข";
            // 
            // txtGuess
            // 
            txtGuess.Location = new Point(382, 66);
            txtGuess.Name = "txtGuess";
            txtGuess.Size = new Size(125, 27);
            txtGuess.TabIndex = 1;
            // 
            // btnGuess
            // 
            btnGuess.Location = new Point(302, 195);
            btnGuess.Name = "btnGuess";
            btnGuess.Size = new Size(130, 38);
            btnGuess.TabIndex = 2;
            btnGuess.Text = "ทาย";
            btnGuess.UseVisualStyleBackColor = true;
            btnGuess.Click += button1_Click;
            // 
            // txtAns
            // 
            txtAns.Location = new Point(264, 296);
            txtAns.Name = "txtAns";
            txtAns.Size = new Size(215, 27);
            txtAns.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtAns);
            Controls.Add(btnGuess);
            Controls.Add(txtGuess);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtGuess;
        private Button btnGuess;
        private TextBox txtAns;
    }
}
