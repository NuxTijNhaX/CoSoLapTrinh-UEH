
namespace ListPath
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
            this.txtMainPath = new System.Windows.Forms.TextBox();
            this.listSubPath = new System.Windows.Forms.ListBox();
            this.btnPick = new System.Windows.Forms.Button();
            this.btnListPath = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMainPath
            // 
            this.txtMainPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainPath.Location = new System.Drawing.Point(12, 12);
            this.txtMainPath.Name = "txtMainPath";
            this.txtMainPath.ReadOnly = true;
            this.txtMainPath.Size = new System.Drawing.Size(450, 31);
            this.txtMainPath.TabIndex = 0;
            // 
            // listSubPath
            // 
            this.listSubPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSubPath.FormattingEnabled = true;
            this.listSubPath.HorizontalScrollbar = true;
            this.listSubPath.ItemHeight = 24;
            this.listSubPath.Location = new System.Drawing.Point(12, 107);
            this.listSubPath.Name = "listSubPath";
            this.listSubPath.Size = new System.Drawing.Size(624, 292);
            this.listSubPath.TabIndex = 1;
            // 
            // btnPick
            // 
            this.btnPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPick.Location = new System.Drawing.Point(504, 11);
            this.btnPick.Name = "btnPick";
            this.btnPick.Size = new System.Drawing.Size(132, 35);
            this.btnPick.TabIndex = 2;
            this.btnPick.Text = "Chọn Folder";
            this.btnPick.UseVisualStyleBackColor = true;
            this.btnPick.Click += new System.EventHandler(this.btnPick_Click);
            // 
            // btnListPath
            // 
            this.btnListPath.Enabled = false;
            this.btnListPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListPath.Location = new System.Drawing.Point(12, 66);
            this.btnListPath.Name = "btnListPath";
            this.btnListPath.Size = new System.Drawing.Size(110, 35);
            this.btnListPath.TabIndex = 3;
            this.btnListPath.Text = "Liệt Kê";
            this.btnListPath.UseVisualStyleBackColor = true;
            this.btnListPath.Click += new System.EventHandler(this.btnListPath_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ListPath.Properties.Resources.file_icon_3_product;
            this.pictureBox1.Location = new System.Drawing.Point(468, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(468, 57);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(168, 35);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Đóng";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(652, 417);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnListPath);
            this.Controls.Add(this.btnPick);
            this.Controls.Add(this.listSubPath);
            this.Controls.Add(this.txtMainPath);
            this.Name = "Form1";
            this.Text = "List Sub Path";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMainPath;
        private System.Windows.Forms.ListBox listSubPath;
        private System.Windows.Forms.Button btnPick;
        private System.Windows.Forms.Button btnListPath;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnExit;
    }
}

