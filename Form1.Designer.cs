
namespace calculator
{
    partial class frmMain
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
            this.lblDisplay = new System.Windows.Forms.Label();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btnCong = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnDoidau = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnThapphan = new System.Windows.Forms.Button();
            this.btnPhantram = new System.Windows.Forms.Button();
            this.btnBang = new System.Windows.Forms.Button();
            this.btnNho = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDisplay
            // 
            this.lblDisplay.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblDisplay.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDisplay.Location = new System.Drawing.Point(12, 38);
            this.lblDisplay.Name = "lblDisplay";
            this.lblDisplay.Size = new System.Drawing.Size(312, 62);
            this.lblDisplay.TabIndex = 0;
            this.lblDisplay.Text = "0.";
            this.lblDisplay.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(75, 401);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(57, 55);
            this.btn0.TabIndex = 1;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(12, 330);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(57, 55);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(138, 330);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(57, 55);
            this.btn3.TabIndex = 3;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(12, 265);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(57, 55);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(75, 265);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(57, 55);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(138, 265);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(57, 55);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(12, 195);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(57, 55);
            this.btn7.TabIndex = 7;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(138, 195);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(57, 55);
            this.btn9.TabIndex = 8;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.NhapSo);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(75, 195);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(57, 55);
            this.btn8.TabIndex = 9;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.NhapSo);
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(201, 195);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(57, 55);
            this.btnCong.TabIndex = 10;
            this.btnCong.Text = "+";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.NhapPhepToan);
            // 
            // btnTru
            // 
            this.btnTru.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnTru.Location = new System.Drawing.Point(201, 263);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(57, 55);
            this.btnTru.TabIndex = 11;
            this.btnTru.Text = "-";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.NhapPhepToan);
            // 
            // btnDoidau
            // 
            this.btnDoidau.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDoidau.Location = new System.Drawing.Point(12, 399);
            this.btnDoidau.Name = "btnDoidau";
            this.btnDoidau.Size = new System.Drawing.Size(57, 55);
            this.btnDoidau.TabIndex = 12;
            this.btnDoidau.Text = "-/+";
            this.btnDoidau.UseVisualStyleBackColor = true;
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(201, 401);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(57, 55);
            this.btnChia.TabIndex = 13;
            this.btnChia.Text = "/";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.NhapPhepToan);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(201, 330);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(57, 55);
            this.btnNhan.TabIndex = 14;
            this.btnNhan.Text = "*";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.NhapPhepToan);
            // 
            // btnThapphan
            // 
            this.btnThapphan.Location = new System.Drawing.Point(138, 401);
            this.btnThapphan.Name = "btnThapphan";
            this.btnThapphan.Size = new System.Drawing.Size(57, 55);
            this.btnThapphan.TabIndex = 15;
            this.btnThapphan.Text = ".";
            this.btnThapphan.UseVisualStyleBackColor = true;
            // 
            // btnPhantram
            // 
            this.btnPhantram.Location = new System.Drawing.Point(267, 265);
            this.btnPhantram.Name = "btnPhantram";
            this.btnPhantram.Size = new System.Drawing.Size(57, 55);
            this.btnPhantram.TabIndex = 16;
            this.btnPhantram.Text = "%";
            this.btnPhantram.UseVisualStyleBackColor = true;
            // 
            // btnBang
            // 
            this.btnBang.Location = new System.Drawing.Point(267, 330);
            this.btnBang.Name = "btnBang";
            this.btnBang.Size = new System.Drawing.Size(57, 126);
            this.btnBang.TabIndex = 17;
            this.btnBang.Text = "=";
            this.btnBang.UseVisualStyleBackColor = true;
            this.btnBang.Click += new System.EventHandler(this.btnBang_Click);
            // 
            // btnNho
            // 
            this.btnNho.Location = new System.Drawing.Point(12, 124);
            this.btnNho.Name = "btnNho";
            this.btnNho.Size = new System.Drawing.Size(120, 55);
            this.btnNho.TabIndex = 18;
            this.btnNho.Text = "C";
            this.btnNho.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(138, 124);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(183, 55);
            this.btnXoa.TabIndex = 19;
            this.btnXoa.Text = "Backsapse";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(75, 330);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(57, 55);
            this.btn2.TabIndex = 20;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.NhapSo);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 464);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnNho);
            this.Controls.Add(this.btnBang);
            this.Controls.Add(this.btnPhantram);
            this.Controls.Add(this.btnThapphan);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnDoidau);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.lblDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.Name = "frmMain";
            this.Text = "Calculator";
            this.Click += new System.EventHandler(this.NhapPhepToan);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmMain_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDisplay;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnDoidau;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnThapphan;
        private System.Windows.Forms.Button btnPhantram;
        private System.Windows.Forms.Button btnBang;
        private System.Windows.Forms.Button btnNho;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btn2;
    }
}

