namespace _3.PL.Views
{
    partial class FrmQuanLySanPham
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
            this.btn_TaoHoaDon = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_Mahd = new System.Windows.Forms.TextBox();
            this.tb_ngaytao = new System.Windows.Forms.TextBox();
            this.tb_tennhanvien = new System.Windows.Forms.TextBox();
            this.tb_tienthua = new System.Windows.Forms.TextBox();
            this.tb_tienkhachdua = new System.Windows.Forms.TextBox();
            this.tb_tongtien = new System.Windows.Forms.TextBox();
            this.btn_thanhToan = new System.Windows.Forms.Button();
            this.dtg_Sanpham = new System.Windows.Forms.DataGridView();
            this.dtg_Giohang = new System.Windows.Forms.DataGridView();
            this.dtg_taohoadon = new System.Windows.Forms.DataGridView();
            this.tb_timkiem = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Sanpham)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Giohang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_taohoadon)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_TaoHoaDon
            // 
            this.btn_TaoHoaDon.Location = new System.Drawing.Point(76, 12);
            this.btn_TaoHoaDon.Name = "btn_TaoHoaDon";
            this.btn_TaoHoaDon.Size = new System.Drawing.Size(214, 43);
            this.btn_TaoHoaDon.TabIndex = 0;
            this.btn_TaoHoaDon.Text = "Tạo hóa đơn";
            this.btn_TaoHoaDon.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dtg_Giohang);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Location = new System.Drawing.Point(76, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 219);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Giỏ hàng ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tb_timkiem);
            this.groupBox2.Controls.Add(this.dtg_Sanpham);
            this.groupBox2.Location = new System.Drawing.Point(76, 492);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(785, 260);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sản phẩm ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_thanhToan);
            this.groupBox3.Controls.Add(this.tb_tienthua);
            this.groupBox3.Controls.Add(this.tb_tienkhachdua);
            this.groupBox3.Controls.Add(this.tb_tongtien);
            this.groupBox3.Controls.Add(this.tb_tennhanvien);
            this.groupBox3.Controls.Add(this.tb_ngaytao);
            this.groupBox3.Controls.Add(this.tb_Mahd);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(923, 265);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(472, 487);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Hóa đơn";
            // 
            // groupBox4
            // 
            this.groupBox4.Location = new System.Drawing.Point(392, -182);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(927, 167);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox4";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(113, 73);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(135, 24);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Chờ thanh toán ";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(113, 115);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(74, 24);
            this.radioButton2.TabIndex = 6;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Tất cả ";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(113, 156);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(80, 24);
            this.radioButton3.TabIndex = 7;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Đã hủy ";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(113, 198);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(128, 24);
            this.radioButton4.TabIndex = 8;
            this.radioButton4.TabStop = true;
            this.radioButton4.Text = "Đã thanh toán ";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã HD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày tạo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên Nhân viên ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 215);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tổng tiền ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Tiền khách đưa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(34, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Tiền Thừa";
            // 
            // tb_Mahd
            // 
            this.tb_Mahd.Location = new System.Drawing.Point(152, 47);
            this.tb_Mahd.Name = "tb_Mahd";
            this.tb_Mahd.Size = new System.Drawing.Size(314, 27);
            this.tb_Mahd.TabIndex = 6;
            // 
            // tb_ngaytao
            // 
            this.tb_ngaytao.Location = new System.Drawing.Point(152, 101);
            this.tb_ngaytao.Name = "tb_ngaytao";
            this.tb_ngaytao.Size = new System.Drawing.Size(314, 27);
            this.tb_ngaytao.TabIndex = 7;
            // 
            // tb_tennhanvien
            // 
            this.tb_tennhanvien.Location = new System.Drawing.Point(152, 157);
            this.tb_tennhanvien.Name = "tb_tennhanvien";
            this.tb_tennhanvien.Size = new System.Drawing.Size(314, 27);
            this.tb_tennhanvien.TabIndex = 8;
            // 
            // tb_tienthua
            // 
            this.tb_tienthua.Location = new System.Drawing.Point(152, 323);
            this.tb_tienthua.Name = "tb_tienthua";
            this.tb_tienthua.Size = new System.Drawing.Size(314, 27);
            this.tb_tienthua.TabIndex = 11;
            // 
            // tb_tienkhachdua
            // 
            this.tb_tienkhachdua.Location = new System.Drawing.Point(152, 267);
            this.tb_tienkhachdua.Name = "tb_tienkhachdua";
            this.tb_tienkhachdua.Size = new System.Drawing.Size(314, 27);
            this.tb_tienkhachdua.TabIndex = 10;
            // 
            // tb_tongtien
            // 
            this.tb_tongtien.Location = new System.Drawing.Point(152, 213);
            this.tb_tongtien.Name = "tb_tongtien";
            this.tb_tongtien.Size = new System.Drawing.Size(314, 27);
            this.tb_tongtien.TabIndex = 9;
            // 
            // btn_thanhToan
            // 
            this.btn_thanhToan.Location = new System.Drawing.Point(206, 393);
            this.btn_thanhToan.Name = "btn_thanhToan";
            this.btn_thanhToan.Size = new System.Drawing.Size(126, 52);
            this.btn_thanhToan.TabIndex = 12;
            this.btn_thanhToan.Text = "Thanh Toán";
            this.btn_thanhToan.UseVisualStyleBackColor = true;
            // 
            // dtg_Sanpham
            // 
            this.dtg_Sanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Sanpham.Location = new System.Drawing.Point(6, 81);
            this.dtg_Sanpham.Name = "dtg_Sanpham";
            this.dtg_Sanpham.RowHeadersWidth = 51;
            this.dtg_Sanpham.RowTemplate.Height = 29;
            this.dtg_Sanpham.Size = new System.Drawing.Size(773, 179);
            this.dtg_Sanpham.TabIndex = 0;
            // 
            // dtg_Giohang
            // 
            this.dtg_Giohang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_Giohang.Location = new System.Drawing.Point(6, 40);
            this.dtg_Giohang.Name = "dtg_Giohang";
            this.dtg_Giohang.RowHeadersWidth = 51;
            this.dtg_Giohang.RowTemplate.Height = 29;
            this.dtg_Giohang.Size = new System.Drawing.Size(773, 179);
            this.dtg_Giohang.TabIndex = 1;
            // 
            // dtg_taohoadon
            // 
            this.dtg_taohoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_taohoadon.Location = new System.Drawing.Point(388, 42);
            this.dtg_taohoadon.Name = "dtg_taohoadon";
            this.dtg_taohoadon.RowHeadersWidth = 51;
            this.dtg_taohoadon.RowTemplate.Height = 29;
            this.dtg_taohoadon.Size = new System.Drawing.Size(975, 200);
            this.dtg_taohoadon.TabIndex = 3;
            // 
            // tb_timkiem
            // 
            this.tb_timkiem.Location = new System.Drawing.Point(15, 36);
            this.tb_timkiem.Name = "tb_timkiem";
            this.tb_timkiem.Size = new System.Drawing.Size(314, 27);
            this.tb_timkiem.TabIndex = 13;
            // 
            // FrmQuanLySanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1430, 764);
            this.Controls.Add(this.dtg_taohoadon);
            this.Controls.Add(this.radioButton4);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_TaoHoaDon);
            this.Name = "FrmQuanLySanPham";
            this.Text = "FrmQuanLySanPham";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Sanpham)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_Giohang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_taohoadon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_TaoHoaDon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dtg_Giohang;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tb_timkiem;
        private System.Windows.Forms.DataGridView dtg_Sanpham;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btn_thanhToan;
        private System.Windows.Forms.TextBox tb_tienthua;
        private System.Windows.Forms.TextBox tb_tienkhachdua;
        private System.Windows.Forms.TextBox tb_tongtien;
        private System.Windows.Forms.TextBox tb_tennhanvien;
        private System.Windows.Forms.TextBox tb_ngaytao;
        private System.Windows.Forms.TextBox tb_Mahd;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.DataGridView dtg_taohoadon;
    }
}