using DAO;
using DTO;
using ThongKe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyHoTroDatVeXe
{
    public partial class fBaoCaoThongKe : Form
    {

        BindingSource dsChuyenDi = new BindingSource();
        BindingSource dsVeXe = new BindingSource();
        public fBaoCaoThongKe()
        {
            InitializeComponent();
            phanQuyen();
            dgvBaoCao.DataSource = dsVeXe;
            dgvthongTinChuyenDi.DataSource = dsChuyenDi;
            
            load();
            hienThiDanhSachChuyenDi();


        }
        #region Methods
        void load()
        {
            dgvBaoCao.DataSource = DatVeXeDAO.Instance.baoCao();

            dgvBaoCao.Columns[0].HeaderText = "Số điện thoại";
            dgvBaoCao.Columns[0].Width = 120;
            dgvBaoCao.Columns[1].HeaderText = "Mã chuyến đi";
            dgvBaoCao.Columns[1].Width = 92;
            dgvBaoCao.Columns[2].HeaderText = "Số ghế";
            dgvBaoCao.Columns[2].Width = 100;
            dgvBaoCao.Columns[3].HeaderText = "Ngày đặt";
            dgvBaoCao.Columns[3].Width = 110;
        }

        void hienThiDanhSachChuyenDi()
        {
            dsChuyenDi.DataSource = ChuyenDiDAO.Instance.LayDsChuyenDi();
            dgvthongTinChuyenDi.Columns[0].HeaderText = "Mã Chuyến đi";
            dgvthongTinChuyenDi.Columns[0].Width = 112;

            dgvthongTinChuyenDi.Columns[2].HeaderText = "Giờ đi";
            dgvthongTinChuyenDi.Columns[2].Width = 112;

            dgvthongTinChuyenDi.Columns[1].HeaderText = "Ngày đi";
            dgvthongTinChuyenDi.Columns[1].Width = 112;

            dgvthongTinChuyenDi.Columns[3].HeaderText = "Nơi xuất phát";
            dgvthongTinChuyenDi.Columns[3].Width = 112;

            dgvthongTinChuyenDi.Columns[4].HeaderText = "Điểm đến";
            dgvthongTinChuyenDi.Columns[4].Width = 112;

            dgvthongTinChuyenDi.Columns[5].HeaderText = "Giá vé";
            dgvthongTinChuyenDi.Columns[5].Width = 112;
        }
        void phanQuyen()
        {
            btDatVe.Enabled = false;
        }
        #endregion

        #region Events
        private void BtChuyenDi_Click(object sender, EventArgs e)
        {
            fQuanLyChuyenDi f = new fQuanLyChuyenDi();
            f.Show();
            this.Dispose(false);
        }

        private void BtXe_Click(object sender, EventArgs e)
        {
            fQuanLyXe f = new fQuanLyXe();
            f.Show();
            this.Dispose(false);
        }

        private void BtKhachHang_Click(object sender, EventArgs e)
        {
            fQuanLyKhachHang f = new fQuanLyKhachHang();
            f.Show();
            this.Dispose(false);
        }

        private void BtThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn rời khỏi phần mềm?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                fDangNhap f = new fDangNhap();
                f.Show();
                this.Dispose(false);
            }
        }

        private void BtTim_Click(object sender, EventArgs e)
        {
            try
            {
                int sdt = int.Parse(txtSDT.Text);
                List<DatVeXe> ds = DatVeXeDAO.Instance.timVeKH(sdt);
                dgvBaoCao.DataSource = ds;
            }
            catch(Exception)
            {
                MessageBox.Show("Lỗi định dạng nhập! Vui lòng kiểm tra lại", "Tìm khách hàng", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            fThongKeVe dlg2 = new fThongKeVe();
            dlg2.ShowDialog();
        }

        private void btnhuyVe_Click(object sender, EventArgs e)
        {
           

            fHuyVe dlg2 = new fHuyVe();
            dlg2.ShowDialog();
        }

        private void dgvBaoCao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int maCD =(int.Parse(dgvBaoCao.CurrentRow.Cells[1].Value.ToString()));
            dgvthongTinChuyenDi.DataSource = ChuyenDiDAO.Instance.LaydsCDThemma(maCD);
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click_1(object sender, EventArgs e)
        {

        }
    }
}
