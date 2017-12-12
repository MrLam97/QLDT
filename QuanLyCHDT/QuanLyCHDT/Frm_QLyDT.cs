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
    public partial class Frm_QLyDT : DevExpress.XtraEditors.XtraForm
    {//Chinh sua
        public Frm_QLyDT()
        {
            InitializeComponent();
        }

        private void Frm_QLyDT_Load(object sender, EventArgs e)
        {
            LoadCombobox();
            HienLoaiMay();
        }

        private void HienLoaiMay()
        {
            dgvHienLoaiM.DataSource = tblLoaiMay_BUS.HienLMay();
            DataBinding();
        }
        
        private void HienCTMtheoMM()
        {
            if (dgvHienLoaiM.Rows.Count > 0)
            {
                int chondong = dgvHienLoaiM.CurrentCell.RowIndex;
                string MaM = dgvHienLoaiM.Rows[chondong].Cells[0].Value.ToString();
                dgvChiTietMay.DataSource = tblChiTietMay_BUS.CTMTheoMM(MaM);
                DataBinding1();
            }
        }

        private void LoadCombobox()
        {
            cbbHang.DataSource = tblHangSX_BUS.HienHSX();
            cbbHang.DisplayMember = "TenH";
            cbbHang.ValueMember = "MaH";
        }

        private void DataBinding()
        {
            txtMaM.DataBindings.Clear();
            txtMaM.DataBindings.Add("Text", dgvHienLoaiM.DataSource, "MaM");
            cbbHang.DataBindings.Clear();
            cbbHang.DataBindings.Add("SelectedValue", dgvHienLoaiM.DataSource, "MaH");
            txtTenM.DataBindings.Clear();
            txtTenM.DataBindings.Add("Text", dgvHienLoaiM.DataSource, "TenM");
            txtGia.DataBindings.Clear();
            txtGia.DataBindings.Add("Text", dgvHienLoaiM.DataSource, "Gia");
            txtSLT.DataBindings.Clear();
            txtSLT.DataBindings.Add("Text", dgvHienLoaiM.DataSource, "SoLuongTon");
            txtTGBH.DataBindings.Clear();
            txtTGBH.DataBindings.Add("Text", dgvHienLoaiM.DataSource, "TGBH");
            txtDungLuong.DataBindings.Clear();
            txtDungLuong.DataBindings.Add("Text", dgvHienLoaiM.DataSource, "DungLuong");
        }

        private void DataBinding1()
        {
            txtImei.DataBindings.Clear();
            txtImei.DataBindings.Add("Text", dgvChiTietMay.DataSource, "Imei");
            txtMau.DataBindings.Clear();
            txtMau.DataBindings.Add("Text", dgvChiTietMay.DataSource, "Mau");
            cbDaBan.DataBindings.Clear();
            cbDaBan.DataBindings.Add("Checked",dgvChiTietMay.DataSource,"DaBan");
        }

        private void cbbHangsx_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvHienLoaiM.DataSource = tblLoaiMay_BUS.HienMayTheoH(cbbHangsx.SelectedValue.ToString());
            DataBinding();
        }

        private void btnHienCTM_Click(object sender, EventArgs e)
        {
            dgvHienLoaiM.DataSource = tblLoaiMay_BUS.HienLMay();
        }

        private void dgvHienLoaiM_MouseClick_1(object sender, MouseEventArgs e)
        {
            HienCTMtheoMM();
        }

        private void cbbHangsx_DropDown(object sender, EventArgs e)
        {
            cbbHangsx.DataSource = tblHangSX_BUS.HienHSX();
            cbbHangsx.DisplayMember = "TenH";
            cbbHangsx.ValueMember = "MaH";
        }

        private void dgvHienLoaiM_SelectionChanged(object sender, EventArgs e)
        {
            HienCTMtheoMM();
        }
    }
}