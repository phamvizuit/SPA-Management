using System;
using System.Collections.Generic;
using System.Text;

namespace quanlyspa_DTO
{
    public class DTO_CTDT
    {
        private string _MABS;
        private string _MALT;
        private string _SOHD;
        private string _SOLUONG;
        private string _THANHTIENLT;

        public string MABS { get => _MABS; set => _MABS = value; }
        public string MALT { get => _MALT; set => _MALT = value; }
        public string SOHD { get => _SOHD; set => _SOHD = value; }
        public string SOLUONG { get => _SOLUONG; set => _SOLUONG = value; }
        public string THANHTIENLT { get => _THANHTIENLT; set => _THANHTIENLT = value; }
    }
}
