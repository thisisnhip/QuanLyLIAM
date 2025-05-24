namespace frmQuanLyLIAM
{
    partial class frmNhanSu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhanSu));
            lbMaNV = new Label();
            lbSoDTNV = new Label();
            lbTenNV = new Label();
            txtSoDTNV = new TextBox();
            txtMaNV = new TextBox();
            txtTenNV = new TextBox();
            btnThem = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            dgvNhanSu = new DataGridView();
            txtTimKiemNV = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvNhanSu).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lbMaNV
            // 
            lbMaNV.AutoSize = true;
            lbMaNV.Location = new Point(355, 160);
            lbMaNV.Name = "lbMaNV";
            lbMaNV.Size = new Size(118, 25);
            lbMaNV.TabIndex = 9;
            lbMaNV.Text = "Mã nhân viên";
            // 
            // lbSoDTNV
            // 
            lbSoDTNV.AutoSize = true;
            lbSoDTNV.Location = new Point(798, 163);
            lbSoDTNV.Name = "lbSoDTNV";
            lbSoDTNV.Size = new Size(117, 25);
            lbSoDTNV.TabIndex = 8;
            lbSoDTNV.Text = "Số điện thoại";
            // 
            // lbTenNV
            // 
            lbTenNV.AutoSize = true;
            lbTenNV.Location = new Point(355, 244);
            lbTenNV.Name = "lbTenNV";
            lbTenNV.Size = new Size(119, 25);
            lbTenNV.TabIndex = 7;
            lbTenNV.Text = "Tên nhân viên";
            // 
            // txtSoDTNV
            // 
            txtSoDTNV.Location = new Point(937, 163);
            txtSoDTNV.Margin = new Padding(4, 5, 4, 5);
            txtSoDTNV.Name = "txtSoDTNV";
            txtSoDTNV.Size = new Size(164, 31);
            txtSoDTNV.TabIndex = 3;
            // 
            // txtMaNV
            // 
            txtMaNV.Location = new Point(511, 157);
            txtMaNV.Margin = new Padding(4, 5, 4, 5);
            txtMaNV.Name = "txtMaNV";
            txtMaNV.Size = new Size(164, 31);
            txtMaNV.TabIndex = 1;
            // 
            // txtTenNV
            // 
            txtTenNV.Location = new Point(511, 244);
            txtTenNV.Margin = new Padding(4, 5, 4, 5);
            txtTenNV.Name = "txtTenNV";
            txtTenNV.Size = new Size(164, 31);
            txtTenNV.TabIndex = 2;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(390, 361);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(112, 34);
            btnThem.TabIndex = 4;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThemNS_Click;
            // 
            // btnSua
            // 
            btnSua.Location = new Point(690, 355);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(112, 34);
            btnSua.TabIndex = 5;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = true;
            btnSua.Click += btnSuaNS_Click;
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(989, 360);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(112, 34);
            btnXoa.TabIndex = 6;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoaNS_Click;
            // 
            // dgvNhanSu
            // 
            dgvNhanSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhanSu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvNhanSu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvNhanSu.Location = new Point(211, 486);
            dgvNhanSu.Name = "dgvNhanSu";
            dgvNhanSu.RowHeadersWidth = 62;
            dgvNhanSu.Size = new Size(1111, 480);
            dgvNhanSu.TabIndex = 7;
            dgvNhanSu.CellClick += dgvNhanSu_CellClick;
            // 
            // txtTimKiemNV
            // 
            txtTimKiemNV.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTimKiemNV.Location = new Point(569, 73);
            txtTimKiemNV.Margin = new Padding(4, 5, 4, 5);
            txtTimKiemNV.Name = "txtTimKiemNV";
            txtTimKiemNV.Size = new Size(564, 34);
            txtTimKiemNV.TabIndex = 0;
            txtTimKiemNV.TextChanged += txtTimKiemNV_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(478, 54);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(57, 63);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // frmNhanSu
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(1898, 1024);
            Controls.Add(pictureBox1);
            Controls.Add(txtTimKiemNV);
            Controls.Add(dgvNhanSu);
            Controls.Add(btnXoa);
            Controls.Add(btnSua);
            Controls.Add(btnThem);
            Controls.Add(txtTenNV);
            Controls.Add(txtMaNV);
            Controls.Add(txtSoDTNV);
            Controls.Add(lbTenNV);
            Controls.Add(lbSoDTNV);
            Controls.Add(lbMaNV);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmNhanSu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmNhanSu";
            ((System.ComponentModel.ISupportInitialize)dgvNhanSu).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label lbMaNV;
        private Label label2;
        private Label lbSoDTNV;
        private Label lbTenNV;
        private TextBox txtSoDTNV;
        private TextBox txtMaNV;
        private TextBox txtTenNV;
        private Button btnThem;
        private Button btnSua;
        private Button btnXoa;
        private DataGridView dgvNhanSu;
        private TextBox txtTimKiemNV;
        private PictureBox pictureBox1;
    }
}