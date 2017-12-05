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
    public partial class Frm_DangNhap : DevExpress.XtraEditors.XtraForm
    {
        public Frm_DangNhap()
        {
            InitializeComponent();
        }

        private void cbHienMK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbHienMK.Checked == true)
                txtPass.UseSystemPasswordChar = false;
            else
                txtPass.UseSystemPasswordChar = true;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string pass = txtPass.Text;
            if (tblUser_BUS.KiemTraDNBoss(id, pass))
            {
                MessageBox.Show("Đăng nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FRM_Main.MaNVDN = txtID.Text;
                this.Hide();
            }
            else
            {
                if (tblUser_BUS.KiemTraDN(id, pass))
                {
                    MessageBox.Show("Đăng nhập thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FRM_Main.MaNVDN = txtID.Text;
                    this.Hide();

                }
                else
                    MessageBox.Show("Sai thông tin đăng nhập.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}