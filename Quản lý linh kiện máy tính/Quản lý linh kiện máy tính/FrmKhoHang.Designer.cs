namespace Quản_lý_linh_kiện_máy_tính
{
    partial class FrmKhoHang
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblLuong = new System.Windows.Forms.Label();
            this.lblprice = new System.Windows.Forms.Label();
            this.lblKieu = new System.Windows.Forms.Label();
            this.lblname = new System.Windows.Forms.Label();
            this.btnBan = new System.Windows.Forms.Button();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGia = new System.Windows.Forms.Label();
            this.lblten = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvsp = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsp)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiem.Location = new System.Drawing.Point(262, 199);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(87, 23);
            this.btnTimKiem.TabIndex = 3;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(14, 201);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(241, 20);
            this.txtTimKiem.TabIndex = 2;
            this.txtTimKiem.TextChanged += new System.EventHandler(this.txtTimKiem_TextChanged);
            // 
            // cmbLoai
            // 
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Items.AddRange(new object[] {
            "   "});
            this.cmbLoai.Location = new System.Drawing.Point(427, 201);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(170, 21);
            this.cmbLoai.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblLuong);
            this.groupBox1.Controls.Add(this.lblprice);
            this.groupBox1.Controls.Add(this.lblKieu);
            this.groupBox1.Controls.Add(this.lblname);
            this.groupBox1.Controls.Add(this.btnBan);
            this.groupBox1.Controls.Add(this.lblSoLuong);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lblGia);
            this.groupBox1.Controls.Add(this.lblten);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(744, 173);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sản phẩm";
            // 
            // lblLuong
            // 
            this.lblLuong.AutoSize = true;
            this.lblLuong.Location = new System.Drawing.Point(403, 147);
            this.lblLuong.Name = "lblLuong";
            this.lblLuong.Size = new System.Drawing.Size(19, 13);
            this.lblLuong.TabIndex = 6;
            this.lblLuong.Text = "...";
            // 
            // lblprice
            // 
            this.lblprice.AutoSize = true;
            this.lblprice.Location = new System.Drawing.Point(403, 112);
            this.lblprice.Name = "lblprice";
            this.lblprice.Size = new System.Drawing.Size(19, 13);
            this.lblprice.TabIndex = 6;
            this.lblprice.Text = "...";
            // 
            // lblKieu
            // 
            this.lblKieu.AutoSize = true;
            this.lblKieu.Location = new System.Drawing.Point(403, 75);
            this.lblKieu.Name = "lblKieu";
            this.lblKieu.Size = new System.Drawing.Size(19, 13);
            this.lblKieu.TabIndex = 6;
            this.lblKieu.Text = "...";
            // 
            // lblname
            // 
            this.lblname.AutoSize = true;
            this.lblname.Location = new System.Drawing.Point(403, 42);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(19, 13);
            this.lblname.TabIndex = 6;
            this.lblname.Text = "...";
            // 
            // btnBan
            // 
            this.btnBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(1)))), ((int)(((byte)(168)))));
            this.btnBan.BackgroundImage = global::Quản_lý_linh_kiện_máy_tính.Properties.Resources.NhapDiem2;
            this.btnBan.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBan.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBan.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBan.ForeColor = System.Drawing.Color.White;
            this.btnBan.Location = new System.Drawing.Point(625, 84);
            this.btnBan.Name = "btnBan";
            this.btnBan.Size = new System.Drawing.Size(113, 83);
            this.btnBan.TabIndex = 5;
            this.btnBan.Text = "Bán";
            this.btnBan.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnBan.UseVisualStyleBackColor = false;
            this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.ForeColor = System.Drawing.Color.White;
            this.lblSoLuong.Location = new System.Drawing.Point(301, 140);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(87, 23);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Số lượng :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(343, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 23);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại:";
            // 
            // lblGia
            // 
            this.lblGia.AutoSize = true;
            this.lblGia.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGia.ForeColor = System.Drawing.Color.White;
            this.lblGia.Location = new System.Drawing.Point(349, 105);
            this.lblGia.Name = "lblGia";
            this.lblGia.Size = new System.Drawing.Size(39, 23);
            this.lblGia.TabIndex = 2;
            this.lblGia.Text = "Giá:";
            // 
            // lblten
            // 
            this.lblten.AutoSize = true;
            this.lblten.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblten.ForeColor = System.Drawing.Color.White;
            this.lblten.Location = new System.Drawing.Point(266, 35);
            this.lblten.Name = "lblten";
            this.lblten.Size = new System.Drawing.Size(122, 23);
            this.lblten.TabIndex = 2;
            this.lblten.Text = "Tên sản phẩm:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(7, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 148);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.Purple;
            this.btnSua.BackgroundImage = global::Quản_lý_linh_kiện_máy_tính.Properties.Resources.sua;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSua.Location = new System.Drawing.Point(650, 390);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(73, 68);
            this.btnSua.TabIndex = 7;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Teal;
            this.btnXoa.BackgroundImage = global::Quản_lý_linh_kiện_máy_tính.Properties.Resources.Xoa;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnXoa.Location = new System.Drawing.Point(650, 464);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(73, 68);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Green;
            this.btnThem.BackgroundImage = global::Quản_lý_linh_kiện_máy_tính.Properties.Resources.Them;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnThem.Location = new System.Drawing.Point(650, 316);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(73, 68);
            this.btnThem.TabIndex = 9;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvsp
            // 
            this.dgvsp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvsp.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvsp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvsp.Location = new System.Drawing.Point(10, 242);
            this.dgvsp.Name = "dgvsp";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver;
            this.dgvsp.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvsp.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvsp.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvsp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvsp.Size = new System.Drawing.Size(587, 285);
            this.dgvsp.TabIndex = 10;
            this.dgvsp.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvsp_CellClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(648, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 68);
            this.button1.TabIndex = 11;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmKhoHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(770, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvsp);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbLoai);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.Name = "FrmKhoHang";
            this.Text = "Kho hàng";
            this.Load += new System.EventHandler(this.FrmKhoHang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvsp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBan;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblGia;
        private System.Windows.Forms.Label lblten;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLuong;
        private System.Windows.Forms.Label lblprice;
        private System.Windows.Forms.Label lblKieu;
        private System.Windows.Forms.Label lblname;
        private System.Windows.Forms.DataGridView dgvsp;
        private System.Windows.Forms.Button button1;
    }
}