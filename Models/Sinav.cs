using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgren.Models
{
    public class Sinav
    {
        public int soru_id { get; set; }
        public string soru { get; set; }
        public string A_sikki { get; set; }
        public string B_sikki { get; set; }
        public string C_sikki { get; set; }
        public string D_sikki { get; set; }
        public string cevap { get; set; }
        public string yazi { get; set; }
        public string baslik { get; set; }

    }
}
