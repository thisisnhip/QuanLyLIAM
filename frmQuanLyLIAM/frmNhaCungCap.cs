using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace frmQuanLyLIAM
{
    public partial class frmNhaCungCap : Form
    {
        private string connStr = "Data Source=DESKTOP-SKBLM54;Initial Catalog=QuanLyLIAM;Integrated Security=True;Trust Server Certificate=True";

        public frmNhaCungCap()
        {
            InitializeComponent();
            LoadDataNCC();
            btnThem.Click += btnThemNCC_Click;
            btnSua.Click += btnSuaNCC_Click;
            btnXoa.Click += btnXoaNCC_Click;
            dgvNhaCungCap.CellClick += dgvNhaCungCap_CellClick;
        }

        private void LoadDataNCC()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT * FROM NhaCungCap";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvNhaCungCap.DataSource = dt;
                ConfigDGV();
            }

        }
        private void ConfigDGV()
        {
            dgvNhaCungCap.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvNhaCungCap.ScrollBars = ScrollBars.Vertical;
            dgvNhaCungCap.AllowUserToAddRows = false;
            dgvNhaCungCap.ReadOnly = true;
            dgvNhaCungCap.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void btnThemNCC_Click(object sender, EventArgs e)
        {
            string tenNCC = txtTenNCC.Text.Trim();
            string sdt = txtSDTNCC.Text.Trim();
            string diaChi = txtDiaChiNCC.Text.Trim();

            if (string.IsNullOrEmpty(tenNCC) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ tên, số điện thoại và địa chỉ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(sdt, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải gồm đúng 10 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand("sp_ThemNCC", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@tenncc", tenNCC);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.Parameters.AddWithValue("@diachincc", diaChi);

                try
                {
                    cmd.ExecuteNonQuery();

                    SqlCommand getMa = new SqlCommand("SELECT TOP 1 MaNCC FROM NhaCungCap WHERE TenNCC = @ten AND SDT = @sdt ORDER BY MaNCC DESC", conn);
                    getMa.Parameters.AddWithValue("@ten", tenNCC);
                    getMa.Parameters.AddWithValue("@sdt", sdt);

                    object result = getMa.ExecuteScalar();
                    if (result != null)
                    {
                        txtMaNCC.Text = result.ToString();
                        MessageBox.Show("Thêm nhà cung cấp thành công! Mã: " + result.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    LoadDataNCC();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm NCC: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSuaNCC_Click(object sender, EventArgs e)
        {
            string maNCC = txtMaNCC.Text.Trim();
            string tenNCC = txtTenNCC.Text.Trim();
            string sdt = txtSDTNCC.Text.Trim();
            string diaChi = txtDiaChiNCC.Text.Trim();

            if (string.IsNullOrEmpty(maNCC) || string.IsNullOrEmpty(tenNCC) || string.IsNullOrEmpty(sdt) || string.IsNullOrEmpty(diaChi))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin để sửa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(sdt, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải gồm đúng 10 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                {
                    SqlCommand cmd = new SqlCommand("CapNhatTT_NCC", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@maNCC", maNCC);
                    cmd.Parameters.AddWithValue("@tenNCC", tenNCC);
                    cmd.Parameters.AddWithValue("@sdt", sdt);
                    cmd.Parameters.AddWithValue("@diaChi", diaChi);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật NCC thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataNCC();
                        ClearInputNCC();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy NCC để sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật NCC: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaNCC_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNCC.Text))
            {
                MessageBox.Show("Vui lòng chọn nhà cung cấp để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa nhà cung cấp này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        string sql = "DELETE FROM NhaCungCap WHERE MaNCC = @MaNCC";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaNCC", txtMaNCC.Text);
                            int rows = cmd.ExecuteNonQuery();

                            if (rows > 0)
                            {
                                MessageBox.Show("Xóa nhà cung cấp thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDataNCC();
                                ClearInputNCC();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy nhà cung cấp để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Không thể xóa nhà cung cấp vì có dữ liệu liên quan ở bảng khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xóa nhà cung cấp: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhaCungCap.Rows[e.RowIndex];
                txtMaNCC.Text = row.Cells["MaNCC"].Value.ToString();
                txtTenNCC.Text = row.Cells["TenNCC"].Value.ToString();
                txtSDTNCC.Text = row.Cells["SDT"].Value.ToString();
                txtDiaChiNCC.Text = row.Cells["DiaChiNCC"].Value.ToString();
            }
        }

        private void txtTimKiemNCC_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiemNCC.Text.Trim();

            if (string.IsNullOrEmpty(tuKhoa))
            {
                LoadDataNCC();
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = @"
                SELECT MaNCC, TenNCC, SDT, DiaChiNCC
                FROM NhaCungCap
                WHERE MaNCC LIKE @TuKhoa 
                   OR TenNCC COLLATE Latin1_General_CI_AI LIKE @TuKhoa
                   OR SDT LIKE @TuKhoa
                   OR DiaChiNCC COLLATE Latin1_General_CI_AI LIKE @TuKhoa";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    try
                    {
                        conn.Open();
                        adapter.Fill(dt);
                        dgvNhaCungCap.DataSource = dt;
                        ConfigDGV();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void ClearInputNCC()
        {
            txtMaNCC.Clear();
            txtTenNCC.Clear();
            txtSDTNCC.Clear();
            txtDiaChiNCC.Clear();
        }

      

        private void dgvNhaCungCap_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Nếu không dùng có thể xoá hoặc để trống.
        }
    }
}
