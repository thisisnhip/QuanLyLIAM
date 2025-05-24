namespace frmQuanLyLIAM
{
    partial class frmNhaCungCap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhaCungCap));
            dgvNhaCungCap = new DataGridView();
            btnSua = new Button();
            btnThem = new Button();
            txtTenNCC = new TextBox();
            txtMaNCC = new TextBox();
            txtDiaChiNCC = new TextBox();
            lbTenNCC = new Label();
            lbDiaChiNCC = new Label();
            lbMaNCC = new Label();
            txtSDTNCC = new TextBox();
            lbSDTNCC = new Label();
            btnXoa = new Button();
            txtTimKiemNCC = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvNhaCungCap
            // 
            dgvNhaCungCap.AllowUserToAddRows = false;
            dgvNhaCungCap.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhaCungCap.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNhaCungCap.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhaCungCap.Location = new Point(162, 437);
            dgvNhaCungCap.Name = "dgvNhaCungCap";
            dgvNhaCungCap.RowHeadersWidth = 62;
            dgvNhaCungCap.Size = new Size(1562, 1024);
            dgvNhaCungCap.TabIndex = 10;
            dgvNhaCungCap.CellContentClick += dgvNhaCungCap_CellContentClick;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(910, 322);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 6;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(565, 322);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 5;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            // 
            // txtTenNCC
            // 
            txtTenNCC.Location = new Point(694, 234);
            txtTenNCC.Margin = new Padding(4, 5, 4, 5);
            txtTenNCC.Name = "txtTenNCC";
            txtTenNCC.Size = new Size(358, 31);
            txtTenNCC.TabIndex = 2;
            // 
            // txtMaNCC
            // 
            txtMaNCC.Location = new Point(694, 137);
            txtMaNCC.Margin = new Padding(4, 5, 4, 5);
            txtMaNCC.Name = "txtMaNCC";
            txtMaNCC.Size = new Size(261, 31);
            txtMaNCC.TabIndex = 1;
            // 
            // txtDiaChiNCC
            // 
            txtDiaChiNCC.Location = new Point(1236, 137);
            txtDiaChiNCC.Margin = new Padding(4, 5, 4, 5);
            txtDiaChiNCC.Name = "txtDiaChiNCC";
            txtDiaChiNCC.Size = new Size(400, 31);
            txtDiaChiNCC.TabIndex = 3;
            // 
            // lbTenNCC
            // 
            lbTenNCC.AutoSize = true;
            lbTenNCC.Location = new Point(463, 237);
            lbTenNCC.Name = "lbTenNCC";
            lbTenNCC.Size = new Size(158, 25);
            lbTenNCC.TabIndex = 17;
            lbTenNCC.Text = "Tên Nhà Cung Cấp";
            // 
            // lbDiaChiNCC
            // 
            lbDiaChiNCC.AutoSize = true;
            lbDiaChiNCC.Location = new Point(1118, 143);
            lbDiaChiNCC.Name = "lbDiaChiNCC";
            lbDiaChiNCC.Size = new Size(70, 25);
            lbDiaChiNCC.TabIndex = 18;
            lbDiaChiNCC.Text = "Địa chỉ ";
            // 
            // lbMaNCC
            // 
            lbMaNCC.AutoSize = true;
            lbMaNCC.Location = new Point(463, 143);
            lbMaNCC.Name = "lbMaNCC";
            lbMaNCC.Size = new Size(157, 25);
            lbMaNCC.TabIndex = 19;
            lbMaNCC.Text = "Mã Nhà Cung Cấp";
            // 
            // txtSDTNCC
            // 
            txtSDTNCC.Location = new Point(1236, 231);
            txtSDTNCC.Margin = new Padding(4, 5, 4, 5);
            txtSDTNCC.Name = "txtSDTNCC";
            txtSDTNCC.Size = new Size(292, 31);
            txtSDTNCC.TabIndex = 4;
            // 
            // lbSDTNCC
            // 
            lbSDTNCC.AutoSize = true;
            lbSDTNCC.Location = new Point(1101, 237);
            lbSDTNCC.Name = "lbSDTNCC";
            lbSDTNCC.Size = new Size(117, 25);
            lbSDTNCC.TabIndex = 21;
            lbSDTNCC.Text = "Số điện thoại";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(1324, 322);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 7;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            // 
            // txtTimKiemNCC
            // 
            txtTimKiemNCC.Location = new Point(649, 66);
            txtTimKiemNCC.Name = "txtTimKiemNCC";
            txtTimKiemNCC.Size = new Size(751, 31);
            txtTimKiemNCC.TabIndex = 0;
            txtTimKiemNCC.TextChanged += txtTimKiemNCC_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(551, 51);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 22;
            pictureBox1.TabStop = false;
            // 
            // frmNhaCungCap
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1898, 1024);
            Controls.Add(pictureBox1);
            Controls.Add(txtTimKiemNCC);
            Controls.Add(btnXoa);
            Controls.Add(lbSDTNCC);
            Controls.Add(txtSDTNCC);
            Controls.Add(dgvNhaCungCap);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtTenNCC);
            Controls.Add(txtMaNCC);
            Controls.Add(txtDiaChiNCC);
            Controls.Add(lbTenNCC);
            Controls.Add(lbDiaChiNCC);
            Controls.Add(lbMaNCC);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmNhaCungCap";
            Text = "NhaCungCap";
            ((System.ComponentModel.ISupportInitialize)dgvNhaCungCap).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvNhaCungCap;
        private Button btnSua;
        private Button btnThem;
        private TextBox txtTenNCC;
        private TextBox txtMaNCC;
        private TextBox txtDiaChiNCC;
        private Label lbTenNCC;
        private Label lbDiaChiNCC;
        private Label lbMaNCC;
        private TextBox txtSDTNCC;
        private Label lbSDTNCC;
        private Button btnXoa;
        private TextBox txtTimKiemNCC;
        private PictureBox pictureBox1;
    }
}