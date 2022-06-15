using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quanlyspa_DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL_quanlyspa
{
    public class DAL_LuongNV
    {
        _connectDataBase con = new _connectDataBase();

        // ham insert
        public void _insertData(DTO_LuongNV val)
        {
            con._insert_update_delete(@"INSERT INTO LUONGNV (MANV, MATT, NGAYTT, TONGTIEN) VALUES (N'" + val.MANV + "',N'" + val.MATT + "',N'" + val.NGAYTT + "','"+val.TONGTIEN+"')");
        }
        // ham update
        public void _updateData(DTO_LuongNV val)
        {
            con._insert_update_delete(@"UPDATE LUONGNV SET MANV = N'" + val.MANV + "', NGAYTT = N'" + val.NGAYTT + "' WHERE MATT = N'" + val.MATT + "'");
        }
        // ham delete
        public void _deleteData(DTO_LuongNV val)
        {
            con._insert_update_delete(@"DELETE FROM LUONGNV WHERE MATT = N'" + val.MATT + "'");
        }
        // ham select
        public DataTable _selectData(string str)
        {
            return con._select("SELECT * FROM LUONGNV " + str);
        }
        public string matutang_lnv(string str)
        {
            return con.matutang_lnv("SELECT * FROM LUONGNV " + str);
        }
    }
}