﻿namespace Quản_lý_linh_kiện_máy_tính
{
    partial class FrmThemSp
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
            this.btnLuu = new System.Windows.Forms.Button();
            this.gbthemSp = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmbLoai = new System.Windows.Forms.ComboBox();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtGia = new System.Windows.Forms.TextBox();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.lblgia = new System.Windows.Forms.Label();
            this.txtMaSp = new System.Windows.Forms.TextBox();
            this.lblTen = new System.Windows.Forms.Label();
            this.lblLoai = new System.Windows.Forms.Label();
            this.lblMaSp = new System.Windows.Forms.Label();
            this.btnnhaplai = new System.Windows.Forms.Button();
            this.gbthemSp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.Orange;
            this.btnLuu.BackgroundImage = global::Quản_lý_linh_kiện_máy_tính.Properties.Resources.Luu;
            this.btnLuu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLuu.Location = new System.Drawing.Point(236, 238);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(73, 68);
            this.btnLuu.TabIndex = 5;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // gbthemSp
            // 
            this.gbthemSp.Controls.Add(this.pictureBox1);
            this.gbthemSp.Controls.Add(this.cmbLoai);
            this.gbthemSp.Controls.Add(this.txtSoLuong);
            this.gbthemSp.Controls.Add(this.txtGia);
            this.gbthemSp.Controls.Add(this.lblSoLuong);
            this.gbthemSp.Controls.Add(this.txtTen);
            this.gbthemSp.Controls.Add(this.lblgia);
            this.gbthemSp.Controls.Add(this.txtMaSp);
            this.gbthemSp.Controls.Add(this.lblTen);
            this.gbthemSp.Controls.Add(this.lblLoai);
            this.gbthemSp.Controls.Add(this.lblMaSp);
            this.gbthemSp.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbthemSp.ForeColor = System.Drawing.Color.White;
            this.gbthemSp.Location = new System.Drawing.Point(12, 12);
            this.gbthemSp.Name = "gbthemSp";
            this.gbthemSp.Size = new System.Drawing.Size(642, 220);
            this.gbthemSp.TabIndex = 6;
            this.gbthemSp.TabStop = false;
            this.gbthemSp.Text = "Sản phẩm";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(6, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(209, 193);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // cmbLoai
            // 
            this.cmbLoai.FormattingEnabled = true;
            this.cmbLoai.Location = new System.Drawing.Point(422, 102);
            this.cmbLoai.Name = "cmbLoai";
            this.cmbLoai.Size = new System.Drawing.Size(148, 23);
            this.cmbLoai.TabIndex = 9;
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(422, 181);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(60, 23);
            this.txtSoLuong.TabIndex = 6;
            // 
            // txtGia
            // 
            this.txtGia.Location = new System.Drawing.Point(422, 144);
            this.txtGia.Name = "txtGia";
            this.txtGia.Size = new System.Drawing.Size(109, 23);
            this.txtGia.TabIndex = 6;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Location = new System.Drawing.Point(304, 177);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(82, 23);
            this.lblSoLuong.TabIndex = 0;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(422, 65);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(202, 23);
            this.txtTen.TabIndex = 6;
            // 
            // lblgia
            // 
            this.lblgia.AutoSize = true;
            this.lblgia.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgia.Location = new System.Drawing.Point(347, 140);
            this.lblgia.Name = "lblgia";
            this.lblgia.Size = new System.Drawing.Size(39, 23);
            this.lblgia.TabIndex = 0;
            this.lblgia.Text = "Giá:";
            // 
            // txtMaSp
            // 
            this.txtMaSp.Location = new System.Drawing.Point(422, 24);
            this.txtMaSp.Name = "txtMaSp";
            this.txtMaSp.Size = new System.Drawing.Size(95, 23);
            this.txtMaSp.TabIndex = 6;
            // 
            // lblTen
            // 
            this.lblTen.AutoSize = true;
            this.lblTen.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Location = new System.Drawing.Point(264, 61);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(122, 23);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên sản phẩm:";
            // 
            // lblLoai
            // 
            this.lblLoai.AutoSize = true;
            this.lblLoai.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoai.Location = new System.Drawing.Point(261, 98);
            this.lblLoai.Name = "lblLoai";
            this.lblLoai.Size = new System.Drawing.Size(125, 23);
            this.lblLoai.TabIndex = 4;
            this.lblLoai.Text = "Loại sản phẩm:";
            // 
            // lblMaSp
            // 
            this.lblMaSp.AutoSize = true;
            this.lblMaSp.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaSp.Location = new System.Drawing.Point(268, 20);
            this.lblMaSp.Name = "lblMaSp";
            this.lblMaSp.Size = new System.Drawing.Size(118, 23);
            this.lblMaSp.TabIndex = 0;
            this.lblMaSp.Text = "Mã sản phẩm:";
            // 
            // btnnhaplai
            // 
            this.btnnhaplai.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnnhaplai.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnnhaplai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnnhaplai.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnnhaplai.Font = new System.Drawing.Font("Segoe UI", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnnhaplai.ForeColor = System.Drawing.Color.White;
            this.btnnhaplai.Location = new System.Drawing.Point(363, 238);
            this.btnnhaplai.Name = "btnnhaplai";
            this.btnnhaplai.Size = new System.Drawing.Size(73, 68);
            this.btnnhaplai.TabIndex = 7;
            this.btnnhaplai.Text = "Nhập lại";
            this.btnnhaplai.UseVisualStyleBackColor = false;
            this.btnnhaplai.Click += new System.EventHandler(this.btnnhaplai_Click);
            // 
            // FrmThemSp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(0)))), ((int)(((byte)(62)))));
            this.ClientSize = new System.Drawing.Size(666, 316);
            this.Controls.Add(this.btnnhaplai);
            this.Controls.Add(this.gbthemSp);
            this.Controls.Add(this.btnLuu);
            this.Name = "FrmThemSp";
            this.Text = "Thêm sản phẩm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmThemSp_FormClosed);
            this.Load += new System.EventHandler(this.FrmThemSp_Load);
            this.gbthemSp.ResumeLayout(false);
            this.gbthemSp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.GroupBox gbthemSp;
        private System.Windows.Forms.ComboBox cmbLoai;
        private System.Windows.Forms.TextBox txtMaSp;
        private System.Windows.Forms.Label lblLoai;
        private System.Windows.Forms.Label lblMaSp;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label lblTen;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtGia;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.Label lblgia;
        private System.Windows.Forms.Button btnnhaplai;
    }
}