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
    {
        public Frm_QLyDT()
        {
            InitializeComponent();
        }

        private void Frm_QLyDT_Load(object sender, EventArgs e)
        {
            cbbHangsx.DataSource = tblHangSX_BUS.HienHSX();
            cbbHangsx.DisplayMember = "TenH";
            cbbHangsx.ValueMember = "MaH";
            dgvHienLoaiM.DataSource = tblLoaiMay_BUS.HienLMay();
        }

        private void cbbHangsx_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvHienLoaiM.DataSource = tblLoaiMay_BUS.HienMayTheoH(cbbHangsx.SelectedValue.ToString());
        }

        private void dgvHienLoaiM_MouseClick(object sender, MouseEventArgs e)
        {
            int chondong = dgvHienLoaiM.CurrentCell.RowIndex;
            string MaM = dgvHienLoaiM.Rows[chondong].Cells[0].Value.ToString();
            dgvChiTietMay.DataSource = tblChiTietMay_BUS.CTMTheoMM(MaM);
        }

        private void btnHienCTM_Click(object sender, EventArgs e)
        {
            dgvHienLoaiM.DataSource = tblLoaiMay_BUS.HienLMay();
        }
    }
}