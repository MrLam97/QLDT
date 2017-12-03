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
            cbbHangsx.DataSource = tblHangSX_BUS.HienHSX();
            cbbHangsx.DisplayMember = "TenH";
            cbbHangsx.ValueMember = "MaH";
        }

        private void btnThemH_Click(object sender, EventArgs e)
        {
            cbbHangsx.DropDownStyle = ComboBoxStyle.Simple;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string maM = txtMaM.Text;
            string maH = cbbHangsx.SelectedValue.ToString();
            string tenM = txtTenM.Text;
            ulong Gia = Convert.ToUInt32(txtGia.Text);
            int soluongton = Convert.ToInt32(txtSoLuongTon.Text);
            int tgbh = Convert.ToInt32(txtTGBH.Text);
            int dungluong = Convert.ToInt32(txtDungluong.Text);
            tblLoaiMay LoaiMay = new tblLoaiMay(maM,maH,tenM,Gia,soluongton,tgbh,dungluong);
            tblLoaiMay_BUS.NhapLoaiM(LoaiMay);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }
    }
}