using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LogInForm
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 fRegister = new Form2(); // Tạo form mới
            fRegister.ShowDialog(); // Mở form
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Chức Năng Đang Được Phát Triển.\n\nThành Thật Xin Lỗi!!! :(", "Forgot Password");
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usernameIn;
            string passIn;

            usernameIn = tbxUserName.Text;
            passIn = tbxPassword.Text;

            // Kiểm tra người dùng có nhập tk, mk đủ không
            if(usernameIn == "" && passIn == "")
            {
                MessageBox.Show("Vui Lòng Cung Cấp Thông Tin Tài Khoản Trước Khi Nhấn Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxUserName.Focus(); // Đưa con trỏ chuột về textbox
            }
            else if (usernameIn == "")
            {
                MessageBox.Show("Vui Lòng Nhập Tên Đăng Nhập", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxUserName.Focus();
            }
            else if (passIn == "")
            {
                MessageBox.Show("Vui Lòng Nhập Mật Khẩu", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbxPassword.Focus();
            }
            else
            {
                SqlConnection cnt = new SqlConnection(@"Data Source=LAPTOP-8RC8J6DJ;Initial Catalog=LoginForm;User ID=sa;Password=123456");
                
                // Try - Catch để bắt lỗi kết nối DB
                try
                {
                    cnt.Open();

                    // Câu lệnh truy vấn
                    SqlCommand cmd = new SqlCommand(@"SELECT * FROM CUSTOMERINFO WHERE USERNAME = '"+tbxUserName.Text+"' AND PASS = '"+tbxPassword.Text+ "'", cnt);
                    SqlDataReader dataRead = cmd.ExecuteReader();

                    if(dataRead.Read()) // Có dữ liệu trả về
                    {
                        Form3 fProfile = new Form3();
                        MessageBox.Show("Đăng Nhập Thành Công", "Thông Báo");
                        fProfile.Show();
                        this.Hide(); // Ẩn form login
                    } 
                    else
                    {
                        MessageBox.Show("Sai Thông Tin Tài Khoản Và Mật Khẩu", "Thông Báo");
                    }
                }
                catch(Exception)
                {
                    MessageBox.Show("Đã Có Lỗi Xảy Ra", "Thông Báo", MessageBoxButtons.OK);
                }               
            }
        }
    }
}
