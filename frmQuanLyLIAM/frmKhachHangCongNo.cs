namespace frmQuanLyLIAM
{
    public partial class frmKhachHangCongNo : Form
    {
        public frmKhachHangCongNo()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string sQuery = "SELECT * FROM KhachHang";
            string sQuery1 = "SELECT * FROM QuanLyNo";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
