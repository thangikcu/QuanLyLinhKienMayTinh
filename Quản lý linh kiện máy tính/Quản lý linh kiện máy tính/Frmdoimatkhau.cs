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
    public partial class Frmdoimatkhau : Form
    {
        public Frmdoimatkhau()
        {
            InitializeComponent();
            
        }
        
        private void Frmdoimatkhau_Load(object sender, EventArgs e)
        {
            label2.Text = Program.quyen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtMatKhauHienTai.Text == "" || txtMatKhauMoi.Text == "" || txtNhapLai.Text == "")
            {
                MessageBox.Show("Bạn cần điền đầy đủ thông tin !");
                return;
            }

            if (txtMatKhauHienTai.Text != Program.matKhau)
            {
                MessageBox.Show("Mật khẩu cũ không đúng !");
                return;
            }

            if (txtMatKhauMoi.Text != txtNhapLai.Text)
            {
                MessageBox.Show("Mật khẩu mới không khớp !");
                return;
            }

            try
            {
                QuanLyLinhKienEntity1 dbo = new QuanLyLinhKienEntity1();

                TaiKhoan tk = dbo.TaiKhoans.First(t => t.Ten == Program.tenTk);

                tk.MatKhau = txtMatKhauMoi.Text;
                dbo.SaveChanges();

                MessageBox.Show("Đổi mật khẩu thành công !");
            }
            catch
            {
                MessageBox.Show("Đổi mật khẩu không thành công !");
            }



        }
    }
}
