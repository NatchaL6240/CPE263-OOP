namespace Lab_8_1
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
            tckRed = new TrackBar();
            tckGreen = new TrackBar();
            tckBlue = new TrackBar();
            lblRed = new Label();
            lblGreen = new Label();
            lblBlue = new Label();
            lblRGB = new Label();
            lblText = new Label();
            ((System.ComponentModel.ISupportInitialize)tckRed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tckGreen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tckBlue).BeginInit();
            SuspendLayout();
            // 
            // tckRed
            // 
            tckRed.Location = new Point(70, 36);
            tckRed.Maximum = 255;
            tckRed.Name = "tckRed";
            tckRed.Orientation = Orientation.Vertical;
            tckRed.Size = new Size(56, 292);
            tckRed.TabIndex = 0;
            tckRed.TickStyle = TickStyle.None;
            tckRed.Scroll += tckRed_Scroll;
            // 
            // tckGreen
            // 
            tckGreen.Location = new Point(364, 36);
            tckGreen.Maximum = 255;
            tckGreen.Name = "tckGreen";
            tckGreen.Orientation = Orientation.Vertical;
            tckGreen.Size = new Size(56, 292);
            tckGreen.TabIndex = 1;
            tckGreen.TickStyle = TickStyle.None;
            tckGreen.Scroll += tckGreen_Scroll;
            // 
            // tckBlue
            // 
            tckBlue.Location = new Point(668, 36);
            tckBlue.Maximum = 255;
            tckBlue.Name = "tckBlue";
            tckBlue.Orientation = Orientation.Vertical;
            tckBlue.Size = new Size(56, 292);
            tckBlue.TabIndex = 2;
            tckBlue.TickStyle = TickStyle.None;
            tckBlue.Scroll += tckBlue_Scroll;
            // 
            // lblRed
            // 
            lblRed.BorderStyle = BorderStyle.Fixed3D;
            lblRed.Location = new Point(156, 36);
            lblRed.Name = "lblRed";
            lblRed.Size = new Size(60, 292);
            lblRed.TabIndex = 3;
            lblRed.Text = "Red";
            // 
            // lblGreen
            // 
            lblGreen.BorderStyle = BorderStyle.Fixed3D;
            lblGreen.Location = new Point(435, 36);
            lblGreen.Name = "lblGreen";
            lblGreen.Size = new Size(60, 292);
            lblGreen.TabIndex = 4;
            lblGreen.Text = "Green";
            // 
            // lblBlue
            // 
            lblBlue.BorderStyle = BorderStyle.Fixed3D;
            lblBlue.Location = new Point(730, 36);
            lblBlue.Name = "lblBlue";
            lblBlue.Size = new Size(60, 292);
            lblBlue.TabIndex = 5;
            lblBlue.Text = "Blue";
            // 
            // lblRGB
            // 
            lblRGB.BorderStyle = BorderStyle.Fixed3D;
            lblRGB.Location = new Point(247, 349);
            lblRGB.Name = "lblRGB";
            lblRGB.Size = new Size(366, 143);
            lblRGB.TabIndex = 6;
            lblRGB.Text = "RGB";
            // 
            // lblText
            // 
            lblText.AutoSize = true;
            lblText.Location = new Point(370, 510);
            lblText.Name = "lblText";
            lblText.Size = new Size(105, 20);
            lblText.TabIndex = 7;
            lblText.Text = "(255, 255, 255)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(889, 565);
            Controls.Add(lblText);
            Controls.Add(lblRGB);
            Controls.Add(lblBlue);
            Controls.Add(lblGreen);
            Controls.Add(lblRed);
            Controls.Add(tckBlue);
            Controls.Add(tckGreen);
            Controls.Add(tckRed);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)tckRed).EndInit();
            ((System.ComponentModel.ISupportInitialize)tckGreen).EndInit();
            ((System.ComponentModel.ISupportInitialize)tckBlue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TrackBar tckRed;
        private TrackBar tckGreen;
        private TrackBar tckBlue;
        private Label lblRed;
        private Label lblGreen;
        private Label lblBlue;
        private Label lblRGB;
        private Label lblText;
    }
}
