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

        void AutoCompleteBan()
        {
            var source = new AutoCompleteStringCollection();

            foreach (BanDTO item in banBus.LoadDsBan())
            {
                source.Add(item.Tenban);
            }

            txtTimKiemBan.AutoCompleteCustomSource = source;
            txtTimKiemBan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimKiemBan.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        //Thức uống
        void LoadComboboxLoaiTU()
        {
            LoaiThucUongBUS ltu = new LoaiThucUongBUS();

            colLoaiThucUong.DataSource = ltu.LoadDsLoaiTU();
            colLoaiThucUong.DisplayMember = "TENLOAITU";
            colLoaiThucUong.ValueMember = "MALOAITU";

            cboLoaiThucUong.DataSource = ltu.LoadDsLoaiTU();
            cboLoaiThucUong.DisplayMember = "TENLOAITU";
            cboLoaiThucUong.ValueMember = "MALOAITU";
        }

        void AutoCompleteTU()
        {
            var source = new AutoCompleteStringCollection();

            foreach(ThucUongDTO item in tuBUS.LoadDsTU())
            {
                source.Add(item.Tentu);
            }

            txtTimKiemThucUong.AutoCompleteCustomSource = source;
            txtTimKiemThucUong.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimKiemThucUong.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

        void AutoCompleteLoaiTU()
        {
            var source = new AutoCompleteStringCollection();

            foreach(LoaiThucUongDTO item in loaituBUS.LoadDsLoaiTU())
            {
                source.Add(item.Tenloaitu);
            }

            txtTimKiemLoaiThucUong.AutoCompleteCustomSource = source;
            txtTimKiemLoaiThucUong.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimKiemLoaiThucUong.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        //Hàng hóa
        void LoadDsHangHoa()
        {
            HangHoaBUS hangBUS = new HangHoaBUS();
            dtgvHangHoa.AutoGenerateColumns = false;
            dtgvHangHoa.DataSource = hangBUS.LoadDsHH();
        }

        void AutoCompleteHH()
        {
            var source = new AutoCompleteStringCollection();

            foreach(HangHoaDTO item in hangBUS.LoadDsHH())
            {
                source.Add(item.Tenhh);
            }

            txtTimKiemHangHoa.AutoCompleteCustomSource = source;
            txtTimKiemHangHoa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimKiemHangHoa.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        //Nhà cung cấp
        void LoadDsNCC()
        {
            NhaCungCapBUS nccBUS = new NhaCungCapBUS();
            dtgvNhaCungCap.AutoGenerateColumns = false;
            dtgvNhaCungCap.DataSource = nccBUS.LoadDsNCC();
        }

        void AutoCompleteNCC()
        {
            var source = new AutoCompleteStringCollection();

            foreach(NhaCungCapDTO item in nccBUS.LoadDsNCC())
            {
                source.Add(item.Tenncc);
            }

            txtTimKiemNhaCungCap.AutoCompleteCustomSource = source;
            txtTimKiemNhaCungCap.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimKiemNhaCungCap.AutoCompleteSource = AutoCompleteSource.CustomSource;
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

        void AutoCompleteTK()
        {
            var source = new AutoCompleteStringCollection();

            foreach (TaiKhoanDTO item in tkBUS.LoadDsTK())
            {
                source.Add(item.Tendangnhap);
            }

            txtTimKiemTaiKhoan.AutoCompleteCustomSource = source;
            txtTimKiemTaiKhoan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimKiemTaiKhoan.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        //Nhân viên
        void LoadDsNhanVien()
        {
            NhanVienBUS nvBUS = new NhanVienBUS();
            dtgvNhanVien.AutoGenerateColumns = false;
            dtgvNhanVien.DataSource = nvBUS.LoadDsNV();
        }

        void AutoCompleteNV()
        {
            var source = new AutoCompleteStringCollection();

            foreach(NhanVienDTO item in nvBUS.LoadDsNV())
            {
                source.Add(item.Tennv);
            }

            txtTimKiemNhanVien.AutoCompleteCustomSource = source;
            txtTimKiemNhanVien.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtTimKiemNhanVien.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        #endregion



        #region Event
        private void frmAdmin_Load(object sender, EventArgs e)
        {
            //Tab bàn
            LoadDsBan();
            AutoCompleteBan();

            //Tab thức uống
            LoadComboboxLoaiTU();
            LoadDsThucUong();
            AutoCompleteTU();

            //Tab loại thức uống
            LoadDsLoaiTU();
            AutoCompleteLoaiTU();

            //Tab hàng hóa
            LoadDsHangHoa();
            AutoCompleteHH();

            //Tab nhà cung cấp
            LoadDsNCC();
            AutoCompleteNCC();

            //Tab tài khoản
            LoadComboBoxTenNVCuaTK();
            LoadDsTaiKhoan();
            AutoCompleteTK();

            //Tab nhân viên
            LoadDsNhanVien();
            AutoCompleteNV();
        }       

        //Bàn
        BanBUS banBus= new BanBUS();

        private void dtgvBan_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridViewRow dtr = dtgvBan.SelectedRows[0];
                txtTenBan.Text = dtr.Cells[1].Value.ToString();
                nmrSoCho.Value = Convert.ToDecimal(dtr.Cells[2].Value);
            }
        }

        private void btnTimKiemBan_Click(object sender, EventArgs e)
        {
            BanDTO banTam = new BanDTO();
            string tenBan = txtTimKiemBan.Text;

            banTam = banBus.TimKiemBan(tenBan);
            if (banTam != null)
            {
                foreach (DataGridViewRow row in dtgvBan.Rows)
                {
                    if (Convert.ToInt32(row.Cells["colMaBan"].Value.ToString()) == banTam.Soban)
                    {
                        row.Selected = true;
                        dtgvBan.CurrentCell = dtgvBan.Rows[row.Index].Cells[0];
                        txtTenBan.Text = banTam.Tenban;
                        nmrSoCho.Value = banTam.Socho;
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThemBan_Click(object sender, EventArgs e)
        {
            BanDTO banTam = new BanDTO();
            if (txtTenBan.Text==string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                banTam.Tenban = txtTenBan.Text;
                banTam.Socho = Convert.ToInt32(nmrSoCho.Value);
            }
            
            if (banBus.ThemBan(banTam))
            {
                MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsBan();
                AutoCompleteBan();
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
                AutoCompleteBan();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaBan_Click(object sender, EventArgs e)
        {
            BanDTO banTam = new BanDTO();
            banTam.Soban = Convert.ToInt32(dtgvBan.SelectedCells[0].OwningRow.Cells["colMaBan"].Value.ToString());
            if (txtTenBan.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                banTam.Tenban = txtTenBan.Text;
                banTam.Socho = Convert.ToInt32(nmrSoCho.Value);
            }

            if (banBus.SuaBan(banTam))
            {
                MessageBox.Show("Sửa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsBan();
                AutoCompleteBan();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Thức uống
        ThucUongBUS tuBUS = new ThucUongBUS();

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

        private void btnTimKiemThucUong_Click(object sender, EventArgs e)
        {
            ThucUongDTO tuTam = new ThucUongDTO();
            string tenTU = txtTimKiemThucUong.Text;
            tuTam = tuBUS.TimKiemTU(tenTU);
            if (tuTam != null)
            {
                foreach (DataGridViewRow row in dtgvThucUong.Rows)
                {
                    if (Convert.ToInt32(row.Cells["colMaTU"].Value.ToString()) == tuTam.Matu)
                    {
                        row.Selected = true;
                        dtgvThucUong.CurrentCell = dtgvThucUong.Rows[row.Index].Cells[0];
                        txtTenThucUong.Text = tuTam.Tentu;
                        cboLoaiThucUong.SelectedValue = tuTam.Maloaitu;
                        txtGia.Text = tuTam.Gia.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThemThucUong_Click(object sender, EventArgs e)
        {
            ThucUongDTO tuTam = new ThucUongDTO();
            if (txtTenThucUong.Text==string.Empty||txtGia.Text==string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tuTam.Tentu = txtTenThucUong.Text;
                tuTam.Maloaitu = Convert.ToInt32(cboLoaiThucUong.SelectedValue);
                tuTam.Gia = Convert.ToDouble(txtGia.Text);
            }
                        
            if (tuBUS.ThemTU(tuTam))
            {
                MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsThucUong();
                AutoCompleteTU();
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
                AutoCompleteTU();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaThucUong_Click(object sender, EventArgs e)
        {
            ThucUongDTO tuTam = new ThucUongDTO();
            tuTam.Matu = Convert.ToInt32(dtgvThucUong.SelectedCells[0].OwningRow.Cells["colMaTU"].Value.ToString());
            if (txtTenThucUong.Text == string.Empty || txtGia.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tuTam.Tentu = txtTenThucUong.Text;
                tuTam.Maloaitu = Convert.ToInt32(cboLoaiThucUong.SelectedValue);
                tuTam.Gia = Convert.ToDouble(txtGia.Text);
            }

            if (tuBUS.SuaTU(tuTam))
            {
                MessageBox.Show("Sửa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsThucUong();
                AutoCompleteTU();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Loại thức uống
        LoaiThucUongBUS loaituBUS = new LoaiThucUongBUS();

        private void dtgvLoaiThucUong_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                DataGridViewRow dtr = dtgvLoaiThucUong.SelectedRows[0];
                txtTenLoaiThucUong.Text = dtr.Cells[1].Value.ToString();
            }
        }

        private void btnLoaiThucUong_Click(object sender, EventArgs e)
        {
            LoaiThucUongDTO ltuTam = new LoaiThucUongDTO();
            string tenLTU = txtTimKiemLoaiThucUong.Text;
            ltuTam = loaituBUS.TimKiemLoaiTU(tenLTU);
            if (ltuTam != null)
            {
                foreach (DataGridViewRow row in dtgvLoaiThucUong.Rows)
                {
                    if (Convert.ToInt32(row.Cells["colMaLoaiTU"].Value.ToString()) == ltuTam.Maloaitu)
                    {
                        row.Selected = true;
                        dtgvLoaiThucUong.CurrentCell = dtgvLoaiThucUong.Rows[row.Index].Cells[0];
                        txtTenLoaiThucUong.Text = ltuTam.Tenloaitu;
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThemLoaiThucUong_Click(object sender, EventArgs e)
        {
            LoaiThucUongDTO ltuTam = new LoaiThucUongDTO();
            if(txtTenLoaiThucUong.Text==string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ltuTam.Tenloaitu = txtTenLoaiThucUong.Text;
            }
            
            if (loaituBUS.ThemLoaiTU(ltuTam))
            {
                MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsLoaiTU();
                LoadComboboxLoaiTU();
                AutoCompleteLoaiTU();
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
                LoadComboboxLoaiTU();
                AutoCompleteLoaiTU();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaLoaiThucUong_Click(object sender, EventArgs e)
        {
            LoaiThucUongDTO ltuTam = new LoaiThucUongDTO();
            ltuTam.Maloaitu = Convert.ToInt32(dtgvLoaiThucUong.SelectedCells[0].OwningRow.Cells["colMaLoaiTU"].Value.ToString());
            if (txtTenLoaiThucUong.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ltuTam.Tenloaitu = txtTenLoaiThucUong.Text;
            }

            if (loaituBUS.SuaLoaiTU(ltuTam))
            {
                MessageBox.Show("Sửa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsLoaiTU();
                LoadComboboxLoaiTU();
                AutoCompleteLoaiTU();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Hàng hóa
        HangHoaBUS hangBUS = new HangHoaBUS();

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

        private void btnTimKiemHangHoa_Click(object sender, EventArgs e)
        {
            HangHoaDTO hhTam = new HangHoaDTO();
            string tenHH = txtTimKiemHangHoa.Text;
            hhTam = hangBUS.TimKiemHH(tenHH);

            if (hhTam != null)
            {
                foreach (DataGridViewRow row in dtgvHangHoa.Rows)
                {
                    if (Convert.ToInt32(row.Cells["colMaHH"].Value.ToString()) == hhTam.Mahh)
                    {
                        row.Selected = true;
                        dtgvHangHoa.CurrentCell = dtgvHangHoa.Rows[row.Index].Cells[0];
                        txtTenHangHoa.Text = hhTam.Tenhh;
                        txtDonViTinh.Text = hhTam.Dvt;
                        txtSoLuongTon.Text = hhTam.Slton.ToString();
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThemHangHoa_Click(object sender, EventArgs e)
        {
            HangHoaDTO hhTam = new HangHoaDTO();
            if (txtTenHangHoa.Text == string.Empty || txtDonViTinh.Text == string.Empty || txtSoLuongTon.Text == string.Empty) 
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                hhTam.Tenhh = txtTenHangHoa.Text;
                hhTam.Dvt = txtDonViTinh.Text;
                hhTam.Slton = Convert.ToInt32(txtSoLuongTon.Text);
            }
            
            if (hangBUS.ThemHH(hhTam))
            {
                MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsHangHoa();
                AutoCompleteHH();
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
                AutoCompleteHH();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaHangHoa_Click(object sender, EventArgs e)
        {
            HangHoaDTO hhTam = new HangHoaDTO();
            hhTam.Mahh = Convert.ToInt32(dtgvHangHoa.SelectedCells[0].OwningRow.Cells["colMaHH"].Value.ToString());
            if (txtTenHangHoa.Text == string.Empty || txtDonViTinh.Text == string.Empty || txtSoLuongTon.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                hhTam.Tenhh = txtTenHangHoa.Text;
                hhTam.Dvt = txtDonViTinh.Text;
                hhTam.Slton = Convert.ToInt32(txtSoLuongTon.Text);
            }

            if (hangBUS.SuaHH(hhTam))
            {
                MessageBox.Show("Sửa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsHangHoa();
                AutoCompleteHH();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Nhà cung cấp
        NhaCungCapBUS nccBUS = new NhaCungCapBUS();

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

        private void btnTimKiemNhaCungCap_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO nccTam = new NhaCungCapDTO();
            string tenNCC = txtTimKiemNhaCungCap.Text;
            nccTam = nccBUS.TimKiemNCC(tenNCC);
            if (nccTam != null)
            {
                foreach(DataGridViewRow row in dtgvNhaCungCap.Rows)
                {
                    if(Convert.ToInt32(row.Cells["colMaNCC"].Value.ToString()) == nccTam.Mancc)
                    {
                        row.Selected = true;
                        dtgvNhaCungCap.CurrentCell = dtgvNhaCungCap.Rows[row.Index].Cells[0];
                        txtTenNhaCungCap.Text = nccTam.Tenncc;
                        txtDiaChiNhaCungCap.Text = nccTam.Diachi;
                        txtSDTNhaCungCap.Text = nccTam.Sdt;
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThemNhaCungCap_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO nccTam = new NhaCungCapDTO();
            if (txtTenNhaCungCap.Text == string.Empty || txtDiaChiNhaCungCap.Text == string.Empty || txtSDTNhaCungCap.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                nccTam.Tenncc = txtTenNhaCungCap.Text;
                nccTam.Diachi = txtDiaChiNhaCungCap.Text;
                nccTam.Sdt = txtSDTNhaCungCap.Text;
            }
            
            if(nccBUS.ThemNCC(nccTam))
            {
                MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsNCC();
                AutoCompleteNCC();
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
                AutoCompleteNCC();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaNhaCungCap_Click(object sender, EventArgs e)
        {
            NhaCungCapDTO nccTam = new NhaCungCapDTO();
            nccTam.Mancc = Convert.ToInt32(dtgvNhaCungCap.SelectedCells[0].OwningRow.Cells["colmancc"].Value.ToString());
            if (txtTenNhaCungCap.Text == string.Empty || txtDiaChiNhaCungCap.Text == string.Empty || txtSDTNhaCungCap.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                nccTam.Tenncc = txtTenNhaCungCap.Text;
                nccTam.Diachi = txtDiaChiNhaCungCap.Text;
                nccTam.Sdt = txtSDTNhaCungCap.Text;
            }

            if (nccBUS.SuaNCC(nccTam))
            {
                MessageBox.Show("Sửa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsNCC();
                AutoCompleteNCC();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Tài khoản
        TaiKhoanBUS tkBUS = new TaiKhoanBUS();

        private void dtgvTaiKhoan_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                DataGridViewRow dtr = dtgvTaiKhoan.SelectedRows[0];
                txtTenDangNhap.Text = dtr.Cells[0].Value.ToString();
                txtMatKhau.Text = dtr.Cells[1].Value.ToString();
                cboLoaiTaiKhoan.SelectedValue = dtr.Cells[2].Value;
                cboTenNVCuaTK.SelectedValue = dtr.Cells[3].Value;
            }
        }

        private void btnTimKiemTaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO tkTam = new TaiKhoanDTO();
            string tenDN = txtTimKiemTaiKhoan.Text;
            tkTam = tkBUS.TimKiemTK(tenDN);
            if (tkTam != null)
            {
                foreach (DataGridViewRow row in dtgvTaiKhoan.Rows)
                {
                    if (row.Cells["colTenDangNhap"].Value.ToString() == tkTam.Tendangnhap)
                    {
                        row.Selected = true;
                        dtgvTaiKhoan.CurrentCell = dtgvTaiKhoan.Rows[row.Index].Cells[0];
                        txtTenDangNhap.Text = tkTam.Tendangnhap;
                        txtMatKhau.Text = tkTam.Matkhau;
                        cboLoaiTaiKhoan.SelectedValue = tkTam.Loaitaikhoan;
                        cboTenNVCuaTK.SelectedValue = tkTam.Manv;
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThemTaiKhoan_Click(object sender, EventArgs e)
        {
            TaiKhoanDTO tkTam = new TaiKhoanDTO();
            if(txtTenDangNhap.Text==string.Empty||txtMatKhau.Text==string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                tkTam.Tendangnhap = txtTenDangNhap.Text;
                tkTam.Matkhau = txtMatKhau.Text;
                tkTam.Loaitaikhoan = Convert.ToInt32(cboLoaiTaiKhoan.SelectedValue.ToString());
                tkTam.Manv = Convert.ToInt32(cboTenNVCuaTK.SelectedValue);
            }
            
            if(tkBUS.ThemTK(tkTam))
            {
                MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsTaiKhoan();
                AutoCompleteTK();
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
                AutoCompleteTK();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Nhân viên
        NhanVienBUS nvBUS = new NhanVienBUS();

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

        private void btnTimKiemNhanVien_Click(object sender, EventArgs e)
        {
            NhanVienDTO nvTam = new NhanVienDTO();
            string tenNV = txtTimKiemNhanVien.Text;
            nvTam = nvBUS.TimKiemNV(tenNV);
            if (nvTam != null)
            {
                foreach (DataGridViewRow row in dtgvNhanVien.Rows)
                {
                    if (Convert.ToInt32(row.Cells["colMaNV"].Value.ToString()) == nvTam.Manv)
                    {
                        row.Selected = true;
                        dtgvNhanVien.CurrentCell = dtgvNhanVien.Rows[row.Index].Cells[0];
                        txtTenNhanVien.Text = nvTam.Tennv;
                        txtDiaChiNhanVien.Text = nvTam.Diachi;
                        txtSDTNhanVien.Text = nvTam.Sdt;
                        txtChucVu.Text = nvTam.Chucvu;
                    }
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThemNhanVien_Click(object sender, EventArgs e)
        {
            NhanVienDTO nvTam = new NhanVienDTO();
            if (txtTenNhanVien.Text == string.Empty || txtDiaChiNhanVien.Text == string.Empty || txtSDTNhanVien.Text == string.Empty || txtChucVu.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                nvTam.Tennv = txtTenNhanVien.Text;
                nvTam.Diachi = txtDiaChiNhanVien.Text;
                nvTam.Sdt = txtSDTNhanVien.Text;
                nvTam.Chucvu = txtChucVu.Text;
            }

            if(nvBUS.ThemNV(nvTam))
            {
                MessageBox.Show("Thêm thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsNhanVien();
                LoadComboBoxTenNVCuaTK();
                AutoCompleteNV();
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
                AutoCompleteNV();
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSuaNhanVien_Click(object sender, EventArgs e)
        {
            NhanVienDTO nvTam = new NhanVienDTO();
            nvTam.Manv = Convert.ToInt32(dtgvNhanVien.SelectedCells[0].OwningRow.Cells["colmanv"].Value.ToString());
            if (txtTenNhanVien.Text == string.Empty || txtDiaChiNhanVien.Text == string.Empty || txtSDTNhanVien.Text == string.Empty || txtChucVu.Text == string.Empty)
            {
                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin!", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                nvTam.Tennv = txtTenNhanVien.Text;
                nvTam.Diachi = txtDiaChiNhanVien.Text;
                nvTam.Sdt = txtSDTNhanVien.Text;
                nvTam.Chucvu = txtChucVu.Text;
            }

            if (nvBUS.SuaNV(nvTam))
            {
                MessageBox.Show("Sửa thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDsNhanVien();
                LoadComboBoxTenNVCuaTK();
                AutoCompleteNV();
            }
            else
            {
                MessageBox.Show("Sửa thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion 

    }
}
