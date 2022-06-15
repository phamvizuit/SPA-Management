using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quanlyspa_DTO;
using System.Data;
using DAL_quanlyspa;

namespace BUS_quanlyspa
{
    public class BUS_KhachHang
    {
        DAL_KhachHang sql = new DAL_KhachHang();

        // ham insert
        public void _insertData(DTO_KhachHang val)
        {
            sql._insertData(val);
        }
        // ham update
        public void _updateData(DTO_KhachHang val)
        {
            sql._updateData(val);
        }
        // ham delete
        public void _deleteData(DTO_KhachHang val)
        {
            sql._deleteData(val);
        }
        // ham select
        public DataTable _selectData(string str)
        {
            return sql._selectData(str);
        }
        public string matutang_kh(string str)
        {
            return sql.matutang_kh(str);
        }
    }
}
