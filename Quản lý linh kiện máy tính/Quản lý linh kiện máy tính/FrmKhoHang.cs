using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.IO;

namespace Quản_lý_linh_kiện_máy_tính
{
    public partial class FrmKhoHang : Form
    {


        QuanLyLinhKienEntity1 dbo = new QuanLyLinhKienEntity1();
        public FrmKhoHang()
        {
            InitializeComponent();
        }

        public Image chuyenanh(byte[] anhmang)
        {
            MemoryStream ms = new MemoryStream(anhmang);
            Image anh = Image.FromStream(ms);
            return anh;
        }
        public void load()
        {
            QuanLyLinhKienEntity1 dbo = new QuanLyLinhKienEntity1();
            var querry = from c in dbo.PhanLoais join o in dbo.SanPhams on c.MaLoai equals o.MaLoai select new { o.TenSp, c.TenLoai, o.Gia, o.SoLuong };

            dgvsp.DataSource = querry.ToList();

            cmbLoai.DataSource = dbo.PhanLoais.ToList();
            cmbLoai.DisplayMember = "TenLoai";
            cmbLoai.ValueMember = "MaLoai";
            cmbLoai.Text = "";

            dgvsp.Columns["TenSp"].HeaderText = "Tên sản phẩm";
            dgvsp.Columns["TenSp"].Width = 150;
            dgvsp.Columns["Gia"].HeaderText = "Giá";
            dgvsp.Columns["TenLoai"].HeaderText = "Tên loại";
            dgvsp.Columns["SoLuong"].HeaderText = "Số lượng";
            if (querry.Count() > 0)
            {
                lblname.Text = dgvsp.CurrentRow.Cells["TenSp"].Value.ToString();
                lblprice.Text = dgvsp.CurrentRow.Cells["Gia"].Value.ToString();
                lblLuong.Text = dgvsp.CurrentRow.Cells["SoLuong"].Value.ToString();
                lblKieu.Text = dgvsp.CurrentRow.Cells["TenLoai"].Value.ToString();

                //var querry = from a in dbo.SanPhams where a.SoLuong == Convert.ToInt32(lblLuong.Text) select new { a.Hinh };


                SanPham sp = dbo.SanPhams.First(a => a.TenSp == lblname.Text);

                MemoryStream ms = new MemoryStream(sp.Hinh);
                Image img = Image.FromStream(ms);
                pictureBox1.Image = img;
            }



        }
        private void FrmKhoHang_Load(object sender, EventArgs e)
        {
            if (Program.quyen != "ThắngIKCU")
            {
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
            }
            load();

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            var tim = from c in dbo.PhanLoais join o in dbo.SanPhams on c.MaLoai equals o.MaLoai where o.TenSp.Contains(txtTimKiem.Text) && c.TenLoai.Contains(cmbLoai.Text) select new { o.TenSp, c.TenLoai, o.Gia, o.SoLuong };
            dgvsp.DataSource = tim.ToList();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

            FrmThemSp frmthem = new FrmThemSp();
            frmthem.ShowDialog();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            FrmSua frmsua = new FrmSua(lblname.Text, lblKieu.Text);
            frmsua.ShowDialog();
        }

        private void dgvsp_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var querry = from s in dbo.SanPhams select s;
            if (querry.Count() > 0)
            {
                lblname.Text = dgvsp.CurrentRow.Cells["TenSp"].Value.ToString();
                lblprice.Text = dgvsp.CurrentRow.Cells["Gia"].Value.ToString();
                lblLuong.Text = dgvsp.CurrentRow.Cells["SoLuong"].Value.ToString();
                lblKieu.Text = dgvsp.CurrentRow.Cells["TenLoai"].Value.ToString();



                SanPham sp = dbo.SanPhams.First(a => a.TenSp == lblname.Text);

                MemoryStream ms = new MemoryStream(sp.Hinh);
                Image img = Image.FromStream(ms);
                pictureBox1.Image = img;
            }

             
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if ((MessageBox.Show("Bạn thực sự muốn xóa ?", "Cảnh báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)) == DialogResult.Yes)
                {
                    string tensp = dgvsp.CurrentRow.Cells["TenSp"].Value.ToString();
                    SanPham sp = dbo.SanPhams.First(i => i.TenSp == tensp);
                    dbo.SanPhams.Remove(sp);
                    dbo.SaveChanges();
                    MessageBox.Show("Xóa thành công !");
                    load();
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Xóa không thành công !");
            }
 


        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmKhoHang_Load(sender, e);
        }

        private void btnBan_Click(object sender, EventArgs e)
        {

            FrmBanSp frmban = new FrmBanSp(dgvsp.CurrentRow.Cells["TenSp"].Value.ToString());
            frmban.ShowDialog();
        }

        private void txtTimKiem_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
