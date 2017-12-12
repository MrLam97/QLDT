using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using DTO;


namespace DAO
{
    public class KetnoiCSDL
    {
        public static SqlConnection Hamketnoi()
        {
            SqlConnection Conn = new SqlConnection("Data Source=DESKTOP-1P5PM5F\\SQLEXPRESS;Initial Catalog=QLCHDT;Integrated Security=True");
            return Conn;
        }
    }
    public class tblHangsx_DAO
    {
        public static bool Kiemtrakhoachinh(string _text, string _text1)
        {
            bool check = false;
            SqlConnection conn = KetnoiCSDL.Hamketnoi();
            SqlCommand cmd = new SqlCommand("select * from HangSX where MaH = '" + _text + "' or TenH='" + _text1 + "'", conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                check = true;
            }
            return check;
        }

        public static void ThemHangSX(tblHangsx hsx)
        {
            SqlConnection conn = KetnoiCSDL.Hamketnoi();
            SqlCommand cmd = new SqlCommand("ThemHangSX", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaH", SqlDbType.NVarChar, 20);
            cmd.Parameters.Add("@TenH", SqlDbType.NVarChar, 20);
            cmd.Parameters["@MaH"].Value = hsx.MaH;
            cmd.Parameters["@TenH"].Value = hsx.TenH;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static DataTable HienHangSX()
        {
            SqlConnection conn = KetnoiCSDL.Hamketnoi();
            SqlCommand cmd = new SqlCommand("HienHangSX", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static void XoaHangSX(string _mah, string _tenh)
        {
            SqlConnection conn = KetnoiCSDL.Hamketnoi();
            SqlCommand cmd = new SqlCommand("XoaHangSX", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaH", SqlDbType.NVarChar, 20);
            cmd.Parameters.Add("@TenH", SqlDbType.NVarChar, 20);
            cmd.Parameters["@MaH"].Value = _mah;
            cmd.Parameters["@TenH"].Value = _tenh;
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        //public static void SuaHangSX(string a, string b, string c, string d)
        //{
        //    SqlConnection conn = KetnoiCSDL.Hamketnoi();
        //    SqlCommand cmd = new SqlCommand("SuaHangSX",conn);
        //    cmd.CommandType = CommandType.StoredProcedure;
        //    cmd.Parameters.Add("@MaH", SqlDbType.NVarChar, 20);
        //    cmd.Parameters.Add("@TenH", SqlDbType.NVarChar, 20);
        //    cmd.Parameters.Add("@MaH1", SqlDbType.NVarChar, 20);
        //    cmd.Parameters.Add("@TenH1", SqlDbType.NVarChar, 20);

        //    cmd.Parameters["@MaH"].Value = a;
        //    cmd.Parameters["@TenH"].Value = b;
        //    cmd.Parameters["@MaH1"].Value = c;
        //    cmd.Parameters["@TenH1"].Value = d;

        //    conn.Open();
        //    cmd.ExecuteNonQuery();
        //    conn.Close();
        //}

        public static DataTable TimHangSX(string tenH)
        {
            SqlConnection conn = KetnoiCSDL.Hamketnoi();
            SqlCommand cmd = new SqlCommand("TimHangSX",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@TenH", SqlDbType.NVarChar, 20);
            cmd.Parameters["@TenH"].Value = tenH;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }

    public class tblLoaiMay_DAO
    {
        public static void NhapLoaiMay(tblLoaiMay lm)
        {
            SqlConnection conn = KetnoiCSDL.Hamketnoi();
            SqlCommand cmd = new SqlCommand("NhapMay", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaM", SqlDbType.NVarChar, 20);
            cmd.Parameters.Add("@MaH", SqlDbType.NVarChar, 20);
            cmd.Parameters.Add("@TenM", SqlDbType.NVarChar, 20);
            cmd.Parameters.Add("@Gia", SqlDbType.Money);
            cmd.Parameters.Add("@SoLuongTon", SqlDbType.Int);
            cmd.Parameters.Add("@TGBH", SqlDbType.Int);
            cmd.Parameters.Add("@DungLuong", SqlDbType.Int);

            cmd.Parameters["@MaM"].Value = lm.MaM1;
            cmd.Parameters["@MaH"].Value = lm.MaH1;
            cmd.Parameters["@TenM"].Value = lm.TenM1;
            cmd.Parameters["@Gia"].Value = lm.Gia1;
            cmd.Parameters["@SoLuongTon"].Value = lm.SoLuongTon1;
            cmd.Parameters["@TGBH"].Value = lm.TGBH1;
            cmd.Parameters["@DungLuong"].Value = lm.DungLuong1;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public static DataTable HienLoaiMay()
        {
            SqlConnection conn = KetnoiCSDL.Hamketnoi();
            SqlCommand cmd = new SqlCommand("XuatTTMay", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static int SoLuongTon(string MaM)
        {
            SqlConnection conn = KetnoiCSDL.Hamketnoi();
            SqlCommand cmd = new SqlCommand("SoLuongTon", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaM", SqlDbType.NVarChar, 20);
            cmd.Parameters["@MaM"].Value = MaM;
            conn.Open();
            int n = (int)cmd.ExecuteScalar();
            conn.Close();
            return n;
        }

        public static void CapNhatSLT(int SLT, string MaMay)
        {
            SqlConnection conn = KetnoiCSDL.Hamketnoi();
            SqlCommand cmd = new SqlCommand("CapNhatSLT", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@SoLuongTon", SqlDbType.Int);
            cmd.Parameters.Add("@MaM", SqlDbType.NVarChar, 20);

            cmd.Parameters["@SoLuongTon"].Value = SLT;
            cmd.Parameters["@MaM"].Value = MaMay;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static bool KiemTraMaM(string _MaM)
        {
            bool check = false;
            SqlConnection conn = KetnoiCSDL.Hamketnoi();
            string sql = "Select * from LoaiMay where MaM='" + _MaM + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                check = true;
            return check;
        }

        public static DataTable LayDL()
        {
            SqlConnection conn = KetnoiCSDL.Hamketnoi();
            SqlCommand cmd = new SqlCommand("LayDL",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static DataTable HienMayTheoHSX(string mah)
        {
            SqlConnection conn = KetnoiCSDL.Hamketnoi();
            SqlCommand cmd = new SqlCommand("HienMayTheoHSX", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaH",SqlDbType.NVarChar,20);

            cmd.Parameters["@MaH"].Value = mah;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }

    public class tblChiTietMay_DAO
    {
        public static void NhapCTMay(tblChiTietMay CTM)
        {
            SqlConnection conn = KetnoiCSDL.Hamketnoi();
            SqlCommand cmd = new SqlCommand("NhapCTMay", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            
            cmd.Parameters.Add("@Imei", SqlDbType.NVarChar, 20);
            cmd.Parameters.Add("@MaM", SqlDbType.NVarChar, 20);
            cmd.Parameters.Add("@Mau", SqlDbType.NVarChar, 15);
            cmd.Parameters.Add("@DaBan", SqlDbType.Bit);

            cmd.Parameters["@Imei"].Value = CTM.Imei;
            cmd.Parameters["@MaM"].Value = CTM.Mam;
            cmd.Parameters["@Mau"].Value = CTM.Mau;
            cmd.Parameters["@DaBan"].Value = CTM.Daban;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        public static bool KiemTraImei(string _Imei)
        {
            bool check = false;
            SqlConnection conn = KetnoiCSDL.Hamketnoi();
            string sql= "Select * from ChiTietMay where Imei='"+_Imei+"'";
            SqlCommand cmd = new SqlCommand(sql,conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                check = true;
            return check;
        }

        public static DataTable LayMau()
        {
            SqlConnection conn = KetnoiCSDL.Hamketnoi();
            SqlCommand cmd = new SqlCommand("LayMau", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }

        public static DataTable CTMTheoMaM(string mah)
        {
            SqlConnection conn = KetnoiCSDL.Hamketnoi();
            SqlCommand cmd = new SqlCommand("CTMTheoMaM", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaM", SqlDbType.NVarChar, 20);

            cmd.Parameters["@MaM"].Value = mah;
            conn.Open();
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            da.SelectCommand = cmd;
            da.Fill(dt);
            conn.Close();
            return dt;
        }
    }

    public class tblUser_DAO
    {
        public static bool KiemTraDangNhap(string id, string pass)
        {
            bool check = false;
            SqlConnection conn = KetnoiCSDL.Hamketnoi();
            SqlCommand cmd = new SqlCommand("select * from NhanVien where MaNV = '"+id+"' and PassNV='"+pass+"'",conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                check = true;
            conn.Close();
            return check;
        }

        public static bool KiemTraDNBoss(string id, string pass)
        {
            bool check = false;
            SqlConnection conn = KetnoiCSDL.Hamketnoi();
            SqlCommand cmd = new SqlCommand("select * from Boss where ID = '" + id + "' and PASS='" + pass + "'", conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                check = true;
            conn.Close();
            return check;
        }

        public static void DangKyNV(tblUser user)
        {
            SqlConnection conn = KetnoiCSDL.Hamketnoi();
            SqlCommand cmd = new SqlCommand("ThemNV",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaNV",SqlDbType.NVarChar,20);
            cmd.Parameters.Add("@TenNV", SqlDbType.NVarChar, 50);
            cmd.Parameters.Add("@PassNV", SqlDbType.NVarChar, 20);
            cmd.Parameters.Add("@SDTNV", SqlDbType.NChar, 12);

            cmd.Parameters["@MaNV"].Value = user.MaNV1;
            cmd.Parameters["@TenNV"].Value = user.TenNV1;
            cmd.Parameters["@PassNV"].Value = user.PassNV1;
            cmd.Parameters["@SDTNV"].Value = user.SDTNV1;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static bool Kiemtrakhoachinh(string _manv)
        {
            bool check = false;
            SqlConnection conn = KetnoiCSDL.Hamketnoi();
            SqlCommand cmd = new SqlCommand("select * from NhanVien n, Boss b where n.MaNV='"+_manv+"' or b.ID='"+_manv+"'", conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                check = true;
            }
            return check;
        }

        public static void DoiMK(string manv, string passnv, string pass)
        {
            SqlConnection conn = KetnoiCSDL.Hamketnoi();
            SqlCommand cmd = new SqlCommand("DoiMK",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaNV",SqlDbType.NVarChar,20);
            cmd.Parameters.Add("@PassNV", SqlDbType.NVarChar, 20);
            cmd.Parameters.Add("@Pass", SqlDbType.NVarChar, 20);

            cmd.Parameters["@MaNV"].Value = manv;
            cmd.Parameters["@PassNV"].Value = passnv;
            cmd.Parameters["@Pass"].Value = pass;

            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public static bool TimIDBoss(string id)
        {
            bool check = false;
            SqlConnection conn = KetnoiCSDL.Hamketnoi();
            SqlCommand cmd = new SqlCommand("select * from Boss where ID = '" + id + "'", conn);
            cmd.CommandType = CommandType.Text;
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                check = true;
            conn.Close();
            return check;
        }
    }
}
