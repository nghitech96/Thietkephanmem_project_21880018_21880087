namespace Quanly_NhaSach.UI
{
    partial class frmQuyDinh
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
            this.dgvQuyDinh = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGiaTri = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColKieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyDinh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(179, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quy Định";
            // 
            // dgvQuyDinh
            // 
            this.dgvQuyDinh.AllowUserToAddRows = false;
            this.dgvQuyDinh.AllowUserToDeleteRows = false;
            this.dgvQuyDinh.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvQuyDinh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuyDinh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.ColTen,
            this.ColGiaTri,
            this.ColKieu});
            this.dgvQuyDinh.Location = new System.Drawing.Point(1, 85);
            this.dgvQuyDinh.Name = "dgvQuyDinh";
            this.dgvQuyDinh.RowHeadersWidth = 51;
            this.dgvQuyDinh.RowTemplate.Height = 29;
            this.dgvQuyDinh.Size = new System.Drawing.Size(987, 363);
            this.dgvQuyDinh.TabIndex = 3;
            this.dgvQuyDinh.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvQuyDinh_CellValueChanged);
            this.dgvQuyDinh.SelectionChanged += new System.EventHandler(this.dgvQuyDinh_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // ColTen
            // 
            this.ColTen.DataPropertyName = "Ten";
            this.ColTen.HeaderText = "Tên ";
            this.ColTen.MinimumWidth = 6;
            this.ColTen.Name = "ColTen";
            this.ColTen.ReadOnly = true;
            this.ColTen.Width = 600;
            // 
            // ColGiaTri
            // 
            this.ColGiaTri.DataPropertyName = "GiaTri";
            this.ColGiaTri.HeaderText = "Giá trị";
            this.ColGiaTri.MinimumWidth = 6;
            this.ColGiaTri.Name = "ColGiaTri";
            this.ColGiaTri.Width = 125;
            // 
            // ColKieu
            // 
            this.ColKieu.DataPropertyName = "Kieu";
            this.ColKieu.HeaderText = "Kiểu";
            this.ColKieu.MinimumWidth = 6;
            this.ColKieu.Name = "ColKieu";
            this.ColKieu.Width = 125;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(155, 50);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(83, 29);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(437, 50);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 29);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(994, 114);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(28, 29);
            this.btnAddItem.TabIndex = 9;
            this.btnAddItem.Text = "+";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(994, 150);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(28, 29);
            this.btnDeleteItem.TabIndex = 10;
            this.btnDeleteItem.Text = "-";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // frmQuyDinh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 450);
            this.Controls.Add(this.btnDeleteItem);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dgvQuyDinh);
            this.Controls.Add(this.label1);
            this.Name = "frmQuyDinh";
            this.Text = "Quy định";
            this.Load += new System.EventHandler(this.frmQuyDinh_Load);
            this.Leave += new System.EventHandler(this.frmQuyDinh_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuyDinh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvQuyDinh;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGiaTri;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColKieu;
    }
}