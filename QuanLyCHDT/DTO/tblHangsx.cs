using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class tblHangsx
    {
        private string _MaH;
        private string _TenH;

        public string MaH
        {
            get
            {
                return _MaH;
            }

            set
            {
                _MaH = value;
            }
        }

        public string TenH
        {
            get
            {
                return _TenH;
            }

            set
            {
                _TenH = value;
            }
        }
        public tblHangsx(string mah,string tenh)
        {
            MaH = mah;
            TenH = tenh;
        }
    }
    
}
