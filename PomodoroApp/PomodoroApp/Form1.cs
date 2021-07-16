using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PomodoroApp
{
    public partial class Form1 : Form
    {
        private int totalSeconds;
        private int m = 25;
        private int s = 0;
        private int check = 1;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0) // Chưa chạy hết thời gian
            {
                // tính lại số phút, giây
                totalSeconds--;
                m = totalSeconds / 60;
                s = totalSeconds - m * 60;

                lbTime.Text = formatTime(m, s);

                // Vô hiệu các nút
                btnPomo.Enabled = false;
                btnShort.Enabled = false;
                btnLong.Enabled = false;
            }
            else
            {
                timer1.Stop(); // dừng timer
                
                // Hiển thị thông báo khi hết giờ
                MessageBox.Show("Hết Thời Gian", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnStart.Text = "Start"; // Stop => Start

                // Kích hoạt lại các nút
                btnPomo.Enabled = true;
                btnShort.Enabled = true;
                btnLong.Enabled = true;
            }
        }

        private void btnPomo_Click(object sender, EventArgs e)
        {
            // Biến Check để sự dụng trong sự kiện cancel
            check = 1;

            // phút, giây của một pomodoro
            m = 25;
            s = 0;

            // Định dạng chuỗi thời gian
            lbTime.Text = formatTime(m, s);

            // Điều khiển Timer dừng
            timer1.Stop();

            // Điều chỉnh màu theo dải RGB
            btnPomo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(85)))), ((int)(((byte)(81)))));
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(100)))), ((int)(((byte)(95)))));
            btnShort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(100)))), ((int)(((byte)(95)))));
            btnLong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(100)))), ((int)(((byte)(95)))));
            btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(100)))), ((int)(((byte)(95)))));
        }

        private void btnShort_Click(object sender, EventArgs e)
        {
            // Biến Check để sự dụng trong sự kiện cancel
            check = 2;

            // phút, giây của một pomodoro
            m = 5;
            s = 0;

            // Định dạng chuỗi thời gian
            lbTime.Text = formatTime(m, s);

            // Điều khiển Timer dừng
            timer1.Stop();

            // Điều chỉnh màu theo dải RGB
            btnPomo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            btnShort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(131)))), ((int)(((byte)(133)))));
            btnLong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
        }

        private void btnLong_Click(object sender, EventArgs e)
        {
            // Biến Check để sự dụng trong sự kiện cancel
            check = 3;

            // phút, giây của một pomodoro
            m = 15;
            s = 0;

            // Định dạng chuỗi thời gian
            lbTime.Text = formatTime(m, s);

            // Điều khiển Timer dừng
            timer1.Stop();

            // Điều chỉnh màu theo dải RGB
            btnPomo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(139)))), ((int)(((byte)(177)))));
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(139)))), ((int)(((byte)(177)))));
            btnShort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(139)))), ((int)(((byte)(177)))));
            btnLong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(118)))), ((int)(((byte)(151)))));
            btnStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(139)))), ((int)(((byte)(177)))));
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            // Tính tổng giây
            totalSeconds = m * 60 + s;       

            // Kích hoạt pictureBoxCancel
            ptBxCancel.Visible = true;
            ptBxCancel.Enabled = true;

            if(!timer1.Enabled) // Nếu Timer chưa chạy thì:
            {
                btnStart.Text = "Stop"; // Start => Stop
                timer1.Start(); // Timer chạy
            }
            else
            {
                // Thông báo người dùng có dừng không? Yes/No
                DialogResult r = MessageBox.Show("Bạn Chắc Chắn Muốn Dừng?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes) // Yes thì:
                {
                    // Kích hoạt lại các nút
                    btnPomo.Enabled = true;
                    btnShort.Enabled = true;
                    btnLong.Enabled = true;

                    btnStart.Text = "Start"; // Stop => Start
                    timer1.Stop(); // Timer dừng
                }
                else
                {
                    //btnStart.Text = "Stop";
                }
            }
        }

        private void ptBxCancel_Click(object sender, EventArgs e)
        {
            // Thông báo người dùng có hủy không? Yes/No
            DialogResult r = MessageBox.Show("Bạn Chắc Chắn Muốn Hủy?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.Yes) // Có thì:
            {
                btnStart.Text = "Start"; // Stop => Start
                timer1.Stop(); // Timer dừng

                // Hiệu chỉnh lại thời gian
                s = 0;
                if (check == 1) m = 25;
                if (check == 2) m = 5;
                if (check == 3) m = 15;

                lbTime.Text = formatTime(m, s);

                // Kích hoạt lại các nút
                btnPomo.Enabled = true;
                btnShort.Enabled = true;
                btnLong.Enabled = true;

                // Vô hiệu pictureBox Cancel
                ptBxCancel.Visible = false;
                ptBxCancel.Enabled = false;
            }
            else
            {
                btnStart.Text = "Stop";
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
       
        private void đồngHồBáoThứcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Chức Năng Đang Được Phát Triển!!!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private string formatTime(int m, int s)
        {
            string minute, second;
            minute = m.ToString().Length > 1 ? m.ToString() : "0" + m.ToString();
            second = s.ToString().Length > 1 ? s.ToString() : "0" + s.ToString();
            return minute + ":" + second;
        }
    }
}
