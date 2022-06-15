using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using quanlyspa_DTO;
using DAL_quanlyspa;

namespace BUS_quanlyspa
{
    public class BUS_CTDT
    {
        DAL_CTDT sql = new DAL_CTDT();
        // ham insert
        public void _insertData(DTO_CTDT val)
        {
            sql._insertData(val);
        }
        // ham update
        public void _updateData(DTO_CTDT val)
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
