using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace DTO
{
    public class HuyVe
    {
        public int SoDienThoai { get; set; }
        public int MaCD { get; set; }
        public string MaGhe { get; set; }
        public string ThoiGianDat { get; set; }

        public HuyVe(int soDienThoai, int maCD, string maGhe, string thoiGianDat)
        {
            this.SoDienThoai = soDienThoai;
            this.MaCD = maCD;
            this.MaGhe = maGhe;
            this.ThoiGianDat = thoiGianDat;
        }

        public HuyVe(DataRow row)
        {
            this.SoDienThoai = (int)row["SoDienThoai"];
            this.MaCD = (int)row["maCD"];
            this.MaGhe = row["maGhe"].ToString();
            this.ThoiGianDat = row["thoiGianDat"].ToString();
        }
    }
}
