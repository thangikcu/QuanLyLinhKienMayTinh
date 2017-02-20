namespace Quản_lý_linh_kiện_máy_tính
{
    partial class FrmHoaDon
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnTimKiem = new System.Windows.Forms.Button();
            this.txtTimKiem = new System.Windows.Forms.TextBox();
            this.dgvhd = new System.Windows.Forms.DataGridView();
            this.quanLyLinhKienDataSet1 = new Quản_lý_linh_kiện_máy_tính.QuanLyLinhKienDataSet1();
            this.hoaDonBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hoa_DonTableAdapter = new Quản_lý_linh_kiện_máy_tính.QuanLyLinhKienDataSet1TableAdapters.Hoa_DonTableAdapter();
            this.maKhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenKhDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soDtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sanPhamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soLuongDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongTienDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ngayBanDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyLinhKienDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTimKiem.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTimKiem.Location = new System.Drawing.Point(327, 34);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Size = new System.Drawing.Size(87, 23);
            this.btnTimKiem.TabIndex = 13;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.UseVisualStyleBackColor = false;
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // txtTimKiem
            // 
            this.txtTimKiem.Location = new System.Drawing.Point(97, 36);
            this.txtTimKiem.Name = "txtTimKiem";
            this.txtTimKiem.Size = new System.Drawing.Size(211, 20);
            this.txtTimKiem.TabIndex = 12;
            // 
            // dgvhd
            // 
            this.dgvhd.AutoGenerateColumns = false;
            this.dgvhd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvhd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvhd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.maKhDataGridViewTextBoxColumn,
            this.tenKhDataGridViewTextBoxColumn,
            this.soDtDataGridViewTextBoxColumn,
            this.sanPhamDataGridViewTextBoxColumn,
            this.soLuongDataGridViewTextBoxColumn,
            this.tongTienDataGridViewTextBoxColumn,
            this.ngayBanDataGridViewTextBoxColumn});
            this.dgvhd.DataSource = this.hoaDonBindingSource;
            this.dgvhd.Location = new System.Drawing.Point(12, 79);
            this.dgvhd.Name = "dgvhd";
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Silver;
            this.dgvhd.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvhd.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dgvhd.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.White;
            this.dgvhd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvhd.Size = new System.Drawing.Size(541, 218);
            this.dgvhd.TabIndex = 11;
            // 
            // quanLyLinhKienDataSet1
            // 
            this.quanLyLinhKienDataSet1.DataSetName = "QuanLyLinhKienDataSet1";
            this.quanLyLinhKienDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // hoaDonBindingSource
            // 
            this.hoaDonBindingSource.DataMember = "Hoa_Don";
            this.hoaDonBindingSource.DataSource = this.quanLyLinhKienDataSet1;
            // 
            // hoa_DonTableAdapter
            // 
            this.hoa_DonTableAdapter.ClearBeforeFill = true;
            // 
            // maKhDataGridViewTextBoxColumn
            // 
            this.maKhDataGridViewTextBoxColumn.DataPropertyName = "MaKh";
            this.maKhDataGridViewTextBoxColumn.HeaderText = "Mã khách hàng";
            this.maKhDataGridViewTextBoxColumn.Name = "maKhDataGridViewTextBoxColumn";
            this.maKhDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tenKhDataGridViewTextBoxColumn
            // 
            this.tenKhDataGridViewTextBoxColumn.DataPropertyName = "TenKh";
            this.tenKhDataGridViewTextBoxColumn.HeaderText = "Tên khách hàng";
            this.tenKhDataGridViewTextBoxColumn.Name = "tenKhDataGridViewTextBoxColumn";
            // 
            // soDtDataGridViewTextBoxColumn
            // 
            this.soDtDataGridViewTextBoxColumn.DataPropertyName = "SoDt";
            this.soDtDataGridViewTextBoxColumn.HeaderText = "Số điện thoại";
            this.soDtDataGridViewTextBoxColumn.Name = "soDtDataGridViewTextBoxColumn";
            // 
            // sanPhamDataGridViewTextBoxColumn
            // 
            this.sanPhamDataGridViewTextBoxColumn.DataPropertyName = "SanPham";
            this.sanPhamDataGridViewTextBoxColumn.HeaderText = "Sản phẩm";
            this.sanPhamDataGridViewTextBoxColumn.Name = "sanPhamDataGridViewTextBoxColumn";
            // 
            // soLuongDataGridViewTextBoxColumn
            // 
            this.soLuongDataGridViewTextBoxColumn.DataPropertyName = "SoLuong";
            this.soLuongDataGridViewTextBoxColumn.HeaderText = "Số lượng";
            this.soLuongDataGridViewTextBoxColumn.Name = "soLuongDataGridViewTextBoxColumn";
            // 
            // tongTienDataGridViewTextBoxColumn
            // 
            this.tongTienDataGridViewTextBoxColumn.DataPropertyName = "TongTien";
            this.tongTienDataGridViewTextBoxColumn.HeaderText = "Tổng tiền";
            this.tongTienDataGridViewTextBoxColumn.Name = "tongTienDataGridViewTextBoxColumn";
            // 
            // ngayBanDataGridViewTextBoxColumn
            // 
            this.ngayBanDataGridViewTextBoxColumn.DataPropertyName = "NgayBan";
            this.ngayBanDataGridViewTextBoxColumn.HeaderText = "Ngày bán";
            this.ngayBanDataGridViewTextBoxColumn.Name = "ngayBanDataGridViewTextBoxColumn";
            // 
            // FrmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(565, 309);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimKiem);
            this.Controls.Add(this.dgvhd);
            this.Name = "FrmHoaDon";
            this.Text = "Quản lý hóa đơn";
            this.Load += new System.EventHandler(this.FrmHoaDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyLinhKienDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hoaDonBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTimKiem;
        private System.Windows.Forms.TextBox txtTimKiem;
        private System.Windows.Forms.DataGridView dgvhd;
        private QuanLyLinhKienDataSet1 quanLyLinhKienDataSet1;
        private System.Windows.Forms.BindingSource hoaDonBindingSource;
        private QuanLyLinhKienDataSet1TableAdapters.Hoa_DonTableAdapter hoa_DonTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn maKhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenKhDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soDtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sanPhamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soLuongDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongTienDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ngayBanDataGridViewTextBoxColumn;
    }
}