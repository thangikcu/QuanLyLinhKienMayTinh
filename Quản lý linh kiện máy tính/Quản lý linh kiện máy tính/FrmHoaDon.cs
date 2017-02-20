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
    public partial class FrmHoaDon : Form
    {
        HoaDonEntityy hdb = new HoaDonEntityy();
        public FrmHoaDon()
        {
            InitializeComponent();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var tim = from c in hdb.Hoa_Don where c.TenKh.Contains(txtTimKiem.Text) select c;
            dgvhd.DataSource = tim.ToList();
        }


        private void FrmHoaDon_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quanLyLinhKienDataSet1.Hoa_Don' table. You can move, or remove it, as needed.
            this.hoa_DonTableAdapter.Fill(this.quanLyLinhKienDataSet1.Hoa_Don);


        }
    }
}
