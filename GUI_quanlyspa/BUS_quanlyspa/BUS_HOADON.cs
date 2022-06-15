using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quanlyspa_DTO;
using System.Data;
using DAL_quanlyspa;


namespace BUS_quanlyspa
{
   public class BUS_HOADON
    {
        DAL_HOADON sql = new DAL_HOADON();
        // ham insert
        public void _insertData(DTO_HOADON val)
        {
            sql._insertData(val);
        }
        // ham update
        public void _updateData(DTO_HOADON val)
        {
            sql._updateData(val);
        }
        // ham delete
        public void _deleteData(string str)
        {
            sql._deleteData(str);
        }
        // ham select
        public DataTable _selectData(string str)
        {
            return sql._selectData(str);
        }
        public string matutang_hoadon(string str)
        {
            return sql.matutang_hoadon(str);
        }
    }
}
