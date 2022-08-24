namespace QuanLyThuoc.Dang_nhap_he_thong
{
    partial class Quenmatkhau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Quenmatkhau));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.txt_mk = new System.Windows.Forms.TextBox();
            this.txt_lmk = new System.Windows.Forms.TextBox();
            this.bt_xn = new System.Windows.Forms.Button();
            this.bt_thoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "LẤY LẠI MẬT KHẨU";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(164, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 125);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 32;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tên nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "Mật khẩu";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Nhập lại mật khẩu";
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(164, 191);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(140, 20);
            this.txt_ten.TabIndex = 36;
            // 
            // txt_mk
            // 
            this.txt_mk.Location = new System.Drawing.Point(164, 233);
            this.txt_mk.Name = "txt_mk";
            this.txt_mk.Size = new System.Drawing.Size(140, 20);
            this.txt_mk.TabIndex = 37;
            // 
            // txt_lmk
            // 
            this.txt_lmk.Location = new System.Drawing.Point(164, 273);
            this.txt_lmk.Name = "txt_lmk";
            this.txt_lmk.Size = new System.Drawing.Size(140, 20);
            this.txt_lmk.TabIndex = 38;
            // 
            // bt_xn
            // 
            this.bt_xn.Location = new System.Drawing.Point(83, 327);
            this.bt_xn.Name = "bt_xn";
            this.bt_xn.Size = new System.Drawing.Size(75, 23);
            this.bt_xn.TabIndex = 39;
            this.bt_xn.Text = "Xác nhận";
            this.bt_xn.UseVisualStyleBackColor = true;
            this.bt_xn.Click += new System.EventHandler(this.bt_xn_Click);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(228, 327);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 23);
            this.bt_thoat.TabIndex = 40;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // Quenmatkhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(515, 408);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_xn);
            this.Controls.Add(this.txt_lmk);
            this.Controls.Add(this.txt_mk);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Name = "Quenmatkhau";
            this.Text = "Quenmatkhau";
            this.Load += new System.EventHandler(this.Quenmatkhau_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.TextBox txt_mk;
        private System.Windows.Forms.TextBox txt_lmk;
        private System.Windows.Forms.Button bt_xn;
        private System.Windows.Forms.Button bt_thoat;
    }
}