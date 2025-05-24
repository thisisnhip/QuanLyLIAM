namespace frmQuanLyLIAM
{
    partial class FrmBaoCao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBaoCao));
            pictureBox1 = new PictureBox();
            btnInBaoCao = new Button();
            btXemBaoCao = new Button();
            label4 = new Label();
            lbLoaiThongKe = new Label();
            lbDieuKienThongKe = new Label();
            lbTuNgay = new Label();
            dgvKhachHang = new DataGridView();
            cbLoaiThongKe = new ComboBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            dtTuNgay = new DateTimePicker();
            dtDenNgay = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(790, 74);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(37, 47);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            // 
            // btnInBaoCao
            // 
            btnInBaoCao.Font = new Font("Segoe UI", 10F);
            btnInBaoCao.Location = new Point(928, 301);
            btnInBaoCao.Margin = new Padding(4, 5, 4, 5);
            btnInBaoCao.Name = "btnInBaoCao";
            btnInBaoCao.Size = new Size(151, 38);
            btnInBaoCao.TabIndex = 19;
            btnInBaoCao.Text = "In báo cáo";
            btnInBaoCao.UseVisualStyleBackColor = true;
            // 
            // btXemBaoCao
            // 
            btXemBaoCao.Font = new Font("Segoe UI", 10F);
            btXemBaoCao.Location = new Point(693, 301);
            btXemBaoCao.Margin = new Padding(4, 5, 4, 5);
            btXemBaoCao.Name = "btXemBaoCao";
            btXemBaoCao.Size = new Size(154, 38);
            btXemBaoCao.TabIndex = 17;
            btXemBaoCao.Text = "Xem báo cáo";
            btXemBaoCao.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(15, 115);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 22;
            label4.Text = "Đến ngày";
            label4.Click += label4_Click;
            // 
            // lbLoaiThongKe
            // 
            lbLoaiThongKe.AutoSize = true;
            lbLoaiThongKe.BackColor = Color.Transparent;
            lbLoaiThongKe.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbLoaiThongKe.Location = new Point(15, 11);
            lbLoaiThongKe.Margin = new Padding(4, 0, 4, 0);
            lbLoaiThongKe.Name = "lbLoaiThongKe";
            lbLoaiThongKe.Size = new Size(178, 28);
            lbLoaiThongKe.TabIndex = 21;
            lbLoaiThongKe.Text = "Chọn loại thống kê";
            // 
            // lbDieuKienThongKe
            // 
            lbDieuKienThongKe.AutoSize = true;
            lbDieuKienThongKe.Font = new Font("Segoe UI", 10F);
            lbDieuKienThongKe.Location = new Point(845, 83);
            lbDieuKienThongKe.Margin = new Padding(4, 0, 4, 0);
            lbDieuKienThongKe.Name = "lbDieuKienThongKe";
            lbDieuKienThongKe.Size = new Size(176, 28);
            lbDieuKienThongKe.TabIndex = 18;
            lbDieuKienThongKe.Text = "Điều kiện thống kê";
            lbDieuKienThongKe.Click += label2_Click;
            // 
            // lbTuNgay
            // 
            lbTuNgay.AutoSize = true;
            lbTuNgay.Font = new Font("Segoe UI", 10F);
            lbTuNgay.Location = new Point(15, 63);
            lbTuNgay.Margin = new Padding(4, 0, 4, 0);
            lbTuNgay.Name = "lbTuNgay";
            lbTuNgay.Size = new Size(82, 28);
            lbTuNgay.TabIndex = 16;
            lbTuNgay.Text = "Từ ngày";
            // 
            // dgvKhachHang
            // 
            dgvKhachHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhachHang.Location = new Point(434, 430);
            dgvKhachHang.Margin = new Padding(4, 5, 4, 5);
            dgvKhachHang.Name = "dgvKhachHang";
            dgvKhachHang.RowHeadersWidth = 62;
            dgvKhachHang.Size = new Size(1420, 502);
            dgvKhachHang.TabIndex = 23;
            // 
            // cbLoaiThongKe
            // 
            cbLoaiThongKe.FormattingEnabled = true;
            cbLoaiThongKe.Items.AddRange(new object[] { "Ngày", "Tuần", "Quý", "Năm", "Nhân Viêniên", "Sản Phẩm", "Lợi Nhuận" });
            cbLoaiThongKe.Location = new Point(292, 14);
            cbLoaiThongKe.Name = "cbLoaiThongKe";
            cbLoaiThongKe.Size = new Size(182, 33);
            cbLoaiThongKe.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(cbLoaiThongKe, 1, 0);
            tableLayoutPanel1.Controls.Add(lbLoaiThongKe, 0, 0);
            tableLayoutPanel1.Controls.Add(lbTuNgay, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(dtTuNgay, 1, 1);
            tableLayoutPanel1.Controls.Add(dtDenNgay, 1, 2);
            tableLayoutPanel1.Location = new Point(568, 129);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(10);
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            tableLayoutPanel1.Size = new Size(578, 177);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // dtTuNgay
            // 
            dtTuNgay.Format = DateTimePickerFormat.Short;
            dtTuNgay.Location = new Point(292, 66);
            dtTuNgay.Name = "dtTuNgay";
            dtTuNgay.Size = new Size(197, 31);
            dtTuNgay.TabIndex = 23;
            // 
            // dtDenNgay
            // 
            dtDenNgay.Format = DateTimePickerFormat.Short;
            dtDenNgay.Location = new Point(292, 118);
            dtDenNgay.Name = "dtDenNgay";
            dtDenNgay.Size = new Size(197, 31);
            dtDenNgay.TabIndex = 24;
            // 
            // FrmBaoCao
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1898, 1024);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(pictureBox1);
            Controls.Add(btnInBaoCao);
            Controls.Add(btXemBaoCao);
            Controls.Add(lbDieuKienThongKe);
            Controls.Add(dgvKhachHang);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "FrmBaoCao";
            Text = "Báo cáo doanh thu";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvKhachHang).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox1;
        private Button btnInBaoCao;
        private Button btXemBaoCao;
        private Label label4;
        private Label lbLoaiThongKe;
        private Label lbDieuKienThongKe;
        private Label lbTuNgay;
        private DataGridView dgvKhachHang;
        private ComboBox cbLoaiThongKe;
        private TableLayoutPanel tableLayoutPanel1;
        private DateTimePicker dtTuNgay;
        private DateTimePicker dtDenNgay;
    }
}