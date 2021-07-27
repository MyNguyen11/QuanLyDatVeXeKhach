using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAO
{
   public class HuyVeDAO
    {
        private static HuyVeDAO instance;

        public static HuyVeDAO Instance
        {
            get { if (instance == null) instance = new HuyVeDAO(); return instance; }
            private set { instance = value; }
        }


        private HuyVeDAO() { }

        //lấy ds chuyến đi
        public List<HuyVe> LayDsve()
        {
            List<HuyVe> danhSach = new List<HuyVe>();

            string query = "SELECT * FROM dbo.DatVeXe";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                danhSach.Add(new HuyVe(item));
            }
            return danhSach;
        }


        public List<HanhKhach> Laydshkhemma(int soDienThoai)
        {
            List<HanhKhach> ds = new List<HanhKhach>();
            string query = "SELECT * FROM HanhKhach WHERE SoDienThoai='" + soDienThoai + "' ";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
                ds.Add(new HanhKhach(item));
            return ds;
        }

        public bool xoave(int soDienThoai, string maGhe)
        {
            int result = DataProvider.Instance.ExecuteNonQuery("DELETE DatVeXe WHERE soDienThoai = '" + soDienThoai + "' and maGhe='"+maGhe+"'");
            return result > 0;
        }
    }
}
