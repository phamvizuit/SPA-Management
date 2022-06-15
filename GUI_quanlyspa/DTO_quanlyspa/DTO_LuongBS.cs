using System;
using System.Collections.Generic;
using System.Text;

namespace quanlyspa_DTO
{
    public class DTO_LuongBS
    {
        private string _MABS;
        private string _MATT;
        private string _NGAYTT;
        private string _TIENTHUONG;
        private string _TONGTIEN;

        public string MABS { get => _MABS; set => _MABS = value; }
        public string MATT { get => _MATT; set => _MATT = value; }
        public string NGAYTT { get => _NGAYTT; set => _NGAYTT = value; }
        public string TIENTHUONG { get => _TIENTHUONG; set => _TIENTHUONG = value; }
        public string TONGTIEN { get => _TONGTIEN; set => _TONGTIEN = value; }
    }
}
