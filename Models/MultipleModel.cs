using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonusarakOgren.Models
{
    public class MultipleModel
    {
        public List<CreateModel> CreateModel { get; set; }
        public List<Sorular> Sorular { get; set; }
        public string yazi { get; set; }
        public int id { get; set; }

    }
}
