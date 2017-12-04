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
using BUS;
using DTO;

namespace QuanLyCHDT
{
    public partial class Frm_HangSX : DevExpress.XtraEditors.XtraForm
    {
        public Frm_HangSX()
        {
            InitializeComponent();
        }

        private void Frm_HangSX_Load(object sender, EventArgs e)
        {
            dgvHangsx.DataSource = tblHangSX_BUS.HienHSX();
            Showcombobox();
            Databinding();
            cbbTenH.Enabled = false;
        }

        private void Databinding()
        {
            txtMaH.DataBindings.Clear();
            txtMaH.DataBindings.Add("Text", dgvHangsx.DataSource, "MaH");
            cbbTenH.DataBindings.Clear();
            cbbTenH.DataBindings.Add("Text", dgvHangsx.DataSource, "TenH");
        }

        private void Reset()
        {
            txtMaH.Text = "";
            cbbTenH.Text = "";
            txtMaH.ReadOnly = false;
            cbbTenH.DropDownStyle = ComboBoxStyle.Simple;
        }

        private void Showcombobox()
        {
            cbbTenH.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbTenH.DataSource = tblHangSX_BUS.HienHSX();
            cbbTenH.DisplayMember = "TenH";
        }

        private void DKKhoa()
        {
            btnXoa.Enabled = false;
            btnLuu.Enabled = true;
            btnHientc.Enabled = false;
            rdbTimT.Enabled = false;
        }

        private void DKMo()
        {
            btnXoa.Enabled = true;
            btnLuu.Enabled = false;
            btnHientc.Enabled = true;
            rdbTimT.Enabled = true;
        }

        private void cbbTenH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rdbTimT.Checked == true)
            {
                string tenH = cbbTenH.Text;
                dgvHangsx.DataSource = tblHangSX_BUS.TimHSX(tenH);
                Databinding();
            }
        }

        private void rdbTimT_CheckedChanged(object sender, EventArgs e)
        {
            string tenH = cbbTenH.Text;
            dgvHangsx.DataSource = tblHangSX_BUS.TimHSX(tenH);
            Databinding();
            cbbTenH.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                DKKhoa();
                Reset();
                btnThem.Text = "Hủy";
                cbbTenH.Enabled = true;
            }
            else
           if (btnThem.Text == "Hủy")
            {
                DKMo();
                Showcombobox();
                btnThem.Text = "Thêm";
                rdbTimT.Checked = false;
                dgvHangsx.DataSource = tblHangSX_BUS.HienHSX();
                Databinding();
                cbbTenH.Enabled = false;

            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string a = txtMaH.Text;
            string b = cbbTenH.Text;
            DialogResult dr = MessageBox.Show("Bạn muốn xóa hãng này?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
            {
                tblHangSX_BUS.XoaHSX(a, b);
                MessageBox.Show("Xóa thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                rdbTimT.Checked = false;
                dgvHangsx.DataSource = tblHangSX_BUS.HienHSX();
                Databinding();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Hủy")
            {
                if (!tblHangSX_BUS.CheckPkey(txtMaH.Text, cbbTenH.Text))
                {
                    if (txtMaH.Text != "" && cbbTenH.Text != "")
                    {
                        string mah = txtMaH.Text;
                        string tenh = cbbTenH.Text;
                        tblHangsx hsx = new tblHangsx(mah, tenh);
                        tblHangSX_BUS.ThemHSX(hsx);
                        rdbTimT.Checked = false;
                        Showcombobox();
                        DKMo();
                        btnThem.Text = "Thêm";
                        txtMaH.ReadOnly = true;
                        dgvHangsx.DataSource = tblHangSX_BUS.HienHSX();
                        Databinding();
                        cbbTenH.Enabled = false;
                    }
                    else
                        MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Mã hãng hoặc tên hãng đã được sửa dụng, vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnHientc_Click(object sender, EventArgs e)
        {
            rdbTimT.Checked = false;
            cbbTenH.Enabled = false;
            rdbTimT.Checked = false;
            dgvHangsx.DataSource = tblHangSX_BUS.HienHSX();
            Databinding();
            
        }
    }
}