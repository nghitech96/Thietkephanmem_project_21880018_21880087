namespace Quanly_NhaSach.UI
{
    partial class frmHoaDonBanHang
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvHoaDonBanHang = new System.Windows.Forms.DataGridView();
            this.ColNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIDKhachhang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtHoaDonBanHangId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.btnAddSach = new System.Windows.Forms.Button();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOldMaHD = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKhachhang = new System.Windows.Forms.Button();
            this.ColSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenSach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColIDPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBanHang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(388, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "Thông tin Hóa đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(932, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày";
            // 
            // dgvHoaDonBanHang
            // 
            this.dgvHoaDonBanHang.AllowUserToAddRows = false;
            this.dgvHoaDonBanHang.AllowUserToDeleteRows = false;
            this.dgvHoaDonBanHang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvHoaDonBanHang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDonBanHang.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNgay,
            this.ColMaPhieu,
            this.ColTongTien,
            this.ColIDKhachhang});
            this.dgvHoaDonBanHang.Location = new System.Drawing.Point(1, 9);
            this.dgvHoaDonBanHang.Name = "dgvHoaDonBanHang";
            this.dgvHoaDonBanHang.ReadOnly = true;
            this.dgvHoaDonBanHang.RowHeadersWidth = 51;
            this.dgvHoaDonBanHang.RowTemplate.Height = 29;
            this.dgvHoaDonBanHang.Size = new System.Drawing.Size(342, 690);
            this.dgvHoaDonBanHang.TabIndex = 15;
            this.dgvHoaDonBanHang.SelectionChanged += new System.EventHandler(this.dgvHoaDonBanHang_SelectionChanged);
            // 
            // ColNgay
            // 
            this.ColNgay.DataPropertyName = "Ngay";
            this.ColNgay.Frozen = true;
            this.ColNgay.HeaderText = "Ngày";
            this.ColNgay.MinimumWidth = 6;
            this.ColNgay.Name = "ColNgay";
            this.ColNgay.ReadOnly = true;
            this.ColNgay.Width = 150;
            // 
            // ColMaPhieu
            // 
            this.ColMaPhieu.DataPropertyName = "Id";
            this.ColMaPhieu.HeaderText = "Mã phiếu";
            this.ColMaPhieu.MinimumWidth = 6;
            this.ColMaPhieu.Name = "ColMaPhieu";
            this.ColMaPhieu.ReadOnly = true;
            this.ColMaPhieu.Width = 125;
            // 
            // ColTongTien
            // 
            this.ColTongTien.DataPropertyName = "ThanhTien";
            this.ColTongTien.HeaderText = "Tổng tiền";
            this.ColTongTien.MinimumWidth = 6;
            this.ColTongTien.Name = "ColTongTien";
            this.ColTongTien.ReadOnly = true;
            this.ColTongTien.Width = 125;
            // 
            // ColIDKhachhang
            // 
            this.ColIDKhachhang.DataPropertyName = "IdKhachHang";
            this.ColIDKhachhang.HeaderText = "Khách hàng";
            this.ColIDKhachhang.MinimumWidth = 6;
            this.ColIDKhachhang.Name = "ColIDKhachhang";
            this.ColIDKhachhang.ReadOnly = true;
            this.ColIDKhachhang.Width = 125;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(464, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 29);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(538, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(66, 29);
            this.btnUpdate.TabIndex = 11;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(612, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 29);
            this.btnDelete.TabIndex = 12;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(686, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(66, 29);
            this.btnFind.TabIndex = 13;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(760, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(66, 29);
            this.btnClose.TabIndex = 14;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtHoaDonBanHangId
            // 
            this.txtHoaDonBanHangId.Location = new System.Drawing.Point(519, 88);
            this.txtHoaDonBanHangId.Name = "txtHoaDonBanHangId";
            this.txtHoaDonBanHangId.Size = new System.Drawing.Size(427, 27);
            this.txtHoaDonBanHangId.TabIndex = 3;
            this.txtHoaDonBanHangId.TextChanged += new System.EventHandler(this.txtHoaDonBanHangId_TextChanged);
            this.txtHoaDonBanHangId.Leave += new System.EventHandler(this.txtHoaDonBanHangId_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(424, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã HĐ";
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(388, 4);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(66, 29);
            this.btnGetAll.TabIndex = 9;
            this.btnGetAll.Text = "All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Visible = false;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(982, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(126, 27);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dgvChiTiet
            // 
            this.dgvChiTiet.AllowUserToAddRows = false;
            this.dgvChiTiet.AllowUserToDeleteRows = false;
            this.dgvChiTiet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvChiTiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChiTiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSTT,
            this.ColTenSach,
            this.ColDonGia,
            this.ColSoluong,
            this.ColTien,
            this.ColMaHD,
            this.ColIDPhieu});
            this.dgvChiTiet.Location = new System.Drawing.Point(382, 173);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersWidth = 51;
            this.dgvChiTiet.RowTemplate.Height = 29;
            this.dgvChiTiet.Size = new System.Drawing.Size(788, 524);
            this.dgvChiTiet.TabIndex = 6;
            this.dgvChiTiet.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvChiTiet_CellBeginEdit);
            this.dgvChiTiet.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTiet_CellValueChanged);
            this.dgvChiTiet.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvChiTiet_EditingControlShowing);
            // 
            // btnAddSach
            // 
            this.btnAddSach.Location = new System.Drawing.Point(1176, 249);
            this.btnAddSach.Name = "btnAddSach";
            this.btnAddSach.Size = new System.Drawing.Size(34, 29);
            this.btnAddSach.TabIndex = 7;
            this.btnAddSach.Text = "+";
            this.btnAddSach.UseVisualStyleBackColor = true;
            this.btnAddSach.Click += new System.EventHandler(this.btnAddSach_Click);
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Location = new System.Drawing.Point(1176, 287);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(34, 29);
            this.btnXoaSach.TabIndex = 8;
            this.btnXoaSach.Text = "-";
            this.btnXoaSach.UseVisualStyleBackColor = true;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Location = new System.Drawing.Point(523, 126);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(423, 28);
            this.cbKhachHang.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Khách hàng";
            // 
            // txtOldMaHD
            // 
            this.txtOldMaHD.Location = new System.Drawing.Point(349, 82);
            this.txtOldMaHD.Name = "txtOldMaHD";
            this.txtOldMaHD.Size = new System.Drawing.Size(51, 27);
            this.txtOldMaHD.TabIndex = 18;
            this.txtOldMaHD.Text = "0";
            this.txtOldMaHD.Visible = false;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(1016, 129);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(140, 27);
            this.txtTongTien.TabIndex = 19;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1022, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Tổng tiền";
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.Location = new System.Drawing.Point(946, 125);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Size = new System.Drawing.Size(34, 29);
            this.btnKhachhang.TabIndex = 21;
            this.btnKhachhang.Text = "+";
            this.btnKhachhang.UseVisualStyleBackColor = true;
            this.btnKhachhang.Click += new System.EventHandler(this.btnKhachhang_Click);
            // 
            // ColSTT
            // 
            this.ColSTT.DataPropertyName = "STT";
            this.ColSTT.HeaderText = "STT";
            this.ColSTT.MinimumWidth = 6;
            this.ColSTT.Name = "ColSTT";
            this.ColSTT.ReadOnly = true;
            this.ColSTT.Width = 50;
            // 
            // ColTenSach
            // 
            this.ColTenSach.DataPropertyName = "IdSach";
            this.ColTenSach.HeaderText = "Tên sách";
            this.ColTenSach.MinimumWidth = 6;
            this.ColTenSach.Name = "ColTenSach";
            this.ColTenSach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColTenSach.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColTenSach.Width = 350;
            // 
            // ColDonGia
            // 
            this.ColDonGia.DataPropertyName = "Dongia";
            this.ColDonGia.HeaderText = "Đơn giá";
            this.ColDonGia.MinimumWidth = 6;
            this.ColDonGia.Name = "ColDonGia";
            this.ColDonGia.Width = 125;
            // 
            // ColSoluong
            // 
            this.ColSoluong.DataPropertyName = "Soluong";
            this.ColSoluong.HeaderText = "Số lượng";
            this.ColSoluong.MinimumWidth = 6;
            this.ColSoluong.Name = "ColSoluong";
            this.ColSoluong.Width = 125;
            // 
            // ColTien
            // 
            this.ColTien.DataPropertyName = "TTien";
            this.ColTien.HeaderText = "Thành Tiền";
            this.ColTien.MinimumWidth = 6;
            this.ColTien.Name = "ColTien";
            this.ColTien.ReadOnly = true;
            this.ColTien.Width = 125;
            // 
            // ColMaHD
            // 
            this.ColMaHD.DataPropertyName = "idHoadon";
            this.ColMaHD.HeaderText = "Mã HĐ";
            this.ColMaHD.MinimumWidth = 6;
            this.ColMaHD.Name = "ColMaHD";
            this.ColMaHD.ReadOnly = true;
            this.ColMaHD.Visible = false;
            this.ColMaHD.Width = 125;
            // 
            // ColIDPhieu
            // 
            this.ColIDPhieu.DataPropertyName = "Id";
            this.ColIDPhieu.HeaderText = "ID Phiếu";
            this.ColIDPhieu.MinimumWidth = 6;
            this.ColIDPhieu.Name = "ColIDPhieu";
            this.ColIDPhieu.Visible = false;
            this.ColIDPhieu.Width = 125;
            // 
            // frmHoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 700);
            this.Controls.Add(this.btnKhachhang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtOldMaHD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbKhachHang);
            this.Controls.Add(this.btnXoaSach);
            this.Controls.Add(this.btnAddSach);
            this.Controls.Add(this.dgvChiTiet);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.txtHoaDonBanHangId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvHoaDonBanHang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHoaDonBanHang";
            this.Text = "Hóa đơn bán hàng";
            this.Load += new System.EventHandler(this.frmHoaDonBanHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDonBanHang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvHoaDonBanHang;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtHoaDonBanHangId;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Button btnAddSach;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOldMaHD;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDKhachhang;
        private System.Windows.Forms.Button btnKhachhang;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSTT;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDPhieu;
    }
}