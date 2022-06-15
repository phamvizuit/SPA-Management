using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using quanlyspa_DTO;
using DAL_quanlyspa;

namespace BUS_quanlyspa
{
    public class BUS_NhapMP
    {
        DAL_NhapMP sql = new DAL_NhapMP();
        // ham insert
        public void _insertData(DTO_NhapMP val)
        {
            sql._insertData(val);
        }
        // ham update
        public void _updateData(DTO_NhapMP val)
        {
            sql._updateData(val);
        }
        // ham delete
        public void _deleteData(DTO_NhapMP val)
        {
            sql._deleteData(val);
        }
        // ham select
        public DataTable _selectData(string str)
        {
            return sql._selectData(str);
        }
        //ma tu tang
        public string matutang_nhapmypham(string str)
        {
            return sql.matutang_nhapmypham(str);
        }
    }
}
