namespace frmQuanLyLIAM
{
    partial class frmDangNhap
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDangNhap));
            panel1 = new Panel();
            txtMK = new TextBox();
            txtTenDN = new TextBox();
            MatKhau = new Label();
            TenDN = new Label();
            btnDN = new Button();
            btnThoat = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtMK);
            panel1.Controls.Add(txtTenDN);
            panel1.Controls.Add(MatKhau);
            panel1.Controls.Add(TenDN);
            panel1.Location = new Point(48, 35);
            panel1.Name = "panel1";
            panel1.Size = new Size(637, 145);
            panel1.TabIndex = 0;
            // 
            // txtMK
            // 
            txtMK.Location = new Point(162, 86);
            txtMK.Name = "txtMK";
            txtMK.Size = new Size(415, 27);
            txtMK.TabIndex = 2;
            txtMK.UseSystemPasswordChar = true;
            // 
            // txtTenDN
            // 
            txtTenDN.Location = new Point(162, 38);
            txtTenDN.Name = "txtTenDN";
            txtTenDN.Size = new Size(415, 27);
            txtTenDN.TabIndex = 1;
            txtTenDN.TextChanged += frmDangNhap_Load;
            // 
            // MatKhau
            // 
            MatKhau.AutoSize = true;
            MatKhau.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MatKhau.Location = new Point(23, 86);
            MatKhau.Name = "MatKhau";
            MatKhau.Size = new Size(91, 23);
            MatKhau.TabIndex = 1;
            MatKhau.Text = "Mật khẩu:";
            MatKhau.Click += label1_Click_1;
            // 
            // TenDN
            // 
            TenDN.AutoSize = true;
            TenDN.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TenDN.Location = new Point(23, 39);
            TenDN.Name = "TenDN";
            TenDN.Size = new Size(133, 23);
            TenDN.TabIndex = 0;
            TenDN.Text = "Tên đăng nhập:";
            TenDN.Click += label1_Click;
            // 
            // btnDN
            // 
            btnDN.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDN.Location = new Point(392, 186);
            btnDN.Name = "btnDN";
            btnDN.Size = new Size(123, 29);
            btnDN.TabIndex = 3;
            btnDN.Text = "Đăng nhập";
            btnDN.UseVisualStyleBackColor = true;
            btnDN.Click += btnDN_click;
            // 
            // btnThoat
            // 
            btnThoat.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(531, 186);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(94, 29);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // frmDangNhap
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(765, 266);
            Controls.Add(btnThoat);
            Controls.Add(btnDN);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmDangNhap";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += frmDangNhap_FormClosing;
            Load += frmDangNhap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label TenDN;
        private Label MatKhau;
        private TextBox txtMK;
        private TextBox txtTenDN;
        private Button btnThoat;
        private Button btnDN;
      
    }
}