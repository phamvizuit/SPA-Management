using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quanlyspa_DTO;
using System.Data;
using System.Data.SqlClient;


namespace DAL_quanlyspa
{
    public class DAL_QLNV
    {
        _connectDataBase con = new _connectDataBase();

        // ham insert
        public void _insertData(DTO_QLNV val)
        {
            con._insert_update_delete(@"INSERT INTO QLNV (MANV, HOTEN, GIOITINH, SDT, NBDHD, NKTHD,PASS,LUONG) VALUES (N'" + val.MANV + "',N'" + val.HOTEN + "',N'" + val.GIOITINH + "','" + val.SDT + "',N'" + val.NBDHD + "',N'" + val.NKTHD +  "', '"+val.PASS+"', '"+val.LUONG+"')");
        }
        // ham update
        public void _updateData(DTO_QLNV val)
        {
            con._insert_update_delete(@"UPDATE  QLNV SET  HOTEN =N'" + val.HOTEN + "', GIOITINH ='" + val.GIOITINH + "', SDT = '" + val.SDT + "', NBDHD =  '" + val.NBDHD + "', NKTHD =  '" + val.NKTHD + "', PASS = '" + val.PASS + "', LUONG= '" + val.LUONG + "' WHERE MANV = N'" + val.MANV+"'");
        }
        // ham delete
        public void _deleteData(DTO_QLNV val)
        {
            con._insert_update_delete(@"DELETE FROM QLNV WHERE MANV = N'" + val.MANV + "'");
        }
        // ham select
        public DataTable _selectData(string str)
        {
            return con._select("SELECT * FROM QLNV " + str);
        }
        public string matutang_nv(string str)
        {
            return con.matutang_nv("SELECT * FROM QLNV " + str);
        }
    }
}
