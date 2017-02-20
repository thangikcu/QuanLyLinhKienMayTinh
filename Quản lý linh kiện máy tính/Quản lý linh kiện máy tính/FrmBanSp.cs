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
    public partial class FrmBanSp : Form
    {
        QuanLyLinhKienEntity1 dbo = new QuanLyLinhKienEntity1();
        SanPham sp;
        HoaDonEntityy hd = new HoaDonEntityy();
        public FrmBanSp(string tensp)
        {
            
            InitializeComponent();
            label1.Text = tensp;
        }

        private void FrmBanSp_Load(object sender, EventArgs e)
        {
            sp = dbo.SanPhams.First(d => d.TenSp == label1.Text);

            label4.Text = sp.Gia.ToString();
            MemoryStream ms = new MemoryStream(sp.Hinh);
            Image img = Image.FromStream(ms);
            pictureBox1.Image = img;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Bạn cần nhập đủ thông tin !");
                return;
            }
            try
            {
                SanPham sp = dbo.SanPhams.First(d => d.TenSp == label1.Text);
                if (sp.SoLuong - Convert.ToInt32(numericUpDown1.Value) >= 0)
                {
                    sp.SoLuong = sp.SoLuong - Convert.ToInt32(numericUpDown1.Value);
                    dbo.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Số lượng sản phẩm trong kho không đủ !");
                    return;
                }

                Hoa_Don hoadon = new Hoa_Don()
                {
                    TenKh = textBox1.Text,
                    SoDt = Convert.ToInt32(textBox2.Text),
                    SoLuong = Convert.ToInt32(numericUpDown1.Value),
                    SanPham = label1.Text,
                    TongTien = Convert.ToInt32(label4.Text),
                    NgayBan = DateTime.Today
                };
                hd.Hoa_Don.Add(hoadon);
                hd.SaveChanges();

                SaveFileDialog save = new SaveFileDialog();
                if (save.ShowDialog() == DialogResult.OK)
                {
                    string noidung= " \r\n Tên sản phẩm:   "+label1.Text+" \r\n Khách hàng:   "+textBox1.Text+"  \r\n Số điện thoại:   "+textBox2.Text+"  \r\n Số lượng:   "+numericUpDown1.Text+"  \r\n Thành tiền:   "+label4.Text+" VNĐ \r\n Ngày bán: "+DateTime.Today+"";
                    File.WriteAllText(save.FileName,noidung);
                }

                MessageBox.Show("Thanh toán thành công !");
            }
            catch
            {
                MessageBox.Show("Thanh toán thất bại !");
            }
        }

        private void numericUpDown1_MouseDown(object sender, MouseEventArgs e)
        {
            if (numericUpDown1.Value < 1)
            {
                MessageBox.Show("Số lượng nhỏ nhất rồi !");
                numericUpDown1.Value++;
                return;
            }
            label4.Text = (sp.Gia * numericUpDown1.Value).ToString();
        }


    }
}
