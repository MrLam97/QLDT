using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAO;
using System.Data;

namespace BUS
{
    public class tblHangSX_BUS
    {
        public static bool CheckPkey(string key,string key1)
        {
            return tblHangsx_DAO.Kiemtrakhoachinh(key,key1);
        }

        public static void ThemHSX(tblHangsx hsx)
        {
            tblHangsx_DAO.ThemHangSX(hsx);
        }

        public static DataTable HienHSX()
        {
            return tblHangsx_DAO.HienHangSX();
        }

        public static void XoaHSX(string a, string b)
        {
             tblHangsx_DAO.XoaHangSX(a, b);
        }

        //public static void SuaHSX(string a, string b, string c, string d)
        //{
        //    tblHangsx_DAO.SuaHangSX(a,b,c,d);
        //}

        public static DataTable TimHSX(string tenh)
        {
            return tblHangsx_DAO.TimHangSX(tenh);
        }
    }

    public class tblLoaiMay_BUS
    {
        public static void NhapLoaiM(tblLoaiMay loaimay)
        {
            tblLoaiMay_DAO.NhapLoaiMay(loaimay);
        }

        public static DataTable HienLMay()
        {
            return tblLoaiMay_DAO.HienLoaiMay();
        }

        public static int SLTon(string MaM)
        {
            return tblLoaiMay_DAO.SoLuongTon(MaM);
        }

        public static void CapNhatSLTon(int slt,string mam)
        {
            tblLoaiMay_DAO.CapNhatSLT(slt,mam);
        }

        public static bool KiemTraMM(string mam)
        {
            return tblLoaiMay_DAO.KiemTraMaM(mam);
        }

        public static DataTable LayDSDL()
        {
            return tblLoaiMay_DAO.LayDL();
        }
    }

    public class tblChiTietMay_BUS
    {
        public static void NhapCTM(tblChiTietMay CTM)
        {
            tblChiTietMay_DAO.NhapCTMay(CTM);
        }

        public static bool KTraImei(string Imei)
        {
            return tblChiTietMay_DAO.KiemTraImei(Imei);
        }



        public static DataTable LayMauM()
        {
            return tblChiTietMay_DAO.LayMau();
        }
    }
}
