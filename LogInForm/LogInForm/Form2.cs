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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //EVENTS

        private void lbBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbBack_MouseHover(object sender, EventArgs e)
        {
            lbBackRegis.ForeColor = Color.Red;
        }

        private void lbBack_MouseLeave(object sender, EventArgs e)
        {
            lbBackRegis.ForeColor = Color.Black;
        }

        private void txtPassRegis_TextChanged(object sender, EventArgs e)
        {
            lbMeasurePass.Visible = true;
            lbMeasurePass.Text = checkPassStrength(txtPassRegis.Text);
        }

        private void txtRetypePassRegis_TextChanged(object sender, EventArgs e)
        {
            if(txtPassRegis.Text != "")
            {
                lbConfirmPass.Visible = true;
                lbConfirmPass.Text = checkRetypingPass(txtPassRegis.Text, txtRetypePassRegis.Text);
            }
        }

        private void btnRegis_Click(object sender, EventArgs e)
        {
            DateTime birth = datePick.Value;

            // Kiểm tra người dùng cung cấp thông tin
            if (string.IsNullOrEmpty(txtNameRegis.Text) || string.IsNullOrWhiteSpace(txtNameRegis.Text))
            {
                MessageBox.Show("Bạn Chưa Nhập Họ Tên", "Thông Báo", MessageBoxButtons.OK);
                txtNameRegis.Focus();
            }
            else if(!rdoMaleRegis.Checked && !rdoFemaleRegis.Checked)
            {
                MessageBox.Show("Vui Lòng Cho Biết Giới Tính", "Thông Báo", MessageBoxButtons.OK);
                rdoMaleRegis.Focus();
            } 
            else if(calcAge(birth) < 16)
            {
                MessageBox.Show("Dưới 16 Tuổi Sẽ Không Được Đăng Ký", "Thông Báo", MessageBoxButtons.OK);
                datePick.Focus();
            }
            else if(checkUsername(txtUsernameRegis.Text))
            {
                MessageBox.Show("Tên Đăng Nhập Không Hợp Lệ!\n\nTên Đăng Nhập Không Bao Gồm Khoảng Trắng, Ký Tự Đặc Biệt Và Ít Nhất 6 Ký Tự", "Thông Báo", MessageBoxButtons.OK);
                txtUsernameRegis.Focus();
            } 
            else if(string.IsNullOrEmpty(txtPassRegis.Text) || string.IsNullOrWhiteSpace(txtPassRegis.Text))
            {
                MessageBox.Show("Vui Lòng Nhập Mật Khẩu", "Thông Báo", MessageBoxButtons.OK);
                txtPassRegis.Focus();
            }
            else if (string.IsNullOrEmpty(txtRetypePassRegis.Text) || string.IsNullOrWhiteSpace(txtRetypePassRegis.Text))
            {
                MessageBox.Show("Vui Lòng Nhập Mật Khẩu", "Thông Báo", MessageBoxButtons.OK);
                txtRetypePassRegis.Focus();
            }
            else // Đã cung cấp đủ thông tin
            {
                // Kết nối với DB
                SqlConnection cnt = new SqlConnection("Data Source=LAPTOP-8RC8J6DJ;Initial Catalog=LoginForm;User ID=sa;Password=123456");
                SqlCommand cmd = new SqlCommand(@"INSERT INTO [dbo].[CUSTOMERINFO]
                   ([FULLNAME]
                   ,[ISMALE]
                   ,[EMAIL]
                   ,[BIRTHDAY]
                   ,[USERNAME]
                   ,[PASS])
             VALUES
                   ('" + txtNameRegis.Text + "', '"+ rdoMaleRegis.Checked +"', '"+ txtEmailRegis.Text + "', '"+ datePick.Value + "', '"+ txtUsernameRegis.Text + "', '"+ txtPassRegis.Text +"')", cnt);

                cnt.Open();
                cmd.ExecuteNonQuery();
                cnt.Close();

                MessageBox.Show("Đăng Ký Thành Công", "Thông Báo", MessageBoxButtons.OK);

                this.Close();
            }
        }

        private void datePick_ValueChanged(object sender, EventArgs e)
        {
            DateTime birth = datePick.Value;
            lbAge.Text = calcAge(birth).ToString(); // Tính tuổi

            // Hiển thị Label tuổi
            lbAge.Visible = true;
            lbTuoi.Visible = true;
        }


        //FUNCTION

        //Tính tuổi
        private int calcAge(DateTime dob)
        {
            int result = 0;
            DateTime dt = DateTime.Now;

            result = dt.Year - dob.Year;

            return result;
        }

        // Kiểm tra định dạng của username
        private bool checkUsername(string txt)
        {
            if (txt.Contains(" ") || txt == "" || txt.Length < 6) return true;

            for(int i = 0; i < txt.Length; i++)
            {
                if (!Char.IsLetterOrDigit(txt[i])) return true;
            }

            return false;
        }

        // Do lường độ an toàn của mật khẩu
        private string checkPassStrength(string txt)
        {
            string result;
            int lengthInput = txt.Length;

            bool hasLower = false;
            bool hasUpper = false;
            bool hasDigit = false; 
            bool specialChar = false;

            for(int i = 0; i < lengthInput; i++)
            {
                if (Char.IsLower(txt[i])) hasLower = true;
                if (Char.IsUpper(txt[i])) hasUpper = true;
                if (Char.IsDigit(txt[i])) hasDigit = true;
                if (!Char.IsLetterOrDigit(txt[i])) specialChar = true;
            }

            if (lengthInput == 0)
            {
                result = "No Password";
                lbMeasurePass.ForeColor = System.Drawing.SystemColors.ControlDark;
            }
            else if (hasLower && hasUpper && hasDigit && specialChar && (lengthInput >= 8))
            {
                result = "Strong";
                lbMeasurePass.ForeColor = System.Drawing.Color.Lime;
            }

            else if (((hasLower || hasUpper) && specialChar && (lengthInput >= 6)) || (hasLower && hasUpper && hasDigit && (lengthInput >= 6)))
            {
                result = "Medium";
                lbMeasurePass.ForeColor = System.Drawing.Color.Gold;
            }
            else 
            { 
                result = "Weak";
                lbMeasurePass.ForeColor = System.Drawing.Color.Red;
            }

            return result;
        }

        // Kiểm tra mk gõ lại đúng chưa
        private string checkRetypingPass(string txt, string txtRetyping)
        {
            string result = "";

            if(txt == txtRetyping)
            {
                result = "Trùng Khớp";
                lbConfirmPass.ForeColor = Color.LimeGreen;
            }
            else
            {
                result = "Không Trùng Khớp";
                lbConfirmPass.ForeColor = Color.Red;
            }

            return result;
        }
    }
}
