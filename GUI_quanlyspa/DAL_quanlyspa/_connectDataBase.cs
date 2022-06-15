using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;

namespace DAL_quanlyspa
{
    public class _connectDataBase
    {
        public static SqlConnection _connect; // default constructor


        public void _KetnoiDB()  // mo ket noi toi database
        {
            if (_connectDataBase._connect == null)
                _connectDataBase._connect = new SqlConnection(@"Data Source=LAPTOP-A60R360U;Initial Catalog=QuanlySpa;Integrated Security=True;"); //đoi lai cho phu hop
            if (_connectDataBase._connect.State != ConnectionState.Open)
                _connectDataBase._connect.Open();
        }
        public void _NgatketnoiDB() // dong ket noi toi database
        {
            if (_connectDataBase._connect != null && _connectDataBase._connect.State == ConnectionState.Open)
                _connectDataBase._connect.Close();
        }
        public void _insert_update_delete(string str) // thuc thi cau lenh them xoa sua bang cach truyen lenh sql vao "str"
        {
            try
            {
                _KetnoiDB();
                SqlCommand _sqlcmd = new SqlCommand(str,_connect);
                _sqlcmd.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine("Someting wrong!" + e);
            }
            finally
            {
                _NgatketnoiDB();
            }
        }
        public DataTable _select(string str) // thuc thi cau lenh select bang cach truyen lenh sql vao "str" tra ve 1 bang du lieu
        {
            try
            {
                _KetnoiDB();
                DataTable dt = new DataTable();
                SqlDataAdapter sqlda = new SqlDataAdapter(str, _connect);
                sqlda.Fill(dt);
                return dt;
            }
            catch (Exception e)
            {
                Console.WriteLine("Someting wrong!" + e);
                return null;
            }
            finally
            {
                _NgatketnoiDB();
            }

        }
        public string _value(string str) // thuc thi cau lenh select bang cach truyen lenh sql vao "str" tra ve 1 ket qua . vs lenh count(*) tra ve 5.
        {
            try
            {
                string kq = null;
                _KetnoiDB();
                SqlCommand sqlcmd = new SqlCommand(str, _connect);
                SqlDataReader sqldr = sqlcmd.ExecuteReader();
                while (sqldr.Read())
                    kq = sqldr[0].ToString();
                return kq;
            }
            catch (Exception e)
            {
                Console.WriteLine("Someting wrong!" + e);
                return null;
            }
            finally
            {
                _NgatketnoiDB();
            }
        }
        public string matutang_lieutrinh(string str)
        {
            DataTable dt = new DataTable();
            dt = _select(str);

            string mlt;
            if (dt.Rows.Count == 0)
                mlt = "LT1";
            else
            {
                string malt = dt.Rows[dt.Rows.Count - 1][0].ToString();
                malt = malt.Substring(2);
                int so = int.Parse(malt) + 1;
                mlt = "LT";
                mlt = mlt + so.ToString();
            }
            return mlt;
        }
        public string matutang_thietbi(string str)
        {
            DataTable dt = new DataTable();
            dt = _select(str);
            string mtb;
            if (dt.Rows.Count == 0)
                mtb = "TB1";
            else
            {
                string matb = dt.Rows[dt.Rows.Count - 1][0].ToString();
                matb = matb.Substring(2);
                int so = int.Parse(matb) + 1;
                mtb = "TB";
                mtb = mtb + so.ToString();
            }
            return mtb;
        }
        public string matutang_mypham(string str)
        {
            DataTable dt = new DataTable();
            dt = _select(str);
            string mmp;
            if (dt.Rows.Count == 0)
                mmp = "MP1";
            else
            {
                string mamp = dt.Rows[dt.Rows.Count - 1][0].ToString();
                mamp = mamp.Substring(2);
                int so = int.Parse(mamp) + 1;
                mmp = "MP";
                mmp = mmp + so.ToString();
            }

            return mmp;
        }
        public string matutang_nhapmypham(string str)
        {
            DataTable dt = new DataTable();
            dt = _select(str);
            string mmp;
            if (dt.Rows.Count == 0)
                mmp = "NMP1";
            else
            {
                string mamp = dt.Rows[dt.Rows.Count - 1][0].ToString();
                mamp = mamp.Substring(3);
                int so = int.Parse(mamp) + 1;
                mmp = "NMP";
                mmp = mmp + so.ToString();
            }
            return mmp;
        }
        public string matutang_hoadon(string str)
        {
            DataTable dt = new DataTable();
            dt = _select(str);
            string mhd;
            if (dt.Rows.Count == 0)
                mhd = "HD1";
            else
            {
                string mahd = dt.Rows[dt.Rows.Count-1][0].ToString();
                mahd = mahd.Substring(2);
                int so = int.Parse(mahd) + 1;
                mhd = "HD";
                mhd = mhd + so.ToString();
            }
            
            return mhd;
        }
        public string matutang_kh(string str)
        {
            DataTable dt = new DataTable();
            dt = _select(str);
            string mkh;
            if (dt.Rows.Count == 0)
                mkh = "KH1";
            else
            {
                string makh = dt.Rows[dt.Rows.Count - 1][0].ToString();
                makh = makh.Substring(2);
                int so = int.Parse(makh) + 1;
                mkh = "KH";
                mkh = mkh + so.ToString();
            }
            return mkh;
        }
        public string matutang_nv(string str)
        {
            DataTable dt = new DataTable();
            dt = _select(str);
            string mnv;
            if (dt.Rows.Count == 0)
                mnv = "NV1";
            else
            {
                string manv = dt.Rows[dt.Rows.Count - 1][0].ToString();
                manv = manv.Substring(2);
                int so = int.Parse(manv) + 1;
                mnv = "NV";
                mnv = mnv + so.ToString();
            }
            return mnv;
        }
        public string matutang_bs(string str)
        {
            DataTable dt = new DataTable();
            dt = _select(str);
            string mbs;
            if (dt.Rows.Count == 0)
                mbs = "BS1";
            else
            {
                string mabs = dt.Rows[dt.Rows.Count - 1][0].ToString();
                mabs = mabs.Substring(2);
                int so = int.Parse(mabs) + 1;
                mbs = "BS";
                mbs = mbs + so.ToString();
            }
            return mbs;
        }
        public string matutang_lnv(string str)
        {
            DataTable dt = new DataTable();
            dt = _select(str);
            string mbs;
            if (dt.Rows.Count == 0)
                mbs = "LNV1";
            else
            {
                string mabs = dt.Rows[dt.Rows.Count - 1][1].ToString();
                mabs = mabs.Substring(3);
                int so = int.Parse(mabs) + 1;
                mbs = "LNV";
                mbs = mbs + so.ToString();
            }
            return mbs;
        }
        public string matutang_lbs(string str)
        {
            DataTable dt = new DataTable();
            dt = _select(str);
            string mbs;
            if (dt.Rows.Count == 0)
                mbs = "LBS1";
            else
            {
                string mabs = dt.Rows[dt.Rows.Count - 1][1].ToString();
                mabs = mabs.Substring(3);
                int so = int.Parse(mabs) + 1;
                mbs = "LBS";
                mbs = mbs + so.ToString();
            }
            return mbs;
        }
    }
}
