using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblUser
    {
        private string MaNV;
        private string TenNV;
        private string PassNV;
        private string SDTNV;

        public string MaNV1
        {
            get
            {
                return MaNV;
            }

            set
            {
                MaNV = value;
            }
        }

        public string TenNV1
        {
            get
            {
                return TenNV;
            }

            set
            {
                TenNV = value;
            }
        }

        public string PassNV1
        {
            get
            {
                return PassNV;
            }

            set
            {
                PassNV = value;
            }
        }

        public string SDTNV1
        {
            get
            {
                return SDTNV;
            }

            set
            {
                SDTNV = value;
            }
        }

        public tblUser(string manv, string tennv, string passnv,string sdtnv)
        {
            MaNV1 = manv;
            TenNV1 = tennv;
            PassNV1 = passnv;
            SDTNV1 = sdtnv;
        }
    }
}
