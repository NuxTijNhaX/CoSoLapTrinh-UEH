
namespace PomodoroApp
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnPomo = new System.Windows.Forms.Button();
            this.btnShort = new System.Windows.Forms.Button();
            this.btnLong = new System.Windows.Forms.Button();
            this.btnStart = new System.Windows.Forms.Button();
            this.lbTime = new System.Windows.Forms.Label();
            this.progressBarTime = new System.Windows.Forms.ProgressBar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.chứcNăngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pomodoroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đồngHồBáoThứcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoátToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ptBxCancel = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBxCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPomo
            // 
            this.btnPomo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(85)))), ((int)(((byte)(81)))));
            this.btnPomo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPomo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnPomo.Location = new System.Drawing.Point(25, 35);
            this.btnPomo.Margin = new System.Windows.Forms.Padding(2);
            this.btnPomo.Name = "btnPomo";
            this.btnPomo.Size = new System.Drawing.Size(170, 75);
            this.btnPomo.TabIndex = 0;
            this.btnPomo.Text = "Pomodoro";
            this.btnPomo.UseVisualStyleBackColor = false;
            this.btnPomo.Click += new System.EventHandler(this.btnPomo_Click);
            // 
            // btnShort
            // 
            this.btnShort.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(100)))), ((int)(((byte)(95)))));
            this.btnShort.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShort.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnShort.Location = new System.Drawing.Point(224, 36);
            this.btnShort.Margin = new System.Windows.Forms.Padding(2);
            this.btnShort.Name = "btnShort";
            this.btnShort.Size = new System.Drawing.Size(170, 74);
            this.btnShort.TabIndex = 1;
            this.btnShort.Text = "Short Break";
            this.btnShort.UseVisualStyleBackColor = false;
            this.btnShort.Click += new System.EventHandler(this.btnShort_Click);
            // 
            // btnLong
            // 
            this.btnLong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(100)))), ((int)(((byte)(95)))));
            this.btnLong.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLong.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnLong.Location = new System.Drawing.Point(422, 36);
            this.btnLong.Margin = new System.Windows.Forms.Padding(2);
            this.btnLong.Name = "btnLong";
            this.btnLong.Size = new System.Drawing.Size(170, 74);
            this.btnLong.TabIndex = 2;
            this.btnLong.Text = "Long Break";
            this.btnLong.UseVisualStyleBackColor = false;
            this.btnLong.Click += new System.EventHandler(this.btnLong_Click);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Snow;
            this.btnStart.Font = new System.Drawing.Font("Arial Rounded MT Bold", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Brown;
            this.btnStart.Location = new System.Drawing.Point(246, 346);
            this.btnStart.Margin = new System.Windows.Forms.Padding(2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(129, 66);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Arial Rounded MT Bold", 99.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbTime.Location = new System.Drawing.Point(104, 128);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(423, 154);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "25:00";
            // 
            // progressBarTime
            // 
            this.progressBarTime.Location = new System.Drawing.Point(1, 304);
            this.progressBarTime.Name = "progressBarTime";
            this.progressBarTime.Size = new System.Drawing.Size(616, 23);
            this.progressBarTime.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarTime.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chứcNăngToolStripMenuItem,
            this.thoátToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(619, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // chứcNăngToolStripMenuItem
            // 
            this.chứcNăngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pomodoroToolStripMenuItem,
            this.đồngHồBáoThứcToolStripMenuItem});
            this.chứcNăngToolStripMenuItem.Name = "chứcNăngToolStripMenuItem";
            this.chứcNăngToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.chứcNăngToolStripMenuItem.Text = "Chức Năng";
            // 
            // pomodoroToolStripMenuItem
            // 
            this.pomodoroToolStripMenuItem.Checked = true;
            this.pomodoroToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pomodoroToolStripMenuItem.Name = "pomodoroToolStripMenuItem";
            this.pomodoroToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.pomodoroToolStripMenuItem.Text = "Pomodoro";
            // 
            // đồngHồBáoThứcToolStripMenuItem
            // 
            this.đồngHồBáoThứcToolStripMenuItem.Name = "đồngHồBáoThứcToolStripMenuItem";
            this.đồngHồBáoThứcToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.đồngHồBáoThứcToolStripMenuItem.Text = "Đồng Hồ Báo Thức";
            this.đồngHồBáoThứcToolStripMenuItem.Click += new System.EventHandler(this.đồngHồBáoThứcToolStripMenuItem_Click);
            // 
            // thoátToolStripMenuItem
            // 
            this.thoátToolStripMenuItem.Name = "thoátToolStripMenuItem";
            this.thoátToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.thoátToolStripMenuItem.Text = "Thoát";
            this.thoátToolStripMenuItem.Click += new System.EventHandler(this.thoátToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ptBxCancel
            // 
            this.ptBxCancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ptBxCancel.Enabled = false;
            this.ptBxCancel.Image = global::PomodoroApp.Properties.Resources.next_white3;
            this.ptBxCancel.Location = new System.Drawing.Point(404, 360);
            this.ptBxCancel.Name = "ptBxCancel";
            this.ptBxCancel.Size = new System.Drawing.Size(40, 40);
            this.ptBxCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptBxCancel.TabIndex = 7;
            this.ptBxCancel.TabStop = false;
            this.ptBxCancel.Visible = false;
            this.ptBxCancel.Click += new System.EventHandler(this.ptBxCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(100)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(619, 438);
            this.Controls.Add(this.ptBxCancel);
            this.Controls.Add(this.progressBarTime);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnLong);
            this.Controls.Add(this.btnShort);
            this.Controls.Add(this.btnPomo);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Pomodoro App";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ptBxCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPomo;
        private System.Windows.Forms.Button btnShort;
        private System.Windows.Forms.Button btnLong;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.ProgressBar progressBarTime;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem chứcNăngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pomodoroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đồngHồBáoThứcToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoátToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox ptBxCancel;
    }
}

