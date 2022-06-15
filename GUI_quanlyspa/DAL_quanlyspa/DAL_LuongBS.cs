using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quanlyspa_DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL_quanlyspa
{
    public class DAL_LuongBS
    {
        _connectDataBase con = new _connectDataBase();

        // ham insert
        public void _insertData(DTO_LuongBS val)
        {
            con._insert_update_delete(@"INSERT INTO LUONGBS(MABS, MATT, NGAYTT,TIENTHUONG, TONGTIEN) VALUES (N'"+val.MABS+ "',N'" + val.MATT + "',N'" + val.NGAYTT + "','"+val.TIENTHUONG+"',N'" + val.TONGTIEN + "')");
        }
        // ham update
        public void _updateData(DTO_LuongBS val)
        {
            con._insert_update_delete(@"UPDATE LUONGBS SET MABS = N'" + val.MABS + "', NGAYTT = N'" + val.NGAYTT + "', TONGTIEN = N'" + val.TONGTIEN + "' WHERE MATT = N'" + val.MATT + "'");
        }
        // ham delete
        public void _deleteData(DTO_LuongBS val)
        {
            con._insert_update_delete(@"DELETE FROM LUONGBS WHERE MATT = N'" + val.MATT + "'");
        }
        // ham select
        public DataTable _selectData(string str)
        {
            return con._select("SELECT * FROM LUONGBS " + str);
        }
        public string matutang_lbs(string str)
        {
            return con.matutang_lbs("SELECT * FROM LUONGBS " + str);
        }
    }
}

