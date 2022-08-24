namespace QuanLyThuoc.Cap_nhat
{
    partial class CNTTkhachhangg
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label diaChiLabel;
            System.Windows.Forms.Label dienThoaiLabel;
            System.Windows.Forms.Label maKhachHangLabel;
            System.Windows.Forms.Label tenKhachHangLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.diaChiTextBox = new System.Windows.Forms.TextBox();
            this.dienThoaiTextBox = new System.Windows.Forms.TextBox();
            this.maKhachHangTextBox = new System.Windows.Forms.TextBox();
            this.tenKhachHangTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.khachHangDataGridView = new System.Windows.Forms.DataGridView();
            this.bt_thoat = new System.Windows.Forms.Button();
            this.bt_xoa = new System.Windows.Forms.Button();
            this.bt_sua = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.khachHangBindingSource = new System.Windows.Forms.BindingSource(this.components);
            diaChiLabel = new System.Windows.Forms.Label();
            dienThoaiLabel = new System.Windows.Forms.Label();
            maKhachHangLabel = new System.Windows.Forms.Label();
            tenKhachHangLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // diaChiLabel
            // 
            diaChiLabel.AutoSize = true;
            diaChiLabel.Location = new System.Drawing.Point(257, 46);
            diaChiLabel.Name = "diaChiLabel";
            diaChiLabel.Size = new System.Drawing.Size(44, 13);
            diaChiLabel.TabIndex = 0;
            diaChiLabel.Text = "Dia Chi:";
            // 
            // dienThoaiLabel
            // 
            dienThoaiLabel.AutoSize = true;
            dienThoaiLabel.Location = new System.Drawing.Point(257, 72);
            dienThoaiLabel.Name = "dienThoaiLabel";
            dienThoaiLabel.Size = new System.Drawing.Size(62, 13);
            dienThoaiLabel.TabIndex = 2;
            dienThoaiLabel.Text = "Dien Thoai:";
            // 
            // maKhachHangLabel
            // 
            maKhachHangLabel.AutoSize = true;
            maKhachHangLabel.Location = new System.Drawing.Point(21, 43);
            maKhachHangLabel.Name = "maKhachHangLabel";
            maKhachHangLabel.Size = new System.Drawing.Size(88, 13);
            maKhachHangLabel.TabIndex = 4;
            maKhachHangLabel.Text = "Ma Khach Hang:";
            // 
            // tenKhachHangLabel
            // 
            tenKhachHangLabel.AutoSize = true;
            tenKhachHangLabel.Location = new System.Drawing.Point(21, 83);
            tenKhachHangLabel.Name = "tenKhachHangLabel";
            tenKhachHangLabel.Size = new System.Drawing.Size(92, 13);
            tenKhachHangLabel.TabIndex = 6;
            tenKhachHangLabel.Text = "Ten Khach Hang:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "CẬP NHẬT THÔNG TIN KHÁCH HÀNG\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(diaChiLabel);
            this.groupBox1.Controls.Add(this.diaChiTextBox);
            this.groupBox1.Controls.Add(dienThoaiLabel);
            this.groupBox1.Controls.Add(this.dienThoaiTextBox);
            this.groupBox1.Controls.Add(maKhachHangLabel);
            this.groupBox1.Controls.Add(this.maKhachHangTextBox);
            this.groupBox1.Controls.Add(tenKhachHangLabel);
            this.groupBox1.Controls.Add(this.tenKhachHangTextBox);
            this.groupBox1.Location = new System.Drawing.Point(26, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 110);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin khách hàng";
            // 
            // diaChiTextBox
            // 
            this.diaChiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "DiaChi", true));
            this.diaChiTextBox.Location = new System.Drawing.Point(355, 43);
            this.diaChiTextBox.Name = "diaChiTextBox";
            this.diaChiTextBox.Size = new System.Drawing.Size(100, 20);
            this.diaChiTextBox.TabIndex = 1;
            // 
            // dienThoaiTextBox
            // 
            this.dienThoaiTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "DienThoai", true));
            this.dienThoaiTextBox.Location = new System.Drawing.Point(355, 69);
            this.dienThoaiTextBox.Name = "dienThoaiTextBox";
            this.dienThoaiTextBox.Size = new System.Drawing.Size(100, 20);
            this.dienThoaiTextBox.TabIndex = 3;
            // 
            // maKhachHangTextBox
            // 
            this.maKhachHangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "MaKhachHang", true));
            this.maKhachHangTextBox.Location = new System.Drawing.Point(119, 40);
            this.maKhachHangTextBox.Name = "maKhachHangTextBox";
            this.maKhachHangTextBox.Size = new System.Drawing.Size(100, 20);
            this.maKhachHangTextBox.TabIndex = 5;
            // 
            // tenKhachHangTextBox
            // 
            this.tenKhachHangTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.khachHangBindingSource, "TenKhachHang", true));
            this.tenKhachHangTextBox.Location = new System.Drawing.Point(119, 80);
            this.tenKhachHangTextBox.Name = "tenKhachHangTextBox";
            this.tenKhachHangTextBox.Size = new System.Drawing.Size(100, 20);
            this.tenKhachHangTextBox.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.khachHangDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(12, 188);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(520, 273);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách khách hàng";
            // 
            // khachHangDataGridView
            // 
            this.khachHangDataGridView.AutoGenerateColumns = false;
            this.khachHangDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.khachHangDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.khachHangDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.khachHangDataGridView.DataSource = this.khachHangBindingSource;
            this.khachHangDataGridView.Location = new System.Drawing.Point(26, 33);
            this.khachHangDataGridView.Name = "khachHangDataGridView";
            this.khachHangDataGridView.Size = new System.Drawing.Size(464, 220);
            this.khachHangDataGridView.TabIndex = 0;
            this.khachHangDataGridView.SelectionChanged += new System.EventHandler(this.khachHangDataGridView_SelectionChanged);
            // 
            // bt_thoat
            // 
            this.bt_thoat.Location = new System.Drawing.Point(624, 304);
            this.bt_thoat.Name = "bt_thoat";
            this.bt_thoat.Size = new System.Drawing.Size(75, 23);
            this.bt_thoat.TabIndex = 13;
            this.bt_thoat.Text = "Thoát";
            this.bt_thoat.UseVisualStyleBackColor = true;
            this.bt_thoat.Click += new System.EventHandler(this.bt_thoat_Click);
            // 
            // bt_xoa
            // 
            this.bt_xoa.Location = new System.Drawing.Point(624, 243);
            this.bt_xoa.Name = "bt_xoa";
            this.bt_xoa.Size = new System.Drawing.Size(75, 23);
            this.bt_xoa.TabIndex = 11;
            this.bt_xoa.Text = "Xóa";
            this.bt_xoa.UseVisualStyleBackColor = true;
            this.bt_xoa.Click += new System.EventHandler(this.bt_xoa_Click);
            // 
            // bt_sua
            // 
            this.bt_sua.Location = new System.Drawing.Point(624, 187);
            this.bt_sua.Name = "bt_sua";
            this.bt_sua.Size = new System.Drawing.Size(75, 23);
            this.bt_sua.TabIndex = 10;
            this.bt_sua.Text = "Sửa";
            this.bt_sua.UseVisualStyleBackColor = true;
            this.bt_sua.Click += new System.EventHandler(this.bt_sua_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(624, 130);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 23);
            this.bt_them.TabIndex = 9;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MaKhachHang";
            this.dataGridViewTextBoxColumn1.HeaderText = "MaKhachHang";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "TenKhachHang";
            this.dataGridViewTextBoxColumn2.HeaderText = "TenKhachHang";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "DiaChi";
            this.dataGridViewTextBoxColumn3.HeaderText = "DiaChi";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "DienThoai";
            this.dataGridViewTextBoxColumn4.HeaderText = "DienThoai";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // khachHangBindingSource
            // 
            this.khachHangBindingSource.DataSource = typeof(QuanLyThuoc.KhachHang);
            // 
            // CNTTkhachhangg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(848, 490);
            this.Controls.Add(this.bt_thoat);
            this.Controls.Add(this.bt_xoa);
            this.Controls.Add(this.bt_sua);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "CNTTkhachhangg";
            this.Text = "CNTTkhachhangg";
            this.Load += new System.EventHandler(this.CNTTkhachhangg_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.khachHangDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.khachHangBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox diaChiTextBox;
        private System.Windows.Forms.BindingSource khachHangBindingSource;
        private System.Windows.Forms.TextBox dienThoaiTextBox;
        private System.Windows.Forms.TextBox maKhachHangTextBox;
        private System.Windows.Forms.TextBox tenKhachHangTextBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView khachHangDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.Button bt_thoat;
        private System.Windows.Forms.Button bt_xoa;
        private System.Windows.Forms.Button bt_sua;
        private System.Windows.Forms.Button bt_them;
    }
}