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
    }
}