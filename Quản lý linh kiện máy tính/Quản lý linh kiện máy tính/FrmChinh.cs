using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Quản_lý_linh_kiện_máy_tính
{
    public partial class FrmChinh : Form
    {


        public FrmChinh()
        {
            InitializeComponent();

        }


        private void FrmChinh_Load(object sender, EventArgs e)
        {
            grbtaikhoan.Text = Program.quyen;
            if (grbtaikhoan.Text == "ThắngIKCU")
            {
                label2.Text = "Chủ cửa hàng";
            }
            else
            {
                label2.Text = "Nhân viên";
                btnHoaDon.Enabled = false;
                btnThongKe.Enabled = false;

            }
                

            
        }


        private void label3_Click(object sender, EventArgs e)
        {
            Frmdoimatkhau frmdoimatkhau = new Frmdoimatkhau();
            frmdoimatkhau.ShowDialog();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            FrmThongKe frmthongke = new FrmThongKe();
            frmthongke.ShowDialog();
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            FrmKhoHang frmkho = new FrmKhoHang();
            frmkho.ShowDialog();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn thực sự muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnThongtin_Click(object sender, EventArgs e)
        {
            FrmThongTin frmthongtin = new FrmThongTin();
            frmthongtin.ShowDialog();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            FrmHoaDon frmhoadon = new FrmHoaDon();
            frmhoadon.ShowDialog();
        }



    }
}
