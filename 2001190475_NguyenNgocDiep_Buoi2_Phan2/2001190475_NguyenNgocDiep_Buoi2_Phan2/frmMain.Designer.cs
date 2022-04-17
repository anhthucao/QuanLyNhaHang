
namespace _2001190475_NguyenNgocDiep_Buoi2_Phan2
{
    partial class frmMain
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
            this.mdDangNhap1 = new _2001190475_NguyenNgocDiep_Buoi2_Phan2.mdDangNhap();
            this.mdDongHo1 = new _2001190475_NguyenNgocDiep_Buoi2_Phan2.mdDongHo();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // mdDangNhap1
            // 
            this.mdDangNhap1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mdDangNhap1.Location = new System.Drawing.Point(85, 207);
            this.mdDangNhap1.Name = "mdDangNhap1";
            this.mdDangNhap1.Size = new System.Drawing.Size(389, 241);
            this.mdDangNhap1.TabIndex = 1;
            // 
            // mdDongHo1
            // 
            this.mdDongHo1.Location = new System.Drawing.Point(40, 31);
            this.mdDongHo1.Name = "mdDongHo1";
            this.mdDongHo1.Size = new System.Drawing.Size(515, 73);
            this.mdDongHo1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 134);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "ĐĂNG NHẬP";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 533);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mdDangNhap1);
            this.Controls.Add(this.mdDongHo1);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Chính";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mdDongHo mdDongHo1;
        private mdDangNhap mdDangNhap1;
        private System.Windows.Forms.Label label1;
    }
}

