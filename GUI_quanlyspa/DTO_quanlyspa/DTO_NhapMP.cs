using System;
using System.Collections.Generic;
using System.Text;

namespace quanlyspa_DTO
{
    public class DTO_NhapMP
    {
        private string _MANMP;
        private string _MAMP;
        private string _DONGIA;
        private string _NGAYNHAP;
        private string _SLNHAP;
        private string _THANHTIENDH;    
        private string _MANV;

        public string MANMP { get => _MANMP; set => _MANMP = value; }
        public string MAMP { get => _MAMP; set => _MAMP = value; }
        public string DONGIA { get => _DONGIA; set => _DONGIA = value; }
        public string NGAYNHAP { get => _NGAYNHAP; set => _NGAYNHAP = value; }      
        public string SLNHAP { get => _SLNHAP; set => _SLNHAP = value; }
        public string THANHTIENDH { get => _THANHTIENDH; set => _THANHTIENDH = value; }   
        public string MANV { get => _MANV; set => _MANV = value; }
    }
}
