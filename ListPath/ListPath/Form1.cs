using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ListPath
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog(); // Mở Browse For Folder
            txtMainPath.Text = folderBrowserDialog1.SelectedPath; // Lưu đường dẫn
            btnListPath.Enabled = true; // Mở khóa nút Liệt Kê 
        }

        private void btnListPath_Click(object sender, EventArgs e)
        {
            // Xóa các Items
            listSubPath.Items.Clear();

            // Lưu đường dẫn files vào mảng files
            string[] files = Directory.GetFiles(txtMainPath.Text);

            // Lưu đường dẫn folders vào mảng dirs
            string[] dirs = Directory.GetDirectories(txtMainPath.Text);

            // Thêm các đường dẫn files vào listBox
            foreach (string f in files)
            {
                listSubPath.Items.Add(f);
            }

            // Thêm các đường dẫn folders vào listBox
            foreach (string d in dirs)
            {
                listSubPath.Items.Add(d);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
