using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DTO;
using BUS;

namespace QuanLyCHDT
{
    public partial class Frm_DoiPass : DevExpress.XtraEditors.XtraForm
    {
        public Frm_DoiPass()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            string manv = txtID.Text;
            string passnv = txtPass.Text;
            string pass = txtDoiPass.Text;
            if (txtID.Text != "" && txtPass.Text != "" && txtDoiPass.Text != "")
            {
                if (tblUser_BUS.KiemTraDN(manv, passnv))
                {
                    tblUser_BUS.DoiMKNV(manv, passnv, pass);
                    MessageBox.Show("Đổi mất khẩu thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtID.Text = "";
                    txtPass.Text = "";
                    txtDoiPass.Text = "";
                }
                else
                    MessageBox.Show("Thông tin tài khoản không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
}