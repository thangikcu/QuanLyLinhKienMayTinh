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
    public partial class FrmThongKe : Form
    {
        public FrmThongKe()
        {
            InitializeComponent();
        }

        private void FrmThongKe_Load(object sender, EventArgs e)
        {
            QuanLyLinhKienEntity1 dbo = new QuanLyLinhKienEntity1();
            HoaDonEntityy hd = new HoaDonEntityy();
            int tongtien = 0;
            int soluong = 0;
            int tongsanpham = 0;
            foreach (var tien in hd.Hoa_Don)
            {
                tongtien += tien.TongTien;
            }
            foreach (var sl in hd.Hoa_Don)
            {
                soluong += sl.SoLuong;
            }
            foreach (var sp in dbo.SanPhams)
            {
                tongsanpham += sp.SoLuong;
            }

            label7.Text = dbo.PhanLoais.Count().ToString();
            label6.Text = dbo.SanPhams.Count().ToString();
            label10.Text = tongtien.ToString();
            label9.Text = soluong.ToString();
            label8.Text = tongsanpham.ToString();

        }
    }
}
