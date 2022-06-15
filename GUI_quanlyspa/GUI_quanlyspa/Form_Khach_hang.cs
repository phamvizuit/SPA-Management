using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using quanlyspa_DTO;
using BUS_quanlyspa;

namespace GUI_quanlyspa
{
    public partial class Form_Khach_hang : Form
    {
        
        public Form_Khach_hang()
        {
            InitializeComponent();
        }
        //constructor
        string manv_ = "";
        public Form_Khach_hang(string Message) : this()
        {
            manv_ = Message;
        }
        BUS_KhachHang bus = new BUS_KhachHang();
        DTO_KhachHang dto = new DTO_KhachHang();
        BUS_HOADON bus_hd = new BUS_HOADON();
        BUS_QLNV bus_qlnv = new BUS_QLNV();
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

        private void label4_Click(object sender, EventArgs e)
        {
            Form_Lieu_trinh obj = new Form_Lieu_trinh(manv_);
            obj.Show();
            this.Hide();
        }
        private void pnl_Lieutrinh_Click(object sender, EventArgs e)
        {
            Form_Lieu_trinh obj = new Form_Lieu_trinh(manv_);
            obj.Show();
            this.Hide();
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Form_Lieu_trinh obj = new Form_Lieu_trinh(manv_);
            obj.Show();
            this.Hide();
        }


        //ket thuc
        //code chuc nang
        bool themDL;

        void set_null()
        {
            tb_makh.Text = "";
            tb_hovaten.Text = "";
            comboBox_gioitinh.Text = "";
            cb_mm.Text = "";
            cb_dd.Text = "";
            tb_yyyy.Text = "";
            tb_sdt.Text = "";
            tb_date_.Text = "";
        }
        void taobang(string str)
        {
            bangkh.DataSource = bus._selectData(str);
        }
        void disable_box()
        {
            tb_hovaten.Enabled = false;
            comboBox_gioitinh.Enabled = false;
            cb_mm.Enabled = false;
            cb_dd.Enabled = false;
            tb_yyyy.Enabled = false;
            tb_sdt.Enabled = false;

            btn_luu.Hide();
            btn_them.Show();
            btn_sua.Show();
            btn_xoa.Show();
        }
        void enable_box()
        {
            tb_hovaten.Enabled = true;
            comboBox_gioitinh.Enabled = true;
            cb_mm.Enabled = true;
            cb_dd.Enabled = true;
            tb_yyyy.Enabled = true;
            tb_sdt.Enabled = true;

            btn_luu.Show();
            btn_them.Hide();
            btn_sua.Hide();
            btn_xoa.Hide();
        }
       
        private void Form_Khach_hang_Load(object sender, EventArgs e)
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
        private void btn_them_Click(object sender, EventArgs e)
        {
            enable_box();
            set_null();
            tb_makh.Text = bus.matutang_kh("");
            themDL = true;
        }
        private void btn_sua_Click(object sender, EventArgs e)
        {
            enable_box();
            set_null();

            themDL = false;
        }
        private void btn_xoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_makh.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn dữ liệu cần xóa");
                    return;
                }
                DataTable dt_hd = new DataTable();
                dt_hd = bus_hd._selectData("WHERE MAKH='" + tb_makh.Text + "'");
                if (dt_hd.Rows.Count != 0)
                {
                    MessageBox.Show("Không thể xóa do liệu trình đã được áp dụng.");
                }
                else
                {
                    dto.MAKH = tb_makh.Text;
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



        private void lb_rs_Click(object sender, EventArgs e)
        {
            disable_box();
            set_null();
        }
        private void btn_luu_Click(object sender, EventArgs e)
        {
            int i = 0;
            if (tb_hovaten.Text == "" || comboBox_gioitinh.Text == ""||cb_mm.Text=="" || cb_dd.Text == "" || tb_yyyy.Text == ""||tb_sdt.Text=="")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin");
                return;
            }
            else if (int.TryParse(tb_yyyy.Text, out i) == false)
            {
                MessageBox.Show("Năm phải là số");
                return;
            }
            
            else if (int.TryParse(tb_sdt.Text, out i) == false)
            {
                MessageBox.Show("Sđt phải là số");
                return;
            }
            try
            {
                dto.MAKH = tb_makh.Text;
                dto.HOTEN = tb_hovaten.Text;
                dto.GIOITINH = comboBox_gioitinh.Text;
                dto.NAMSINH = cb_mm.Text+"-"+cb_dd.Text+"-"+tb_yyyy.Text;
                dto.DIENTHOAI = tb_sdt.Text;
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

        private void bangkh_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                tb_makh.Text = bangkh.Rows[e.RowIndex].Cells[0].Value.ToString();
                tb_hovaten.Text = bangkh.Rows[e.RowIndex].Cells[1].Value.ToString();
                comboBox_gioitinh.Text = bangkh.Rows[e.RowIndex].Cells[2].Value.ToString();
                tb_date_.Text = bangkh.Rows[e.RowIndex].Cells[3].Value.ToString().Substring(0, 10);
                tb_sdt.Text = bangkh.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi");
                return;
            }
        }
        //dang xuat
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

        private void pnl_Home_Click(object sender, EventArgs e)
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

        private void pictureBox2_Click(object sender, EventArgs e)
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

    }
}
