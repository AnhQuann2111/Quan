namespace Buoi03_1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCong = new System.Windows.Forms.Button();
            this.lblSoA = new System.Windows.Forms.Label();
            this.lblSoB = new System.Windows.Forms.Label();
            this.lblChuongTrinh = new System.Windows.Forms.Label();
            this.lblKetQua = new System.Windows.Forms.Label();
            this.txtSoA = new System.Windows.Forms.TextBox();
            this.txtSoB = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(70, 256);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(86, 39);
            this.btnCong.TabIndex = 0;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click_1);
            // 
            // lblSoA
            // 
            this.lblSoA.AutoSize = true;
            this.lblSoA.Location = new System.Drawing.Point(66, 105);
            this.lblSoA.Name = "lblSoA";
            this.lblSoA.Size = new System.Drawing.Size(44, 20);
            this.lblSoA.TabIndex = 1;
            this.lblSoA.Text = "Số A";
            this.lblSoA.Click += new System.EventHandler(this.lblSoA_Click);
            // 
            // lblSoB
            // 
            this.lblSoB.AutoSize = true;
            this.lblSoB.Location = new System.Drawing.Point(66, 151);
            this.lblSoB.Name = "lblSoB";
            this.lblSoB.Size = new System.Drawing.Size(44, 20);
            this.lblSoB.TabIndex = 2;
            this.lblSoB.Text = "Số B";
            // 
            // lblChuongTrinh
            // 
            this.lblChuongTrinh.AutoSize = true;
            this.lblChuongTrinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChuongTrinh.ForeColor = System.Drawing.Color.Red;
            this.lblChuongTrinh.Location = new System.Drawing.Point(225, 28);
            this.lblChuongTrinh.Name = "lblChuongTrinh";
            this.lblChuongTrinh.Size = new System.Drawing.Size(322, 29);
            this.lblChuongTrinh.TabIndex = 3;
            this.lblChuongTrinh.Text = "CHƯƠNG TRÌNH TÍNH 2 SỐ";
            // 
            // lblKetQua
            // 
            this.lblKetQua.AutoSize = true;
            this.lblKetQua.Location = new System.Drawing.Point(66, 356);
            this.lblKetQua.Name = "lblKetQua";
            this.lblKetQua.Size = new System.Drawing.Size(67, 20);
            this.lblKetQua.TabIndex = 4;
            this.lblKetQua.Text = "Kết Quả";
            // 
            // txtSoA
            // 
            this.txtSoA.Location = new System.Drawing.Point(174, 99);
            this.txtSoA.Name = "txtSoA";
            this.txtSoA.Size = new System.Drawing.Size(100, 26);
            this.txtSoA.TabIndex = 5;
            // 
            // txtSoB
            // 
            this.txtSoB.Location = new System.Drawing.Point(175, 151);
            this.txtSoB.Name = "txtSoB";
            this.txtSoB.Size = new System.Drawing.Size(100, 26);
            this.txtSoB.TabIndex = 6;
            // 
            // txtKetQua
            // 
            this.txtKetQua.Location = new System.Drawing.Point(175, 350);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(100, 26);
            this.txtKetQua.TabIndex = 7;
            this.txtKetQua.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(188, 256);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(86, 39);
            this.btnTru.TabIndex = 0;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(450, 256);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(86, 39);
            this.btnChia.TabIndex = 0;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(327, 256);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(86, 39);
            this.btnNhan.TabIndex = 0;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(584, 256);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(86, 39);
            this.btnThoat.TabIndex = 0;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 450);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.txtSoB);
            this.Controls.Add(this.txtSoA);
            this.Controls.Add(this.lblKetQua);
            this.Controls.Add(this.lblChuongTrinh);
            this.Controls.Add(this.lblSoB);
            this.Controls.Add(this.lblSoA);
            this.Controls.Add(this.btnNhan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnChia);
            this.Controls.Add(this.btnTru);
            this.Controls.Add(this.btnCong);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.Label lblSoA;
        private System.Windows.Forms.Label lblSoB;
        private System.Windows.Forms.Label lblChuongTrinh;
        private System.Windows.Forms.Label lblKetQua;
        private System.Windows.Forms.TextBox txtSoA;
        private System.Windows.Forms.TextBox txtSoB;
        private System.Windows.Forms.TextBox txtKetQua;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnThoat;
    }
}

