using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HanhKhachDAO
    {
        private static HanhKhachDAO instance;

        public static HanhKhachDAO Instance
        {
            get { if (instance == null) instance = new HanhKhachDAO(); return instance; }
            private set { instance = value; }
        }

        public List<HanhKhach> layDsKhachHang()
        {
            List<HanhKhach> ds = new List<HanhKhach>();
            string query = "SELECT * FROM dbo.HanhKhach";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in table.Rows)
                ds.Add(new HanhKhach(row));

            return ds;
        }
        //lấy khách hàng bằng số điện thoại
        public HanhKhach layKH(int? sdt)
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.HanhKhach WHERE soDienThoai = " + sdt);
            foreach (DataRow row in table.Rows)
            {
                return new HanhKhach(row);
            }
            return null;
        }
        //tìm khách hàng bằng số điện thoại
        public int timKH(int sdt)
        {
            DataTable table = DataProvider.Instance.ExecuteQuery("SELECT * FROM dbo.HanhKhach WHERE soDienThoai = " + sdt );
            foreach (DataRow row in table.Rows)
            {
                HanhKhach KHTim = new HanhKhach(row);
                return KHTim.SoDienThoai;
            }
            return -1;
        }
        //thêm 1 khách hàng vô danh sách khách hàng
        public bool themKH(int sdt, int cnmd, string ht, string gt, string dc, string email)
        {
            
            int result = DataProvider.Instance.ExecuteNonQuery("themKH " + sdt +", " + cnmd + ", N'" + ht + "', N'" + gt + "', N'" + dc + "', '" + email + "'");
            int b = DataProvider.Instance.ExecuteNonQuery("INSERT INTO TaiKhoan (tenDangNhap,matKhau,loaiTaiKhoan,soDienThoai) VALUES ('" + sdt + "','" + cnmd.ToString() + "',0," + sdt + ")");
            return result > 0;
        }

        //sửa thông tin khách hàng bằng số điện thoại
        public bool suaKHBangSDT(int sdt, int cmnd, string ht, string gt, string dc, string email)
        {
            string query = "UPDATE dbo.HanhKhach SET CMND =" + cmnd + ", hoTen = N'" + ht 
                    + "', gioiTinh = N'" + gt + "', diaChi = N'" + dc + "', email ='" + email 
                    + "' WHERE soDienThoai = " + sdt;
            int b = DataProvider.Instance.ExecuteNonQuery("UPDATE TaiKhoan SET matkhau='"+cmnd+"' WHERE soDienThoai = "+sdt.ToString());
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }


        //xóa khách hàng bằng số điện thoại
        public bool xoaKHBangSDT(int sdt)
        {
            string query = "DELETE dbo.HanhKhach WHERE soDienThoai = " + sdt;
            int b = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.TaiKhoan WHERE soDienThoai="+sdt.ToString());
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
