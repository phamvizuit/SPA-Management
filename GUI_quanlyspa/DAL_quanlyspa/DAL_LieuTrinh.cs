using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quanlyspa_DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL_quanlyspa
{
    public class DAL_LieuTrinh
    {
        _connectDataBase con = new _connectDataBase();

        // ham insert
        public void _insertData(DTO_LieuTrinh val)
        {
            con._insert_update_delete(@"INSERT INTO LIEUTRINH (MALT, TENLT, THOIGIANDT, GIATIEN) VALUES ('"+val.MALT+"',N'"+val.TENLT+"','"+val.THOIGIANDT+"','"+val.GIATIEN+"')");
        }
        // ham update
        public void _updateData(DTO_LieuTrinh val)
        {
            con._insert_update_delete(@"UPDATE LIEUTRINH SET TENLT =N'" + val.TENLT + "', THOIGIANDT ='" + val.THOIGIANDT + "', GIATIEN ='" + val.GIATIEN + "' WHERE MALT='" + val.MALT+"'");
        }
        // ham delete
        public void _deleteData(DTO_LieuTrinh val)
        {
            con._insert_update_delete(@"DELETE FROM LIEUTRINH WHERE MALT='" + val.MALT + "'");
        }
        // ham select
        public DataTable _selectData(string str)
        {
            return con._select("SELECT * FROM LIEUTRINH "+str);
        }
        public string matutang_lieutrinh(string str)
        {
            return con.matutang_lieutrinh("SELECT * FROM LIEUTRINH "+str);
        }
    }
}
