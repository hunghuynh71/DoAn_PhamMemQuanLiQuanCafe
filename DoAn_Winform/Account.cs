using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
namespace DoAn_Winform
{
    public partial class frmAccount : Form
    {
        TaiKhoanDTO TaiKhoanGlobal = new TaiKhoanDTO();
        public frmAccount()
        {
            InitializeComponent();
        }
        public frmAccount(TaiKhoanDTO tk)
        {
            TaiKhoanGlobal = tk;          
            InitializeComponent();
            txtTenTaiKhoan.Text = tk.Tendangnhap;
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
            TaiKhoanBUS tkbus = new TaiKhoanBUS();
            if (txtMatKhauCu.Text == "" || txtMatKhauMoi.Text == "" || txtNhapLaiMatKhau.Text == "")
                MessageBox.Show("Không Để Trống", "Thông Báo");
            else if(txtMatKhauCu.Text == txtMatKhauMoi.Text)
                MessageBox.Show("Mật Khẩu Mới Trùng Mật Khẩu Cũ", "Thông Báo");
            else if (txtMatKhauMoi.Text != txtNhapLaiMatKhau.Text)
                MessageBox.Show("Nhập Lại Mật Khẩu Mới Không Đúng", "Thông Báo");
            else
            {
                if(tkbus.SuaTK(TaiKhoanGlobal,txtMatKhauCu.Text,txtMatKhauMoi.Text))
                    MessageBox.Show("Thành Công", "Thông Báo");
                else
                    MessageBox.Show("Sai Mật Khẩu Củ", "Thông Báo");
            }
            txtMatKhauCu.Text = string.Empty;
            txtMatKhauMoi.Text = string.Empty;
            txtNhapLaiMatKhau.Text = string.Empty;
        }


        
        private void btnThoatAccount_Click(object sender, EventArgs e)
        {
            if (txtMatKhauCu.Text != "" || txtMatKhauMoi.Text != "" || txtNhapLaiMatKhau.Text != "")
            {
                DialogResult res = MessageBox.Show("Chưa Thây Đổi Tài Khoản Muốn Ở Chỉnh Sửa Không ", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.No)
                    this.Close();
            }
            else
                this.Close();
        }

    }
}
