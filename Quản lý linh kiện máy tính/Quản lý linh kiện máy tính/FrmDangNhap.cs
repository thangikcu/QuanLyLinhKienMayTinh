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


namespace Quản_lý_linh_kiện_máy_tính
{
    public partial class FrmDangNhap : Form
    {

        QuanLyLinhKienEntity1 dbo = new QuanLyLinhKienEntity1();
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((MessageBox.Show("Bạn thực sự muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text=="" || textBox2.Text=="")
            {
                label6.Visible = true;
                return;
            }

            TaiKhoan tk = new TaiKhoan();

            foreach (var user in dbo.TaiKhoans)
            {
                if (user.Ten.Trim() == textBox1.Text && user.MatKhau.Trim() == textBox2.Text)
                {
                    Program.tenTk = textBox1.Text;
                    Program.matKhau = textBox2.Text;
                    Program.quyen = user.Quyen.Trim();

                    FrmChinh frmchinh = new FrmChinh();
                    Hide();
                    frmchinh.ShowDialog();
                    Close();
                }
            }

            MessageBox.Show("Tài Khoản hoặc mật khẩu không đúng !");



           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {

        }
    }
}
