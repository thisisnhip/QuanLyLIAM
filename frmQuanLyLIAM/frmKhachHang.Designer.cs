namespace frmQuanLyLIAM
{
    partial class frmKhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKhachHang));
            dgvKhachHang = new DataGridView();
            txtMaKH = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtTenKH = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtDiaChiKH = new TextBox();
            txtSDTKH = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            txtTimKiem = new TextBox();
            pictureBox1 = new PictureBox();
            pnMenuKH = new Panel();
            btnUsers = new Button();
            lbMenu = new Label();
            pictureBox2 = new PictureBox();
            btnQuanLyNSvaNCC = new Button();
            btnBaoCao = new Button();
            btnQuanLiSP = new Button();
            btnNhapHang = new Button();
            btnTaoDonHang = new Button();
            btnQuanLiNo = new Button();
            btnTrangChu = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnMenuKH.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(389, 430);
            dgvKhachHang.Margin = new Padding(4, 5, 4, 5);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 62;
            dgvKhachHang.Size = new Size(1420, 502);
            dgvKhachHang.TabIndex = 8;
            dgvKhachHang.CellContentClick += dgvKhachHang_CellContentClick;
            // 
            // txtMaKH
            // 
            txtMaKH.Location = new Point(816, 174);
            txtMaKH.Margin = new Padding(4, 5, 4, 5);
            txtMaKH.Name = "txtMaKH";
            txtMaKH.Size = new Size(164, 31);
            txtMaKH.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.Location = new Point(647, 246);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(146, 28);
            label1.TabIndex = 4;
            label1.Text = "Tên khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.Location = new Point(647, 179);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(145, 28);
            label2.TabIndex = 5;
            label2.Text = "Mã khách hàng";
            // 
            // txtTenKH
            // 
            txtTenKH.Location = new Point(816, 246);
            txtTenKH.Margin = new Padding(4, 5, 4, 5);
            txtTenKH.Name = "txtTenKH";
            txtTenKH.Size = new Size(164, 31);
            txtTenKH.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(1067, 179);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 28);
            label3.TabIndex = 7;
            label3.Text = "Địa chỉ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(1067, 251);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(128, 28);
            label4.TabIndex = 8;
            label4.Text = "Số điện thoại";
            // 
            // txtDiaChiKH
            // 
            txtDiaChiKH.Location = new Point(1216, 174);
            txtDiaChiKH.Margin = new Padding(4, 5, 4, 5);
            txtDiaChiKH.Name = "txtDiaChiKH";
            txtDiaChiKH.Size = new Size(164, 31);
            txtDiaChiKH.TabIndex = 3;
            // 
            // txtSDTKH
            // 
            txtSDTKH.Location = new Point(1216, 246);
            txtSDTKH.Margin = new Padding(4, 5, 4, 5);
            txtSDTKH.Name = "txtSDTKH";
            txtSDTKH.Size = new Size(164, 31);
            txtSDTKH.TabIndex = 4;
            // 
            // btnThem
            // 
            btnThem.Font = new Font("Segoe UI", 10F);
            btnThem.Location = new Point(782, 343);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(107, 38);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // btnSua
            // 
            btnSua.Font = new Font("Segoe UI", 10F);
            btnSua.Location = new Point(980, 343);
            btnSua.Margin = new Padding(4, 5, 4, 5);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(107, 38);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.Font = new Font("Segoe UI", 10F);
            btnXoa.Location = new Point(1183, 343);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(107, 38);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // txtTimKiem
            // 
            txtTimKiem.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiem.Location = new Point(816, 103);
            txtTimKiem.Margin = new Padding(4, 5, 4, 5);
            txtTimKiem.Name = "txtTimKiem";
            txtTimKiem.Size = new Size(564, 34);
            txtTimKiem.TabIndex = 9;
            txtTimKiem.TextChanged += txtTimKiem_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(754, 91);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 10;
            pictureBox1.TabStop = false;
            // 
            // pnMenuKH
            // 
            pnMenuKH.BackColor = SystemColors.ButtonFace;
            pnMenuKH.Controls.Add(btnUsers);
            pnMenuKH.Controls.Add(lbMenu);
            pnMenuKH.Controls.Add(pictureBox2);
            pnMenuKH.Controls.Add(btnQuanLyNSvaNCC);
            pnMenuKH.Controls.Add(btnBaoCao);
            pnMenuKH.Controls.Add(btnQuanLiSP);
            pnMenuKH.Controls.Add(btnNhapHang);
            pnMenuKH.Controls.Add(btnTaoDonHang);
            pnMenuKH.Controls.Add(btnQuanLiNo);
            pnMenuKH.Controls.Add(btnTrangChu);
            pnMenuKH.Dock = DockStyle.Left;
            pnMenuKH.Location = new Point(0, 0);
            pnMenuKH.Name = "pnMenuKH";
            pnMenuKH.Size = new Size(300, 1024);
            pnMenuKH.TabIndex = 11;
            // 
            // btnUsers
            // 
            btnUsers.Font = new Font("Segoe UI", 10F);
            btnUsers.Location = new Point(58, 883);
            btnUsers.Name = "btnUsers";
            btnUsers.Size = new Size(180, 50);
            btnUsers.TabIndex = 19;
            btnUsers.Text = "Quản lý Users";
            btnUsers.UseVisualStyleBackColor = true;
            // 
            // lbMenu
            // 
            lbMenu.AutoSize = true;
            lbMenu.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lbMenu.Location = new Point(123, 47);
            lbMenu.Margin = new Padding(4, 0, 4, 0);
            lbMenu.Name = "lbMenu";
            lbMenu.Size = new Size(127, 48);
            lbMenu.TabIndex = 12;
            lbMenu.Text = "MENU";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(43, 39);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(63, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 12;
            pictureBox2.TabStop = false;
            // 
            // btnQuanLyNSvaNCC
            // 
            btnQuanLyNSvaNCC.Font = new Font("Segoe UI", 10F);
            btnQuanLyNSvaNCC.Location = new Point(58, 743);
            btnQuanLyNSvaNCC.Name = "btnQuanLyNSvaNCC";
            btnQuanLyNSvaNCC.Size = new Size(180, 91);
            btnQuanLyNSvaNCC.TabIndex = 18;
            btnQuanLyNSvaNCC.Text = "Nhân Sự \r\nNhà Cung Cấp";
            btnQuanLyNSvaNCC.UseVisualStyleBackColor = true;
            // 
            // btnBaoCao
            // 
            btnBaoCao.Font = new Font("Segoe UI", 10F);
            btnBaoCao.Location = new Point(58, 644);
            btnBaoCao.Name = "btnBaoCao";
            btnBaoCao.Size = new Size(180, 50);
            btnBaoCao.TabIndex = 17;
            btnBaoCao.Text = "Báo Cáo";
            btnBaoCao.UseVisualStyleBackColor = true;
            // 
            // btnQuanLiSP
            // 
            btnQuanLiSP.Font = new Font("Segoe UI", 10F);
            btnQuanLiSP.Location = new Point(58, 539);
            btnQuanLiSP.Name = "btnQuanLiSP";
            btnQuanLiSP.Size = new Size(180, 50);
            btnQuanLiSP.TabIndex = 16;
            btnQuanLiSP.Text = "Sản Phẩm";
            btnQuanLiSP.UseVisualStyleBackColor = true;
            btnQuanLiSP.Click += btnQuanLiSP_Click;
            // 
            // btnNhapHang
            // 
            btnNhapHang.Font = new Font("Segoe UI", 10F);
            btnNhapHang.Location = new Point(58, 446);
            btnNhapHang.Name = "btnNhapHang";
            btnNhapHang.Size = new Size(180, 50);
            btnNhapHang.TabIndex = 15;
            btnNhapHang.Text = "Nhập Hàng";
            btnNhapHang.UseVisualStyleBackColor = true;
            // 
            // btnTaoDonHang
            // 
            btnTaoDonHang.Font = new Font("Segoe UI", 10F);
            btnTaoDonHang.Location = new Point(58, 351);
            btnTaoDonHang.Name = "btnTaoDonHang";
            btnTaoDonHang.Size = new Size(180, 50);
            btnTaoDonHang.TabIndex = 14;
            btnTaoDonHang.Text = "Tạo Đơn Hàng";
            btnTaoDonHang.UseVisualStyleBackColor = true;
            // 
            // btnQuanLiNo
            // 
            btnQuanLiNo.Font = new Font("Segoe UI", 10F);
            btnQuanLiNo.Location = new Point(58, 250);
            btnQuanLiNo.Name = "btnQuanLiNo";
            btnQuanLiNo.Size = new Size(180, 50);
            btnQuanLiNo.TabIndex = 13;
            btnQuanLiNo.Text = "Quản Lí Nợ";
            btnQuanLiNo.UseVisualStyleBackColor = true;
            // 
            // btnTrangChu
            // 
            btnTrangChu.Font = new Font("Segoe UI", 10F);
            btnTrangChu.Location = new Point(58, 155);
            btnTrangChu.Name = "btnTrangChu";
            btnTrangChu.Size = new Size(180, 50);
            btnTrangChu.TabIndex = 12;
            btnTrangChu.Text = "Trang Chủ";
            btnTrangChu.UseVisualStyleBackColor = true;
            // 
            // frmKhachHang
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1898, 1024);
            Controls.Add(pnMenuKH);
            Controls.Add(pictureBox1);
            Controls.Add(txtTimKiem);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtSDTKH);
            Controls.Add(txtDiaChiKH);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtTenKH);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtMaKH);
            Controls.Add(dgvKhachHang);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmKhachHang";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Khách hàng";
            Load += frmKhachHang_Load;
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnMenuKH.ResumeLayout(false);
            pnMenuKH.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvKhachHang;
        private TextBox txtMaKH;
        private Label label1;
        private Label label2;
        private TextBox txtTenKH;
        private Label label3;
        private Label label4;
        private TextBox txtDiaChiKH;
        private TextBox txtSDTKH;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private TextBox txtTimKiem;
        private PictureBox pictureBox1;
        private Panel pnMenuKH;
        private Button btnTrangChu;
        private Button btnNhapHang;
        private Button btnTaoDonHang;
        private Button btnQuanLiNo;
        private Button btnQuanLyNSvaNCC;
        private Button btnBaoCao;
        private Button btnQuanLiSP;
        private PictureBox pictureBox2;
        private Label lbMenu;
        private Button btnUsers;
    }
}
