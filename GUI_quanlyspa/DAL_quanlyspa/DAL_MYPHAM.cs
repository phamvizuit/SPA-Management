using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quanlyspa_DTO;
using System.Data;
using System.Data.SqlClient;


namespace DAL_quanlyspa
{
    public class DAL_MYPHAM
    {
        _connectDataBase con = new _connectDataBase();

        // ham insert
        public void _insertData(DTO_MYPHAM val)
        {
            con._insert_update_delete(@"INSERT INTO MYPHAM  (MAMP, TENMP, SOLUONGTONKHO, GIABAN ) VALUES (N'" + val.MAMP + "',N'" + val.TENMP + "',N'" + val.SOLUONGTONKHO + "',N'" + val.GIABAN + "')");
        }
        // ham update
        public void _updateData(DTO_MYPHAM val)
        {
            con._insert_update_delete(@"UPDATE MYPHAM SET MAMP = N'" + val.MAMP + "', TENMP = N'" + val.TENMP + "', SOLUONGTONKHO = N'" + val.SOLUONGTONKHO + "', GIABAN = N'" + val.GIABAN +  "' WHERE MAMP = N'" + val.MAMP + "'");
        }
        // ham delete
        public void _deleteData(DTO_MYPHAM val)
        {
            con._insert_update_delete(@"DELETE FROM MYPHAM WHERE MAMP = N'" + val.MAMP + "'");
        }
        // ham select
        public DataTable _selectData(string str)
        {
            return con._select("SELECT * FROM MYPHAM "+str);
        }

        public string matutang_mypham(string str)
        {
            return con.matutang_mypham("SELECT * FROM MYPHAM " + str);
        }
        public void _updatesl(string str, int sltk)
        {
            con._insert_update_delete("UPDATE MYPHAM SET SOLUONGTONKHO = '" + sltk + "' "+str);

        }
    }
}
