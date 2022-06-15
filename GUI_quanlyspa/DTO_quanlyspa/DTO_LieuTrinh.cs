using System;
using System.Collections.Generic;
using System.Text;

namespace quanlyspa_DTO
{
    public class DTO_LieuTrinh
    {
        private string _MALT;
        private string _TENLT;
        private string _THOIGIANDT;
        private string _GIATIEN;

        public string MALT { get => _MALT; set => _MALT = value; }
        public string TENLT { get => _TENLT; set => _TENLT = value; }
        public string THOIGIANDT { get => _THOIGIANDT; set => _THOIGIANDT = value; }
        public string GIATIEN { get => _GIATIEN; set => _GIATIEN = value; }
    }
}
