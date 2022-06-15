using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quanlyspa_DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL_quanlyspa
{
    public class DAL_CTDT
    {
        _connectDataBase con = new _connectDataBase();

        // ham insert
        public void _insertData(DTO_CTDT val)
        {
            con._insert_update_delete(@"INSERT INTO CTDT (MABS, MALT, SOHD, SOLUONG, THANHTIENLT) VALUES ('"+val.MABS+"','"+val.MALT+"','"+val.SOHD+"','"+val.SOLUONG+"','"+val.THANHTIENLT+"')");
        }
        // ham update
        public void _updateData(DTO_CTDT val)
        {
            con._insert_update_delete(@"UPDATE CTDT SET SOLUONG ='" + val.SOLUONG + "', THANHTIENLT ='" + val.THANHTIENLT + "'");
        }
        // ham delete
        public void _deleteData(string str)
        {
            con._insert_update_delete("DELETE FROM CTDT " + str);
        }
        // ham select
        public DataTable _selectData(string str)
        {
            return con._select("SELECT * FROM CTDT "+str);
        }
    }
}
