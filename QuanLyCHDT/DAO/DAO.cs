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
            SqlConnection Conn = new SqlConnection("Data Source=MRLAM-PC\\SQLEXPRESS;Initial Catalog=QLCHDT;Integrated Security=True");
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
            SqlCommand cmd = new SqlCommand("NhapMay",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@MaM",SqlDbType.NVarChar,20);
            cmd.Parameters.Add("@MaH", SqlDbType.NVarChar, 20);
            cmd.Parameters.Add("@TenM", SqlDbType.NVarChar, 20);
            cmd.Parameters.Add("@Gia",SqlDbType.Money);
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
    }
}
