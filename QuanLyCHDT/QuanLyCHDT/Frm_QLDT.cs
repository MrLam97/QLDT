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
    public partial class Frm_QLDT : DevExpress.XtraEditors.XtraForm
    {
        public Frm_QLDT()
        {
            InitializeComponent();
        }

        private void Frm_QLDT_Load(object sender, EventArgs e)
        {
            dgvHienLoaiM.DataSource = tblLoaiMay_BUS.HienLMay();
            cbbHangsx.DataSource = tblHangSX_BUS.HienHSX();
            cbbHangsx.DisplayMember = "TenH";
            cbbHangsx.ValueMember = "MaH";
            cbbDungLuong.DataSource = tblLoaiMay_BUS.LayDSDL();
            cbbDungLuong.DisplayMember = "DungLuong";
            DataBinding();
        }

        private void DataBinding()
        {
            txtMaM.DataBindings.Clear();
            txtMaM.DataBindings.Add("Text", dgvHienLoaiM.DataSource, "MaM");
            cbbHangsx.DataBindings.Clear();
            cbbHangsx.DataBindings.Add("SelectedValue", dgvHienLoaiM.DataSource, "MaH");
            txtTenM.DataBindings.Clear();
            txtTenM.DataBindings.Add("Text", dgvHienLoaiM.DataSource, "TenM");
            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add("Text", dgvHienLoaiM.DataSource, "Gia");
            txtTGBH.DataBindings.Clear();
            txtTGBH.DataBindings.Add("Text", dgvHienLoaiM.DataSource, "TGBH");
            cbbDungLuong.DataBindings.Clear();
            cbbDungLuong.DataBindings.Add("Text", dgvHienLoaiM.DataSource, "DungLuong");
        }

        private void DKMo()
        {
            cbbHangsx.Enabled = true;
            txtMaM.ReadOnly = false;
            txtTenM.ReadOnly = false;
            txtGia.ReadOnly = false;
            txtTGBH.ReadOnly = false;
            cbbDungLuong.Enabled = true;
            btnThemDL.Visible = true;
        }

        private void DKKhoa()
        {
            cbbHangsx.Enabled = false;
            txtMaM.ReadOnly = true;
            txtTenM.ReadOnly = true;
            txtGia.ReadOnly = true;
            txtTGBH.ReadOnly = true;
            cbbDungLuong.Enabled = false;
            btnThemDL.Visible = false;
            cbbDungLuong.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (btnThem.Text == "Thêm")
            {
                Reset();
                btnThem.Text = "Hủy";
                btnLuu.Enabled = true;
                btnThemct.Enabled = false;
                dgvHienLoaiM.Enabled = false;
                DKMo();
            }
            else
            {
                btnThem.Text = "Hủy";
                btnLuu.Enabled = false;
                dgvHienLoaiM.Enabled = true;
                btnThemct.Enabled = true;
                btnThem.Text = "Thêm";
                DKKhoa();
            }
        }

        private void Reset()
        {
            txtMaM.Text = "";
            txtTenM.Text = "";
            txtGia.Text = "";
            txtTGBH.Text = "";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtImei.Text = "";
            cbbMau.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbMau.DataSource = tblChiTietMay_BUS.LayMauM();
            cbbMau.DisplayMember = "Mau";
        }

        private void btnHoanThanh_Click(object sender, EventArgs e)
        {
            
            btnThem.Enabled = true;
            btnThemct.Enabled = true;
            btnLuu.Enabled = false;
            groupBox2.Visible = false;
            dgvHienLoaiM.Enabled = true;
            dgvHienLoaiM.DataSource = tblLoaiMay_BUS.HienLMay();
            DataBinding();
        }

        private void btnThemct_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
            dgvHienLoaiM.Enabled = false;
            btnThemct.Enabled = false;
            btnThem.Enabled = false;
            btnLuu.Enabled = false;
            cbbMau.DataSource = tblChiTietMay_BUS.LayMauM();
            cbbMau.DisplayMember = "Mau";
        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            string ImeiM = txtImei.Text;
            string MaMay = txtMaM.Text;
            string MauMay = cbbMau.Text;
            bool DaBanM = false;
            tblChiTietMay NhapCTM=new tblChiTietMay(ImeiM,MaMay,MauMay,DaBanM);
            tblChiTietMay_BUS.NhapCTM(NhapCTM);

            int n = tblLoaiMay_BUS.SLTon(txtMaM.Text);
            tblLoaiMay_BUS.CapNhatSLTon(n,txtMaM.Text);

            MessageBox.Show("Thêm thành công.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (!tblLoaiMay_BUS.KiemTraMM(txtMaM.Text))
            {
                if (cbbHangsx.Text != "" && txtMaM.Text != "" && txtTenM.Text != "" && txtGia.Text != "" && txtTGBH.Text != "" && cbbDungLuong.Text != "")
                {
                    string maM = txtMaM.Text;
                    string maH = cbbHangsx.SelectedValue.ToString();
                    string tenM = txtTenM.Text;
                    ulong Gia = Convert.ToUInt32(txtGia.Text);
                    int soluongton = 0;
                    int tgbh = Convert.ToInt32(txtTGBH.Text);
                    int dungluong = Convert.ToInt32(cbbDungLuong.Text);
                    tblLoaiMay LoaiMay = new tblLoaiMay(maM, maH, tenM, Gia, soluongton, tgbh, dungluong);
                    tblLoaiMay_BUS.NhapLoaiM(LoaiMay);
                    dgvHienLoaiM.DataSource = tblLoaiMay_BUS.HienLMay();
                    dgvHienLoaiM.Enabled = true;
                    DataBinding();
                    btnThem.Text = "Thêm";
                    btnThemct.Enabled = true;
                    DKKhoa();
                }
                else
                    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Mã máy đã được sử dụng. Vui lòng nhập lại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnThemDL_Click(object sender, EventArgs e)
        {
            cbbDungLuong.DropDownStyle = ComboBoxStyle.Simple;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cbbMau.DropDownStyle = ComboBoxStyle.Simple;
        }
    }
}