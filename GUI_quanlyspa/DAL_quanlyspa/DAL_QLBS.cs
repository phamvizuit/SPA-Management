using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quanlyspa_DTO;
using System.Data;
using System.Data.SqlClient;


namespace DAL_quanlyspa
{
   public class DAL_QLBS
    {
        _connectDataBase con = new _connectDataBase();

        // ham insert
        public void _insertData(DTO_QLBS val)
        {
            con._insert_update_delete(@"INSERT INTO QLBS (MABS, HOTEN, GIOITINH,SDT,LUONG, NBDHD, NKTHD) VALUES (N'" + val.MABS + "',N'" + val.HOTEN + "',N'" + val.GIOITINH + "',N'" + val.SDT + "',N'" + val.LUONG + "',N'" + val.NBDHD + "',N'" + val.NKTHD + "')");
        }
        // ham update
        public void _updateData(DTO_QLBS val)
        {
            con._insert_update_delete(@"UPDATE QLBS SET HOTEN =N'" + val.HOTEN + "', GIOITINH =N'" + val.GIOITINH + "',  SDT =N'" + val.SDT + "', LUONG =N'" + val.LUONG + "', NBDHD =N'" + val.NBDHD + "', NKTHD =N'" + val.NKTHD + "' WHERE MABS= N'" + val.MABS + "'");
        }
        // ham delete
        public void _deleteData(DTO_QLBS val)
        {
            con._insert_update_delete(@"DELETE FROM QLBS WHERE MABS= N'" + val.MABS + "'");
        }
        // ham select
        public DataTable _selectData(string str)
        {
            return con._select("SELECT * FROM QLBS " + str);
        }
        public string matutang_bs(string str)
        {
            return con.matutang_bs("SELECT * FROM QLBS " + str);
        }

    }
}
