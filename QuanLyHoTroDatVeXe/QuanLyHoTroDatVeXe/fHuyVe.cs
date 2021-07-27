using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAO;
using DTO;
namespace QuanLyHoTroDatVeXe
{
    public partial class fHuyVe : Form
    {
        BindingSource dsVeXe = new BindingSource();
        BindingSource dsHanhKhach = new BindingSource();
        public fHuyVe()
        {
            InitializeComponent();
            dgvdsve.DataSource = dsVeXe;
            load();
            taoRangBuoc();
            btnhuyve.Enabled = false;
            txtsdt.Enabled = false;
            txtmaGhe.Enabled = false;
            txtmaCD.Enabled = false;
            txttime.Enabled = false;
        }

        void load()
        {
            dgvdsve.DataSource = HuyVeDAO.Instance.LayDsve();

            dgvdsve.Columns[0].HeaderText = "Số điện thoại";
            dgvdsve.Columns[0].Width = 120;
            dgvdsve.Columns[1].HeaderText = "Mã chuyến đi";
            dgvdsve.Columns[1].Width = 92;
            dgvdsve.Columns[2].HeaderText = "Số ghế";
            dgvdsve.Columns[2].Width = 100;
            dgvdsve.Columns[3].HeaderText = "Ngày đặt";
            dgvdsve.Columns[3].Width = 110;
        }

        void taoRangBuoc()
        {
            txtsdt.DataBindings.Add("Text", dgvdsve.DataSource, "soDienThoai", true, DataSourceUpdateMode.Never);
            txtmaCD.DataBindings.Add("text", dgvdsve.DataSource, "maCD", true, DataSourceUpdateMode.Never);
            txtmaGhe.DataBindings.Add("text", dgvdsve.DataSource, "maGhe", true, DataSourceUpdateMode.Never);
            txttime.DataBindings.Add("text", dgvdsve.DataSource, "thoiGianDat", true, DataSourceUpdateMode.Never);
        }


        void hienThiDanhSach()
        {
            dsHanhKhach.DataSource = HanhKhachDAO.Instance.layDsKhachHang();

            dgvtthk.Columns[0].HeaderText = "Số điện thoại";
            dgvtthk.Columns[0].Width = 120;

            dgvtthk.Columns[1].HeaderText = "CMND";
            dgvtthk.Columns[1].Width = 100;

            dgvtthk.Columns[2].HeaderText = "Họ tên";
            dgvtthk.Columns[2].Width = 165;

            dgvtthk.Columns[3].HeaderText = "Giới tính";
            dgvtthk.Columns[3].Width = 70;

            dgvtthk.Columns[4].HeaderText = "Địa chỉ";
            dgvtthk.Columns[4].Width = 120;

            dgvtthk.Columns[5].HeaderText = "Email";
            dgvtthk.Columns[5].Width = 180;
        }
        private void btnhuyve_Click(object sender, EventArgs e)
        {
            int sdt = int.Parse(txtsdt.Text);
            string maghe = txtmaGhe.Text;
            if (sdt == 0 || maghe == "")
                MessageBox.Show("Bạn chưa chọn vé xe", "Hủy Vé Xe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                MessageBox.Show("Hủy vé thành công", "Hủy Vé Xe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                HuyVeDAO.Instance.xoave(sdt,maghe);
                load();
           

            }
        }

        private void dgvdsve_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int sdt = (int.Parse(dgvdsve.CurrentRow.Cells[0].Value.ToString()));
            dgvtthk.DataSource = HuyVeDAO.Instance.Laydshkhemma(sdt);
            hienThiDanhSach();
        }

      
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            btnhuyve.Enabled = true;
        }
    }
}
