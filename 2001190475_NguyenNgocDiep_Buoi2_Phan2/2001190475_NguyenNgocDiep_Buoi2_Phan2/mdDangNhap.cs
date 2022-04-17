using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2001190475_NguyenNgocDiep_Buoi2_Phan2
{
    public partial class mdDangNhap : UserControl
    {
        public mdDangNhap()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tên đăng nhập là: " + txtDangNhap.Text);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn đóng chương trình !?!",
              "Hỏi người dùng", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            // MessageBox.Show("Hẹn gặp lại !!! ");
            {
                Application.Exit();
            }
        }
    }
}
