using System;
using System.Collections.Generic;
using System.Text;

namespace quanlyspa_DTO
{
    public class DTO_MYPHAM
    {
        private string _MAMP;
        private string _TENMP;
        private string _SOLUONGTONKHO;
        private string _GIABAN;


        public string MAMP { get => _MAMP; set => _MAMP = value; }
        public string TENMP { get => _TENMP; set => _TENMP = value; }
        public string SOLUONGTONKHO { get => _SOLUONGTONKHO; set => _SOLUONGTONKHO = value; }
        public string GIABAN { get => _GIABAN; set => _GIABAN = value; }

    }
}
