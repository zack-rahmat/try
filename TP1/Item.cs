using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1
{
    class Item
    {
        public string jenis { get; set; }
        public string harga { get; set; }
        public Item(string jenis, string harga)
        {
            this.jenis = jenis;
            this.harga = harga;
        }

        public Item()
        {

        }
    }
}
