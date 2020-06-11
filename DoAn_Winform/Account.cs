using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Winform
{
    public partial class frmAccount : Form
    {
        public frmAccount()
        {
            InitializeComponent();
        }

        private void btnExitAccount_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnResetAccount_Click(object sender, EventArgs e)
        {
            txtMatKhauCu.Text = "";
            txtMatKhauMoi.Text = "";
            txtNhapLaiMatKhau.Text = "";
        }

        private void btnThayDoiAccount_Click(object sender, EventArgs e)
        {
            DialogResult drl= MessageBox.Show("Xác Nhận Thây Đổi Mật Khẩu.","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(drl== DialogResult.Yes)
            {
                // #Thực Hiện Thây Đổi Mật Khẩu Trên CSDL TỪ Đây

                MessageBox.Show("Thay Đổi Thành Công.","Thông Báo");
            }
            else
            {
                MessageBox.Show("Mật Khẩu Chưa Thây Đổi.","Thông Báo");
            }

        }

    }
}
