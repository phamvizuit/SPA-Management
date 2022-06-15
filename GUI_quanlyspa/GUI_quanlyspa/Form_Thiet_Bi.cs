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
    public partial class Form_Thiet_Bi : Form
    {
        BUS_QLBS bus = new BUS_QLBS();
        DTO_QLBS dto = new DTO_QLBS();
        BUS_CTDT bus_ctdt = new BUS_CTDT();
        DTO_LuongBS dto_lbs = new DTO_LuongBS();
        BUS_LuongBS bus_lbs = new BUS_LuongBS();
        BUS_HOADON bus_hd = new BUS_HOADON();

        BUS_LuongBS bus_nv = new BUS_LuongBS();
        BUS_QLNV bus_qlnv = new BUS_QLNV();
        public Form_Thiet_Bi()
        {
            InitializeComponent();
        }
        //contructor
        string manv_ = "";
        public Form_Thiet_Bi(string Message) : this()
        {
            manv_ = Message;
        }
        //code nut exit 
        private void picBox_iconExit_Click(object sender, EventArgs e)
        {
            DialogResult resu_lt = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (resu_lt == DialogResult.Yes)
                Application.Exit();
        }
        // code hover cho cac module
       
        //ket thuc
        //code chuc nang
        bool themDL;
        void set_null()
        {
            tb_mabs.Text = "";
            tb_hovaten.Text = "";
            cb_gioitinh.Text = "";
            tb_sdt.Text = "";            
            tb_luong.Text = "";
        }
        void taobang(string str)
        {
            bangbs.DataSource = bus._selectData(str);
        }
        void disable_box()
        {
            tb_mabs.Enabled = false;
            tb_hovaten.Enabled = false;
            cb_gioitinh.Enabled = false;
            tb_sdt.Enabled = false;
            tb_luong.Enabled = false;

            date_picker_nbd.Enabled = false;
            date_picker_nkt.Enabled = false;

            btn_luu.Hide();
            btn_them.Show();
            btn_sua.Show();
            btn_xoa.Show();
            btn_tl.Show();
        }
        void enable_box()
        {
            tb_hovaten.Enabled = true;
            cb_gioitinh.Enabled = true;
            tb_sdt.Enabled = true;
            tb_luong.Enabled = true;

            date_picker_nbd.Enabled = true;
            date_picker_nkt.Enabled = true;

            btn_luu.Show();
            btn_them.Hide();
            btn_sua.Hide();
            btn_xoa.Hide();
            btn_tl.Hide();
        }
        private void Form_Thiet_Bi_Load_1(object sender, EventArgs e)
        {
            string manv = manv_;//thay ma vn o day
            DataTable dt_lbnv = new DataTable();
            dt_lbnv = bus_qlnv._selectData("WHERE MANV='" + manv + "'");
            lb_dangxuat.Text = dt_lbnv.Rows[0]["HOTEN"].ToString();
            disable_box();
            cb_tinhluong.Hide();
            btn_tinhluong.Hide();
            taobang("");
        }
        private void btn_them_Click_1(object sender, EventArgs e)
        {
            enable_box();
            set_null();
            tb_mabs.Text = bus.matutang_bs("");
            themDL = true;
        }
        private void btn_sua_Click_1(object sender, EventArgs e)
        {
            enable_box();
            set_null();

            themDL = false;
        }
        private void btn_xoa_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (tb_mabs.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu cần xóa");
                    return;
                }
                DataTable dt_ctdt = new DataTable();
                DataTable dt_lbs = new DataTable();
                dt_ctdt = bus_ctdt._selectData("WHERE MABS='" + tb_mabs.Text + "'");
                dt_lbs = bus_nv._selectData("WHERE MABS='" + tb_mabs.Text + "'");
                if (dt_ctdt.Rows.Count != 0 || dt_lbs.Rows.Count != 0)
                {
                    MessageBox.Show("Không thể xóa bác sĩ này.");
                }
                else
                {
                    dto.MABS = tb_mabs.Text;
                    bus._deleteData(dto);
                    MessageBox.Show("Đã xóa thành công");
                }
                set_null();
                taobang("");
            }
            catch
            {
                MessageBox.Show("Lỗi");
                return;
            }
        }
        private void bangbs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_mabs.Text = bangbs.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_hovaten.Text = bangbs.Rows[e.RowIndex].Cells[1].Value.ToString();
                cb_gioitinh.Text = bangbs.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_sdt.Text = bangbs.Rows[e.RowIndex].Cells[3].Value.ToString();
                tb_luong.Text = bangbs.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi");
                return;
            }
        }
        
        private void lb_rs_Click_1(object sender, EventArgs e)
        {
            show();
            disable_box();
            set_null();
        }
        private void btn_luu_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            string j;
            if (tb_hovaten.Text == "" || cb_gioitinh.Text == ""||tb_sdt.Text==""||tb_luong.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else if (int.TryParse(tb_sdt.Text, out i) == false)
            {
                MessageBox.Show("Số điện thoại phải là số");
                return;
            }
            else if (int.TryParse(tb_luong.Text, out i) == false)
            {
                MessageBox.Show("Lương phải là số");
                return;
            }
            try
            {
                dto.MABS = tb_mabs.Text;
                dto.HOTEN = tb_hovaten.Text;
                dto.GIOITINH = cb_gioitinh.Text;
                dto.SDT = tb_sdt.Text;
                dto.LUONG = tb_luong.Text;
                dto.NBDHD = date_picker_nbd.Value.ToShortDateString();
                dto.NKTHD = date_picker_nkt.Value.ToShortDateString();
                if (themDL == true)
                {
                    bus._insertData(dto);
                    MessageBox.Show("Thêm mới thành công");
                }
                else if (themDL == false)
                {
                    bus._updateData(dto);
                    MessageBox.Show("Sửa thành công");
                }
                set_null();
                disable_box();
                taobang("");

            }
            catch
            {
                MessageBox.Show("Lỗi");
                return;
            }
        }
        private void pnl_logout_Click_1(object sender, EventArgs e)
        {
            DialogResult result_dx = MessageBox.Show("Đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result_dx == DialogResult.Yes)
            {
                Form_Login obj = new Form_Login();
                obj.Show();
                this.Hide();
            }
        }

        private void lb_dangxuat_Click_1(object sender, EventArgs e)
        {
            DialogResult result_dx = MessageBox.Show("Đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result_dx == DialogResult.Yes)
            {
                Form_Login obj = new Form_Login();
                obj.Show();
                this.Hide();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            DialogResult result_dx = MessageBox.Show("Đăng xuất?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (result_dx == DialogResult.Yes)
            {
                Form_Login obj = new Form_Login();
                obj.Show();
                this.Hide();
            }
        }
        //tính lương
        void hide()
        {
            tb_mabs.Hide();
            tb_hovaten.Hide();
            cb_gioitinh.Hide();
            tb_sdt.Hide();
            date_picker_nbd.Hide();
            date_picker_nkt.Hide();
            tb_luong.Hide();

            lb1.Hide();
            lb2.Hide();
            lb3.Hide();
            lb4.Hide();
            lb5.Hide();
            lb6.Hide();
            lb7.Hide();
            lb8.Hide();
            lb9.Hide();

            btn_luu.Hide();
            btn_them.Hide();
            btn_sua.Hide();
            btn_xoa.Hide();
            btn_tl.Hide();
        }
        void show()
        {
            tb_mabs.Show();
            tb_hovaten.Show();
            cb_gioitinh.Show();
            tb_sdt.Show();
            date_picker_nbd.Show();
            date_picker_nkt.Show();
            tb_luong.Show();

            lb1.Show();
            lb2.Show();
            lb3.Show();
            lb4.Show();
            lb5.Show();
            lb6.Show();
            lb7.Show();
            lb8.Show();
            lb9.Show();

            cb_tinhluong.Hide();
            btn_tinhluong.Hide();
        }

        private void btn_tl_Click(object sender, EventArgs e)
        {
            cb_tinhluong.Show();
            btn_tinhluong.Show();
            hide();
            //cb_manv
            cb_tinhluong.DataSource = bus._selectData("");
            cb_tinhluong.DisplayMember = "MABS";
            cb_tinhluong.ValueMember = "MABS";
            cb_tinhluong.Text = "";
        }

        private void btn_tinhluong_Click(object sender, EventArgs e)
        {
            if (cb_tinhluong.Text == "")
            {
                MessageBox.Show("Chưa chọn bác sĩ");
            }
            else
            {
                //tinh tien thuong
                float tienthuong = 0;
                //lay hd trong thang
                string thang=DateTime.Now.ToString("MM");
                DataTable dt_hd_thang = new DataTable();
                dt_hd_thang = bus_hd._selectData("WHERE MONTH(NGAYTAO)='" + thang + "'");
                if(dt_hd_thang.Rows.Count != 0)
                {
                    for(int i=0;i< dt_hd_thang.Rows.Count;i++)
                    {
                        //lay ctdt
                        DataTable dt_tienthuong = new DataTable();
                        dt_tienthuong = bus_ctdt._selectData("WHERE MABS='" + cb_tinhluong.Text + "' AND SOHD='"+ dt_hd_thang.Rows[i]["SOHD"] + "'");
                        if (dt_tienthuong.Rows.Count != 0)
                        {
                            for(int j=0;j< dt_tienthuong.Rows.Count;j++)
                            {
                                tienthuong = tienthuong + (int.Parse(dt_tienthuong.Rows[j]["THANHTIENLT"].ToString()) * 5 / 100);
                            }    
                        }
                    }    
                }    
                DataTable dt_qlbs_1 = new DataTable();
                dt_qlbs_1 = bus._selectData("WHERE MABS='" + cb_tinhluong.Text + "'");
                DateTime datetime = DateTime.UtcNow.Date;
                dto_lbs.MATT = bus_lbs.matutang_lbs("");
                dto_lbs.MABS = cb_tinhluong.Text;
                dto_lbs.TIENTHUONG = ((int)tienthuong).ToString();
                dto_lbs.NGAYTT = datetime.ToString("MM/dd/yyyy");
                dto_lbs.TONGTIEN = (int.Parse(dt_qlbs_1.Rows[0]["LUONG"].ToString())+ int.Parse(dto_lbs.TIENTHUONG)).ToString();
                bus_lbs._insertData(dto_lbs);
                MessageBox.Show("Đã thanh toán lương nhân viên " + cb_tinhluong.Text + " ngày " + datetime.ToString("MM/dd/yyyy") + " số tiền: " + dto_lbs.TONGTIEN + " đồng.");
            }
        }

        private void pnl_Home_MouseHover_1(object sender, EventArgs e)
        {
            pnl_Home.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void label1_MouseHover_1(object sender, EventArgs e)
        {
            pnl_Home.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pictureBox2_MouseHover_1(object sender, EventArgs e)
        {
            pnl_Home.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pnl_Home_MouseLeave_1(object sender, EventArgs e)
        {
            pnl_Home.BackColor = Color.FromArgb(14, 93, 71);
        }

        private void pnl_Nhanvien_MouseHover_1(object sender, EventArgs e)
        {
            pnl_Nhanvien.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void label2_MouseHover_1(object sender, EventArgs e)
        {
            pnl_Nhanvien.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pictureBox3_MouseHover_1(object sender, EventArgs e)
        {
            pnl_Nhanvien.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pnl_Nhanvien_MouseLeave_1(object sender, EventArgs e)
        {
            pnl_Nhanvien.BackColor = Color.FromArgb(14, 93, 71);
        }

        private void pnl_Mypham_MouseHover_1(object sender, EventArgs e)
        {
            pnl_Mypham.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void label3_MouseHover_1(object sender, EventArgs e)
        {
            pnl_Mypham.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pictureBox4_MouseHover_1(object sender, EventArgs e)
        {
            pnl_Mypham.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pnl_Mypham_MouseLeave_1(object sender, EventArgs e)
        {
            pnl_Mypham.BackColor = Color.FromArgb(14, 93, 71);
        }

        private void pnl_Lieutrinh_MouseHover(object sender, EventArgs e)
        {
            pnl_Lieutrinh.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            pnl_Lieutrinh.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            pnl_Lieutrinh.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pnl_Lieutrinh_MouseLeave(object sender, EventArgs e)
        {
            pnl_Lieutrinh.BackColor = Color.FromArgb(14, 93, 71);
        }

        private void pnl_Khachhang_MouseHover_1(object sender, EventArgs e)
        {
            pnl_Khachhang.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void label5_MouseHover_1(object sender, EventArgs e)
        {
            pnl_Khachhang.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pictureBox6_MouseHover_1(object sender, EventArgs e)
        {
            pnl_Khachhang.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pnl_Khachhang_MouseLeave_1(object sender, EventArgs e)
        {
            pnl_Khachhang.BackColor = Color.FromArgb(14, 93, 71);
        }

        private void pnl_Hoadon_MouseHover_1(object sender, EventArgs e)
        {
            pnl_Hoadon.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void label7_MouseHover_1(object sender, EventArgs e)
        {
            pnl_Hoadon.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pictureBox8_MouseHover_1(object sender, EventArgs e)
        {
            pnl_Hoadon.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pnl_Hoadon_MouseLeave_1(object sender, EventArgs e)
        {
            pnl_Hoadon.BackColor = Color.FromArgb(14, 93, 71);
        }

        private void pnl_Home_Click(object sender, EventArgs e)
        {
            Form_Home obj = new Form_Home(manv_);
            obj.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form_Home obj = new Form_Home(manv_);
            obj.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form_Home obj = new Form_Home(manv_);
            obj.Show();
            this.Hide();
        }

        private void pnl_Nhanvien_Click(object sender, EventArgs e)
        {
            Form_Nhan_vien obj = new Form_Nhan_vien(manv_);
            obj.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Form_Nhan_vien obj = new Form_Nhan_vien(manv_);
            obj.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Form_Nhan_vien obj = new Form_Nhan_vien(manv_);
            obj.Show();
            this.Hide();
        }

        private void pnl_Mypham_Click(object sender, EventArgs e)
        {
            Form_MYPHAM obj = new Form_MYPHAM(manv_);
            obj.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Form_MYPHAM obj = new Form_MYPHAM(manv_);
            obj.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Form_MYPHAM obj = new Form_MYPHAM(manv_);
            obj.Show();
            this.Hide();
        }

        private void pnl_Lieutrinh_Click(object sender, EventArgs e)
        {
            Form_Lieu_trinh obj = new Form_Lieu_trinh(manv_);
            obj.Show();
            this.Hide();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {
            Form_Lieu_trinh obj = new Form_Lieu_trinh(manv_);
            obj.Show();
            this.Hide();
        }

        private void pictureBox5_Click_1(object sender, EventArgs e)
        {
            Form_Lieu_trinh obj = new Form_Lieu_trinh(manv_);
            obj.Show();
            this.Hide();
        }

        private void pnl_Khachhang_Click(object sender, EventArgs e)
        {
            Form_Khach_hang obj = new Form_Khach_hang(manv_);
            obj.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Form_Khach_hang obj = new Form_Khach_hang(manv_);
            obj.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Form_Khach_hang obj = new Form_Khach_hang(manv_);
            obj.Show();
            this.Hide();
        }

        private void pnl_Hoadon_Click(object sender, EventArgs e)
        {
            Form_Hoa_don obj = new Form_Hoa_don(manv_);
            obj.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            Form_Hoa_don obj = new Form_Hoa_don(manv_);
            obj.Show();
            this.Hide();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            Form_Hoa_don obj = new Form_Hoa_don(manv_);
            obj.Show();
            this.Hide();
        }
    }
}
