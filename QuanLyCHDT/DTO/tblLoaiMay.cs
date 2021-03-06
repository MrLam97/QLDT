﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblLoaiMay
    {
        private string MaM;
        private string MaH;
        private string TenM;
        private string Gia;
        private int SoLuongTon;
        private int TGBH;
        private int DungLuong;
        private int Ram;

        public string MaM1
        {
            get
            {
                return MaM;
            }

            set
            {
                MaM = value;
            }
        }

        public string MaH1
        {
            get
            {
                return MaH;
            }

            set
            {
                MaH = value;
            }
        }

        public string TenM1
        {
            get
            {
                return TenM;
            }

            set
            {
                TenM = value;
            }
        }

        public string Gia1
        {
            get
            {
                return Gia;
            }

            set
            {
                Gia = value;
            }
        }

        public int SoLuongTon1
        {
            get
            {
                return SoLuongTon;
            }

            set
            {
                SoLuongTon = value;
            }
        }

        public int TGBH1
        {
            get
            {
                return TGBH;
            }

            set
            {
                TGBH = value;
            }
        }

        public int DungLuong1
        {
            get
            {
                return DungLuong;
            }

            set
            {
                DungLuong = value;
            }
        }

        public int Ram1
        {
            get
            {
                return Ram;
            }

            set
            {
                Ram = value;
            }
        }

        public tblLoaiMay(string mam, string mah, string tenm, string gia, int soluongton, int tgbh, int dungluong,int ram)
        {
            MaM1 = mah;
            MaH1 = mah;
            TenM1 = tenm;
            Gia1 = gia;
            SoLuongTon1 = soluongton;
            TGBH1 = tgbh;
            DungLuong1 = dungluong;
            Ram1 = ram;
        }
    }
}
