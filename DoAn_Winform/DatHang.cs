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
    public partial class frmDatHang : Form
    {
        public frmDatHang()
        {
            InitializeComponent();
        }
        int i = 5;
        private void addThemDongDH()
        {
            //Panel Pan = new Panel() { Width = 444, Height = 35, BackColor = Color.Silver };
            //Label lblTenH = new Label() { Size = new Size(58, 13), Text = "Tên Hàng:", Location = new Point(13, 11) };
            //ComboBox cboTenH = new ComboBox() { Width = 121, Height = 21, Size = new Size(121, 21), Location = new Point(76, 8) };
            //Label lblSL = new Label() { Size = new Size(60, 13), Text = "Số Lượng:", Location = new Point(217, 11) };
            //NumericUpDown numSL = new NumericUpDown() { Size = new Size(45, 20), Location = new Point(276, 9), Minimum = 1 };
            //ComboBox cboDVT = new ComboBox() { Size = new Size(49, 21), Location = new Point(347, 8) };

            //Pan.Controls.Add(lblTenH);
            //Pan.Controls.Add(cboTenH);
            //Pan.Controls.Add(lblSL);
            //Pan.Controls.Add(numSL);
            //Pan.Controls.Add(cboDVT);
            
           
        }

        private void BtnThemDongDatH_Click(object sender, EventArgs e)
        {
            addThemDongDH();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
          
        }
    }
}
