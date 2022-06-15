using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using quanlyspa_DTO;
using DAL_quanlyspa;

namespace BUS_quanlyspa
{
    public class BUS_MYPHAM
    {
        DAL_MYPHAM sql = new DAL_MYPHAM();
        // ham insert
        public void _insertData(DTO_MYPHAM val)
        {
            sql._insertData(val);
        }
        // ham update
        public void _updateData(DTO_MYPHAM val)
        {
            sql._updateData(val);
        }
        // ham delete
        public void _deleteData(DTO_MYPHAM val)
        {
            sql._deleteData(val);
        }
        // ham selectS
        public DataTable _selectData(string str)
        {
            return sql._selectData(str);
        }

        public string matutang_mypham(string str)
        {
            return sql.matutang_mypham(str);
        }
        public void _updatesl(string str, int sltk)
        {
            sql._updatesl(str,sltk);

        }
    }
}
