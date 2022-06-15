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
    public partial class Form_MYPHAM : Form
    {
        public Form_MYPHAM()
        {
            InitializeComponent();
        }
        //contructor
        string manv_ = "";
        public Form_MYPHAM(string Message) : this()
        {
            manv_ = Message;
        }

        BUS_MYPHAM bus_mp = new BUS_MYPHAM();
        BUS_NhapMP bus_nmp = new BUS_NhapMP();
        BUS_QLNV bus_qlnv = new BUS_QLNV();

        DTO_MYPHAM dto_mp = new DTO_MYPHAM();
        DTO_NhapMP dto_nmp = new DTO_NhapMP();
        bool moi = true;
        //code nút exit
        private void picBox_iconExit_Click(object sender, EventArgs e)
        {
            DialogResult resu_lt = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (resu_lt == DialogResult.Yes)
                Application.Exit();
        }
        
        void set_null()
        {
            txtbox_Manmp.Text = "";
            txtbox_dongia.Text = "";
            txtBox_soluong.Text = "";
            txtbox_thanhtien.Text = "";
            txtBox_giaban.Text = "";
            comboBox_manv.Text = "";
            txtBox_mamp1.Text = "";
            txtBox_mamp2.Text = "";
            txtBox_tenmp2.Text = "";
            comboBox_tenmp1.Text = "";
        }
        void hide_load()
        {
            btn_luu.Hide();
            lb_mmp1.Hide();
            lb_mmp2.Hide();
            lb_tmp1.Hide();
            lb_tmp2.Hide();

            txtBox_mamp1.Hide();
            txtBox_mamp2.Hide();
            txtBox_tenmp2.Hide();
            comboBox_tenmp1.Hide();
        }
        void disable_load()
        {
            txtbox_dongia.Enabled = false;
            txtBox_soluong.Enabled = false;
            txtBox_giaban.Enabled = false;
            comboBox_manv.Enabled = false;

            txtBox_tenmp2.Enabled = false;
            comboBox_tenmp1.Enabled = false;
        }
        //tao bangmp
        void taobang(string str)
        {
            bangmp.DataSource = bus_mp._selectData(str);
        }
        //load
        private void Form_MYPHAM_Load(object sender, EventArgs e)
        {
            //hienthi lb dang xuat
            string manv = manv_;//thay ma vn o day
            DataTable dt_lbnv = new DataTable();
            dt_lbnv = bus_qlnv._selectData("WHERE MANV='" + manv + "'");
            lb_dangxuat.Text = dt_lbnv.Rows[0]["HOTEN"].ToString();
            //ẩn nút, thuộc tính
            set_null();
            hide_load();
            disable_load();
            //hien thi bang mp
            taobang("");
            //đổ data vào combo box
            //combobox manv
            comboBox_manv.DataSource = bus_qlnv._selectData("");
            comboBox_manv.DisplayMember = "MANV";
            comboBox_manv.ValueMember = "MANV";
            comboBox_manv.Text = "";
            //combobox tenmp
            //comboBox_tenmp1.DataSource = bus_mp._selectData("");
            //comboBox_tenmp1.DisplayMember = "TENMP";
            //comboBox_tenmp1.ValueMember = "MAMP";
            //comboBox_tenmp1.Text = "";
        }
        void enable_cu()
        {
            txtbox_dongia.Enabled = true;
            txtBox_soluong.Enabled = true;
            txtBox_giaban.Enabled = true;
            comboBox_manv.Enabled = true;

            comboBox_tenmp1.Enabled = true;
        }
        void show_cu()
        {
            lb_mmp1.Show();
            lb_tmp1.Show();

            txtBox_mamp1.Show();
            comboBox_tenmp1.Show();
            btn_luu.Show();
            btn_cu.Hide();
            btn_moi.Hide();

        }
        private void btn_cu_Click(object sender, EventArgs e)
        {
            //hien thi
            enable_cu();
            show_cu();
            //combobox tenmp
            comboBox_tenmp1.DataSource = bus_mp._selectData("");
            comboBox_tenmp1.DisplayMember = "TENMP";
            comboBox_tenmp1.ValueMember = "MAMP";
            comboBox_tenmp1.Text = "";
            //ma tu tang nhap my pham
            txtbox_Manmp.Text = bus_nmp.matutang_nhapmypham("");
            moi = false;
        }
        void enable_moi()
        {
            txtbox_dongia.Enabled = true;
            txtBox_soluong.Enabled = true;
            txtBox_giaban.Enabled = true;
            comboBox_manv.Enabled = true;

            txtBox_tenmp2.Enabled = true;
        }
        void show_moi()
        {
            lb_mmp2.Show();
            lb_tmp2.Show();

            txtBox_mamp2.Show();
            txtBox_tenmp2.Show();
            btn_luu.Show();
            btn_cu.Hide();
            btn_moi.Hide();

        }
        private void btn_moi_Click(object sender, EventArgs e)
        {
            enable_moi();
            show_moi();
            //ma tu tang my pham
            txtBox_mamp2.Text = bus_mp.matutang_mypham("");
            //ma tu tang nhap my pham
            txtbox_Manmp.Text = bus_nmp.matutang_nhapmypham("");
            moi = true;
        }

        void reset()
        {
            set_null();
            hide_load();
            disable_load();
            btn_cu.Show();
            btn_moi.Show();
            taobang("");
        }
        private void lb_rs_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void comboBox_tenmp1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            txtBox_mamp1.Text = comboBox_tenmp1.SelectedValue.ToString();
        }
        // code tính thành tiền
        private void txtbox_dongia_TextChanged(object sender, EventArgs e)
        {
            int dg = 0;
            int sl = 0;
            int gb = 0;
            if (txtbox_dongia.Text == "")
            {
                txtbox_thanhtien.Text = "";
                return;
            }
            else
            {
                if (int.TryParse(txtbox_dongia.Text, out gb) == true)
                {
                    if (gb <= 0)
                    {
                        MessageBox.Show("Đơn giá phải lớn hơn 0");
                        txtbox_dongia.Text = "";
                        return;
                    }
                    float giaban = gb * 110 / 100;
                    txtBox_giaban.Text = ((int)giaban).ToString();
                }  
                else
                {
                    MessageBox.Show("Đơn giá phải là số.");
                    txtbox_dongia.Text = "";
                    return;
                }    
            }
            if (txtBox_soluong.Text != "")
            {
                if (int.TryParse(txtbox_dongia.Text, out dg)==true)
                {
                    if(int.TryParse(txtBox_soluong.Text, out sl) == true)
                    {
                        int thanhtien = dg * sl;
                        txtbox_thanhtien.Text = thanhtien.ToString();
                    }   
                    else
                    {
                        MessageBox.Show("Số lượng phải là số.");
                        txtBox_soluong.Text = "";
                        return;
                    }    
                }
                else
                {
                    MessageBox.Show("Đơn giá phải là số.");
                    txtbox_dongia.Text = "";
                    return;
                }    
            }    
        }
        private void txtBox_soluong_TextChanged(object sender, EventArgs e)
        {
            int dg = 0;
            int sl = 0;
            int sl1 = 0;
            if (txtBox_soluong.Text == "")
            {
                txtbox_thanhtien.Text = "";
                return;
            }  
            else
            {
                if (int.TryParse(txtBox_soluong.Text, out sl1) == false)
                {
                    MessageBox.Show("Số lượng phải là số");
                    txtBox_soluong.Text = "";
                    return;
                }
                else
                {
                    if(sl1<=0)
                    {
                        MessageBox.Show("Số lượng phải lớn hơn 0");
                        txtBox_soluong.Text = "";
                        return;
                    }    
                }    
            }
            if (txtbox_dongia.Text != "")
            {
                if (int.TryParse(txtBox_soluong.Text, out dg) == true)
                {
                    if (int.TryParse(txtbox_dongia.Text, out sl) == true)
                    {
                        int thanhtien = dg * sl;
                        txtbox_thanhtien.Text = thanhtien.ToString();
                    }
                    else
                    {
                        MessageBox.Show("Đơn giá phải là số");
                        txtbox_dongia.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Số lượng phải là số");
                    txtBox_soluong.Text = "";
                }
            }
        }
        //kiem tra gia ban
        private void txtBox_giaban_TextChanged(object sender, EventArgs e)
        {
            int gb = 0;
            if (txtBox_giaban.Text == "")
            {
                return;
            }
            if (int.TryParse(txtBox_giaban.Text, out gb) == false)
            {
                MessageBox.Show("Giá bán phải là số");
                txtBox_giaban.Text = "";
                return;
            }
        }
        //kiểm tra thông tin bị thiếu
        bool check_null()
        {
            if (txtbox_dongia.Text=="")
            {
                MessageBox.Show("Không được để trống đơn giá.");
                return true;
            }
            if (txtBox_soluong.Text == "")
            {
                MessageBox.Show("Không được để trống số lượng.");
                return true;
            }
            if (txtbox_thanhtien.Text == "")
            {
                MessageBox.Show("Không được để trống thành tiền.");
                return true;
            }
            if (txtBox_giaban.Text == "")
            {
                MessageBox.Show("Không được để trống giá bán.");
                return true;
            }
            else
            {
                if (int.Parse(txtBox_giaban.Text) <= int.Parse(txtbox_dongia.Text))
                {
                    MessageBox.Show("Giá bán phải lớn hơn giá nhập");
                    return true;
                }    
            }
            if (comboBox_manv.SelectedItem == null)
            {
                MessageBox.Show("Chưa chọn mã nhân viên.");
                return true;
            }
            if (moi==true)
            {
                if(txtBox_tenmp2.Text=="")
                {
                    MessageBox.Show("Không được để trống tên mỹ phẩm.");
                    return true;
                }    
            }  
            else
            {
                if(txtBox_mamp1.Text=="")
                {
                    MessageBox.Show("Chưa chọn mỹ phẩm.");
                    return true;
                }    
            }
            return false;
        }
        //code nút lưu
        private void btn_luu_Click(object sender, EventArgs e)
        {
            //kiểm tra thông tin có bị trống hay không
            bool null_ = check_null();
            //nếu không tiến hành nhập dữ liệu
            if (null_!=true)
            {
                if (moi==true) // nhap my pham moi (mp2)
                {
                    //1. nhập bảng "mỹ phẩm" trước
                    dto_mp.MAMP = txtBox_mamp2.Text;
                    dto_mp.TENMP = txtBox_tenmp2.Text;
                    dto_mp.SOLUONGTONKHO = txtBox_soluong.Text;
                    dto_mp.GIABAN = txtBox_giaban.Text;
                    bus_mp._insertData(dto_mp);
                    //2. nhập bảng  "nhập mỹ phẩm" sau
                    dto_nmp.MANMP = txtbox_Manmp.Text;
                    dto_nmp.MAMP = txtBox_mamp2.Text;
                    dto_nmp.DONGIA = txtbox_dongia.Text;
                    dto_nmp.NGAYNHAP = date_picker_ngaynhap.Value.ToShortDateString();
                    dto_nmp.SLNHAP = txtBox_soluong.Text;
                    dto_nmp.THANHTIENDH = txtbox_thanhtien.Text;
                    dto_nmp.MANV = comboBox_manv.SelectedValue.ToString();
                    bus_nmp._insertData(dto_nmp);

                    //thông báo
                    MessageBox.Show("Đã lưu.");

                    //reset
                    reset();
                }   
                else // nhap my pham cu (mp1)
                {
                    //1. nhập bảng  "nhập mỹ phẩm" trước

                    dto_nmp.MANMP = txtbox_Manmp.Text;
                    dto_nmp.MAMP = txtBox_mamp1.Text;
                    dto_nmp.DONGIA = txtbox_dongia.Text;
                    dto_nmp.NGAYNHAP = date_picker_ngaynhap.Value.ToShortDateString();
                    dto_nmp.SLNHAP = txtBox_soluong.Text;
                    dto_nmp.THANHTIENDH = txtbox_thanhtien.Text;
                    dto_nmp.MANV = comboBox_manv.SelectedValue.ToString();
                    bus_nmp._insertData(dto_nmp);
                    //2. cập nhật bảng  "mỹ phẩm" sau

                    //lấy sô lượng ton kho
                    DataTable dt_mp = new DataTable();
                    dt_mp = bus_mp._selectData("WHERE MAMP= '" + txtBox_mamp1.Text + "' ");
                    int sltk = int.Parse(dt_mp.Rows[0]["SOLUONGTONKHO"].ToString());
                    //cộng với sl nhập
                    int sl_updated = sltk+ int.Parse(txtBox_soluong.Text);
                    //update 

                    bus_mp._updatesl(" , GIABAN = '" + txtBox_giaban.Text + "' WHERE MAMP='"+ txtBox_mamp1.Text+ "' ", sl_updated);

                    //thông báo
                    MessageBox.Show("Đã lưu");

                    //reset
                    reset();
                }
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
        //code chuyển tab
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

        private void pnl_Lieutrinh_Click(object sender, EventArgs e)
        {
            Form_Lieu_trinh obj = new Form_Lieu_trinh(manv_);
            obj.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
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
        //code hover
        private void pnl_Home_MouseHover(object sender, EventArgs e)
        {
            pnl_Home.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            pnl_Home.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            pnl_Home.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pnl_Home_MouseLeave(object sender, EventArgs e)
        {
            pnl_Home.BackColor = Color.FromArgb(14, 93, 71);
        }
        //
        private void pnl_Nhanvien_MouseHover(object sender, EventArgs e)
        {
            pnl_Nhanvien.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            pnl_Nhanvien.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pnl_Nhanvien.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pnl_Nhanvien_MouseLeave(object sender, EventArgs e)
        {
            pnl_Nhanvien.BackColor = Color.FromArgb(14, 93, 71);
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

        private void pnl_Khachhang_MouseHover(object sender, EventArgs e)
        {
            pnl_Khachhang.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            pnl_Khachhang.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pictureBox6_MouseHover(object sender, EventArgs e)
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

        private void label6_MouseHover(object sender, EventArgs e)
        {
            pnl_Thietbi.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pictureBox7_MouseHover(object sender, EventArgs e)
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

        private void label7_MouseHover(object sender, EventArgs e)
        {
            pnl_Hoadon.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pictureBox8_MouseHover(object sender, EventArgs e)
        {
            pnl_Hoadon.BackColor = Color.FromArgb(147, 211, 124);
        }

        private void pnl_Hoadon_MouseLeave(object sender, EventArgs e)
        {
            pnl_Hoadon.BackColor = Color.FromArgb(14, 93, 71);
        }
    }
}
