namespace Quanly_NhaSach.UI
{
    partial class frmPhieuNhapSach
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
            this.dgvPhieuNhapSach = new System.Windows.Forms.DataGridView();
            this.ColNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnFind = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtPhieuNhapSachId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGetAll = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dgvChiTiet = new System.Windows.Forms.DataGridView();
            this.ColIDPhieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenSach = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColSoluong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddSach = new System.Windows.Forms.Button();
            this.btnXoaSach = new System.Windows.Forms.Button();
            this.txtOldIdPhieu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhapSach)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(589, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thông tin Phiếu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày";
            // 
            // dgvPhieuNhapSach
            // 
            this.dgvPhieuNhapSach.AllowUserToAddRows = false;
            this.dgvPhieuNhapSach.AllowUserToDeleteRows = false;
            this.dgvPhieuNhapSach.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvPhieuNhapSach.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhieuNhapSach.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNgay,
            this.ColMaPhieu});
            this.dgvPhieuNhapSach.Location = new System.Drawing.Point(1, 9);
            this.dgvPhieuNhapSach.Name = "dgvPhieuNhapSach";
            this.dgvPhieuNhapSach.RowHeadersWidth = 51;
            this.dgvPhieuNhapSach.RowTemplate.Height = 29;
            this.dgvPhieuNhapSach.Size = new System.Drawing.Size(342, 507);
            this.dgvPhieuNhapSach.TabIndex = 14;
            this.dgvPhieuNhapSach.SelectionChanged += new System.EventHandler(this.dgvPhieuNhapSach_SelectionChanged);
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
            this.ColMaPhieu.Width = 125;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(464, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(66, 29);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(538, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(66, 29);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(612, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(66, 29);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(686, 4);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(66, 29);
            this.btnFind.TabIndex = 12;
            this.btnFind.Text = "Tìm";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(760, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(66, 29);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtPhieuNhapSachId
            // 
            this.txtPhieuNhapSachId.Location = new System.Drawing.Point(535, 131);
            this.txtPhieuNhapSachId.Name = "txtPhieuNhapSachId";
            this.txtPhieuNhapSachId.Size = new System.Drawing.Size(427, 27);
            this.txtPhieuNhapSachId.TabIndex = 4;
            this.txtPhieuNhapSachId.TextChanged += new System.EventHandler(this.txtPhieuNhapSachId_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(430, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mã phiếu";
            // 
            // btnGetAll
            // 
            this.btnGetAll.Location = new System.Drawing.Point(388, 4);
            this.btnGetAll.Name = "btnGetAll";
            this.btnGetAll.Size = new System.Drawing.Size(66, 29);
            this.btnGetAll.TabIndex = 16;
            this.btnGetAll.Text = "All";
            this.btnGetAll.UseVisualStyleBackColor = true;
            this.btnGetAll.Visible = false;
            this.btnGetAll.Click += new System.EventHandler(this.btnGetAll_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(535, 90);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(250, 27);
            this.dateTimePicker1.TabIndex = 17;
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
            this.ColIDPhieu,
            this.ColTenSach,
            this.ColSoluong,
            this.ColID});
            this.dgvChiTiet.Location = new System.Drawing.Point(349, 175);
            this.dgvChiTiet.Name = "dgvChiTiet";
            this.dgvChiTiet.RowHeadersWidth = 51;
            this.dgvChiTiet.RowTemplate.Height = 29;
            this.dgvChiTiet.Size = new System.Drawing.Size(677, 341);
            this.dgvChiTiet.TabIndex = 18;
            this.dgvChiTiet.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dgvChiTiet_CellBeginEdit);
            this.dgvChiTiet.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvChiTiet_CellValueChanged);
            this.dgvChiTiet.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvChiTiet_EditingControlShowing);
            // 
            // ColIDPhieu
            // 
            this.ColIDPhieu.DataPropertyName = "IdPhieuNhap";
            this.ColIDPhieu.HeaderText = "ID Phiếu";
            this.ColIDPhieu.MinimumWidth = 6;
            this.ColIDPhieu.Name = "ColIDPhieu";
            this.ColIDPhieu.Visible = false;
            this.ColIDPhieu.Width = 125;
            // 
            // ColTenSach
            // 
            this.ColTenSach.DataPropertyName = "IdSach";
            this.ColTenSach.HeaderText = "Tên sách";
            this.ColTenSach.MinimumWidth = 6;
            this.ColTenSach.Name = "ColTenSach";
            this.ColTenSach.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColTenSach.Width = 350;
            // 
            // ColSoluong
            // 
            this.ColSoluong.DataPropertyName = "Soluong";
            this.ColSoluong.HeaderText = "Số lượng";
            this.ColSoluong.MinimumWidth = 6;
            this.ColSoluong.Name = "ColSoluong";
            this.ColSoluong.Width = 125;
            // 
            // ColID
            // 
            this.ColID.DataPropertyName = "Id";
            this.ColID.HeaderText = "ID";
            this.ColID.MinimumWidth = 6;
            this.ColID.Name = "ColID";
            this.ColID.Visible = false;
            this.ColID.Width = 125;
            // 
            // btnAddSach
            // 
            this.btnAddSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddSach.Location = new System.Drawing.Point(1032, 225);
            this.btnAddSach.Name = "btnAddSach";
            this.btnAddSach.Size = new System.Drawing.Size(34, 29);
            this.btnAddSach.TabIndex = 19;
            this.btnAddSach.Text = "+";
            this.btnAddSach.UseVisualStyleBackColor = true;
            this.btnAddSach.Click += new System.EventHandler(this.btnAddSach_Click);
            // 
            // btnXoaSach
            // 
            this.btnXoaSach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXoaSach.Location = new System.Drawing.Point(1032, 260);
            this.btnXoaSach.Name = "btnXoaSach";
            this.btnXoaSach.Size = new System.Drawing.Size(34, 29);
            this.btnXoaSach.TabIndex = 20;
            this.btnXoaSach.Text = "-";
            this.btnXoaSach.UseVisualStyleBackColor = true;
            this.btnXoaSach.Click += new System.EventHandler(this.btnXoaSach_Click);
            // 
            // txtOldIdPhieu
            // 
            this.txtOldIdPhieu.Location = new System.Drawing.Point(349, 39);
            this.txtOldIdPhieu.Name = "txtOldIdPhieu";
            this.txtOldIdPhieu.Size = new System.Drawing.Size(82, 27);
            this.txtOldIdPhieu.TabIndex = 21;
            this.txtOldIdPhieu.Text = "0";
            this.txtOldIdPhieu.Visible = false;
            // 
            // frmPhieuNhapSach
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 517);
            this.Controls.Add(this.txtOldIdPhieu);
            this.Controls.Add(this.btnXoaSach);
            this.Controls.Add(this.btnAddSach);
            this.Controls.Add(this.dgvChiTiet);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btnGetAll);
            this.Controls.Add(this.txtPhieuNhapSachId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.dgvPhieuNhapSach);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmPhieuNhapSach";
            this.Text = "Phiếu Nhập sách";
            this.Load += new System.EventHandler(this.frmPhieuNhapSach_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhieuNhapSach)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChiTiet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvPhieuNhapSach;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhieuNhapSachId;
        private System.Windows.Forms.Button btnGetAll;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dgvChiTiet;
        private System.Windows.Forms.Button btnAddSach;
        private System.Windows.Forms.Button btnXoaSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgay;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaPhieu;
        private System.Windows.Forms.TextBox txtOldIdPhieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIDPhieu;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColTenSach;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoluong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
    }
}