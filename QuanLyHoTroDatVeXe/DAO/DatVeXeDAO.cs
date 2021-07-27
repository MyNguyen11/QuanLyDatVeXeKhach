using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class DatVeXeDAO
    {
        private static DatVeXeDAO instance;
        public static DatVeXeDAO Instance 
        {
            get { if (instance == null) instance = new DatVeXeDAO(); return instance; }
            private set { instance = value; }
        }

        public List<DatVeXe> layDsVeXe(int maCD)
        {
            List<DatVeXe> ds = new List<DatVeXe>();
            string query = "SELECT * FROM dbo.DatVeXe WHERE maCD = " + maCD;
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow item in table.Rows)
                ds.Add(new DatVeXe(item));
            return ds;
        }

        public bool isFull(int maCD)
        {
            if (layDsVeXe(maCD).Count == 15)
                return true;
            return false;
        }

        public bool datVe(int sdt, int maCD, string maGhe)
        {
            int stt = int.Parse(maGhe.Substring(1));
            if (stt <= 15 && stt > 0)
            {
                DateTime tg = DateTime.Now;
                string sqlFormattedDate = tg.ToString("yyyy-MM-dd HH:mm:ss");
                string query = "themDatVeXe " + sdt + ", " + maCD + ", '" + maGhe + "', '" + sqlFormattedDate + "'";
                int result = DataProvider.Instance.ExecuteNonQuery(query);
                return result > 0;
            }
            return false;
        }

        public List<DatVeXe> baoCao()
        {
            List<DatVeXe> ds = new List<DatVeXe>();
            string query = "SELECT * FROM dbo.DatVeXe";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
                ds.Add(new DatVeXe(item));
            return ds;
        }


        public List<DatVeXe> timVeKH( int SDT)
        {
            List<DatVeXe> ds = new List<DatVeXe>();
            string query = "SELECT * FROM dbo.DatVeXe WHERE soDienThoai LIKE '%"+SDT+"'";
            DataTable table = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in table.Rows)
                ds.Add( new DatVeXe(item));
            return ds;
        }


        public bool xoaVe(int sdt)
        {
            string query = "DELETE dbo.DatVeXe WHERE soDienThoai = " + sdt;
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
    }
}
