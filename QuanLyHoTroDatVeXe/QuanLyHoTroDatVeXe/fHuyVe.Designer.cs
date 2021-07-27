
namespace QuanLyHoTroDatVeXe
{
    partial class fHuyVe
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvdsve = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvtthk = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txttime = new System.Windows.Forms.TextBox();
            this.txtmaGhe = new System.Windows.Forms.TextBox();
            this.txtmaCD = new System.Windows.Forms.TextBox();
            this.txtsdt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.btnhuyve = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsve)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvtthk)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(406, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(621, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "HỦY VÉ XE HÀNH KHÁCH ĐÃ ĐẶT";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvdsve);
            this.groupBox1.Location = new System.Drawing.Point(24, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(509, 490);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DANH SÁCH VÉ ĐẶT";
            // 
            // dgvdsve
            // 
            this.dgvdsve.BackgroundColor = System.Drawing.Color.White;
            this.dgvdsve.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdsve.Location = new System.Drawing.Point(6, 25);
            this.dgvdsve.Name = "dgvdsve";
            this.dgvdsve.RowHeadersWidth = 62;
            this.dgvdsve.RowTemplate.Height = 28;
            this.dgvdsve.Size = new System.Drawing.Size(497, 459);
            this.dgvdsve.TabIndex = 0;
            this.dgvdsve.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdsve_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvtthk);
            this.groupBox2.Location = new System.Drawing.Point(539, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(755, 227);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "THÔNG TIN HÀNH KHÁCH";
            // 
            // dgvtthk
            // 
            this.dgvtthk.BackgroundColor = System.Drawing.Color.White;
            this.dgvtthk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvtthk.Location = new System.Drawing.Point(4, 25);
            this.dgvtthk.Name = "dgvtthk";
            this.dgvtthk.RowHeadersWidth = 62;
            this.dgvtthk.RowTemplate.Height = 28;
            this.dgvtthk.Size = new System.Drawing.Size(745, 196);
            this.dgvtthk.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txttime);
            this.groupBox3.Controls.Add(this.txtmaGhe);
            this.groupBox3.Controls.Add(this.txtmaCD);
            this.groupBox3.Controls.Add(this.txtsdt);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(549, 410);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(745, 250);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "THÔNG TIN VÉ XE";
            // 
            // txttime
            // 
            this.txttime.Location = new System.Drawing.Point(557, 140);
            this.txttime.Name = "txttime";
            this.txttime.Size = new System.Drawing.Size(172, 26);
            this.txttime.TabIndex = 7;
            // 
            // txtmaGhe
            // 
            this.txtmaGhe.Location = new System.Drawing.Point(557, 60);
            this.txtmaGhe.Name = "txtmaGhe";
            this.txtmaGhe.Size = new System.Drawing.Size(172, 26);
            this.txtmaGhe.TabIndex = 6;
            // 
            // txtmaCD
            // 
            this.txtmaCD.Location = new System.Drawing.Point(197, 138);
            this.txtmaCD.Name = "txtmaCD";
            this.txtmaCD.Size = new System.Drawing.Size(183, 26);
            this.txtmaCD.TabIndex = 5;
            // 
            // txtsdt
            // 
            this.txtsdt.Location = new System.Drawing.Point(197, 60);
            this.txtsdt.Name = "txtsdt";
            this.txtsdt.Size = new System.Drawing.Size(183, 26);
            this.txtsdt.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(406, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Thời Gian Đặt";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(456, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mã Ghế:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mã Chuyến Đi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số Điện Thoại:";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(73, 112);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(86, 24);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Hủy Vé";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnhuyve
            // 
            this.btnhuyve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnhuyve.BackgroundImage = global::QuanLyHoTroDatVeXe.Properties.Resources.editdelete;
            this.btnhuyve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnhuyve.Location = new System.Drawing.Point(1139, 666);
            this.btnhuyve.Name = "btnhuyve";
            this.btnhuyve.Size = new System.Drawing.Size(149, 61);
            this.btnhuyve.TabIndex = 7;
            this.btnhuyve.UseVisualStyleBackColor = false;
            this.btnhuyve.Click += new System.EventHandler(this.btnhuyve_Click);
            // 
            // fHuyVe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1306, 739);
            this.Controls.Add(this.btnhuyve);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "fHuyVe";
            this.Text = "Hủy Vé Xe";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdsve)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvtthk)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvdsve;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvtthk;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txttime;
        private System.Windows.Forms.TextBox txtmaGhe;
        private System.Windows.Forms.TextBox txtmaCD;
        private System.Windows.Forms.TextBox txtsdt;
        private System.Windows.Forms.Button btnhuyve;
    }
}