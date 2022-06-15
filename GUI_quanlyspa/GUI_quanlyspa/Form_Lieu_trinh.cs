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
    public partial class Form_Lieu_trinh : Form
    {
        BUS_LieuTrinh bus = new BUS_LieuTrinh();
        DTO_LieuTrinh dto = new DTO_LieuTrinh();
        BUS_CTDT bus_ctdt = new BUS_CTDT();
        BUS_QLNV bus_qlnv = new BUS_QLNV();
        public Form_Lieu_trinh()
        {
            InitializeComponent();
        }
        //constructor
        string manv_ = "";
        public Form_Lieu_trinh(string Message) : this()
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

        private void label7_MouseHover(object sender, EventArgs e)
        {
            pnl_Hoadon.BackColor = Color.FromArgb(147, 211, 124);
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

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pnl_Hoadon.BackColor = Color.FromArgb(147, 211, 124);
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
        //code chuc nang
        bool themDL;
        void set_null()
        {
            txtbox_Malt.Text = "";
            txtbox_tenlt.Text = "";
            txtbox_tg.Text = "";
            txtbox_giatien.Text = "";
        }
        void taobang(string str)
        {
            banglt.DataSource = bus._selectData(str);
        }
        void disable_box()
        {
            txtbox_tenlt.Enabled = false;
            txtbox_tg.Enabled = false;
            txtbox_giatien.Enabled = false;

            btn_luu.Hide();
            btn_them.Show();
            btn_sua.Show();
            btn_xoa.Show();
        }
        void enable_box()
        {
            txtbox_tenlt.Enabled = true;
            txtbox_tg.Enabled = true;
            txtbox_giatien.Enabled = true;

            btn_luu.Show();
            btn_them.Hide();
            btn_sua.Hide();
            btn_xoa.Hide();
        }
        private void Form_Lieu_trinh_Load(object sender, EventArgs e)
        {
            //hienthi lb dang xuat
            string manv = manv_;//thay ma vn o day
            DataTable dt_lbnv = new DataTable();
            dt_lbnv = bus_qlnv._selectData("WHERE MANV='" + manv + "'");
            lb_dangxuat.Text = dt_lbnv.Rows[0]["HOTEN"].ToString();
            //default
            disable_box();
            taobang("");
        }
        //code nut them
        private void btn_them_Click(object sender, EventArgs e)
        {
            enable_box();
            set_null();
            txtbox_Malt.Text = bus.matutang_lieutrinh("");
            themDL = true;
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            enable_box();
            set_null();

            themDL = false;
        }
        //code nut xoa
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtbox_Malt.Text=="")
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu cần xóa");
                    return;
                }
                DataTable dt_ctdt = new DataTable();
                dt_ctdt = bus_ctdt._selectData("WHERE MALT='" + txtbox_Malt.Text + "'");
                if(dt_ctdt.Rows.Count!=0)
                {
                    MessageBox.Show("Không thể xóa do liệu trình đã được áp dụng.");
                }
                else
                {
                    dto.MALT = txtbox_Malt.Text;
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
        //chọn 1 dòng trong bảng
        private void banglt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtbox_Malt.Text = banglt.Rows[e.RowIndex].Cells[0].Value.ToString();
                txtbox_tenlt.Text = banglt.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtbox_tg.Text = banglt.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtbox_giatien.Text = banglt.Rows[e.RowIndex].Cells[3].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi");
                return;
            }
        }
        //code nut reset
        private void lb_rs_Click(object sender, EventArgs e)
        {
            disable_box();
            set_null();
        }
        //code but luu
        private void btn_luu_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (txtbox_tenlt.Text==""||txtbox_giatien.Text==""||txtbox_tg.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else if (int.TryParse(txtbox_tg.Text, out i)==false)
            {
                MessageBox.Show("Thời gian phải là số");
                return;
            }
            else if (int.TryParse(txtbox_giatien.Text, out i) == false)
            {
                MessageBox.Show("Giá tiền phải là số");
                return;
            }
            try
            {
                dto.MALT = txtbox_Malt.Text;
                dto.TENLT = txtbox_tenlt.Text;
                dto.THOIGIANDT = txtbox_tg.Text;
                dto.GIATIEN = txtbox_giatien.Text;
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


    }

}
