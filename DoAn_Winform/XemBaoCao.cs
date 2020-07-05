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
using DAO;
using BUS;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;

namespace DoAn_Winform
{
    public partial class frmXemBaoCao : Form
    {
        SqlConnection conn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter da = new SqlDataAdapter();

        public frmXemBaoCao()
        {
            InitializeComponent();
            conn.ConnectionString = @"Data Source=.\sqlexpress;Initial Catalog=QUAN_LI_QUAN_CAFE_HBK;Integrated Security=True";
            conn.Open();
            cmd.Connection = conn;
        }

        

        public void BaoCaoDoanhThuTrongNgay()
        {
            //HoaDonBUS hdBUS=new HoaDonBUS();
            
            //List<HoaDonDTO> ListHDTrongNgay = hdBUS.LoadDsHDTrongNgay();

            cmd.CommandText = "select hd.MAHD, nv.TENNV, b.TENBAN, Sum(ct.SL*ct.GIABAN) as TONGTIEN"
                            + " from HOA_DON hd, CHI_TIET_HOA_DON ct, NHAN_VIEN nv, BAN b"
                            + " where hd.MAHD=ct.MAHD and hd.MANVLAP=nv.MANV and hd.SOBAN=b.SOBAN and hd.TRANGTHAI=1 and hd.NGAYLAP=CONVERT(varchar, getdate(), 23)"
                            + " group by hd.MAHD, nv.TENNV, b.TENBAN";
            da.SelectCommand=cmd;

            DataTable dt = new DataTable("DoanhThuTrongNgay");
            da.Fill(dt);

            crptDoanhThuTrongNgay rp = new crptDoanhThuTrongNgay();
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }

        public void BaoCaoChiTieuTrongNgay()
        {
            cmd.CommandText = "select pnh.MAPNH, nv.TENNV, ncc.TENNCC, Sum(ct.SL*ct.GIA) as TONGTIEN"
                            + " from PHIEU_NHAP_HANG pnh, CHI_TIET_PHIEU_NHAP_HANG ct, NHAN_VIEN nv, NHA_CUNG_CAP ncc"
                            + " where pnh.MAPNH=ct.MAPNH and pnh.MANVLAP=nv.MANV and pnh.MANCC=ncc.MANCC and pnh.NGAYLAP=CONVERT(varchar, getdate(), 23)"
                            + " group by pnh.MAPNH, nv.TENNV, ncc.TENNCC";
            da.SelectCommand = cmd;

            DataTable dt = new DataTable("ChiTieuTrongNgay");
            da.Fill(dt);

            crptChiTieuTrongNgay rp = new crptChiTieuTrongNgay();
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }

        public void BaoCaoDoanhThuTrongKhoan(DateTime tuNgay, DateTime denNgay)
        {
            cmd.CommandText = "select hd.MAHD, nv.TENNV, hd.NGAYLAP, b.TENBAN, Sum(ct.SL*ct.GIABAN) as TONGTIEN"
                            + " from HOA_DON hd, CHI_TIET_HOA_DON ct, NHAN_VIEN nv, BAN b"
                            + " where hd.MAHD=ct.MAHD and hd.MANVLAP=nv.MANV and hd.SOBAN=b.SOBAN and hd.TRANGTHAI=1 and hd.NGAYLAP>='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", tuNgay) + "' and hd.NGAYLAP<='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", denNgay)+"'"
                            + " group by hd.MAHD, nv.TENNV, hd.NGAYLAP, b.TENBAN";
            da.SelectCommand = cmd;

            DataTable dt = new DataTable("DoanhThuTrongKhoanTG");
            da.Fill(dt);

            crptDoanhThuTrongKhoan rp = new crptDoanhThuTrongKhoan();
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }

        public void BaoCaoChiTieuTrongKhoan(DateTime tuNgay, DateTime denNgay)
        {
            cmd.CommandText = "select pnh.MAPNH, nv.TENNV, pnh.NGAYLAP, ncc.TENNCC, Sum(ct.SL*ct.GIA) as TONGTIEN"
                            + " from PHIEU_NHAP_HANG pnh, CHI_TIET_PHIEU_NHAP_HANG ct, NHAN_VIEN nv, NHA_CUNG_CAP ncc"
                            + " where pnh.MAPNH=ct.MAPNH and pnh.MANVLAP=nv.MANV and pnh.MANCC=ncc.MANCC and pnh.NGAYLAP>='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", tuNgay) + "' and pnh.NGAYLAP<='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", denNgay) + "'"
                            + " group by pnh.MAPNH, nv.TENNV, pnh.NGAYLAP, ncc.TENNCC";
            da.SelectCommand = cmd;

            DataTable dt = new DataTable("ChiTieuTrongKhoan");
            da.Fill(dt);

            crptChiTieuTrongKhoan rp = new crptChiTieuTrongKhoan();
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }

        public void BaoCaoDoanhThuTungSPTrongThang()
        {
            DateTime tuNgay = new DateTime(DateTime.Now.Year,DateTime.Now.Month, 1);
            DateTime denNgay = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            cmd.CommandText = "select tu.TENTU, cthd.GIABAN, sum(cthd.SL) as TONGSL, sum(cthd.SL*cthd.GIABAN) as TONGDOANHTHU"
                            + " from THUC_UONG tu, CHI_TIET_HOA_DON cthd, HOA_DON hd"
                            + " where tu.MATU=cthd.MATU and cthd.MAHD=hd.MAHD and tu.TRANGTHAIXOA=0 and hd.NGAYLAP>='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", tuNgay) + "' and hd.NGAYLAP<='" + string.Format("{0:yyyy-MM-dd HH:mm:ss}", denNgay) + "'"
                            + " group by tu.MATU, tu.TENTU, cthd.GIABAN";
            da.SelectCommand = cmd;

            DataTable dt = new DataTable("DoanhThuTungSPTrongThang");
            da.Fill(dt);

            crptDoanhThuTungSPTrongThang rp = new crptDoanhThuTungSPTrongThang();
            rp.SetDataSource(dt);
            crystalReportViewer1.ReportSource = rp;
        }
    }
}
