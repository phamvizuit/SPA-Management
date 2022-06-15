using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quanlyspa_DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL_quanlyspa
{
   public  class DAL_HOADON
    {
        _connectDataBase con = new _connectDataBase();

        // ham insert
        public void _insertData(DTO_HOADON val)
        {
            con._insert_update_delete(@"INSERT INTO HOADON (SOHD, MAKH,TONGTIEN, MANV,NGAYTAO) VALUES ('"+val.SOHD +"','"+val.MAKH + "', '"+val.TONGTIEN+"' ,'" + val.MANV+ "','" + val.NGAYTAO + "')");
        }
        // ham update
        public void _updateData(DTO_HOADON val)
        {
            con._insert_update_delete(@"UPDATE HOADON SET TONGTIEN = N'"+ val.TONGTIEN +"' WHERE SOHD= N'"+ val.SOHD +"'");
        }
        // ham delete
        public void _deleteData(string str)
        {
            con._insert_update_delete("DELETE FROM HOADON " + str);
        }
        // ham select
        public DataTable _selectData(string str)
        {
            return con._select("SELECT * FROM HOADON "+str);
        }
        public string matutang_hoadon(string str)
        {
            return con.matutang_hoadon("SELECT * FROM HOADON " + str);
        }
    }
}
