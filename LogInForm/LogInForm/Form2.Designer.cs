
namespace LogInForm
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbPassRegis = new System.Windows.Forms.Label();
            this.lbUsernameRegis = new System.Windows.Forms.Label();
            this.btnRegis = new System.Windows.Forms.Button();
            this.txtPassRegis = new System.Windows.Forms.TextBox();
            this.txtUsernameRegis = new System.Windows.Forms.TextBox();
            this.lbFormNameRegis = new System.Windows.Forms.Label();
            this.lbNameRegis = new System.Windows.Forms.Label();
            this.txtNameRegis = new System.Windows.Forms.TextBox();
            this.lbRetypePassRegis = new System.Windows.Forms.Label();
            this.txtRetypePassRegis = new System.Windows.Forms.TextBox();
            this.lbEmailRegis = new System.Windows.Forms.Label();
            this.txtEmailRegis = new System.Windows.Forms.TextBox();
            this.datePick = new System.Windows.Forms.DateTimePicker();
            this.lbDOBRegis = new System.Windows.Forms.Label();
            this.lbMustHave = new System.Windows.Forms.Label();
            this.lbBackRegis = new System.Windows.Forms.Label();
            this.lbSexRegis = new System.Windows.Forms.Label();
            this.rdoFemaleRegis = new System.Windows.Forms.RadioButton();
            this.rdoMaleRegis = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lbTuoi = new System.Windows.Forms.Label();
            this.lbMeasurePass = new System.Windows.Forms.Label();
            this.lbConfirmPass = new System.Windows.Forms.Label();
            this.lbAge = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbPassRegis
            // 
            this.lbPassRegis.AutoSize = true;
            this.lbPassRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassRegis.Location = new System.Drawing.Point(67, 390);
            this.lbPassRegis.Name = "lbPassRegis";
            this.lbPassRegis.Size = new System.Drawing.Size(87, 20);
            this.lbPassRegis.TabIndex = 15;
            this.lbPassRegis.Text = "Mật Khẩu*:";
            // 
            // lbUsernameRegis
            // 
            this.lbUsernameRegis.AutoSize = true;
            this.lbUsernameRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsernameRegis.Location = new System.Drawing.Point(23, 328);
            this.lbUsernameRegis.Name = "lbUsernameRegis";
            this.lbUsernameRegis.Size = new System.Drawing.Size(131, 20);
            this.lbUsernameRegis.TabIndex = 14;
            this.lbUsernameRegis.Text = "Tên Đăng Nhập*:";
            // 
            // btnRegis
            // 
            this.btnRegis.BackColor = System.Drawing.Color.LimeGreen;
            this.btnRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegis.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnRegis.Location = new System.Drawing.Point(138, 537);
            this.btnRegis.Name = "btnRegis";
            this.btnRegis.Size = new System.Drawing.Size(258, 47);
            this.btnRegis.TabIndex = 13;
            this.btnRegis.Text = "Đăng Ký";
            this.btnRegis.UseVisualStyleBackColor = false;
            this.btnRegis.Click += new System.EventHandler(this.btnRegis_Click);
            // 
            // txtPassRegis
            // 
            this.txtPassRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassRegis.Location = new System.Drawing.Point(154, 382);
            this.txtPassRegis.Name = "txtPassRegis";
            this.txtPassRegis.Size = new System.Drawing.Size(351, 35);
            this.txtPassRegis.TabIndex = 7;
            this.txtPassRegis.UseSystemPasswordChar = true;
            this.txtPassRegis.TextChanged += new System.EventHandler(this.txtPassRegis_TextChanged);
            // 
            // txtUsernameRegis
            // 
            this.txtUsernameRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsernameRegis.Location = new System.Drawing.Point(154, 320);
            this.txtUsernameRegis.Name = "txtUsernameRegis";
            this.txtUsernameRegis.Size = new System.Drawing.Size(351, 35);
            this.txtUsernameRegis.TabIndex = 6;
            // 
            // lbFormNameRegis
            // 
            this.lbFormNameRegis.AutoSize = true;
            this.lbFormNameRegis.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFormNameRegis.Location = new System.Drawing.Point(93, 39);
            this.lbFormNameRegis.Name = "lbFormNameRegis";
            this.lbFormNameRegis.Size = new System.Drawing.Size(341, 40);
            this.lbFormNameRegis.TabIndex = 10;
            this.lbFormNameRegis.Text = "Registration Form";
            // 
            // lbNameRegis
            // 
            this.lbNameRegis.AutoSize = true;
            this.lbNameRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNameRegis.Location = new System.Drawing.Point(80, 118);
            this.lbNameRegis.Name = "lbNameRegis";
            this.lbNameRegis.Size = new System.Drawing.Size(71, 20);
            this.lbNameRegis.TabIndex = 19;
            this.lbNameRegis.Text = "Họ Tên*:";
            // 
            // txtNameRegis
            // 
            this.txtNameRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameRegis.Location = new System.Drawing.Point(154, 111);
            this.txtNameRegis.Name = "txtNameRegis";
            this.txtNameRegis.Size = new System.Drawing.Size(351, 35);
            this.txtNameRegis.TabIndex = 1;
            // 
            // lbRetypePassRegis
            // 
            this.lbRetypePassRegis.AutoSize = true;
            this.lbRetypePassRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRetypePassRegis.Location = new System.Drawing.Point(-2, 463);
            this.lbRetypePassRegis.Name = "lbRetypePassRegis";
            this.lbRetypePassRegis.Size = new System.Drawing.Size(154, 20);
            this.lbRetypePassRegis.TabIndex = 21;
            this.lbRetypePassRegis.Text = "Nhập Lại Mật Khẩu*:";
            // 
            // txtRetypePassRegis
            // 
            this.txtRetypePassRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRetypePassRegis.Location = new System.Drawing.Point(153, 455);
            this.txtRetypePassRegis.Name = "txtRetypePassRegis";
            this.txtRetypePassRegis.Size = new System.Drawing.Size(351, 35);
            this.txtRetypePassRegis.TabIndex = 8;
            this.txtRetypePassRegis.UseSystemPasswordChar = true;
            this.txtRetypePassRegis.TextChanged += new System.EventHandler(this.txtRetypePassRegis_TextChanged);
            // 
            // lbEmailRegis
            // 
            this.lbEmailRegis.AutoSize = true;
            this.lbEmailRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmailRegis.Location = new System.Drawing.Point(96, 219);
            this.lbEmailRegis.Name = "lbEmailRegis";
            this.lbEmailRegis.Size = new System.Drawing.Size(52, 20);
            this.lbEmailRegis.TabIndex = 23;
            this.lbEmailRegis.Text = "Email:";
            // 
            // txtEmailRegis
            // 
            this.txtEmailRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailRegis.Location = new System.Drawing.Point(154, 212);
            this.txtEmailRegis.Name = "txtEmailRegis";
            this.txtEmailRegis.Size = new System.Drawing.Size(351, 35);
            this.txtEmailRegis.TabIndex = 4;
            // 
            // datePick
            // 
            this.datePick.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePick.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePick.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePick.Location = new System.Drawing.Point(154, 266);
            this.datePick.Name = "datePick";
            this.datePick.Size = new System.Drawing.Size(168, 26);
            this.datePick.TabIndex = 5;
            this.datePick.ValueChanged += new System.EventHandler(this.datePick_ValueChanged);
            // 
            // lbDOBRegis
            // 
            this.lbDOBRegis.AutoSize = true;
            this.lbDOBRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDOBRegis.Location = new System.Drawing.Point(63, 270);
            this.lbDOBRegis.Name = "lbDOBRegis";
            this.lbDOBRegis.Size = new System.Drawing.Size(91, 20);
            this.lbDOBRegis.TabIndex = 25;
            this.lbDOBRegis.Text = "Ngày Sinh*:";
            // 
            // lbMustHave
            // 
            this.lbMustHave.AutoSize = true;
            this.lbMustHave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMustHave.ForeColor = System.Drawing.Color.Red;
            this.lbMustHave.Location = new System.Drawing.Point(24, 88);
            this.lbMustHave.Name = "lbMustHave";
            this.lbMustHave.Size = new System.Drawing.Size(95, 16);
            this.lbMustHave.TabIndex = 26;
            this.lbMustHave.Text = "* là bắt buộc";
            // 
            // lbBackRegis
            // 
            this.lbBackRegis.AutoSize = true;
            this.lbBackRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBackRegis.Location = new System.Drawing.Point(14, 12);
            this.lbBackRegis.Name = "lbBackRegis";
            this.lbBackRegis.Size = new System.Drawing.Size(89, 20);
            this.lbBackRegis.TabIndex = 27;
            this.lbBackRegis.Text = "<= Trở Lại";
            this.lbBackRegis.Click += new System.EventHandler(this.lbBack_Click);
            this.lbBackRegis.MouseLeave += new System.EventHandler(this.lbBack_MouseLeave);
            this.lbBackRegis.MouseHover += new System.EventHandler(this.lbBack_MouseHover);
            // 
            // lbSexRegis
            // 
            this.lbSexRegis.AutoSize = true;
            this.lbSexRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSexRegis.Location = new System.Drawing.Point(71, 174);
            this.lbSexRegis.Name = "lbSexRegis";
            this.lbSexRegis.Size = new System.Drawing.Size(81, 20);
            this.lbSexRegis.TabIndex = 28;
            this.lbSexRegis.Text = "Giới Tính*:";
            // 
            // rdoFemaleRegis
            // 
            this.rdoFemaleRegis.AutoSize = true;
            this.rdoFemaleRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoFemaleRegis.Location = new System.Drawing.Point(69, 3);
            this.rdoFemaleRegis.Name = "rdoFemaleRegis";
            this.rdoFemaleRegis.Size = new System.Drawing.Size(47, 24);
            this.rdoFemaleRegis.TabIndex = 2;
            this.rdoFemaleRegis.TabStop = true;
            this.rdoFemaleRegis.Text = "Nữ";
            this.rdoFemaleRegis.UseVisualStyleBackColor = true;
            // 
            // rdoMaleRegis
            // 
            this.rdoMaleRegis.AutoSize = true;
            this.rdoMaleRegis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoMaleRegis.Location = new System.Drawing.Point(3, 3);
            this.rdoMaleRegis.Name = "rdoMaleRegis";
            this.rdoMaleRegis.Size = new System.Drawing.Size(60, 24);
            this.rdoMaleRegis.TabIndex = 1;
            this.rdoMaleRegis.TabStop = true;
            this.rdoMaleRegis.Text = "Nam";
            this.rdoMaleRegis.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.rdoMaleRegis);
            this.flowLayoutPanel1.Controls.Add(this.rdoFemaleRegis);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(154, 168);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(351, 29);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // lbTuoi
            // 
            this.lbTuoi.AutoSize = true;
            this.lbTuoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTuoi.Location = new System.Drawing.Point(336, 270);
            this.lbTuoi.Name = "lbTuoi";
            this.lbTuoi.Size = new System.Drawing.Size(43, 20);
            this.lbTuoi.TabIndex = 29;
            this.lbTuoi.Text = "Tuổi:";
            this.lbTuoi.Visible = false;
            // 
            // lbMeasurePass
            // 
            this.lbMeasurePass.AutoSize = true;
            this.lbMeasurePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMeasurePass.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbMeasurePass.Location = new System.Drawing.Point(154, 422);
            this.lbMeasurePass.Name = "lbMeasurePass";
            this.lbMeasurePass.Size = new System.Drawing.Size(89, 16);
            this.lbMeasurePass.TabIndex = 30;
            this.lbMeasurePass.Text = "No Password";
            this.lbMeasurePass.Visible = false;
            // 
            // lbConfirmPass
            // 
            this.lbConfirmPass.AutoSize = true;
            this.lbConfirmPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbConfirmPass.Location = new System.Drawing.Point(153, 495);
            this.lbConfirmPass.Name = "lbConfirmPass";
            this.lbConfirmPass.Size = new System.Drawing.Size(15, 16);
            this.lbConfirmPass.TabIndex = 31;
            this.lbConfirmPass.Text = "0";
            this.lbConfirmPass.Visible = false;
            // 
            // lbAge
            // 
            this.lbAge.AutoSize = true;
            this.lbAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAge.Location = new System.Drawing.Point(375, 270);
            this.lbAge.Name = "lbAge";
            this.lbAge.Size = new System.Drawing.Size(18, 20);
            this.lbAge.TabIndex = 32;
            this.lbAge.Text = "0";
            this.lbAge.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbAge.Visible = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(534, 600);
            this.Controls.Add(this.lbAge);
            this.Controls.Add(this.lbConfirmPass);
            this.Controls.Add(this.lbMeasurePass);
            this.Controls.Add(this.lbTuoi);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbSexRegis);
            this.Controls.Add(this.lbBackRegis);
            this.Controls.Add(this.lbMustHave);
            this.Controls.Add(this.lbDOBRegis);
            this.Controls.Add(this.datePick);
            this.Controls.Add(this.lbEmailRegis);
            this.Controls.Add(this.txtEmailRegis);
            this.Controls.Add(this.lbRetypePassRegis);
            this.Controls.Add(this.txtRetypePassRegis);
            this.Controls.Add(this.lbNameRegis);
            this.Controls.Add(this.txtNameRegis);
            this.Controls.Add(this.lbPassRegis);
            this.Controls.Add(this.lbUsernameRegis);
            this.Controls.Add(this.btnRegis);
            this.Controls.Add(this.txtPassRegis);
            this.Controls.Add(this.txtUsernameRegis);
            this.Controls.Add(this.lbFormNameRegis);
            this.Name = "Form2";
            this.Text = "Registration Form";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbPassRegis;
        private System.Windows.Forms.Label lbUsernameRegis;
        private System.Windows.Forms.Button btnRegis;
        private System.Windows.Forms.TextBox txtPassRegis;
        private System.Windows.Forms.TextBox txtUsernameRegis;
        private System.Windows.Forms.Label lbFormNameRegis;
        private System.Windows.Forms.Label lbNameRegis;
        private System.Windows.Forms.TextBox txtNameRegis;
        private System.Windows.Forms.Label lbRetypePassRegis;
        private System.Windows.Forms.TextBox txtRetypePassRegis;
        private System.Windows.Forms.Label lbEmailRegis;
        private System.Windows.Forms.TextBox txtEmailRegis;
        private System.Windows.Forms.DateTimePicker datePick;
        private System.Windows.Forms.Label lbDOBRegis;
        private System.Windows.Forms.Label lbMustHave;
        private System.Windows.Forms.Label lbBackRegis;
        private System.Windows.Forms.Label lbSexRegis;
        private System.Windows.Forms.RadioButton rdoFemaleRegis;
        private System.Windows.Forms.RadioButton rdoMaleRegis;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label lbTuoi;
        private System.Windows.Forms.Label lbMeasurePass;
        private System.Windows.Forms.Label lbConfirmPass;
        private System.Windows.Forms.Label lbAge;
    }
}