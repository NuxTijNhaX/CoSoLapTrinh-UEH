
namespace LogInForm
{
    partial class Form3
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
            this.ptBxAvatar = new System.Windows.Forms.PictureBox();
            this.btnLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptBxAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // ptBxAvatar
            // 
            this.ptBxAvatar.Image = global::LogInForm.Properties.Resources.profile_287_460516;
            this.ptBxAvatar.Location = new System.Drawing.Point(12, 12);
            this.ptBxAvatar.Name = "ptBxAvatar";
            this.ptBxAvatar.Size = new System.Drawing.Size(140, 147);
            this.ptBxAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptBxAvatar.TabIndex = 0;
            this.ptBxAvatar.TabStop = false;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.LimeGreen;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnLogin.Location = new System.Drawing.Point(214, 54);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(258, 47);
            this.btnLogin.TabIndex = 6;
            this.btnLogin.Text = "Đóng";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(541, 185);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.ptBxAvatar);
            this.Name = "Form3";
            this.Text = "User Profile";
            ((System.ComponentModel.ISupportInitialize)(this.ptBxAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptBxAvatar;
        private System.Windows.Forms.Button btnLogin;
    }
}