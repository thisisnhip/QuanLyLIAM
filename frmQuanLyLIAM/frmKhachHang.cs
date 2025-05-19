using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
//using System.Data.SqlClient;

namespace frmQuanLyLIAM
{
    public partial class frmKhachHang : Form
    {
        string sCon = "Data Source=DESKTOP-U15MUJ5\\PHUONGNHI;Initial Catalog=QuanLyLIAM;Integrated Security=True;Encrypt=False";
        BindingSource bs = new BindingSource();
        public frmKhachHang()
        {
            InitializeComponent();
        }
        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(sCon);
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kết nối DB không thành công");
            }
            //bước 2: Lấy dữ liệu từ DB
            string sQuery = "SELECT * FROM KhachHang";
            SqlDataAdapter adapter = new SqlDataAdapter(sQuery, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds, "KhachHang"); //đổ dữ liệu về dataset, đặt tên là KhachHang
            //bước 3: Đổ dữ liệu vào DataGridView
            dgvKhachHang.DataSource = ds.Tables["KhachHang"];

            // Gán BindingSource để hỗ trợ lọc
            bs.DataSource = ds.Tables["KhachHang"];
            dgvKhachHang.DataSource = bs;

            //bước 4: Đóng kết nối
            con.Close();
            // ===== CHỈNH KÍCH THƯỚC CỘT Ở ĐÂY =====
            dgvKhachHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;

            dgvKhachHang.Columns["MaKH"].Width = 120;
            dgvKhachHang.Columns["TenKH"].Width = 250;
            dgvKhachHang.Columns["DiaChi"].Width = 700;
            dgvKhachHang.Columns["SDT_KH"].Width = 260;

            foreach (DataGridViewColumn col in dgvKhachHang.Columns)
            {
                col.Resizable = DataGridViewTriState.False; // Không cho resize
            }

            dgvKhachHang.AllowUserToResizeColumns = false; // Không cho người dùng resize bằng chuột
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenKH = txtTenKH.Text.Trim();
            string diaChi = txtDiaChiKH.Text.Trim();
            string sdt = txtSDTKH.Text.Trim();

            if (tenKH.Length <= 5 || tenKH.Any(char.IsDigit) || tenKH.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Tên khách hàng phải dài hơn 5 ký tự và không chứa số hoặc ký tự đặc biệt.");
                return;
            }

            if (diaChi.Length <= 5)
            {
                MessageBox.Show("Địa chỉ phải dài hơn 5 ký tự.");
                return;
            }

            if (!Regex.IsMatch(sdt, @"^\d{10}$"))
            {
                MessageBox.Show("Số điện thoại phải gồm đúng 10 chữ số.");
                return;
            }
            // Kiểm tra trùng SDT
            string sqlCheck = "SELECT COUNT(*) FROM KhachHang WHERE SDT_KH = @sdt";
            using (SqlConnection con = new SqlConnection(sCon))
            using (SqlCommand cmd = new SqlCommand(sqlCheck, con))
            {
                cmd.Parameters.AddWithValue("@sdt", sdt);
                con.Open();
                int count = (int)cmd.ExecuteScalar();
                con.Close();

                if (count > 0)
                {
                    MessageBox.Show("Số điện thoại này đã tồn tại. Vui lòng nhập số khác.");
                    return;
                }
            }

            using (SqlConnection con = new SqlConnection(sCon))
            {
                SqlCommand cmd = new SqlCommand("sp_NhapKhachHang", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@tenKH", tenKH);
                cmd.Parameters.AddWithValue("@diachi", diaChi);
                cmd.Parameters.AddWithValue("@sdt", sdt);

                SqlParameter ret = new SqlParameter("@ret", SqlDbType.Bit)
                {
                    Direction = ParameterDirection.Output
                };
                cmd.Parameters.Add(ret);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();

                    bool result = (bool)ret.Value;
                    if (result)
                    {
                        MessageBox.Show("Thêm khách hàng thành công.");
                        LoadKhachHang(); // gợi ý: viết hàm Load lại dgvKhachHang sau khi thêm
                    }
                    else
                    {
                        MessageBox.Show("Không thêm được khách hàng. Kiểm tra lại dữ liệu hoặc trùng số điện thoại.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi thêm khách hàng: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
        private void LoadKhachHang()
        {
            using (SqlConnection con = new SqlConnection(sCon))
            {
                string query = "SELECT * FROM KhachHang";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);

                // Gán lại DataSource cho BindingSource
                bs.DataSource = dt;
                dgvKhachHang.DataSource = bs;
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string tenKH = txtTenKH.Text.Trim();
            string diaChi = txtDiaChiKH.Text.Trim();
            string sdt = txtSDTKH.Text.Trim();

            if (tenKH == "" || diaChi == "" || sdt == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Tên KH, Địa chỉ và SĐT.");
                return;
            }

            using (SqlConnection con = new SqlConnection(sCon))
            {
                try
                {
                    con.Open();

                    // Tìm mã KH từ 3 trường nhập
                    SqlCommand cmdFind = new SqlCommand(@"
                SELECT MaKH FROM KhachHang 
                WHERE TenKH = @tenKH AND DiaChi = @diaChi AND SDT_KH = @sdt", con);

                    cmdFind.Parameters.AddWithValue("@tenKH", tenKH);
                    cmdFind.Parameters.AddWithValue("@diaChi", diaChi);
                    cmdFind.Parameters.AddWithValue("@sdt", sdt);

                    object result = cmdFind.ExecuteScalar();

                    if (result == null)
                    {
                        MessageBox.Show("Không tìm thấy khách hàng khớp với thông tin đã nhập.");
                        return;
                    }

                    string maKH = result.ToString();

                    DialogResult confirm = MessageBox.Show($"Xác nhận xóa khách hàng có mã {maKH}?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.No) return;

                    // Thực hiện xóa
                    SqlCommand cmdDelete = new SqlCommand("DELETE FROM KhachHang WHERE MaKH = @maKH", con);
                    cmdDelete.Parameters.AddWithValue("@maKH", maKH);

                    cmdDelete.ExecuteNonQuery();
                    MessageBox.Show("Xóa khách hàng thành công.");

                    LoadKhachHang(); // làm mới lưới
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Không thể xóa khách hàng. Có thể khách hàng đã có đơn hàng.\nChi tiết: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string maKH = txtMaKH.Text.Trim();
            string tenKH = txtTenKH.Text.Trim();
            string diaChi = txtDiaChiKH.Text.Trim();
            string sdt = txtSDTKH.Text.Trim();

            // Kiểm tra mã KH
            if (string.IsNullOrEmpty(maKH))
            {
                MessageBox.Show("Vui lòng nhập hoặc chọn mã khách hàng cần sửa.");
                return;
            }

            // Kiểm tra tên hợp lệ
            if (tenKH.Length <= 5 || tenKH.Any(char.IsDigit) || tenKH.Any(c => !char.IsLetter(c) && !char.IsWhiteSpace(c)))
            {
                MessageBox.Show("Tên khách hàng phải dài hơn 5 ký tự và không chứa số hoặc ký tự đặc biệt.");
                return;
            }

            // Kiểm tra địa chỉ
            if (diaChi.Length <= 5)
            {
                MessageBox.Show("Địa chỉ phải dài hơn 5 ký tự.");
                return;
            }

            // Kiểm tra SĐT
            if (sdt.Length != 10 || !sdt.All(char.IsDigit))
            {
                MessageBox.Show("Số điện thoại phải gồm đúng 10 chữ số.");
                return;
            }

            using (SqlConnection con = new SqlConnection(sCon))
            {
                con.Open();

                // Lấy dữ liệu cũ từ DB để so sánh
                SqlCommand checkCmd = new SqlCommand("SELECT TenKH, DiaChi, SDT_KH FROM KhachHang WHERE MaKH = @maKH", con);
                checkCmd.Parameters.AddWithValue("@maKH", maKH);

                SqlDataReader reader = checkCmd.ExecuteReader();
                if (reader.Read())
                {
                    string tenCu = reader["TenKH"].ToString().Trim();
                    string diaChiCu = reader["DiaChi"].ToString().Trim();
                    string sdtCu = reader["SDT_KH"].ToString().Trim();

                    if (tenCu == tenKH && diaChiCu == diaChi && sdtCu == sdt)
                    {
                        MessageBox.Show("Dữ liệu không thay đổi, không cần cập nhật.");
                        reader.Close();
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng.");
                    reader.Close();
                    return;
                }
                reader.Close();

                // Cập nhật nếu khác dữ liệu cũ
                SqlCommand cmd = new SqlCommand(@"
            UPDATE KhachHang 
            SET TenKH = @tenKH, DiaChi = @diaChi, SDT_KH = @sdt 
            WHERE MaKH = @maKH", con);

                cmd.Parameters.AddWithValue("@tenKH", tenKH);
                cmd.Parameters.AddWithValue("@diaChi", diaChi);
                cmd.Parameters.AddWithValue("@sdt", sdt);
                cmd.Parameters.AddWithValue("@maKH", maKH);

                int row = cmd.ExecuteNonQuery();

                if (row > 0)
                {
                    MessageBox.Show("Cập nhật khách hàng thành công.");
                    LoadKhachHang(); // Làm mới bảng
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại.");
                }
            }
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {
            string keyword = txtTimKiem.Text.Trim().Replace("'", "''");

            // Nếu từ khóa là số thì tìm SDT từ trái sang phải
            if (long.TryParse(keyword, out _))
            {
                bs.Filter = $"SDT_KH LIKE '{keyword}%'"; // SDT bắt đầu bằng keyword
            }
            else
            {
                bs.Filter = $"MaKH LIKE '%{keyword}%' OR TenKH LIKE '%{keyword}%' OR DiaChi LIKE '%{keyword}%'";
            }
        }

        private void btnQuanLiSP_Click(object sender, EventArgs e)
        {

        }
    }
}
