using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAO
{
   public class ThongTinVeXeDAO
    {
        private static ThongTinVeXeDAO instance;

        public static ThongTinVeXeDAO Instance
        {
            get { if (instance == null) instance = new ThongTinVeXeDAO(); return instance; }
            private set { instance = value; }
        }

        private ThongTinVeXeDAO() { }


        public List<ThongTinVeXe> LayDsThongTinVeXe()
        {
            List<ThongTinVeXe> danhSach = new List<ThongTinVeXe>();

            string query = "SELECT * FROM dbo.ThongTinVeXe";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                danhSach.Add(new ThongTinVeXe(item));
            }
            return danhSach;
        }




        ////thêm thông tin vé xe vào danh sách
        public bool themTTVeXe(string bienSo, int maCD, int soLuongVe)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("themTTVeXe '" + bienSo + "', '" + maCD + "', N'" + soLuongVe + "'");
            return result > 0;
        }

        //xóa thông tin vé xe
        public bool xoaChuyenDiBangmaCD_bienso(string bienSo ,int maCD)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE dbo.ThongTinVeXe WHERE maCD = '" + maCD + "' and bienSo='"+bienSo+"'");
            return result > 0;
        }

        //sửa thông tin vé xe
        public bool suaThongTinChuyenDi(string bienSo, int maCD, int soLuongVe)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("UPDATE dbo.ThongTinVeXe SET soLuongVe = N'" + soLuongVe + "', maCD = '" + maCD + "' WHERE  bienSo = '" + bienSo+"'");
            return result > 0;
        }
    }
}
