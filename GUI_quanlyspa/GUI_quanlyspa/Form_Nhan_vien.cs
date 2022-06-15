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
    public partial class Form_Nhan_vien : Form
    {
        BUS_QLNV bus = new BUS_QLNV();
        DTO_QLNV dto = new DTO_QLNV();
        BUS_HOADON bus_hd = new BUS_HOADON();
        BUS_NhapMP bus_nmp = new BUS_NhapMP();
        DTO_LuongNV dto_lnv = new DTO_LuongNV();
        BUS_LuongNV bus_lnv = new BUS_LuongNV();
        BUS_LuongNV bus_nv = new BUS_LuongNV();
        BUS_QLNV bus_qlnv = new BUS_QLNV();
        public Form_Nhan_vien()
        {
            InitializeComponent();
        }
        //contructor
        string manv_ = "";
        public Form_Nhan_vien(string Message) : this()
        {
            manv_ = Message;
        }
        //code nut exit 
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

        private void pnl_Hoadon_MouseHover(object sender, EventArgs e)
        {
            pnl_Hoadon.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pnl_Hoadon_MouseLeave(object sender, EventArgs e)
        {
            pnl_Hoadon.BackColor = Color.FromArgb(14, 93, 71);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            pnl_Home.BackColor = Color.FromArgb(147, 211, 124);
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

        private void label7_MouseHover(object sender, EventArgs e)
        {
            pnl_Hoadon.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pnl_Home.BackColor = Color.FromArgb(147, 211, 124);
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

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pnl_Hoadon.BackColor = Color.FromArgb(147, 211, 124);
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
        //ketthuc
        //code chuyen tab cho cac module
        private void pnl_Home_MouseClick(object sender, MouseEventArgs e)
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
        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            Form_Home obj = new Form_Home(manv_);
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
        private void pnl_Thietbi_Click(object sender, EventArgs e)
        {
            Form_Thiet_Bi obj = new Form_Thiet_Bi(manv_);
            obj.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Form_Thiet_Bi obj = new Form_Thiet_Bi(manv_);
            obj.Show();
            this.Hide();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Form_Thiet_Bi obj = new Form_Thiet_Bi(manv_);
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
       
        //ket thuc
        //code chuc nang
        bool themDL;
        void set_null()
        {
            tb_manv.Text = "";
            tb_hovaten.Text = "";
            cb_gioitinh.Text = "";
            tb_sdt.Text = "";
            tb_luong.Text = "";
            tb_pass.Text = "";
        }
        void taobang(string str)
        {
            bangnv.DataSource = bus._selectData(str);
        }
        void disable_box()
        {
            tb_hovaten.Enabled = false;
            cb_gioitinh.Enabled = false;
            tb_sdt.Enabled = false;
            date_picker_nbd.Enabled = false;
            date_picker_nkt.Enabled = false;
            tb_pass.Enabled = false;
            tb_luong.Enabled = false;

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
            date_picker_nbd.Enabled = true;
            date_picker_nkt.Enabled = true;
            tb_pass.Enabled = true;
            tb_luong.Enabled = true;

            btn_luu.Show();
            btn_them.Hide();
            btn_sua.Hide();
            btn_xoa.Hide();
            btn_tl.Show();
        }

        private void Form_Nhan_vien_Load(object sender, EventArgs e)
        {
            //hienthi lb dang xuat
            string manv = manv_;//thay ma vn o day
            DataTable dt_lbnv = new DataTable();
            dt_lbnv = bus_qlnv._selectData("WHERE MANV='" + manv + "'");
            lb_dangxuat.Text = dt_lbnv.Rows[0]["HOTEN"].ToString();
            //default
            disable_box();
            cb_tinhluong.Hide();
            btn_tinhluong.Hide();
            taobang("");
        }
        private void btn_them_Click_1(object sender, EventArgs e)
        {
            enable_box();
            set_null();
            tb_manv.Text = bus.matutang_nv("");
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
                if (tb_manv.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu cần xóa");
                    return;
                }
                DataTable dt_hd = new DataTable();
                DataTable dt_lnv = new DataTable();
                DataTable dt_nmp = new DataTable();
                dt_hd = bus_hd._selectData("WHERE MANV='" + tb_manv.Text + "'");
                dt_lnv = bus_nv._selectData("WHERE MANV='" + tb_manv.Text + "'");
                dt_nmp = bus_nmp._selectData("WHERE MANV='" + tb_manv.Text + "'");
                if (dt_hd.Rows.Count != 0 || dt_lnv.Rows.Count != 0 || dt_nmp.Rows.Count != 0)
                {
                    MessageBox.Show("Không thể xóa nhân viên này.");
                }
                else
                {
                    dto.MANV = tb_manv.Text;
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
        private void lb_rs_Click_1(object sender, EventArgs e)
        {
            show();
            disable_box();
            set_null();
        }
        private void btn_luu_Click_1(object sender, EventArgs e)
        {
            int i = 0;
            if (tb_hovaten.Text == "" || cb_gioitinh.Text == "" || tb_sdt.Text == "" || tb_pass.Text == "" || tb_luong.Text == "")
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
                dto.MANV = tb_manv.Text;
                dto.HOTEN = tb_hovaten.Text;
                dto.GIOITINH = cb_gioitinh.Text;
                dto.SDT = tb_sdt.Text;
                dto.NBDHD = date_picker_nbd.Value.ToShortDateString();
                dto.NKTHD = date_picker_nkt.Value.ToShortDateString();
                dto.PASS = tb_pass.Text;
                dto.LUONG = tb_luong.Text;
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

        //dang xuat
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

        private void bangnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_manv.Text = bangnv.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_hovaten.Text = bangnv.Rows[e.RowIndex].Cells[1].Value.ToString();
                cb_gioitinh.Text = bangnv.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_sdt.Text = bangnv.Rows[e.RowIndex].Cells[3].Value.ToString().Substring(0, 10);
                tb_pass.Text = bangnv.Rows[e.RowIndex].Cells[6].Value.ToString();
                tb_luong.Text = bangnv.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi");
                return;
            }
        }
        //code tính lương
        void hide()
        {
            tb_manv.Hide();
            tb_hovaten.Hide();
            cb_gioitinh.Hide();
            tb_sdt.Hide();
            date_picker_nbd.Hide();
            date_picker_nkt.Hide();
            tb_pass.Hide();
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
            lb10.Hide();

            btn_luu.Hide();
            btn_them.Hide();
            btn_sua.Hide();
            btn_xoa.Hide();
            btn_tl.Hide();
        }
        void show()
        {
            tb_manv.Show();
            tb_hovaten.Show();
            cb_gioitinh.Show();
            tb_sdt.Show();
            date_picker_nbd.Show();
            date_picker_nkt.Show();
            tb_pass.Show();
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
            lb10.Show();

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
            cb_tinhluong.DisplayMember = "MANV";
            cb_tinhluong.ValueMember = "MANV";
            cb_tinhluong.Text = "";

        }

        private void btn_tinhluong_Click(object sender, EventArgs e)
        {
            if (cb_tinhluong.Text=="")
            {
                MessageBox.Show("Chưa chọn nhân viên");
            }    
            else
            {
                DataTable dt_qlnv_1 = new DataTable();
                dt_qlnv_1 = bus._selectData("WHERE MANV='" + cb_tinhluong.Text + "'");
                DateTime datetime = DateTime.UtcNow.Date;
                dto_lnv.MATT = bus_lnv.matutang_lnv("");
                dto_lnv.MANV = cb_tinhluong.Text;
                dto_lnv.NGAYTT= datetime.ToString("MM/dd/yyyy");
                dto_lnv.TONGTIEN = dt_qlnv_1.Rows[0]["LUONG"].ToString();
                bus_lnv._insertData(dto_lnv);
                MessageBox.Show("Đã thanh toán lương nhân viên " + cb_tinhluong.Text + " ngày " + datetime.ToString("MM/dd/yyyy") + " số tiền: " + dt_qlnv_1.Rows[0]["LUONG"].ToString() + " đồng.");
            }    
        }

        























        //ket thuc

    }
}
