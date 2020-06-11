using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DAO;
using DTO;

namespace DoAn_Winform
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        #region Method

        //Bàn
        void LoadDsBan()
        {
            BanBUS ban = new BanBUS();
            dtgvBan.AutoGenerateColumns = false;
            dtgvBan.DataSource = ban.LoadDsBan();
        }

        //Thức uống
        void LoadComboboxLoaiTU()
        {
            LoaiThucUongBUS ltu = new LoaiThucUongBUS();

            colLoaiThucUong.DataSource = ltu.LoadDsLoaiTU();
            colLoaiThucUong.DisplayMember = "TENLOAITU";
            colLoaiThucUong.ValueMember = "MALOAITU";

            cboLoaiThucUong.DataSource=ltu.LoadDsLoaiTU();
            cboLoaiThucUong.DisplayMember = "TENLOAITU";
            cboLoaiThucUong.ValueMember = "MALOAITU";
        }

        void LoadDsThucUong()
        {
            ThucUongBUS tu = new ThucUongBUS();
            dtgvThucUong.AutoGenerateColumns = false;
            dtgvThucUong.DataSource = tu.LoadDsTU();
        }

        //Loại thức uống
        void LoadDsLoaiTU()
        {
            LoaiThucUongBUS loaituBUS = new LoaiThucUongBUS();
            dtgvLoaiThucUong.AutoGenerateColumns = false;
            dtgvLoaiThucUong.DataSource = loaituBUS.LoadDsLoaiTU();
        }

        //Hàng hóa
        void LoadDsHangHoa()
        {
            HangHoaBUS hangBUS = new HangHoaBUS();
            dtgvHangHoa.AutoGenerateColumns = false;
            dtgvHangHoa.DataSource = hangBUS.LoadDsHH();
        }

        //Nhà cung cấp
        void LoadDsNCC()
        {
            NhaCungCapBUS nccBUS = new NhaCungCapBUS();
            dtgvNhaCungCap.AutoGenerateColumns = false;
            dtgvNhaCungCap.DataSource = nccBUS.LoadDsNCC();
        }

        //Tài khoản
        void LoadComboBoxTenNVCuaTK()
        {
            NhanVienBUS nvBUS = new NhanVienBUS();
            cboTenNVCuaTK.DataSource = nvBUS.LoadDsNV();
            cboTenNVCuaTK.DisplayMember = "TENNV";
            cboTenNVCuaTK.ValueMember = "MANV";
        }

        void LoadDsTaiKhoan()
        {
            TaiKhoanBUS tkBUS = new TaiKhoanBUS();
            dtgvTaiKhoan.AutoGenerateColumns = false;
            dtgvTaiKhoan.DataSource = tkBUS.LoadDsTK();
        }

        //Nhân viên
        void LoadDsNhanVien()
        {
            NhanVienBUS nvBUS = new NhanVienBUS();
            dtgvNhanVien.AutoGenerateColumns = false;
            dtgvNhanVien.DataSource = nvBUS.LoadDsNV();
        }

        #endregion



        #region Event
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            //Load bàn
            LoadDsBan();

            //Load thức uống
            LoadComboboxLoaiTU();
            LoadDsThucUong();

            //Load loại thức uống
            LoadDsLoaiTU();

            //Load hàng hóa
            LoadDsHangHoa();

            //Load nhà cung cấp
            LoadDsNCC();

            //Load tài khoản
            LoadComboBoxTenNVCuaTK();
            LoadDsTaiKhoan();

            //Load nhân viên
            LoadDsNhanVien();
        }       

        //Bàn
        BanBUS banBus= new BanBUS();
        BanDTO banTam=new BanDTO();

        private void dtgvBan_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridViewRow dtr = dtgvBan.SelectedRows[0];
                txtTenBan.Text = dtr.Cells[1].Value.ToString();
                nmrSoCho.Value = Convert.ToDecimal(dtr.Cells[2].Value);
            }
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            banTam.Tenban = txtTenBan.Text;
            banTam.Socho = Convert.ToInt32(nmrSoCho.Value);
            if (banBus.ThemBan(banTam))
            {
                MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsBan();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaBan_Click(object sender, EventArgs e)
        {
            int maBan = Convert.ToInt32(dtgvBan.SelectedCells[0].OwningRow.Cells["colMaBan"].Value.ToString());
            if (banBus.XoaBan(maBan))
            {
                MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsBan();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaBan_Click(object sender, EventArgs e)
        {
            banTam.Soban = Convert.ToInt32(dtgvBan.SelectedCells[0].OwningRow.Cells["colMaBan"].Value.ToString());
            banTam.Tenban = txtTenBan.Text;
            banTam.Socho = Convert.ToInt32(nmrSoCho.Value);
            if (banBus.SuaBan(banTam))
            {
                MessageBox.Show("Sửa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsBan();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Thức uống
        ThucUongBUS tuBUS = new ThucUongBUS();
        ThucUongDTO tuTam = new ThucUongDTO();

        private void dtgvThucUong_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridViewRow dtr = dtgvThucUong.SelectedRows[0];
                txtTenThucUong.Text = dtr.Cells[1].Value.ToString();
                cboLoaiThucUong.SelectedValue = dtr.Cells[2].Value;
                txtGia.Text = dtr.Cells[3].Value.ToString();                
            }
        }

        private void btnThemThucUong_Click(object sender, EventArgs e)
        {
            tuTam.Tentu = txtTenThucUong.Text;
            tuTam.Maloaitu = Convert.ToInt32(cboLoaiThucUong.SelectedValue);
            tuTam.Gia = Convert.ToDouble(txtGia.Text);            
            if (tuBUS.ThemTU(tuTam))
            {
                MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsThucUong();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaThucUong_Click(object sender, EventArgs e)
        {
            int maTU = Convert.ToInt32(dtgvThucUong.SelectedCells[0].OwningRow.Cells["colMaTU"].Value.ToString());
            if (tuBUS.XoaTU(maTU))
            {
                MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsThucUong();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaThucUong_Click(object sender, EventArgs e)
        {
            tuTam.Matu = Convert.ToInt32(dtgvThucUong.SelectedCells[0].OwningRow.Cells["colMaTU"].Value.ToString());
            tuTam.Tentu = txtTenThucUong.Text;
            tuTam.Maloaitu = Convert.ToInt32(cboLoaiThucUong.SelectedValue);
            tuTam.Gia = Convert.ToDouble(txtGia.Text);
            if (tuBUS.SuaTU(tuTam))
            {
                MessageBox.Show("Sửa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsThucUong();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Loại thức uống
        LoaiThucUongBUS loaituBUS = new LoaiThucUongBUS();
        LoaiThucUongDTO ltuTam = new LoaiThucUongDTO();

        private void dtgvLoaiThucUong_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                DataGridViewRow dtr = dtgvLoaiThucUong.SelectedRows[0];
                txtTenLoaiThucUong.Text = dtr.Cells[1].Value.ToString();
            }
        }

        private void btnThemLoaiThucUong_Click(object sender, EventArgs e)
        {
            ltuTam.Tenloaitu = txtTenLoaiThucUong.Text;
            if (loaituBUS.ThemLoaiTU(ltuTam))
            {
                MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsLoaiTU();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaLoaiThucUong_Click(object sender, EventArgs e)
        {
            int maLTU = Convert.ToInt32(dtgvLoaiThucUong.SelectedCells[0].OwningRow.Cells["colMaLoaiTU"].Value.ToString());
            if (loaituBUS.XoaLoaiTU(maLTU))
            {
                MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsLoaiTU();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaLoaiThucUong_Click(object sender, EventArgs e)
        {
            ltuTam.Maloaitu = Convert.ToInt32(dtgvLoaiThucUong.SelectedCells[0].OwningRow.Cells["colMaLoaiTU"].Value.ToString());
            ltuTam.Tenloaitu = txtTenLoaiThucUong.Text;
            if (loaituBUS.SuaLoaiTU(ltuTam))
            {
                MessageBox.Show("Sửa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsLoaiTU();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Hàng hóa
        HangHoaBUS hangBUS = new HangHoaBUS();
        HangHoaDTO hhTam = new HangHoaDTO();

        private void dtgvHangHoa_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                DataGridViewRow dtr = dtgvHangHoa.SelectedRows[0];
                txtTenHangHoa.Text = dtr.Cells[1].Value.ToString();
                txtDonViTinh.Text = dtr.Cells[2].Value.ToString();
                txtSoLuongTon.Text = dtr.Cells[3].Value.ToString();
            }
        }

        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            hhTam.Tenhh = txtTenHangHoa.Text;
            hhTam.Dvt = txtDonViTinh.Text;
            hhTam.Slton = Convert.ToInt32(txtSoLuongTon.Text);
            if (hangBUS.ThemHH(hhTam))
            {
                MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsHangHoa();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaHangHoa_Click(object sender, EventArgs e)
        {
            int maHH = Convert.ToInt32(dtgvHangHoa.SelectedCells[0].OwningRow.Cells["colMaHH"].Value.ToString());
            if (hangBUS.XoaHH(maHH))
            {
                MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsHangHoa();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaHangHoa_Click(object sender, EventArgs e)
        {
            hhTam.Mahh = Convert.ToInt32(dtgvHangHoa.SelectedCells[0].OwningRow.Cells["colMaHH"].Value.ToString());
            hhTam.Tenhh = txtTenHangHoa.Text;
            hhTam.Dvt = txtDonViTinh.Text;
            hhTam.Slton = Convert.ToInt32(txtSoLuongTon.Text);
            if (hangBUS.ThemHH(hhTam))
            {
                MessageBox.Show("Sửa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsHangHoa();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Nhà cung cấp
        NhaCungCapBUS nccBUS = new NhaCungCapBUS();
        NhaCungCapDTO nccTam = new NhaCungCapDTO();


        private void dtgvNhaCungCap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridViewRow dtr = dtgvNhaCungCap.SelectedRows[0];
                txtTenNhaCungCap.Text = dtr.Cells[1].Value.ToString();
                txtDiaChiNhaCungCap.Text = dtr.Cells[2].Value.ToString();
                txtSDTNhaCungCap.Text = dtr.Cells[3].Value.ToString();
            }
        }

        private void btnThemNhaCungCap_Click(object sender, EventArgs e)
        {
            nccTam.Tenncc = txtTenNhaCungCap.Text;
            nccTam.Diachi = txtDiaChiNhaCungCap.Text;
            nccTam.Sdt = txtSDTNhaCungCap.Text;
            if(nccBUS.ThemNCC(nccTam))
            {
                MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsNCC();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaNhaCungCap_Click(object sender, EventArgs e)
        {
            int maNCC = Convert.ToInt32(dtgvNhaCungCap.SelectedCells[0].OwningRow.Cells["colmancc"].Value.ToString());
            if (nccBUS.XoaNCC(maNCC))
            {
                MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsNCC();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaNhaCungCap_Click(object sender, EventArgs e)
        {
            nccTam.Mancc = Convert.ToInt32(dtgvNhaCungCap.SelectedCells[0].OwningRow.Cells["colmancc"].Value.ToString());
            nccTam.Tenncc = txtTenNhaCungCap.Text;
            nccTam.Diachi = txtDiaChiNhaCungCap.Text;
            nccTam.Sdt = txtSDTNhaCungCap.Text;
            if (nccBUS.SuaNCC(nccTam))
            {
                MessageBox.Show("Sửa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsNCC();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Tài khoản
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();
        TaiKhoanDTO tkTam = new TaiKhoanDTO();

        private void dtgvTaiKhoan_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridViewRow dtr = dtgvTaiKhoan.SelectedRows[0];
                txtTenDangNhap.Text = dtr.Cells[0].Value.ToString();
                txtMatKhau.Text = dtr.Cells[1].Value.ToString();
                txtLoaiTaiKhoan.Text = dtr.Cells[2].Value.ToString();
                cboTenNVCuaTK.SelectedValue = dtr.Cells[3].Value;
            }
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            tkTam.Tendangnhap = txtTenDangNhap.Text;
            tkTam.Matkhau = txtMatKhau.Text;
            tkTam.Loaitaikhoan = txtLoaiTaiKhoan.Text;
            tkTam.Manv = Convert.ToInt32(cboTenNVCuaTK.SelectedValue);
            if(tkBUS.ThemTK(tkTam))
            {
                MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsTaiKhoan();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            string tenDN = dtgvTaiKhoan.SelectedCells[0].OwningRow.Cells["coltendangnhap"].Value.ToString();
            if (tkBUS.XoaTK(tenDN))
            {
                MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsTaiKhoan();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Nhân viên
        NhanVienBUS nvBUS = new NhanVienBUS();
        NhanVienDTO nvTam = new NhanVienDTO();

        private void dtgvNhanVien_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridViewRow dtr = dtgvNhanVien.SelectedRows[0];
                txtTenNhanVien.Text = dtr.Cells[1].Value.ToString();
                txtDiaChiNhanVien.Text = dtr.Cells[2].Value.ToString();
                txtSDTNhanVien.Text = dtr.Cells[3].Value.ToString();
                txtChucVu.Text = dtr.Cells[4].Value.ToString();              
                
            }
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            nvTam.Tennv = txtTenNhanVien.Text;
            nvTam.Diachi = txtDiaChiNhanVien.Text;
            nvTam.Sdt = txtSDTNhanVien.Text;
            nvTam.Chucvu = txtChucVu.Text;
            if(nvBUS.ThemNV(nvTam))
            {
                MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsNhanVien();
                LoadComboBoxTenNVCuaTK();
            }
            else
            {
                MessageBox.Show("Thêm thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoaNhanVien_Click(object sender, EventArgs e)
        {
            int maNV = Convert.ToInt32(dtgvNhanVien.SelectedCells[0].OwningRow.Cells["colmanv"].Value.ToString());
            if (nvBUS.XoaNV(maNV))
            {
                MessageBox.Show("Xóa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsNhanVien();
                LoadComboBoxTenNVCuaTK();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            nvTam.Manv = Convert.ToInt32(dtgvNhanVien.SelectedCells[0].OwningRow.Cells["colmanv"].Value.ToString());
            nvTam.Tennv = txtTenNhanVien.Text;
            nvTam.Diachi = txtDiaChiNhanVien.Text;
            nvTam.Sdt = txtSDTNhanVien.Text;
            nvTam.Chucvu = txtChucVu.Text;
            if (nvBUS.SuaNV(nvTam))
            {
                MessageBox.Show("Sửa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsNhanVien();
                LoadComboBoxTenNVCuaTK();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion 

        private void btnTimKiemBan_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemThucUong_Click(object sender, EventArgs e)
        {

        }

        private void btnLoaiThucUong_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemHangHoa_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemNhaCungCap_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void btnTimKiemNhanVien_Click(object sender, EventArgs e)
        {

        }

    }
}
