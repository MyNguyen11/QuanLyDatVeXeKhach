using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DatVeXe
    {
        public int SDT { get; set; }
        public int MaCD { get; set; }
        public string MaGhe { get; set; }
        public DateTime ThoiGianDat { get; set; }
        public DatVeXe() { }
        public DatVeXe(int sdt, int maCD, string maGhe, DateTime thoiGianDat)
        {
            this.SDT = sdt;
            this.MaCD = maCD;
            this.MaGhe = maGhe;
            this.ThoiGianDat = thoiGianDat;
        }

        public DatVeXe(DataRow row)
        {
            this.SDT = (int)row["soDienThoai"];
            this.MaCD = (int)row["maCD"];
            this.MaGhe = row["maGhe"].ToString();
            this.ThoiGianDat = (DateTime)row["thoiGianDat"];
        }
    }
}
