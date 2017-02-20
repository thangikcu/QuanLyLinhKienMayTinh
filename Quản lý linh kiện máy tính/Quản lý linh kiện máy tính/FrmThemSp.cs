using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Quản_lý_linh_kiện_máy_tính
{
    public partial class FrmThemSp : Form
    {
        string file;
        byte[] imageMang;
        QuanLyLinhKienEntity1 dbo = new QuanLyLinhKienEntity1();
        public FrmThemSp()
        {
            InitializeComponent();
        }


        private void btnnhaplai_Click(object sender, EventArgs e)
        {
            txtTen.Text = txtGia.Text = txtMaSp.Text = txtSoLuong.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "" || txtGia.Text == "" || txtMaSp.Text == "" || txtSoLuong.Text == "" || string.IsNullOrEmpty(file))
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin !");
                return;
            }

            try
            {
                SanPham sanpham = new SanPham()
                {
                    MaSp = txtMaSp.Text,
                    MaLoai = cmbLoai.SelectedValue.ToString(),
                    Gia = Convert.ToInt32(txtGia.Text),
                    TenSp = txtTen.Text,
                    SoLuong = Convert.ToInt32(txtSoLuong.Text),
                    Hinh = imageMang
                };

                dbo.SanPhams.Add(sanpham);
                dbo.SaveChanges();
                MessageBox.Show("Thêm sản phẩm thành công !");

                return;
            }
            catch
            {
                MessageBox.Show("Không thành công !");
            }

            

        }

        private void FrmThemSp_Load(object sender, EventArgs e)
        {
            
            cmbLoai.DataSource = dbo.PhanLoais.ToList();
            cmbLoai.DisplayMember = "TenLoai";
            cmbLoai.ValueMember = "MaLoai";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                file = openFile.FileName;
                
                pictureBox1.ImageLocation = file;
                Image myimage = Image.FromFile(file);
                pictureBox1.Image = myimage;

                FileStream fs = new FileStream(file, FileMode.Open, FileAccess.Read);

                imageMang = new byte[fs.Length];
                fs.Read(imageMang, 0, (int)fs.Length);
                
                
            }
        }

        private void FrmThemSp_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
    }
}
