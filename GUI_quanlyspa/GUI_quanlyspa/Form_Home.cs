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
    public partial class Form_Home : Form
    {
        public Form_Home()
        {
            InitializeComponent();
        }
        //contructor
        string manv_="";
        public Form_Home(string Message) : this()
        {
            manv_ = Message;
        }


        BUS_HOADON bus_hd = new BUS_HOADON();
        BUS_LuongBS bus_lbs = new BUS_LuongBS();
        BUS_LuongNV bus_lnv = new BUS_LuongNV();
        BUS_NhapMP bus_nmp = new BUS_NhapMP();
        BUS_QLNV bus_nv = new BUS_QLNV();
        //code nut exit 
        private void picBox_iconExit_MouseClick(object sender, MouseEventArgs e)
        {
            DialogResult resu_lt = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (resu_lt == DialogResult.Yes)
                Application.Exit();
        }
        // code hover cho cac module


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

        private void pnl_Lieutrinh_MouseHover(object sender, EventArgs e)
        {
            pnl_Lieutrinh.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pnl_Lieutrinh_MouseLeave(object sender, EventArgs e)
        {
            pnl_Lieutrinh.BackColor = Color.FromArgb(14, 93, 71);
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

        private void pnl_Hoadon_MouseHover(object sender, EventArgs e)
        {
            pnl_Hoadon.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pnl_Hoadon_MouseLeave(object sender, EventArgs e)
        {
            pnl_Hoadon.BackColor = Color.FromArgb(14, 93, 71);
        }

     

        private void label2_MouseHover(object sender, EventArgs e)
        {
            pnl_Nhanvien.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            pnl_Mypham.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            pnl_Lieutrinh.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            pnl_Khachhang.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            pnl_Thietbi.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            pnl_Hoadon.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pnl_Nhanvien.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pictureBox4_MouseHover(object sender, EventArgs e)
        {
            pnl_Mypham.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pnl_Lieutrinh.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
        {
            pnl_Khachhang.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
        {
            pnl_Thietbi.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pnl_Hoadon.BackColor = Color.FromArgb(147, 211, 124);
        }
        //ketthuc
        //code chuyen tab cho cac module
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

        private void pnl_Hoadon_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Hoa_don obj = new Form_Hoa_don(manv_);
            obj.Show();
            this.Hide();
        }

        private void label7_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Hoa_don obj = new Form_Hoa_don(manv_);
            obj.Show();
            this.Hide();
        }

        private void pictureBox8_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Hoa_don obj = new Form_Hoa_don(manv_);
            obj.Show();
            this.Hide();
        }
        //ket thuc
        private void btn_tinhthu_Click(object sender, EventArgs e)
        {
            banghd.Rows.Clear();
            DataTable dt_hd = new DataTable();
            dt_hd = bus_hd._selectData("WHERE NGAYTAO='" + date_picker_thu.Value.ToShortDateString() + "'");
            if (dt_hd.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu.");
                return;
            }
            int thu = 0;
            for (int i = 0; i < dt_hd.Rows.Count; i++)
            {
                string cell_0 = dt_hd.Rows[i]["SOHD"].ToString();
                string cell_1 = dt_hd.Rows[i]["MAKH"].ToString();
                string cell_2 = (dt_hd.Rows[i]["NGAYTAO"].ToString()).Substring(0,10);
                string cell_3 = dt_hd.Rows[i]["MANV"].ToString();
                string cell_4 = dt_hd.Rows[i]["TONGTIEN"].ToString();
                banghd.Rows.Add(cell_0, cell_1, cell_2, cell_3, cell_4);
                thu = thu + int.Parse(cell_4);
            }
            lb_tongtienthu.Text = thu.ToString();
        }

        private void btn_tinhchi_Click(object sender, EventArgs e)
        {
            bang_luongbs.Rows.Clear();
            bang_luongnv.Rows.Clear();
            bang_nhapmp.Rows.Clear();
            int chi = 0;
            //bang luong bs
            DataTable dt_lbs = new DataTable();
            dt_lbs = bus_lbs._selectData("WHERE NGAYTT='" + date_picker_chi.Value.ToShortDateString() + "'");
            if (dt_lbs.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu lương bác sĩ.");
            }
            else
            {
                for (int i = 0; i < dt_lbs.Rows.Count; i++)
                {
                    //tt chinh
                    string cell_0 = dt_lbs.Rows[i]["MABS"].ToString();
                    string cell_1 = dt_lbs.Rows[i]["TIENTHUONG"].ToString();
                    string cell_2 = dt_lbs.Rows[i]["TONGTIEN"].ToString();
                    bang_luongbs.Rows.Add(cell_0, cell_1, cell_2);
                    chi = chi + int.Parse(cell_2);
                }
            }    
            //bang luong nv
            DataTable dt_lnv = new DataTable();
            dt_lnv = bus_lnv._selectData("WHERE NGAYTT='" + date_picker_chi.Value.ToShortDateString() + "'");
            if (dt_lnv.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu lương nhân viên.");
            }
            else
            {
                for (int i = 0; i < dt_lnv.Rows.Count; i++)
                {
                    //tt chinh
                    string cell_0 = dt_lnv.Rows[i]["MANV"].ToString();
                    string cell_1 = dt_lnv.Rows[i]["TONGTIEN"].ToString();
                    bang_luongnv.Rows.Add(cell_0, cell_1);
                    chi = chi + int.Parse(cell_1);
                }
            }
            //bang nhap my pham
            DataTable dt_nmp = new DataTable();
            dt_nmp = bus_nmp._selectData("WHERE NGAYNHAP='" + date_picker_chi.Value.ToShortDateString() + "'");
            if (dt_nmp.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu nhập mỹ phẩm.");
            }
            else
            {
                for (int i = 0; i < dt_nmp.Rows.Count; i++)
                {
                    string cell_0 = dt_nmp.Rows[i]["MAMP"].ToString();
                    string cell_1 = dt_nmp.Rows[i]["THANHTIENDH"].ToString();
                    bang_nhapmp.Rows.Add(cell_0, cell_1);
                    chi = chi + int.Parse(cell_1);
                }
            }         
            //tinh tong chi
            lb_tongtienchi.Text = chi.ToString();
        }
        //load form
        void setnull()
        {
            lb_manv.Text = "";
            lb_ten.Text = "";
            lb_sdt.Text = "";
            lb_dangxuat.Text = "";
        }
        private void Form_Home_Load(object sender, EventArgs e)
        {
            setnull();
            string manv = manv_;//thay ma vn o day
            DataTable dt_nv = new DataTable();
            dt_nv = bus_nv._selectData("WHERE MANV='" + manv + "'");
            lb_manv.Text = manv;
            lb_ten.Text = dt_nv.Rows[0]["HOTEN"].ToString();
            lb_sdt.Text = dt_nv.Rows[0]["SDT"].ToString();
            lb_dangxuat.Text = dt_nv.Rows[0]["HOTEN"].ToString();
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





        //ket thuc
    }
}
