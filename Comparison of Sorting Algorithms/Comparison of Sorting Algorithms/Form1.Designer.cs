
namespace Comparison_of_Sorting_Algorithms
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
            this.btnExe = new System.Windows.Forms.Button();
            this.cartesianChart1 = new LiveCharts.WinForms.CartesianChart();
            this.cbbxPick = new System.Windows.Forms.ComboBox();
            this.lbOptions = new System.Windows.Forms.Label();
            this.panelAlgo = new System.Windows.Forms.Panel();
            this.rdoBtnQuick = new System.Windows.Forms.RadioButton();
            this.rdoBtnRadix = new System.Windows.Forms.RadioButton();
            this.rdoBtnHeap = new System.Windows.Forms.RadioButton();
            this.rdoBtnMerge = new System.Windows.Forms.RadioButton();
            this.rdoBtnShaker = new System.Windows.Forms.RadioButton();
            this.rdoBtnInsertion = new System.Windows.Forms.RadioButton();
            this.rdoBtnSelection = new System.Windows.Forms.RadioButton();
            this.rdoBtnBubble = new System.Windows.Forms.RadioButton();
            this.btnExit = new System.Windows.Forms.Button();
            this.rdoBtnBasic = new System.Windows.Forms.RadioButton();
            this.rdoBtnAdvance = new System.Windows.Forms.RadioButton();
            this.panelAlgo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExe
            // 
            this.btnExe.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExe.Location = new System.Drawing.Point(960, 57);
            this.btnExe.Name = "btnExe";
            this.btnExe.Size = new System.Drawing.Size(169, 47);
            this.btnExe.TabIndex = 0;
            this.btnExe.Text = "START";
            this.btnExe.UseVisualStyleBackColor = true;
            this.btnExe.Click += new System.EventHandler(this.btnExe_Click);
            // 
            // cartesianChart1
            // 
            this.cartesianChart1.Location = new System.Drawing.Point(3, 225);
            this.cartesianChart1.Name = "cartesianChart1";
            this.cartesianChart1.Size = new System.Drawing.Size(1180, 535);
            this.cartesianChart1.TabIndex = 1;
            this.cartesianChart1.Text = "cartesianChart1";
            this.cartesianChart1.Visible = false;
            // 
            // cbbxPick
            // 
            this.cbbxPick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbxPick.FormattingEnabled = true;
            this.cbbxPick.Items.AddRange(new object[] {
            "Một Thuật Toán",
            "Nhiều Thuật Toán"});
            this.cbbxPick.Location = new System.Drawing.Point(43, 46);
            this.cbbxPick.Name = "cbbxPick";
            this.cbbxPick.Size = new System.Drawing.Size(211, 32);
            this.cbbxPick.TabIndex = 2;
            this.cbbxPick.SelectedIndexChanged += new System.EventHandler(this.cbbxPick_SelectedIndexChanged);
            // 
            // lbOptions
            // 
            this.lbOptions.AutoSize = true;
            this.lbOptions.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOptions.Location = new System.Drawing.Point(12, 9);
            this.lbOptions.Name = "lbOptions";
            this.lbOptions.Size = new System.Drawing.Size(142, 24);
            this.lbOptions.TabIndex = 3;
            this.lbOptions.Text = "Vui Lòng Chọn:";
            // 
            // panelAlgo
            // 
            this.panelAlgo.Controls.Add(this.rdoBtnQuick);
            this.panelAlgo.Controls.Add(this.rdoBtnRadix);
            this.panelAlgo.Controls.Add(this.rdoBtnHeap);
            this.panelAlgo.Controls.Add(this.rdoBtnMerge);
            this.panelAlgo.Controls.Add(this.rdoBtnShaker);
            this.panelAlgo.Controls.Add(this.rdoBtnInsertion);
            this.panelAlgo.Controls.Add(this.rdoBtnSelection);
            this.panelAlgo.Controls.Add(this.rdoBtnBubble);
            this.panelAlgo.Location = new System.Drawing.Point(384, 44);
            this.panelAlgo.Name = "panelAlgo";
            this.panelAlgo.Size = new System.Drawing.Size(443, 170);
            this.panelAlgo.TabIndex = 4;
            this.panelAlgo.Visible = false;
            // 
            // rdoBtnQuick
            // 
            this.rdoBtnQuick.AutoSize = true;
            this.rdoBtnQuick.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnQuick.Location = new System.Drawing.Point(309, 139);
            this.rdoBtnQuick.Name = "rdoBtnQuick";
            this.rdoBtnQuick.Size = new System.Drawing.Size(115, 28);
            this.rdoBtnQuick.TabIndex = 7;
            this.rdoBtnQuick.TabStop = true;
            this.rdoBtnQuick.Text = "Quick Sort";
            this.rdoBtnQuick.UseVisualStyleBackColor = true;
            // 
            // rdoBtnRadix
            // 
            this.rdoBtnRadix.AutoSize = true;
            this.rdoBtnRadix.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnRadix.Location = new System.Drawing.Point(309, 95);
            this.rdoBtnRadix.Name = "rdoBtnRadix";
            this.rdoBtnRadix.Size = new System.Drawing.Size(114, 28);
            this.rdoBtnRadix.TabIndex = 6;
            this.rdoBtnRadix.TabStop = true;
            this.rdoBtnRadix.Text = "Radix Sort";
            this.rdoBtnRadix.UseVisualStyleBackColor = true;
            // 
            // rdoBtnHeap
            // 
            this.rdoBtnHeap.AutoSize = true;
            this.rdoBtnHeap.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnHeap.Location = new System.Drawing.Point(309, 44);
            this.rdoBtnHeap.Name = "rdoBtnHeap";
            this.rdoBtnHeap.Size = new System.Drawing.Size(112, 28);
            this.rdoBtnHeap.TabIndex = 5;
            this.rdoBtnHeap.TabStop = true;
            this.rdoBtnHeap.Text = "Heap Sort";
            this.rdoBtnHeap.UseVisualStyleBackColor = true;
            // 
            // rdoBtnMerge
            // 
            this.rdoBtnMerge.AutoSize = true;
            this.rdoBtnMerge.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnMerge.Location = new System.Drawing.Point(309, 3);
            this.rdoBtnMerge.Name = "rdoBtnMerge";
            this.rdoBtnMerge.Size = new System.Drawing.Size(121, 28);
            this.rdoBtnMerge.TabIndex = 4;
            this.rdoBtnMerge.TabStop = true;
            this.rdoBtnMerge.Text = "Merge Sort";
            this.rdoBtnMerge.UseVisualStyleBackColor = true;
            // 
            // rdoBtnShaker
            // 
            this.rdoBtnShaker.AutoSize = true;
            this.rdoBtnShaker.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnShaker.Location = new System.Drawing.Point(3, 139);
            this.rdoBtnShaker.Name = "rdoBtnShaker";
            this.rdoBtnShaker.Size = new System.Drawing.Size(195, 28);
            this.rdoBtnShaker.TabIndex = 3;
            this.rdoBtnShaker.TabStop = true;
            this.rdoBtnShaker.Text = "Cocktail Shaker Sort";
            this.rdoBtnShaker.UseVisualStyleBackColor = true;
            // 
            // rdoBtnInsertion
            // 
            this.rdoBtnInsertion.AutoSize = true;
            this.rdoBtnInsertion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnInsertion.Location = new System.Drawing.Point(3, 95);
            this.rdoBtnInsertion.Name = "rdoBtnInsertion";
            this.rdoBtnInsertion.Size = new System.Drawing.Size(137, 28);
            this.rdoBtnInsertion.TabIndex = 2;
            this.rdoBtnInsertion.TabStop = true;
            this.rdoBtnInsertion.Text = "Insertion Sort";
            this.rdoBtnInsertion.UseVisualStyleBackColor = true;
            // 
            // rdoBtnSelection
            // 
            this.rdoBtnSelection.AutoSize = true;
            this.rdoBtnSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnSelection.Location = new System.Drawing.Point(3, 49);
            this.rdoBtnSelection.Name = "rdoBtnSelection";
            this.rdoBtnSelection.Size = new System.Drawing.Size(144, 28);
            this.rdoBtnSelection.TabIndex = 1;
            this.rdoBtnSelection.TabStop = true;
            this.rdoBtnSelection.Text = "Selection Sort";
            this.rdoBtnSelection.UseVisualStyleBackColor = true;
            // 
            // rdoBtnBubble
            // 
            this.rdoBtnBubble.AutoSize = true;
            this.rdoBtnBubble.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnBubble.Location = new System.Drawing.Point(3, 3);
            this.rdoBtnBubble.Name = "rdoBtnBubble";
            this.rdoBtnBubble.Size = new System.Drawing.Size(126, 28);
            this.rdoBtnBubble.TabIndex = 0;
            this.rdoBtnBubble.TabStop = true;
            this.rdoBtnBubble.Text = "Bubble Sort";
            this.rdoBtnBubble.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(960, 148);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(169, 47);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rdoBtnBasic
            // 
            this.rdoBtnBasic.AutoSize = true;
            this.rdoBtnBasic.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnBasic.Location = new System.Drawing.Point(314, 13);
            this.rdoBtnBasic.Name = "rdoBtnBasic";
            this.rdoBtnBasic.Size = new System.Drawing.Size(95, 28);
            this.rdoBtnBasic.TabIndex = 8;
            this.rdoBtnBasic.TabStop = true;
            this.rdoBtnBasic.Text = "Cơ Bản:";
            this.rdoBtnBasic.UseVisualStyleBackColor = true;
            this.rdoBtnBasic.Visible = false;
            this.rdoBtnBasic.CheckedChanged += new System.EventHandler(this.rdoBtnBasic_CheckedChanged);
            // 
            // rdoBtnAdvance
            // 
            this.rdoBtnAdvance.AutoSize = true;
            this.rdoBtnAdvance.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdoBtnAdvance.Location = new System.Drawing.Point(597, 13);
            this.rdoBtnAdvance.Name = "rdoBtnAdvance";
            this.rdoBtnAdvance.Size = new System.Drawing.Size(118, 28);
            this.rdoBtnAdvance.TabIndex = 9;
            this.rdoBtnAdvance.TabStop = true;
            this.rdoBtnAdvance.Text = "Nâng Cao:";
            this.rdoBtnAdvance.UseVisualStyleBackColor = true;
            this.rdoBtnAdvance.Visible = false;
            this.rdoBtnAdvance.CheckedChanged += new System.EventHandler(this.rdoBtnAdvance_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 761);
            this.Controls.Add(this.rdoBtnAdvance);
            this.Controls.Add(this.rdoBtnBasic);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.panelAlgo);
            this.Controls.Add(this.lbOptions);
            this.Controls.Add(this.cbbxPick);
            this.Controls.Add(this.cartesianChart1);
            this.Controls.Add(this.btnExe);
            this.Name = "Form1";
            this.Text = "Comparison of Sorting Algorithms";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.panelAlgo.ResumeLayout(false);
            this.panelAlgo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExe;
        private LiveCharts.WinForms.CartesianChart cartesianChart1;
        private System.Windows.Forms.ComboBox cbbxPick;
        private System.Windows.Forms.Label lbOptions;
        private System.Windows.Forms.Panel panelAlgo;
        private System.Windows.Forms.RadioButton rdoBtnHeap;
        private System.Windows.Forms.RadioButton rdoBtnMerge;
        private System.Windows.Forms.RadioButton rdoBtnShaker;
        private System.Windows.Forms.RadioButton rdoBtnInsertion;
        private System.Windows.Forms.RadioButton rdoBtnSelection;
        private System.Windows.Forms.RadioButton rdoBtnBubble;
        private System.Windows.Forms.RadioButton rdoBtnQuick;
        private System.Windows.Forms.RadioButton rdoBtnRadix;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton rdoBtnBasic;
        private System.Windows.Forms.RadioButton rdoBtnAdvance;
    }
}

