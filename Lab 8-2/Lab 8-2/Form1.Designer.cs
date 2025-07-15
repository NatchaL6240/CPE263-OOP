namespace Lab_8_2
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
            progressBar1 = new ProgressBar();
            radBlocks = new RadioButton();
            radCont = new RadioButton();
            radMarq = new RadioButton();
            btnStart = new Button();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(110, 117);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(598, 44);
            progressBar1.TabIndex = 0;
            // 
            // radBlocks
            // 
            radBlocks.AutoSize = true;
            radBlocks.Location = new Point(143, 220);
            radBlocks.Name = "radBlocks";
            radBlocks.Size = new Size(72, 24);
            radBlocks.TabIndex = 1;
            radBlocks.TabStop = true;
            radBlocks.Text = "Blocks";
            radBlocks.UseVisualStyleBackColor = true;
            // 
            // radCont
            // 
            radCont.AutoSize = true;
            radCont.Location = new Point(343, 220);
            radCont.Name = "radCont";
            radCont.Size = new Size(104, 24);
            radCont.TabIndex = 2;
            radCont.TabStop = true;
            radCont.Text = "Continuous";
            radCont.UseVisualStyleBackColor = true;
            // 
            // radMarq
            // 
            radMarq.AutoSize = true;
            radMarq.Location = new Point(555, 220);
            radMarq.Name = "radMarq";
            radMarq.Size = new Size(89, 24);
            radMarq.TabIndex = 3;
            radMarq.TabStop = true;
            radMarq.Text = "Marquee";
            radMarq.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(322, 314);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(163, 33);
            btnStart.TabIndex = 4;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStart);
            Controls.Add(radMarq);
            Controls.Add(radCont);
            Controls.Add(radBlocks);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ProgressBar progressBar1;
        private RadioButton radBlocks;
        private RadioButton radCont;
        private RadioButton radMarq;
        private Button btnStart;
    }
}
