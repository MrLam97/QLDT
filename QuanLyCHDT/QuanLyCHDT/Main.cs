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
using DevExpress.XtraBars;
using DTO;
using BUS;

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
        public static string MaNVDN = string.Empty;
        public FRM_Main()
        {
            InitializeComponent();
           
        }

        private void MoDK()
        {
            bbtnDangKy.Enabled = true;
            bbtnDoiPass.Enabled = true;
            bbtnDangXuat.Enabled = true;
        }

        private void KhoaDK()
        {
            bbtnDangKy.Enabled = false;
            bbtnDoiPass.Enabled = false;
            bbtnDangXuat.Enabled = false;
        }

        private void bbtnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DialogResult dr= MessageBox.Show("Bạn muốn thoát khỏi chương trình?","Thông báo",MessageBoxButtons.OKCancel,MessageBoxIcon.Question);
            if (dr == DialogResult.OK)
                this.Close();
        }

        private void FRM_Main_Load(object sender, EventArgs e)
        {
            UserLookAndFeel.Default.SetSkinStyle("iMaginary");
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
                if (f.Name == "Frm_HangSX")
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

        private void bbtnDangNhap1_ItemClick(object sender,ItemClickEventArgs e)
        {
            if (bhiManv.Caption != "")
                MessageBox.Show("Bạn chưa đăng xuất.","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
            else
            {
                Frm_DangNhap DangNhap = new Frm_DangNhap();
                DangNhap.ShowDialog();
            }
        }

        private void bbtnDangXuat_ItemClick(object sender,ItemClickEventArgs e)
        {
            if (bhiManv.Caption != "")
            {
                DialogResult dr = MessageBox.Show("Bạn muốn đăng xuất?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.OK)
                {
                    MaNVDN = null;
                    bbtnDangXuat.Enabled = false;

                    MessageBox.Show("Đăng xuất thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void FRM_Main_Activated(object sender, EventArgs e)
        {
            bhiManv.Caption = MaNVDN;

            if (tblUser_BUS.TimIDBoss(bhiManv.Caption))
            {
                MoDK();
            }
            else
            {
                if (bhiManv.Caption != "")
                {
                    bbtnDangXuat.Enabled = true;
                }
                else
                    KhoaDK();
            }
        }

        private void bbtnDangKy_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "Frm_DangKy")
                {
                    f.Activate();
                    return;
                }
            Frm_DangKy dk = new Frm_DangKy();
            dk.MdiParent = this;
            dk.Show();
        }

        private void bbtnDoiPass_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "Frm_DoiPass")
                {
                    f.Activate();
                    return;
                }
            Frm_DoiPass dk = new Frm_DoiPass();
            dk.MdiParent = this;
            dk.Show();
        }

        private void bbtnTraCuuMay_ItemClick(object sender, ItemClickEventArgs e)
        {
            foreach (Form f in this.MdiChildren)
                if (f.Name == "Frm_QLyDT")
                {
                    f.Activate();
                    return;
                }
            Frm_QLyDT dk = new Frm_QLyDT();
            dk.MdiParent = this;
            dk.Show();
        }
    }
}
