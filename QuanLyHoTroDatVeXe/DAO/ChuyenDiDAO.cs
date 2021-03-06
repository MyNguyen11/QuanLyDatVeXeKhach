using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class ChuyenDiDAO
    {
        private static ChuyenDiDAO instance;

        public static ChuyenDiDAO Instance
        {
            get { if (instance == null) instance = new ChuyenDiDAO(); return instance; }
            private set { instance = value; }
        }

        private ChuyenDiDAO() { }

        //lấy ds chuyến đi
        public List<ChuyenDi> LayDsChuyenDi()
        {
            List<ChuyenDi> danhSach = new List<ChuyenDi>();

            string query = "SELECT * FROM dbo.ChuyenDi";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                danhSach.Add(new ChuyenDi(item));
            }
            return danhSach;
        }

        public List<ChuyenDi> LaydsCDThemma(int maCD)
        {
            List<ChuyenDi> ds = new List<ChuyenDi>();
            string query = "SELECT * FROM ChuyenDi WHERE maCD='"+maCD+"' ";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
                ds.Add(new ChuyenDi(item));
            return ds;
        }


        //Tìm chuyến đi để dặt vé
        public ChuyenDi timChuyenDi(string gd, string ngayDi, string diemDi, string diemDen)
        {
            string query = "SELECT* FROM dbo.ChuyenDi WHERE gioDi = '" + gd+ "' AND ngayDi = '" 
                + ngayDi + "' AND diemDi = N'" + diemDi + "' AND diemDen = N'" + diemDen + "'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in table.Rows)
            {
                return new ChuyenDi(row); 
            }
            return null;
        }


    ////////////////

        //thêm chuyến đi vào danh sách
        public bool themChuyenDi(string gioDi, string ngayDi, string diemDi, string diemDen, double giaVe)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("themChuyenDi '" + gioDi + "', '" + ngayDi + "', N'" + diemDi + "', N'" + diemDen + "', " + giaVe + "");
            return result > 0;
        }

        //xóa chuyến đi
        public bool xoaChuyenDiBangmaCD(int maCD)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.ChuyenDi WHERE maCD = '" + maCD + "'");
            return result > 0;
        }

        //sửa thông tin
        public bool suaThongTinChuyenDi(int maCD, string gioDi, string ngayDi, string diemDi, string diemDen, double giaVe)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.ChuyenDi SET gioDi = N'"+ gioDi + "', ngayDi = '" + ngayDi + "', diemDi = N'" + diemDi + "', diemDen = N'" + diemDen + "', giaVe = '"+ giaVe+ "' WHERE maCD = " + maCD);
            return result > 0;
        }
    }
}
