using System;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace frmQuanLyLIAM
{
    public partial class frmNhanSu : Form
    {
        private string connStr = "Data Source=DESKTOP-SKBLM54;Initial Catalog=QuanLyLIAM;Integrated Security=True;Trust Server Certificate=True";

        public frmNhanSu()
        {
            InitializeComponent();
            LoadDataNhanVien();
        }
        private void LoadDataNhanVien()
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                string query = "SELECT * FROM NhanVien";
                SqlDataAdapter da = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvNhanSu.DataSource = dt;
                dgvNhanSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        private void btnThemNS_Click(object sender, EventArgs e)
        {
            string tenNV = txtTenNV.Text.Trim();
            string sdt = txtSoDTNV.Text.Trim();

            if (string.IsNullOrEmpty(tenNV) || string.IsNullOrEmpty(sdt))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ tên và số điện thoại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(sdt, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải gồm đúng 10 chữ số!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                try
                {
                    conn.Open();

                    // Gọi thủ tục thêm
                    SqlCommand cmd = new SqlCommand("sp_ThemNV", conn);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@hoTen", tenNV);
                    cmd.Parameters.AddWithValue("@sdt", sdt);
                    cmd.ExecuteNonQuery();

                    // Lấy mã NV vừa tạo
                    SqlCommand getMa = new SqlCommand(
                        "SELECT TOP 1 MaNV FROM NhanVien WHERE TenNV = @ten AND SDT_NV = @sdt ORDER BY MaNV DESC", conn);
                    getMa.Parameters.AddWithValue("@ten", tenNV);
                    getMa.Parameters.AddWithValue("@sdt", sdt);

                    object result = getMa.ExecuteScalar();
                    if (result != null)
                    {
                        txtMaNV.Text = result.ToString();
                        MessageBox.Show("Thêm nhân sự thành công! Mã: " + result.ToString(),
                            "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    LoadDataNhanVien();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm nhân sự: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSuaNS_Click(object sender, EventArgs e)
        {
            string maNV = txtMaNV.Text.Trim();
            string tenNV = txtTenNV.Text.Trim();
            string sdt = txtSoDTNV.Text.Trim();

            if (string.IsNullOrEmpty(maNV) || string.IsNullOrEmpty(tenNV) || string.IsNullOrEmpty(sdt))
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
                    SqlCommand cmd = new SqlCommand("CapNhatTT_NV", conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@maNV", maNV);
                    cmd.Parameters.AddWithValue("@tenNV", tenNV);
                    cmd.Parameters.AddWithValue("@sdt", sdt);

                    conn.Open();
                    int result = cmd.ExecuteNonQuery();

                    if (result > 0)
                    {
                        MessageBox.Show("Cập nhật nhân sự thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadDataNhanVien();
                        ClearInputNS();
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy nhân sự cần sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật nhân sự: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaNS_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtMaNV.Text))
            {
                MessageBox.Show("Vui lòng chọn nhân sự để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult dr = MessageBox.Show("Bạn có chắc muốn xóa nhân sự này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    using (SqlConnection conn = new SqlConnection(connStr))
                    {
                        conn.Open();
                        string sql = "DELETE FROM NhanVien WHERE MaNV = @MaNV";
                        using (SqlCommand cmd = new SqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@MaNV", txtMaNV.Text);
                            int rows = cmd.ExecuteNonQuery();

                            if (rows > 0)
                            {
                                MessageBox.Show("Xóa nhân sự thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                LoadDataNhanVien();
                                ClearInputNS();
                            }
                            else
                            {
                                MessageBox.Show("Không tìm thấy nhân sự để xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    if (ex.Number == 547)
                    {
                        MessageBox.Show("Không thể xóa nhân sự vì có dữ liệu liên quan ở bảng khác.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Lỗi khi xóa nhân sự: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvNhanSu_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvNhanSu.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                txtTenNV.Text = row.Cells["TenNV"].Value.ToString();
                txtSoDTNV.Text = row.Cells["SDT_NV"].Value.ToString();
            }
        }

        private void ClearInputNS()
        {
            txtMaNV.Clear();
            txtTenNV.Clear();
            txtSoDTNV.Clear();
        }

        private void txtTimKiemNV_TextChanged(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiemNV.Text.Trim();
            string connectionString = "Data Source=.;Initial Catalog=QuanLyLIAM;Integrated Security=True;TrustServerCertificate=True";


            string query = @"
        SELECT MaNV, TenNV, SDT_NV
        FROM NhanVien
        WHERE MaNV LIKE @TuKhoa OR TenNV LIKE @TuKhoa OR SDT_NV LIKE @TuKhoa";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    try
                    {
                        conn.Open();
                        adapter.Fill(dt);
                        dgvNhanSu.DataSource = dt;
                    
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
                    }

                }
            }
        }


    }
}