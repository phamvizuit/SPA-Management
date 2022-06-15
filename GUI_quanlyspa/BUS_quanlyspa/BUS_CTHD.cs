using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quanlyspa_DTO;
using System.Data;
using DAL_quanlyspa;

namespace BUS_quanlyspa
{
   public class BUS_CTHD
    {
        DAL_CTHD sql = new DAL_CTHD();
        // ham insert
        public void _insertData(DTO_CTHD val)
        {
            sql._insertData(val);
        }
        // ham update
        public void _updateData(DTO_CTHD val)
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
    }
}
