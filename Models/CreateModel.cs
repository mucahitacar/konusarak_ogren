using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgren.Models
{
    public class CreateModel
    {
        public string baslik { get; set; }
        public string yazi { get; set; }
        public int soru_id { get; set; }
      
    }
}
