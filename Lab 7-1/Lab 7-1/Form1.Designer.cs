namespace Lab_7_1
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            txtONOFF = new TextBox();
            btnELECcreate = new Button();
            txtSN = new TextBox();
            txtLT = new TextBox();
            txtType = new TextBox();
            txtBrand = new TextBox();
            btnWorkE = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            txtTime = new TextBox();
            txtDay = new TextBox();
            txtChannel = new TextBox();
            txtTVsn = new TextBox();
            txtMonitor = new TextBox();
            txtTypeTV = new TextBox();
            btnTV = new Button();
            btnCreateTV = new Button();
            label12 = new Label();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(48, 49);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(685, 353);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtONOFF);
            tabPage1.Controls.Add(btnELECcreate);
            tabPage1.Controls.Add(txtSN);
            tabPage1.Controls.Add(txtLT);
            tabPage1.Controls.Add(txtType);
            tabPage1.Controls.Add(txtBrand);
            tabPage1.Controls.Add(btnWorkE);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(677, 320);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "อุปกรณไฟฟ้า";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtONOFF
            // 
            txtONOFF.Location = new Point(547, 146);
            txtONOFF.Name = "txtONOFF";
            txtONOFF.Size = new Size(68, 27);
            txtONOFF.TabIndex = 13;
            // 
            // btnELECcreate
            // 
            btnELECcreate.Location = new Point(425, 41);
            btnELECcreate.Name = "btnELECcreate";
            btnELECcreate.Size = new Size(180, 74);
            btnELECcreate.TabIndex = 12;
            btnELECcreate.Text = "สร้าง Object อุปกรณ์ไฟฟ้า";
            btnELECcreate.UseVisualStyleBackColor = true;
            btnELECcreate.Click += btnELECcreate_Click;
            // 
            // txtSN
            // 
            txtSN.Location = new Point(141, 218);
            txtSN.Name = "txtSN";
            txtSN.Size = new Size(81, 27);
            txtSN.TabIndex = 11;
            // 
            // txtLT
            // 
            txtLT.Location = new Point(112, 146);
            txtLT.Name = "txtLT";
            txtLT.Size = new Size(68, 27);
            txtLT.TabIndex = 10;
            // 
            // txtType
            // 
            txtType.Location = new Point(222, 92);
            txtType.Name = "txtType";
            txtType.Size = new Size(108, 27);
            txtType.TabIndex = 9;
            // 
            // txtBrand
            // 
            txtBrand.Location = new Point(222, 34);
            txtBrand.Name = "txtBrand";
            txtBrand.Size = new Size(108, 27);
            txtBrand.TabIndex = 8;
            // 
            // btnWorkE
            // 
            btnWorkE.Location = new Point(425, 217);
            btnWorkE.Name = "btnWorkE";
            btnWorkE.Size = new Size(127, 37);
            btnWorkE.TabIndex = 7;
            btnWorkE.Text = "Working";
            btnWorkE.UseVisualStyleBackColor = true;
            btnWorkE.Click += btnWorkE_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(425, 153);
            label6.Name = "label6";
            label6.Size = new Size(104, 20);
            label6.TabIndex = 5;
            label6.Text = "พิมพ์ (ON/OFF)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 225);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 4;
            label5.Text = "Save No.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(186, 153);
            label4.Name = "label4";
            label4.Size = new Size(18, 20);
            label4.TabIndex = 3;
            label4.Text = "ปี";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 153);
            label3.Name = "label3";
            label3.Size = new Size(89, 20);
            label3.TabIndex = 2;
            label3.Text = "อายุการใช้งาน";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(68, 95);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 1;
            label2.Text = "ชนิดไฟฟ้า (AC,DC)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 41);
            label1.Name = "label1";
            label1.Size = new Size(42, 20);
            label1.TabIndex = 0;
            label1.Text = "บริษัท";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(txtTime);
            tabPage2.Controls.Add(txtDay);
            tabPage2.Controls.Add(txtChannel);
            tabPage2.Controls.Add(txtTVsn);
            tabPage2.Controls.Add(txtMonitor);
            tabPage2.Controls.Add(txtTypeTV);
            tabPage2.Controls.Add(btnTV);
            tabPage2.Controls.Add(btnCreateTV);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(677, 320);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "TV";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // txtTime
            // 
            txtTime.Location = new Point(462, 231);
            txtTime.Name = "txtTime";
            txtTime.Size = new Size(110, 27);
            txtTime.TabIndex = 13;
            // 
            // txtDay
            // 
            txtDay.Location = new Point(462, 180);
            txtDay.Name = "txtDay";
            txtDay.Size = new Size(110, 27);
            txtDay.TabIndex = 12;
            // 
            // txtChannel
            // 
            txtChannel.Location = new Point(462, 135);
            txtChannel.Name = "txtChannel";
            txtChannel.Size = new Size(110, 27);
            txtChannel.TabIndex = 11;
            // 
            // txtTVsn
            // 
            txtTVsn.Location = new Point(151, 166);
            txtTVsn.Name = "txtTVsn";
            txtTVsn.Size = new Size(110, 27);
            txtTVsn.TabIndex = 10;
            // 
            // txtMonitor
            // 
            txtMonitor.Location = new Point(223, 81);
            txtMonitor.Name = "txtMonitor";
            txtMonitor.Size = new Size(110, 27);
            txtMonitor.TabIndex = 9;
            // 
            // txtTypeTV
            // 
            txtTypeTV.Location = new Point(223, 29);
            txtTypeTV.Name = "txtTypeTV";
            txtTypeTV.Size = new Size(110, 27);
            txtTypeTV.TabIndex = 8;
            // 
            // btnTV
            // 
            btnTV.Location = new Point(471, 277);
            btnTV.Name = "btnTV";
            btnTV.Size = new Size(107, 26);
            btnTV.TabIndex = 7;
            btnTV.Text = "TV";
            btnTV.UseVisualStyleBackColor = true;
            btnTV.Click += btnTV_Click;
            // 
            // btnCreateTV
            // 
            btnCreateTV.Location = new Point(440, 35);
            btnCreateTV.Name = "btnCreateTV";
            btnCreateTV.Size = new Size(169, 61);
            btnCreateTV.TabIndex = 6;
            btnCreateTV.Text = "สร้างออปเจคท์ TV";
            btnCreateTV.UseVisualStyleBackColor = true;
            btnCreateTV.Click += btnCreateTV_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(404, 234);
            label12.Name = "label12";
            label12.Size = new Size(38, 20);
            label12.TabIndex = 5;
            label12.Text = "เวลา:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(404, 187);
            label11.Name = "label11";
            label11.Size = new Size(28, 20);
            label11.TabIndex = 4;
            label11.Text = "วัน:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(404, 142);
            label10.Name = "label10";
            label10.Size = new Size(55, 20);
            label10.TabIndex = 3;
            label10.Text = "รายการ:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(44, 173);
            label9.Name = "label9";
            label9.Size = new Size(88, 20);
            label9.TabIndex = 2;
            label9.Text = "TV Save No.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(44, 81);
            label8.Name = "label8";
            label8.Size = new Size(154, 20);
            label8.TabIndex = 1;
            label8.Text = "จอภาพ (CRT/LCD/LED)";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(44, 36);
            label7.Name = "label7";
            label7.Size = new Size(149, 20);
            label7.TabIndex = 0;
            label7.Text = "ชนิด (Analog/Digital)";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox txtSN;
        private TextBox txtLT;
        private TextBox txtType;
        private TextBox txtBrand;
        private Button btnWorkE;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        private TextBox txtTime;
        private TextBox txtDay;
        private TextBox txtChannel;
        private TextBox txtTVsn;
        private TextBox txtMonitor;
        private TextBox txtTypeTV;
        private Button btnTV;
        private Button btnCreateTV;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Button btnELECcreate;
        private TextBox txtONOFF;
    }
}
