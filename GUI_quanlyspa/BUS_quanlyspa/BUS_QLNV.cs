using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using quanlyspa_DTO;
using DAL_quanlyspa;


namespace BUS_quanlyspa
{
    public class BUS_QLNV
    {
        DAL_QLNV sql = new DAL_QLNV();
        // ham insert
        public void _insertData(DTO_QLNV val)
        {
            sql._insertData(val);
        }
        // ham update
        public void _updateData(DTO_QLNV val)
        {
            sql._updateData(val);
        }
        // ham delete
        public void _deleteData(DTO_QLNV val)
        {
            sql._deleteData(val);
        }
        // ham selectS
        public DataTable _selectData(string str)
        {
            return sql._selectData(str);
        }
        public string matutang_nv(string str)
        {
            return sql.matutang_nv(str);
        }
    }
}
