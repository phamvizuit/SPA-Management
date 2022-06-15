using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quanlyspa_DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL_quanlyspa
{
    public class DAL_CTHD
    {
        _connectDataBase con = new _connectDataBase();

        // ham insert
        public void _insertData(DTO_CTHD val)
        {
            con._insert_update_delete(@"INSERT INTO CTHD (SOHD, MAMP,THANHTIENMP, SOLUONG) VALUES (N'" + val.SOHD + "',N'" + val.MAMP + "','"+val.THANHTIENMP+"',N'"+ val.SOLUONG +"')");
        }
        // ham update
        public void _updateData(DTO_CTHD val)
        {
            con._insert_update_delete(@"UPDATE CTHD SET SOLUONG = N'" + val.SOLUONG + "' WHERE SOHD= N'" + val.SOHD + "'");
        }
        // ham delete
        public void _deleteData(string str)
        {
            con._insert_update_delete("DELETE FROM CTHD " + str);
        }
        // ham select
        public DataTable _selectData(string str)
        {
            return con._select("SELECT * FROM CTHD " + str);
        }
    }
}
