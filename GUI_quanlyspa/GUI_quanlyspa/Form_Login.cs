using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GUI_quanlyspa
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
        }
        private void password_tb_OnValueChanged(object sender, EventArgs e)
        {
            password_tb.isPassword = true;
        }

        //code dang nhap qua SQL
        private void login_button_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=LAPTOP-A60R360U;Initial Catalog=QuanlySpa;Integrated Security=True;");
            try
            {
                conn.Open();
                string tk = user_tb.Text;
                string mk = password_tb.Text;
                string sql = "select *from QLNV where MANV='" + tk + "' and PASS='" + mk + "'";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    //MessageBox.Show("Đăng nhập thành công");
                    Form_Home home_ = new Form_Home(user_tb.Text);
                    this.Hide();
                    home_.Show();
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu hoặc tài khoản.");
                }

            }
            catch /*(Exception ex)*/
            {
                MessageBox.Show("Lỗi kết nối");
            }

            if (remember_cb.Checked == true)
            {
                Properties.Settings.Default.Username = user_tb.Text;
                Properties.Settings.Default.Password = password_tb.Text;
                Properties.Settings.Default.Save();
            }

            if (remember_cb.Checked == false)
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Save();
            }
        }

        //code nut clear
        private void clear_lb_Click(object sender, EventArgs e)
        {
            user_tb.Text = "";
            password_tb.Text = "";
        }
        //load form
        private void Form_Login_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.Username != String.Empty)
            {
                Properties.Settings.Default.Username = user_tb.Text;
                Properties.Settings.Default.Password = password_tb.Text;
            }
        }
        //code nut exit
        private void exit_lb_Click(object sender, EventArgs e)
        {
            DialogResult resu_lt = MessageBox.Show("Bạn chắc chắn muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (resu_lt == DialogResult.Yes)
                Application.Exit();
        }

    }
}

