using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgren.Models
{
    public enum Cevap
    {
        A, B, C, D
    }
    public class Sorular
    {

        public int soru_id { get; set; }
        public string soru { get; set; }
        public string A_sikki { get; set; }
        public string B_sikki { get; set; }
        public string C_sikki { get; set; }
        public string D_sikki { get; set; }
        public Cevap cevap { get; set; }
        public string baslik { get; set; }
        public string yazi { get; set; }
        public static IEnumerable<SelectListItem> GetCevapSelectItems()
        {
            yield return new SelectListItem { Text = "A", Value = "a" };
            yield return new SelectListItem { Text = "B", Value = "b" };
            yield return new SelectListItem { Text = "C", Value = "c" };
            yield return new SelectListItem { Text = "D", Value = "d" };
        }
    }
}
