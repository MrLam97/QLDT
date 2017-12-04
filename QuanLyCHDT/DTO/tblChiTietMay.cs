using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblChiTietMay
    {
        private string imei;
        private string mam;
        private string mau;
        private bool daban;

        public string Imei
        {
            get
            {
                return imei;
            }

            set
            {
                imei = value;
            }
        }

        public string Mam
        {
            get
            {
                return mam;
            }

            set
            {
                mam = value;
            }
        }

        public string Mau
        {
            get
            {
                return mau;
            }

            set
            {
                mau = value;
            }
        }

        public bool Daban
        {
            get
            {
                return daban;
            }

            set
            {
                daban = value;
            }
        }

        public tblChiTietMay(string _imei, string _mam, string _mau, bool _daBan)
        {
            Imei = _imei;
            Mam = _mam;
            Mau = _mau;
            Daban = _daBan;
        }
    }
}
