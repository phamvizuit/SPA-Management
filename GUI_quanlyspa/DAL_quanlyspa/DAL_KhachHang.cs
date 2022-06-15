using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using quanlyspa_DTO;
using System.Data;
using System.Data.SqlClient;

namespace DAL_quanlyspa
{
    public class DAL_KhachHang
    {
        _connectDataBase con = new _connectDataBase();

        // ham insert
        public void _insertData(DTO_KhachHang val)
        {
            con._insert_update_delete(@"INSERT INTO KHACHHANG (MAKH, HOTEN, GIOITINH, NAMSINH, DIENTHOAI) VALUES ('"+val.MAKH+"',N'"+val.HOTEN+"','"+val.GIOITINH+"','"+val.NAMSINH+"','"+val.DIENTHOAI+"')");
        }
        // ham update
        public void _updateData(DTO_KhachHang val)
        {
            con._insert_update_delete(@"UPDATE KHACHHANG SET HOTEN =N'"+val.HOTEN+"', GIOITINH ='"+val.GIOITINH+ "', NAMSINH ='" + val.NAMSINH + "', DIENTHOAI ='" + val.DIENTHOAI + "' WHERE MAKH='" + val.MAKH+"'");
        }
        // ham delete
        public void _deleteData(DTO_KhachHang val)
        {
            con._insert_update_delete(@"DELETE FROM KHACHHANG WHERE MAKH='"+val.MAKH+"'");
        }
        // ham select
        public DataTable _selectData(string str)
        {
            return con._select("SELECT * FROM KHACHHANG "+str);
        }
        public string matutang_kh(string str)
        {
            return con.matutang_kh("SELECT * FROM KHACHHANG " + str);
        }
    }
}
