using DAO;
using DTO;
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
    public partial class fDatVeXe : Form
    {
        //tạo biến singleton
        private HanhKhach taiKhoanKH;
        public HanhKhach TaiKhoanKH { get { return taiKhoanKH; } set { taiKhoanKH = value; } }
        ChuyenDi chuyenDangChon = new ChuyenDi();

        public fDatVeXe(HanhKhach kh)
        {
            InitializeComponent();
            this.taiKhoanKH = kh;
            fromMacDinh();
        }

        #region Methods
        //
        void fromMacDinh()
        {
            phanQuyen();
            hienThiDiemDen();
            hienThiDiemDi();
            hienThiGioDi();
            grbGhe.Enabled = false;
            btChon.Enabled = false;
            btXacNhan.Visible = false;
            panel1.Visible = false;
            txtHoTen.Text = taiKhoanKH.HoTen;
            txtSDT.Text = "0" + taiKhoanKH.SoDienThoai;
        }
        void reLoad()
        {
            fDatVeXe from = new fDatVeXe(taiKhoanKH);
            from.Show();
            this.Dispose();
        }
        void phanQuyen()
        {
            btChuyenDi.Enabled = false;
            btXe.Enabled = false;
            btKhachHang.Enabled = false;
            btBaoCao.Enabled = false;
        }
        void hienThiDiemDi()
        {
            List<ChuyenDi> dsChuyen = ChuyenDiDAO.Instance.LayDsChuyenDi();
            for (int i = 0; i < dsChuyen.Count-1; i++)
            {
                for (int j = i+1; j < dsChuyen.Count; j++)
                {
                    if (dsChuyen.ElementAt(i).DiemDi.Contains(dsChuyen.ElementAt(j).DiemDi))
                        dsChuyen.RemoveAt(j);
                }
            }

            cbDiemDi.DataSource = dsChuyen;
            cbDiemDi.DisplayMember = "diemDi";
        }
        void hienThiDiemDen()
        {
            List<ChuyenDi> dsChuyen = ChuyenDiDAO.Instance.LayDsChuyenDi();
            for (int i = 0; i < dsChuyen.Count - 1; i++)
            {
                for (int j = i + 1; j < dsChuyen.Count; j++)
                {
                    if (dsChuyen.ElementAt(i).DiemDen.Contains(dsChuyen.ElementAt(j).DiemDen))
                        dsChuyen.RemoveAt(j);
                }
            }
            cbDiemDen.DataSource = dsChuyen;
            cbDiemDen.DisplayMember = "diemDen";
        }
        void hienThiGioDi()
        {
            List<ChuyenDi> dsChuyen = ChuyenDiDAO.Instance.LayDsChuyenDi();
            for (int i = 0; i < dsChuyen.Count - 1; i++)
            {
                for (int j = i + 1; j < dsChuyen.Count; j++)
                {
                    if (dsChuyen.ElementAt(i).GioDi == dsChuyen.ElementAt(j).GioDi )
                        dsChuyen.RemoveAt(j);
                }
            }
            cbGio.DataSource = dsChuyen;
            cbGio.DisplayMember = "gioDi";
        }
        #endregion

        #region Events

        private void ChonGhe_Click(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            if (p.BackColor == Color.Gray)
            {
                lbGheDangChon.Items.Remove(p.Name);
                p.BackColor = pGhe.BackColor;
            }
            else
            {
                lbGheDangChon.Items.Add(p.Name);
                p.BackColor = Color.Gray;
            }
        }
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
        private void BtBaoCao_Click(object sender, EventArgs e)
        {
            fBaoCaoThongKe f = new fBaoCaoThongKe();
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
        private void btTimChuyen_Click(object sender, EventArgs e)
        {
            string gio = cbGio.GetItemText(cbGio.SelectedItem);
            string ngay = dtpNgayDi.Value.Month + "-" + dtpNgayDi.Value.Day + "-" + dtpNgayDi.Value.Year;
            string di = cbDiemDi.GetItemText(cbDiemDi.SelectedItem);
            string den = cbDiemDen.GetItemText(cbDiemDen.SelectedItem);

            chuyenDangChon = ChuyenDiDAO.Instance.timChuyenDi(gio, ngay, di, den);
            if (chuyenDangChon != null)
            {
                grbGhe.Enabled = true;
                btChon.Enabled = true;

                List<DatVeXe> dsVeDaDat = DatVeXeDAO.Instance.layDsVeXe(chuyenDangChon.MaCD);
                foreach (DatVeXe ve in dsVeDaDat)
                {
                    ((PictureBox)grbGhe.Controls[ve.MaGhe]).BackColor = Color.Orange;
                    ((PictureBox)grbGhe.Controls[ve.MaGhe]).Enabled = false;
                }
            }
            else
                MessageBox.Show("Nhà xe chưa có chuyến này!! Bạn vui lòng tìm chuyến khác nhé", "Tìm chuyến", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void BtChon_Click(object sender, EventArgs e)
        {
            int soLuongGhe = lbGheDangChon.Items.Count;
            if (soLuongGhe > 0)
            {
 
                lbChuyen.Text = chuyenDangChon.DiemDi + " - " + chuyenDangChon.DiemDen;
                lbGio.Text = chuyenDangChon.GioDi + " " + chuyenDangChon.NgayDi.Day + "/"
                        + chuyenDangChon.NgayDi.Month + "/" + chuyenDangChon.NgayDi.Year;
                string ghe = "";
                foreach (var item in lbGheDangChon.Items)
                {
                    ghe += item.ToString() + " ";
                }
                lbGheDaChon.Text = ghe;
                lbSoLuong.Text = soLuongGhe.ToString();
                lbGia.Text = string.Format("{0:0,0} VNĐ", chuyenDangChon.GiaVe);
                double tong = chuyenDangChon.GiaVe * soLuongGhe;
                lbTongTien.Text = string.Format( "{0:0,0} VNĐ", tong);
            }
            else
                MessageBox.Show("Bạn chưa chọn ghế!! Mau chọn ghế đi nè", "Chọn ghế", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btXacNhan_Click(object sender, EventArgs e)
        {
           
            string stk = txtSTK.Text;
            int dem = 0;
            foreach (string item in lbGheDangChon.Items)
            {
                bool result = DatVeXeDAO.Instance.datVe(taiKhoanKH.SoDienThoai, chuyenDangChon.MaCD, item);
                if (result)
                    dem++;
            }
            if (dem == 0)
                MessageBox.Show("Đặt không thành công \n Chưa chọn vé kìa!!", "Đặt vé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (stk=="")
                MessageBox.Show("Đặt không thành công \n Nhập số tài khoản vào để thanh toán nha!!", "Đặt vé", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                MessageBox.Show("Thanh Toán Thành Công \nBạn đã đặt thành công " + dem + " vé", "Đặt vé", MessageBoxButtons.OK, MessageBoxIcon.Information);
                reLoad();
            }
        }
        #endregion

        private void btDatVe_Click(object sender, EventArgs e)
        {

        }

        private void btnhuyVe_Click(object sender, EventArgs e)
        {
           
        }

        private void chbxThanhToan_CheckedChanged(object sender, EventArgs e)
        {
                panel1.Visible = true;
                btXacNhan.Visible = true;
        }

        private void txtSTK_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
