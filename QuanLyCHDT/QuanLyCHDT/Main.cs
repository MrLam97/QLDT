using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Configuration;

namespace QuanLyCHDT
{

    //internal class CustomApplicationSettings : ApplicationSettingsBase
    //{
    //    [UserScopedSetting(), DefaultSettingValue("DevExpress Style")]
    //    public string SkinName
    //    {
    //        get { return this("SkinName").ToString(); }
    //        set { this("SkinName") = value; }
    //    }
    //}

    public partial class FRM_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public FRM_Main()
        {
            InitializeComponent();
           
        }


        private void bbtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr= MessageBox.Show("Bạn muốn thoát khỏi chương trình?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
                this.Close();
        }

        private void FRM_Main_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle("Seven");
            //ApplicationSettings = new CustomApplicationSettings();
            //UserLookAndFeel.Default.SkinName = ApplicationSettings.SkinName;
        }

        private void bbtnNhapSP_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "Frm_QLDT")
                {
                    f.Activate();
                    return;
                }
            Frm_QLDT qldt = new Frm_QLDT();
            qldt.MdiParent = this;
            qldt.Show();
        }

        private void bbtnQlHang_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "Frm_HangSx")
                {
                    f.Activate();
                    return;
                }
            Frm_HangSX qlh = new Frm_HangSX();
            qlh.MdiParent = this;
            qlh.Show();
        }

        private void FRM_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //ApplicationSettings.SkinName = UserLookAndFeel.Default.SkinName;
            //ApplicationSettings.Save();
        }
    }
}
