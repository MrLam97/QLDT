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
    public partial class Frm_DangKy : DevExpress.XtraEditors.XtraForm
    {
        public Frm_DangKy()
        {
            InitializeComponent();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "" && txtPass.Text != "" && txtNhapLai.Text != "" && txtTen.Text != "" && txtSDT.Text != "")
            {
                if (!tblUser_BUS.KiemTraTenDK(txtID.Text))
                {
                    if (txtPass.Text == txtNhapLai.Text)
                    {
                        string MaNV = txtID.Text;
                        string TenNV = txtTen.Text;
                        string Pass = txtPass.Text;
                        string SDT = txtSDT.Text;
                        tblUser user = new tblUser(MaNV, TenNV, Pass, SDT);
                        tblUser_BUS.DangKy(user);
                        MessageBox.Show("Đăng ký thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtID.Text = "";
                        txtPass.Text = "";
                        txtTen.Text = "";
                        txtSDT.Text = "";
                    }
                    else
                        MessageBox.Show("Thông tin mật khẩu không chính xác.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Tên đăng nhập đã được sử dụng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtNhapLai_TextChanged(object sender, EventArgs e)
        {
            if (txtPass.Text != txtNhapLai.Text)
                lblNhapLai.Text = "Nhập sai!";
            else
                lblNhapLai.Text = "";
        }
    }
}