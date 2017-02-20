using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Quản_lý_linh_kiện_máy_tính
{
    public partial class FrmSua : Form
    {
        QuanLyLinhKienEntity1 dbo = new QuanLyLinhKienEntity1();
        string file;
        byte[] imageMang;
        string get;
        
        public FrmSua(string ten, string loai)
        {
            get = ten;
            InitializeComponent();
            cmbLoai.DataSource = dbo.PhanLoais.ToList();
            cmbLoai.DisplayMember = "TenLoai";
            cmbLoai.ValueMember = "MaLoai";
            cmbLoai.Text = loai;
            txtTen.Text = ten;
            
            

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (txtTen.Text == "" || txtGia.Text == "" || txtSoLuong.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin !");
                return;
            }
            try
            {
                SanPham sp = dbo.SanPhams.First(d => d.TenSp == get);
                sp.Gia = Convert.ToInt32(txtGia.Text);
                sp.TenSp = txtTen.Text;
                sp.SoLuong = Convert.ToInt32(txtSoLuong.Text);
                sp.Hinh = imageMang;
                sp.MaLoai = cmbLoai.SelectedValue.ToString();
                dbo.SaveChanges();

                MessageBox.Show("Cập nhật thành công !");
            }
            catch
            {
                MessageBox.Show("Cập nhật không thành công !");
            }
        }

        private void FrmSua_Load(object sender, EventArgs e)
        {

            SanPham sp = dbo.SanPhams.First(d => d.TenSp == get);

            txtGia.Text = sp.Gia.ToString();
            txtSoLuong.Text = sp.SoLuong.ToString();
            imageMang = sp.Hinh;

            MemoryStream ms = new MemoryStream(sp.Hinh);
            Image img = Image.FromStream(ms);
            pictureBox1.Image = img;

            



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
    }
}
