using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class ThongTinVeXe
    {
        public string BienSo { get; set; }
        public int MaCD { get; set; }
        public int SoLuongVe { get; set; }

        public ThongTinVeXe(string bienSo, int maCD,int soLuongVe )
        {
            this.BienSo = bienSo;
            this.MaCD = maCD;
            this.SoLuongVe = soLuongVe;

        }
        public ThongTinVeXe(DataRow row)
        {
            this.MaCD = (int)row["maCD"];
            this.BienSo = row["bienSo"].ToString();
            this.SoLuongVe = (int)row["soLuongVe"];

        }

    }
}
