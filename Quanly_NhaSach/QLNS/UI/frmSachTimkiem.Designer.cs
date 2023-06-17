namespace Quanly_NhaSach.UI
{
    partial class frmSachTimkiem
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
            this.txtTenTacgia = new System.Windows.Forms.TextBox();
            this.txtTheloai = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lbMessage = new System.Windows.Forms.Label();
            this.txtTenSach = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tên Tác giả";
            // 
            // txtTenTacgia
            // 
            this.txtTenTacgia.Location = new System.Drawing.Point(151, 67);
            this.txtTenTacgia.Name = "txtTenTacgia";
            this.txtTenTacgia.Size = new System.Drawing.Size(347, 27);
            this.txtTenTacgia.TabIndex = 4;
            // 
            // txtTheloai
            // 
            this.txtTheloai.Location = new System.Drawing.Point(151, 100);
            this.txtTheloai.Name = "txtTheloai";
            this.txtTheloai.Size = new System.Drawing.Size(347, 27);
            this.txtTheloai.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thể loại";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(166, 160);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(94, 29);
            this.btnSearch.TabIndex = 9;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnClose
            // 
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClose.Location = new System.Drawing.Point(318, 160);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 29);
            this.btnClose.TabIndex = 10;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lbMessage
            // 
            this.lbMessage.ForeColor = System.Drawing.Color.Red;
            this.lbMessage.Location = new System.Drawing.Point(12, 9);
            this.lbMessage.Name = "lbMessage";
            this.lbMessage.Size = new System.Drawing.Size(532, 20);
            this.lbMessage.TabIndex = 0;
            this.lbMessage.Text = "Message";
            this.lbMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbMessage.Visible = false;
            // 
            // txtTenSach
            // 
            this.txtTenSach.Location = new System.Drawing.Point(151, 34);
            this.txtTenSach.Name = "txtTenSach";
            this.txtTenSach.Size = new System.Drawing.Size(347, 27);
            this.txtTenSach.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tên sách";
            // 
            // frmSachTimkiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnClose;
            this.ClientSize = new System.Drawing.Size(545, 206);
            this.Controls.Add(this.txtTenSach);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbMessage);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtTheloai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenTacgia);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSachTimkiem";
            this.Text = "Tìm kiếm";
            this.Load += new System.EventHandler(this.frmSachTimkiem_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTenTacgia;
        private System.Windows.Forms.TextBox txtTheloai;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lbMessage;
        private System.Windows.Forms.TextBox txtTenSach;
        private System.Windows.Forms.Label label4;
    }
}