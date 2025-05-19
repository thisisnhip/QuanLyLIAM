using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmQuanLyLIAM
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDN_click(object sender, EventArgs e)
        {

            //frmManHinhChinh frm = new frmManHinhChinh();
            //this.Hide();
            //frm.ShowDialog(); //toi khi cai showdialog tat di thi no moi hien cai show
            //this.Show();
        }

        private void frmDangNhap_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình?", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK) 
            {
                e.Cancel = true;
            }//hiển thị 1 messagebõx có title là thông báo  với câu hỏi bạn có...?, kiểu button là  1 nút ok 1 nút cancel, khi người dùng không nhấn ok thì k cho phép thoát, nhấn ok mơis ddc thoát
        }
    }
}
