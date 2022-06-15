using System;
using System.Collections.Generic;
using System.Text;

namespace quanlyspa_DTO
{
    public class DTO_HOADON
    {
        private string _SOHD;
        private string _MAKH;
        private string _TONGTIEN;
        private string _MANV;
        private string _NGAYTAO;

        public string SOHD { get => _SOHD; set => _SOHD = value; }
        public string MAKH { get => _MAKH; set => _MAKH = value; }
        public string TONGTIEN { get => _TONGTIEN; set => _TONGTIEN = value; }
        public string MANV { get => _MANV; set => _MANV = value; }
        public string NGAYTAO { get => _NGAYTAO; set => _NGAYTAO = value; }

    }
}