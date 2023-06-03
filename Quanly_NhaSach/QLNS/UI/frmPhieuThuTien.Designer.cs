namespace Quanly_NhaSach.UI
{
    partial class frmPhieuThuTien
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtPhieuThuTien = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvPhieuthu = new System.Windows.Forms.DataGridView();
            this.ColNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenKH = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cbKhachHang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOldMaHD = new System.Windows.Forms.TextBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuthu)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(75, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 41);
            this.label1.TabIndex = 16;
            this.label1.Text = "Thông tin Phiếu thu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(586, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ngày";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(213, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(80, 28);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(297, 140);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 28);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(381, 140);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 28);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(465, 140);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(80, 28);
            this.btnFind.TabIndex = 12;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(549, 140);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(80, 28);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtPhieuThuTien
            // 
            this.txtPhieuThuTien.Location = new System.Drawing.Point(152, 63);
            this.txtPhieuThuTien.Name = "txtPhieuThuTien";
            this.txtPhieuThuTien.Size = new System.Drawing.Size(441, 27);
            this.txtPhieuThuTien.TabIndex = 3;
            this.txtPhieuThuTien.TextChanged += new System.EventHandler(this.txtPhieuThuTienId_TextChanged);
            this.txtPhieuThuTien.Leave += new System.EventHandler(this.txtPhieuThuTienId_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã HĐ";
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(129, 140);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(80, 28);
            this.btnGetAll.TabIndex = 8;
            this.btnGetAll.Text = "All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Visible = false;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(638, 30);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(140, 27);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dgvPhieuthu
            // 
            this.dgvPhieuthu.AllowUserToAddRows = false;
            this.dgvPhieuthu.AllowUserToDeleteRows = false;
            this.dgvPhieuthu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhieuthu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuthu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNgay,
            this.ColID,
            this.ColTenKH,
            this.ColTien});
            this.dgvPhieuthu.Location = new System.Drawing.Point(-1, 177);
            this.dgvPhieuthu.Name = "dgvPhieuthu";
            this.dgvPhieuthu.ReadOnly = true;
            this.dgvPhieuthu.RowHeadersWidth = 51;
            this.dgvPhieuthu.RowTemplate.Height = 29;
            this.dgvPhieuthu.Size = new System.Drawing.Size(806, 523);
            this.dgvPhieuthu.TabIndex = 14;
            this.dgvPhieuthu.SelectionChanged += new System.EventHandler(this.dgvPhieuthu_SelectionChanged);
            // 
            // ColNgay
            // 
            this.ColNgay.DataPropertyName = "Ngay";
            this.ColNgay.HeaderText = "Ngày";
            this.ColNgay.MinimumWidth = 6;
            this.ColNgay.Name = "ColNgay";
            this.ColNgay.ReadOnly = true;
            this.ColNgay.Width = 125;
            // 
            // ColID
            // 
            this.ColID.DataPropertyName = "Id";
            this.ColID.HeaderText = "Mã Phiếu";
            this.ColID.MinimumWidth = 6;
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            this.ColID.Width = 125;
            // 
            // ColTenKH
            // 
            this.ColTenKH.DataPropertyName = "IdKhachHang";
            this.ColTenKH.HeaderText = "Tên Khách hàng";
            this.ColTenKH.MinimumWidth = 6;
            this.ColTenKH.Name = "ColTenKH";
            this.ColTenKH.ReadOnly = true;
            this.ColTenKH.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColTenKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.ColTenKH.Width = 350;
            // 
            // ColTien
            // 
            this.ColTien.DataPropertyName = "Tien";
            this.ColTien.HeaderText = "Thành Tiền";
            this.ColTien.MinimumWidth = 6;
            this.ColTien.Name = "ColTien";
            this.ColTien.ReadOnly = true;
            this.ColTien.Width = 125;
            // 
            // cbKhachHang
            // 
            this.cbKhachHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbKhachHang.FormattingEnabled = true;
            this.cbKhachHang.Location = new System.Drawing.Point(152, 101);
            this.cbKhachHang.Name = "cbKhachHang";
            this.cbKhachHang.Size = new System.Drawing.Size(437, 28);
            this.cbKhachHang.TabIndex = 5;
            this.cbKhachHang.SelectedIndexChanged += new System.EventHandler(this.cbKhachHang_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Khách hàng";
            // 
            // txtOldMaHD
            // 
            this.txtOldMaHD.Location = new System.Drawing.Point(-1, 0);
            this.txtOldMaHD.Name = "txtOldMaHD";
            this.txtOldMaHD.Size = new System.Drawing.Size(51, 27);
            this.txtOldMaHD.TabIndex = 15;
            this.txtOldMaHD.Text = "0";
            this.txtOldMaHD.Visible = false;
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(623, 100);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Size = new System.Drawing.Size(154, 27);
            this.txtTongTien.TabIndex = 7;
            this.txtTongTien.TextChanged += new System.EventHandler(this.txtTongTien_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(643, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Tổng tiền";
            // 
            // frmPhieuThuTien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 700);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtOldMaHD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbKhachHang);
            this.Controls.Add(this.dgvPhieuthu);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.txtPhieuThuTien);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPhieuThuTien";
            this.Text = "Danh sách Phiếu thu tiền";
            this.Load += new System.EventHandler(this.frmPhieuThuTien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuthu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhieuThuTien;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvPhieuthu;
        private System.Windows.Forms.ComboBox cbKhachHang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOldMaHD;
        private System.Windows.Forms.TextBox txtTongTien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColTenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTien;
    }
}