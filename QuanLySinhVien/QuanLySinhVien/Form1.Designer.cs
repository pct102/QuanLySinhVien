namespace QuanLySinhVien
{
    partial class Form1
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
            this.pnlButton = new System.Windows.Forms.Panel();
            this.pnlAvatarSinhVien = new System.Windows.Forms.Panel();
            this.pnlDanhSachSinhVien = new System.Windows.Forms.Panel();
            this.pnlThongTinSinhVien = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(931, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chương Trình Quản Lý Sinh Viên";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnlButton
            // 
            this.pnlButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButton.Location = new System.Drawing.Point(0, 382);
            this.pnlButton.Name = "pnlButton";
            this.pnlButton.Size = new System.Drawing.Size(931, 100);
            this.pnlButton.TabIndex = 1;
            // 
            // pnlAvatarSinhVien
            // 
            this.pnlAvatarSinhVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlAvatarSinhVien.Location = new System.Drawing.Point(0, 31);
            this.pnlAvatarSinhVien.Name = "pnlAvatarSinhVien";
            this.pnlAvatarSinhVien.Size = new System.Drawing.Size(200, 351);
            this.pnlAvatarSinhVien.TabIndex = 2;
            // 
            // pnlDanhSachSinhVien
            // 
            this.pnlDanhSachSinhVien.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDanhSachSinhVien.Location = new System.Drawing.Point(731, 31);
            this.pnlDanhSachSinhVien.Name = "pnlDanhSachSinhVien";
            this.pnlDanhSachSinhVien.Size = new System.Drawing.Size(200, 351);
            this.pnlDanhSachSinhVien.TabIndex = 3;
            // 
            // pnlThongTinSinhVien
            // 
            this.pnlThongTinSinhVien.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlThongTinSinhVien.Location = new System.Drawing.Point(200, 31);
            this.pnlThongTinSinhVien.Name = "pnlThongTinSinhVien";
            this.pnlThongTinSinhVien.Size = new System.Drawing.Size(531, 351);
            this.pnlThongTinSinhVien.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 482);
            this.Controls.Add(this.pnlThongTinSinhVien);
            this.Controls.Add(this.pnlDanhSachSinhVien);
            this.Controls.Add(this.pnlAvatarSinhVien);
            this.Controls.Add(this.pnlButton);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlButton;
        private System.Windows.Forms.Panel pnlAvatarSinhVien;
        private System.Windows.Forms.Panel pnlDanhSachSinhVien;
        private System.Windows.Forms.Panel pnlThongTinSinhVien;
    }
}

