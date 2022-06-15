using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using quanlyspa_DTO;
using BUS_quanlyspa;

namespace GUI_quanlyspa
{
    public partial class Form_Hoa_don : Form
    {
        public Form_Hoa_don()
        {
            InitializeComponent();
        }
        //contructor
        string manv_ = "";
        public Form_Hoa_don(string Message) : this()
        {
            manv_ = Message;
        }

        BUS_HOADON bus_hd = new BUS_HOADON();
        BUS_CTHD bus_cthd = new BUS_CTHD();
        BUS_QLNV bus_qlnv = new BUS_QLNV();
        BUS_KhachHang bus_kh = new BUS_KhachHang();
        BUS_MYPHAM bus_mp = new BUS_MYPHAM();
        BUS_CTDT bus_ctdt = new BUS_CTDT();
        BUS_QLBS bus_qlbs = new BUS_QLBS();
        BUS_LieuTrinh bus_lt = new BUS_LieuTrinh();

        DTO_HOADON dto_hd = new DTO_HOADON();
        DTO_CTHD dto_cthd = new DTO_CTHD();
        DTO_CTDT dto_ctdt = new DTO_CTDT();

        //chuyen  tab

        private void pnl_Home_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Home obj = new Form_Home(manv_);
            obj.Show();
            this.Hide();
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Home obj = new Form_Home(manv_);
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Home obj = new Form_Home(manv_);
            obj.Show();
            this.Hide();
        }

        private void pnl_Nhanvien_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Nhan_vien obj = new Form_Nhan_vien(manv_);
            obj.Show();
            this.Hide();
        }

        private void label2_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Nhan_vien obj = new Form_Nhan_vien(manv_);
            obj.Show();
            this.Hide();
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Nhan_vien obj = new Form_Nhan_vien(manv_);
            obj.Show();
            this.Hide();
        }

        private void pnl_Mypham_MouseClick(object sender, MouseEventArgs e)
        {
            Form_MYPHAM obj = new Form_MYPHAM(manv_);
            obj.Show();
            this.Hide();
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            Form_MYPHAM obj = new Form_MYPHAM(manv_);
            obj.Show();
            this.Hide();
        }

        private void pictureBox4_MouseClick(object sender, MouseEventArgs e)
        {
            Form_MYPHAM obj = new Form_MYPHAM(manv_);
            obj.Show();
            this.Hide();
        }

        private void pnl_Lieutrinh_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Lieu_trinh obj = new Form_Lieu_trinh(manv_);
            obj.Show();
            this.Hide();
        }

        private void label4_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Lieu_trinh obj = new Form_Lieu_trinh(manv_);
            obj.Show();
            this.Hide();
        }

        private void pictureBox5_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Lieu_trinh obj = new Form_Lieu_trinh(manv_);
            obj.Show();
            this.Hide();
        }

        private void pnl_Khachhang_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Khach_hang obj = new Form_Khach_hang(manv_);
            obj.Show();
            this.Hide();
        }

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Khach_hang obj = new Form_Khach_hang(manv_);
            obj.Show();
            this.Hide();
        }

        private void pictureBox6_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Khach_hang obj = new Form_Khach_hang(manv_);
            obj.Show();
            this.Hide();
        }

        private void pnl_Thietbi_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Thiet_Bi obj = new Form_Thiet_Bi(manv_);
            obj.Show();
            this.Hide();
        }

        private void label6_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Thiet_Bi obj = new Form_Thiet_Bi(manv_);
            obj.Show();
            this.Hide();
        }

        private void pictureBox7_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Thiet_Bi obj = new Form_Thiet_Bi(manv_);
            obj.Show();
            this.Hide();
        }
        // code exit
        private void picBox_iconExit_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult resu_lt = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (resu_lt == DialogResult.Yes)
                Application.Exit();
        }
        // code hover cho cac module
        private void pnl_Home_MouseHover(object sender, EventArgs e)
        {
            pnl_Home.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pnl_Home_MouseLeave(object sender, EventArgs e)
        {
            pnl_Home.BackColor = Color.FromArgb(14, 93, 71);
        }

        private void pnl_Nhanvien_MouseHover(object sender, EventArgs e)
        {
            pnl_Nhanvien.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pnl_Nhanvien_MouseLeave(object sender, EventArgs e)
        {
            pnl_Nhanvien.BackColor = Color.FromArgb(14, 93, 71);
        }

        private void pnl_Mypham_MouseHover(object sender, EventArgs e)
        {
            pnl_Mypham.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pnl_Mypham_MouseLeave(object sender, EventArgs e)
        {
            pnl_Mypham.BackColor = Color.FromArgb(14, 93, 71);
        }

        private void pnl_Khachhang_MouseHover(object sender, EventArgs e)
        {
            pnl_Khachhang.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pnl_Khachhang_MouseLeave(object sender, EventArgs e)
        {
            pnl_Khachhang.BackColor = Color.FromArgb(14, 93, 71);
        }

        private void pnl_Thietbi_MouseHover(object sender, EventArgs e)
        {
            pnl_Thietbi.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pnl_Thietbi_MouseLeave(object sender, EventArgs e)
        {
            pnl_Thietbi.BackColor = Color.FromArgb(14, 93, 71);
        }




        private void label1_MouseHover(object sender, EventArgs e)
        {
            pnl_Home.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            pnl_Nhanvien.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            pnl_Mypham.BackColor = Color.FromArgb(147, 211, 124);
        }


        private void label5_MouseHover(object sender, EventArgs e)
        {
            pnl_Khachhang.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            pnl_Thietbi.BackColor = Color.FromArgb(147, 211, 124);
        }



        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pnl_Home.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pnl_Nhanvien.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pnl_Mypham.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pnl_Khachhang.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pnl_Thietbi.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pnl_Lieutrinh_MouseHover(object sender, EventArgs e)
        {
            pnl_Lieutrinh.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pnl_Lieutrinh_MouseLeave(object sender, EventArgs e)
        {
            pnl_Lieutrinh.BackColor = Color.FromArgb(14, 93, 71);
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            pnl_Lieutrinh.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pnl_Lieutrinh.BackColor = Color.FromArgb(147, 211, 124);
        }
        void setnull()
        {
            comboBox_tenkh.Text = "";
            txt_box_sdt.Text = "";
            txt_box_makh.Text = "";
            txt_box_tennv.Text = "";
            txt_box_mahd.Text = "";
            comboBox_manv.Text = "";
            lb_date.Text = "";

            banglt1.Rows.Clear();
            banglt.Rows.Clear();
        }
        //code chuc nang
        private void Form_Hoa_don_Load(object sender, EventArgs e)
        {
            //hienthi lb dang xuat
            string manv = manv_;//thay ma vn o day
            DataTable dt_lbnv = new DataTable();
            dt_lbnv = bus_qlnv._selectData("WHERE MANV='" + manv + "'");
            lb_dangxuat.Text = dt_lbnv.Rows[0]["HOTEN"].ToString();
            //null date
            lb_date.Text = "";
            //an 6 thuoc tinh
            btn_mo.Hide();
            btn_xoa.Hide();
            lb_mahd1.Hide();
            comboBox_mahd1.Hide();
            bangmp_hienthi.Hide();
            banglt_hienthi.Hide();
            //combobox mypham
            Col_tenmp.DataSource = bus_mp._selectData("WHERE SOLUONGTONKHO>0");
            Col_tenmp.DisplayMember = "TENMP";
            Col_tenmp.ValueMember = "MAMP";
            //combobox lieutrinh
            Col_tenlt.DataSource = bus_lt._selectData("");
            Col_tenlt.DisplayMember = "TENLT";
            Col_tenlt.ValueMember = "MALT";
            //combobox bacsi
            Col_mabs.DataSource = bus_qlbs._selectData("");
            Col_mabs.DisplayMember = "HOTEN";
            Col_mabs.ValueMember = "MABS";
            //combobox tenkh
            comboBox_tenkh.DataSource = bus_kh._selectData("");
            comboBox_tenkh.DisplayMember = "HOTEN";
            comboBox_tenkh.ValueMember = "MAKH";
            comboBox_tenkh.Text = "";
            //combobox manhanvien
            comboBox_manv.DataSource = bus_qlnv._selectData("");
            comboBox_manv.DisplayMember = "MANV";
            comboBox_manv.ValueMember = "MANV";
            comboBox_manv.Text = "";
        }
        
        //gridview mypham
        int dong=0;
        int tong_tien = 0;
        private void banglt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong = e.RowIndex;
            if (dong != -1)
            {
                if (banglt.Rows[dong].Cells[1].Value != null)
                    Col_soluong.ReadOnly = false;
                else
                    Col_soluong.ReadOnly = true;
            }
            
        }
        bool kiem_tra_sl_tk()
        {
            for (int i = 0; i < banglt.Rows.Count - 1; i++)
            {
                string a = banglt.Rows[i].Cells[2].Value.ToString();
                string b = banglt.Rows[i].Cells[3].Value.ToString();
                if (int.Parse(a) > int.Parse(b))
                {
                    return true;
                }
            }
            return false;
        }
        private void banglt_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
            if (banglt.Rows[dong].Cells[2].Value != null && banglt.Rows[dong].Cells[4].Value != null)
            {
                try
                {
                    banglt.Rows[dong].Cells[5].Value = (double.Parse(banglt.Rows[dong].Cells[2].Value.ToString()) * double.Parse(banglt.Rows[dong].Cells[4].Value.ToString())).ToString();
                }
                catch 
                { }
            }
            
            //fill du lieu vao cac cot
            try
            {
                DataTable dt_mp = new DataTable();
                dt_mp = bus_mp._selectData("WHERE MAMP='" + banglt.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");
                
                banglt.Rows[dong].Cells[0].Value = dt_mp.Rows[0]["MAMP"].ToString();
                banglt.Rows[dong].Cells[3].Value = dt_mp.Rows[0]["SOLUONGTONKHO"].ToString();
                banglt.Rows[dong].Cells[4].Value = dt_mp.Rows[0]["GIABAN"].ToString();
            }
            catch { return; }

            int temp=0;
            for (int i = 0; i < banglt.Rows.Count - 1; i++)
            {
                if (banglt.Rows[i].Cells[1].Value != null && banglt.Rows[i].Cells[2].Value == null)
                    banglt.Rows[i].Cells[2].Value = "1";

                
            }
            for (int i = 0; i < banglt.Rows.Count - 1; i++)
            {    
                if (int.TryParse(banglt.Rows[i].Cells[2].Value.ToString(), out temp) == false)
                {
                    banglt.Rows.RemoveAt(i);
                    MessageBox.Show("số lượng phải là số.");

                    return;
                }
                
            }
            if (int.Parse(banglt.Rows[e.RowIndex].Cells[2].Value.ToString()) > int.Parse(banglt.Rows[e.RowIndex].Cells[3].Value.ToString()))
            {
                MessageBox.Show("số lượng phải nhỏ hơn tồn kho.");
                return;
            }
            //tinh tong tien hoa don
            tong_tien = 0;
            for (int i = 0; i < banglt.Rows.Count - 1; i++)
            {
                if(banglt.Rows[i].Cells[5].Value !=null)
                    tong_tien = tong_tien + int.Parse(banglt.Rows[i].Cells[5].Value.ToString());
            }
            for (int i = 0; i < banglt1.Rows.Count - 1; i++)
            {
                if (banglt1.Rows[i].Cells[5].Value != null)
                    tong_tien = tong_tien + int.Parse(banglt1.Rows[i].Cells[5].Value.ToString());
            }
            //string tt = tong_tien.ToString();
            lb_tongtien.Text = tong_tien.ToString();
            //mo khoa so luong
            Col_soluong.ReadOnly = true;
        }
        //gridview lieutrinh
        int dong1 = 0;

        private void banglt1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dong1 = e.RowIndex;
            if (dong1 != -1)
            {
                if (banglt1.Rows[dong1].Cells[1].Value != null)
                {
                    Col_sl.ReadOnly = false;
                    Col_mabs.ReadOnly = false;
                }
                else
                {
                    Col_sl.ReadOnly = true;
                    Col_mabs.ReadOnly = true;
                }
            }
        }

        private void banglt1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (banglt1.Rows[dong1].Cells[3].Value != null && banglt1.Rows[dong1].Cells[4].Value != null)
            {
                try
                {
                    banglt1.Rows[dong1].Cells[5].Value = (double.Parse(banglt1.Rows[dong1].Cells[3].Value.ToString()) * double.Parse(banglt1.Rows[dong1].Cells[4].Value.ToString())).ToString();
                }
                catch
                { }
            }
            try
            {
                DataTable dt_lt = new DataTable();
                dt_lt = bus_lt._selectData("WHERE MALT='" + banglt1.Rows[e.RowIndex].Cells[1].Value.ToString() + "'");
                banglt1.Rows[dong1].Cells[0].Value = dt_lt.Rows[0]["MALT"].ToString();
                banglt1.Rows[dong1].Cells[2].Value = dt_lt.Rows[0]["THOIGIANDT"].ToString();
                banglt1.Rows[dong1].Cells[4].Value = dt_lt.Rows[0]["GIATIEN"].ToString();
            }
            catch
            {

            }
            // them so luong con trong
            for (int i = 0; i < banglt1.Rows.Count - 1; i++)
            {
                if (banglt1.Rows[i].Cells[1].Value != null && banglt1.Rows[i].Cells[3].Value == null)
                    banglt1.Rows[i].Cells[3].Value = "1";
            }
            //tinh tong tien hoa don
            tong_tien = 0;
            for (int i = 0; i < banglt1.Rows.Count - 1; i++)
            {
                if (banglt1.Rows[i].Cells[5].Value != null)
                    tong_tien = tong_tien + int.Parse(banglt1.Rows[i].Cells[5].Value.ToString());
            }
            for (int i = 0; i < banglt.Rows.Count - 1; i++)
            {
                if (banglt.Rows[i].Cells[4].Value != null)
                    tong_tien = tong_tien + int.Parse(banglt.Rows[i].Cells[5].Value.ToString());
            }
            //string tt = tong_tien.ToString();
            lb_tongtien.Text = tong_tien.ToString();
            //mo khoa soluong + bac si
            Col_sl.ReadOnly = true;
            Col_mabs.ReadOnly = true;
        }
        // thong tin kh-nhan vien
        private void comboBox_tenkh_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_kh = new DataTable();
                dt_kh = bus_kh._selectData("WHERE MAKH= '" + comboBox_tenkh.SelectedValue.ToString() + "' ");
                txt_box_sdt.Text = dt_kh.Rows[0]["DIENTHOAI"].ToString();
                txt_box_makh.Text = dt_kh.Rows[0]["MAKH"].ToString();
            }
            catch
            {

            }
        }
        private void comboBox_manv_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_qlnv = new DataTable();
                dt_qlnv = bus_qlnv._selectData("WHERE MANV= '" + comboBox_manv.SelectedValue.ToString() + "' ");
                txt_box_tennv.Text = dt_qlnv.Rows[0]["HOTEN"].ToString();
            }
            catch
            {

            }
        }


        //check soluongmp
        bool check_slmp()
        {
            for (int i = 0; i < banglt.Rows.Count - 1; i++)
            {
                if (banglt.Rows[i].Cells[2].Value == null)
                    return true;
            }
            return false;
        }
        //check soluonglt
        bool check_sllt()
        {
            for (int i = 0; i < banglt1.Rows.Count - 1; i++)
            {
                if (banglt1.Rows[i].Cells[3].Value == null)
                    return true;
            }
            return false;
        }
        //btn tao hoa don
        private void btn_luu_Click(object sender, EventArgs e)
        {
            // kiem tra thieu du lieu
            if (txt_box_sdt.Text=="" || txt_box_tennv.Text==""|| txt_box_mahd.Text=="" )
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.");
                return;
            }
            else if(banglt1.Rows.Count <=1 && banglt.Rows.Count <=1 )
            {
                MessageBox.Show("Vui lòng chọn tối thiểu 1 sản phẩm hoặc 1 liệu trình.");
                return;
            }  
            else if(check_slmp()==true)
            {
                MessageBox.Show("Vui lòng nhập số lượng.");
                return;
            }
            else if (check_sllt() == true)
            {
                MessageBox.Show("Vui lòng nhập số lượng.");
                return;
            }

            else
            {
                for (int i = 0; i < banglt.Rows.Count - 1; i++)
                {
                    if (int.Parse(banglt.Rows[i].Cells[2].Value.ToString()) > int.Parse(banglt.Rows[i].Cells[3].Value.ToString()))
                    {
                        MessageBox.Show("Số lượng phải nhỏ hơn tồn kho.");
                        MessageBox.Show("Tạo hóa đơn thất bại.");
                        return;
                    }
                }
                for (int i = 0; i < banglt.Rows.Count - 2; i++)
                {
                    for (int j = i+1; j < banglt.Rows.Count -1; j++)
                    {
                        if (banglt.Rows[i].Cells[0].Value.ToString()== banglt.Rows[j].Cells[0].Value.ToString())
                        {
                            MessageBox.Show("Trùng sản phẩm "+ banglt.Rows[i].Cells[0].Value.ToString());
                            MessageBox.Show("Tạo hóa đơn thất bại.");
                            return;
                        }
                    }
                }
                for (int i = 0; i < banglt1.Rows.Count - 1; i++)
                {
                    

                    if (banglt1.Rows[i].Cells[6].Value == null)
                    {
                        MessageBox.Show("Vui lòng chọn bác sĩ.");
                        return;
                    }
                }
                for (int i = 0; i < banglt1.Rows.Count - 2; i++)
                {
                    for (int j = i + 1; j < banglt1.Rows.Count - 1; j++)
                    {
                        if (banglt1.Rows[i].Cells[0].Value.ToString() == banglt1.Rows[j].Cells[0].Value.ToString())
                        {
                            MessageBox.Show("Trùng liệu trình "+ banglt1.Rows[i].Cells[0].Value.ToString());
                            MessageBox.Show("Tạo hóa đơn thất bại.");
                            return;
                        }
                    }
                }
                //nap du lieu hoadon
                dto_hd.SOHD = txt_box_mahd.Text;
                dto_hd.MAKH = txt_box_makh.Text;
                dto_hd.TONGTIEN = lb_tongtien.Text;
                dto_hd.MANV = comboBox_manv.Text;
                dto_hd.NGAYTAO = lb_date.Text;
                try { bus_hd._insertData(dto_hd); } catch { }
                //nap du lieu mypham
                try
                {
                    for (int i = 0; i < banglt.Rows.Count - 1; i++)
                    {
                        dto_cthd.SOHD = txt_box_mahd.Text;
                        dto_cthd.MAMP = banglt.Rows[i].Cells[0].Value.ToString();
                        dto_cthd.THANHTIENMP = banglt.Rows[i].Cells[5].Value.ToString(); ;
                        dto_cthd.SOLUONG = banglt.Rows[i].Cells[2].Value.ToString(); ;
                        bus_cthd._insertData(dto_cthd);
                    }
                }
                catch { }
                //nap du lieu lieutrinh
                try
                {
                    for (int i = 0; i < banglt1.Rows.Count - 1; i++)
                    {
                        dto_ctdt.MALT = banglt1.Rows[i].Cells[0].Value.ToString();
                        dto_ctdt.MABS = banglt1.Rows[i].Cells[6].Value.ToString();
                        dto_ctdt.SOHD = txt_box_mahd.Text;
                        dto_ctdt.SOLUONG = banglt1.Rows[i].Cells[3].Value.ToString();
                        dto_ctdt.THANHTIENLT = banglt1.Rows[i].Cells[5].Value.ToString();
                        bus_ctdt._insertData(dto_ctdt);
                    }
                }
                catch { }

                // tru so luong trong my pham
                try
                {
                    for (int i = 0; i < banglt.Rows.Count - 1; i++)
                    {
                        int sl_updated = 0;
                        sl_updated=int.Parse(banglt.Rows[i].Cells[3].Value.ToString())- int.Parse(banglt.Rows[i].Cells[2].Value.ToString());
                        bus_mp._updatesl("WHERE MAMP='" + banglt.Rows[i].Cells[0].Value.ToString() + "'", sl_updated);
                    }
                }
                catch { }
                MessageBox.Show("Tạo hóa đơn thành công");

                setnull();
        
            }    
            
        }
        //ma tu tang hoa don
        private void label9_MouseClick(object sender, MouseEventArgs e)
        {
            //ma tu tang hoa don
            DateTime datetime = DateTime.UtcNow.Date;
            txt_box_mahd.Text = bus_hd.matutang_hoadon("");
            lb_date.Text = datetime.ToString("MM/dd/yyyy");
        }
        // xoa 1 dong my pham
        private void lb_xoamp_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                banglt.Rows.RemoveAt(dong);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.");
            }

        }
        //xoa 1 dong lieu trinh
        private void lb_xoalt_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                banglt1.Rows.RemoveAt(dong1);
            }
            catch
            {
                MessageBox.Show("Vui lòng chọn dòng cần xóa.");
            }
        }
        //tinh lai tong tien sau khi xoa 1 dong bang mp
        private void banglt_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            tong_tien = 0;
            for (int i = 0; i < banglt1.Rows.Count - 1; i++)
            {
                if (banglt1.Rows[i].Cells[5].Value != null)
                    tong_tien = tong_tien + int.Parse(banglt1.Rows[i].Cells[5].Value.ToString());
            }
            for (int i = 0; i < banglt.Rows.Count - 1; i++)
            {
                if (banglt.Rows[i].Cells[5].Value != null)
                    tong_tien = tong_tien + int.Parse(banglt.Rows[i].Cells[5].Value.ToString());
            }
            lb_tongtien.Text = tong_tien.ToString();
        }
        //tinh lai tong tien sau khi xoa 1 dong bang lt
        private void banglt1_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            tong_tien = 0;
            for (int i = 0; i < banglt1.Rows.Count - 1; i++)
            {
                if (banglt1.Rows[i].Cells[5].Value != null)
                    tong_tien = tong_tien + int.Parse(banglt1.Rows[i].Cells[5].Value.ToString());
            }
            for (int i = 0; i < banglt.Rows.Count - 1; i++)
            {
                if (banglt.Rows[i].Cells[5].Value != null)
                    tong_tien = tong_tien + int.Parse(banglt.Rows[i].Cells[5].Value.ToString());
            }
            lb_tongtien.Text = tong_tien.ToString();
        }
        
        void _hide1()
        {
            lb_tenkh.Hide();
            lb_sdt.Hide();
            lb_makh.Hide();
            lb_tennv.Hide();
            lb_mahd.Hide();
            lb_manv.Hide();

            comboBox_tenkh.Hide();
            comboBox_manv.Hide();

            txt_box_sdt.Hide();
            txt_box_makh.Hide();
            txt_box_tennv.Hide();
            txt_box_mahd.Hide();

            label9.Hide();
            pnl_date.Hide();

            btn_xemhd.Hide(); //nut xem hoa don
            btn_luu.Hide();
            //lb_rs.Hide();
            banglt.Hide();
            banglt1.Hide();
            lb_xoamp.Hide();
            lb_xoalt.Hide();
        }
        void _hide2()
        {
            btn_mo.Hide();
            btn_xoa.Hide();
            lb_mahd1.Hide();
            comboBox_mahd1.Hide(); 

        }
        void _show2()
        {
            lb_tenkh.Show();
            lb_sdt.Show();
            lb_makh.Show();
            lb_tennv.Show();
            lb_mahd.Show();
            lb_manv.Show();

            comboBox_tenkh.Show();
            comboBox_manv.Show();

            txt_box_sdt.Show();
            txt_box_makh.Show();
            txt_box_tennv.Show();
            txt_box_mahd.Show();

            label9.Show();
            pnl_date.Show();

            btn_xemhd.Show(); //nut xem hoa don
            btn_luu.Show();
            //lb_rs.Show();
        }
        void _show1()
        {
            btn_mo.Show();
            btn_xoa.Show();
            lb_mahd1.Show();
            comboBox_mahd1.Show();
            banglt_hienthi.Show();
            bangmp_hienthi.Show();
        }
        // nut mo hoa don
        private void btn_xemhd_Click(object sender, EventArgs e)
        {
            _hide1();
            _show1();
            banglt_hienthi.Rows.Clear();
            bangmp_hienthi.Rows.Clear();

            comboBox_mahd1.DataSource = bus_hd._selectData("");
            comboBox_mahd1.DisplayMember = "SOHD";
            comboBox_mahd1.ValueMember = "SOHD";
        }
        // code nut reset
        private void lb_rs_MouseClick(object sender, MouseEventArgs e)
        {
            _hide2();
            _show2();
            banglt_hienthi.Hide();
            bangmp_hienthi.Hide();
            banglt.Show();
            banglt1.Show();
            lb_xoamp.Show();
            lb_xoalt.Show();
            comboBox_tenkh.Enabled = true;
            comboBox_manv.Enabled =true;
            setnull();
        }
        // code nut mo
        private void btn_mo_Click(object sender, EventArgs e)
        {
            if(comboBox_mahd1.Text==null || comboBox_mahd1.Text == "")
            {
                MessageBox.Show("Vui lòng chọn hóa đơn.");
            }
            else
            {
                DataTable dt_hd = new DataTable();
                dt_hd = bus_hd._selectData("WHERE SOHD= '" + comboBox_mahd1.Text.ToString() + "' ");
                // hide show
                _hide2();
                _show2();
                banglt_hienthi.Show();
                bangmp_hienthi.Show();
                btn_luu.Hide();
                label9.Hide();
                comboBox_tenkh.Enabled = false;
                comboBox_manv.Enabled=false;
                // lay du lieu bang hoa don
                txt_box_mahd.Text = dt_hd.Rows[0]["SOHD"].ToString();
                comboBox_manv.Text= dt_hd.Rows[0]["MANV"].ToString();
                txt_box_makh.Text= dt_hd.Rows[0]["MAKH"].ToString();
                lb_tongtien.Text= dt_hd.Rows[0]["TONGTIEN"].ToString();
                lb_date.Text= (dt_hd.Rows[0]["NGAYTAO"].ToString()).Substring(0,10);// sua lai MM/DD/YYYY
                //lay du lieu bang khach hang
                DataTable dt_kh = new DataTable();
                dt_kh = bus_kh._selectData("WHERE MAKH= '" + txt_box_makh.Text + "' ");
                comboBox_tenkh.Text=dt_kh.Rows[0]["HOTEN"].ToString();
                txt_box_sdt.Text= dt_kh.Rows[0]["DIENTHOAI"].ToString();
                //lay du lieu bang QLNV
                DataTable dt_qlnv = new DataTable();
                dt_qlnv = bus_qlnv._selectData("WHERE MANV= '" + comboBox_manv.Text + "' ");
                txt_box_tennv.Text = dt_qlnv.Rows[0]["HOTEN"].ToString();
                // fill danh sach my pham
                //CTHD
                DataTable dt_cthd = new DataTable();
                dt_cthd = bus_cthd._selectData("WHERE SOHD= '" + comboBox_mahd1.Text + "' ");
                //CTDT
                DataTable dt_ctdt = new DataTable();
                dt_ctdt = bus_ctdt._selectData("WHERE SOHD= '" + comboBox_mahd1.Text + "' ");
                int temp = dt_cthd.Rows.Count;
                //mypham
                DataTable dt_mp = new DataTable();
                //lieutrinh
                DataTable dt_lt = new DataTable();
                //QLBS
                DataTable dt_qlbs = new DataTable();
                for (int i=0;i<dt_cthd.Rows.Count;i++)
                {
                    //tt chinh
                    string cell_0 = dt_cthd.Rows[i]["MAMP"].ToString(); 
                    string cell_2 = dt_cthd.Rows[i]["SOLUONG"].ToString();
                    string cell_4 = dt_cthd.Rows[i]["THANHTIENMP"].ToString();
                    ////tt phu
                    dt_mp = bus_mp._selectData("WHERE MAMP= '" + dt_cthd.Rows[i]["MAMP"].ToString() + "' ");
                    string cell_1 = dt_mp.Rows[0]["TENMP"].ToString();
                    string cell_3 = dt_mp.Rows[0]["GIABAN"].ToString();
                    bangmp_hienthi.Rows.Add(cell_0, cell_1, cell_2, cell_3, cell_4);
                }
                for (int i = 0; i < dt_ctdt.Rows.Count; i++)
                {
                    //tt chinh
                    string cell_0 = dt_ctdt.Rows[i]["MALT"].ToString();
                    string cell_3 = dt_ctdt.Rows[i]["SOLUONG"].ToString();
                    string cell_5 = dt_ctdt.Rows[i]["THANHTIENLT"].ToString();
                    //tt phu
                    dt_lt = bus_lt._selectData("WHERE MALT= '" + dt_ctdt.Rows[i]["MALT"].ToString() + "' ");
                    string cell_1 = dt_lt.Rows[0]["TENLT"].ToString();
                    string cell_2 = dt_lt.Rows[0]["THOIGIANDT"].ToString();
                    string cell_4 = dt_lt.Rows[0]["GIATIEN"].ToString();
                    //ten bs
                    dt_qlbs = bus_qlbs._selectData("WHERE MABS= '" + dt_ctdt.Rows[i]["MABS"].ToString() + "' ");
                    string cell_6 = dt_qlbs.Rows[0]["HOTEN"].ToString();
                    banglt_hienthi.Rows.Add(cell_0, cell_1, cell_2, cell_3, cell_4, cell_5, cell_6);
                }
            }
        }
        //code nut xoa
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (comboBox_mahd1.Text == null)
            {
                MessageBox.Show("Vui lòng chọn hóa đơn cần xóa.");
                return;
            }
            else
            {
                bus_ctdt._deleteData("WHERE SOHD=  '" + comboBox_mahd1.Text.ToString() + "' ");
                bus_cthd._deleteData("WHERE SOHD=  '" + comboBox_mahd1.Text.ToString() + "' ");
                bus_hd._deleteData("WHERE SOHD=  '" + comboBox_mahd1.Text.ToString() + "' ");
                MessageBox.Show("Xóa hóa đơn thành công");
                comboBox_mahd1.DataSource = bus_hd._selectData("");
                comboBox_mahd1.DisplayMember = "SOHD";
                comboBox_mahd1.ValueMember = "SOHD";
                comboBox_mahd1.Text = null;
            }
        }
        //code dang xuat


        private void lb_dangxuat_Click(object sender, EventArgs e)
        {
            DialogResult result_dx = MessageBox.Show("Đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result_dx == DialogResult.Yes)
            {
                Form_Login obj = new Form_Login();
                obj.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DialogResult result_dx = MessageBox.Show("Đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result_dx == DialogResult.Yes)
            {
                Form_Login obj = new Form_Login();
                obj.Show();
                this.Hide();
            }
        }

        private void pnl_logout_Click(object sender, EventArgs e)
        {
            DialogResult result_dx = MessageBox.Show("Đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result_dx == DialogResult.Yes)
            {
                Form_Login obj = new Form_Login();
                obj.Show();
                this.Hide();
            }
        }


    }
}
