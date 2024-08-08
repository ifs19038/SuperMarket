using System.Collections.Generic;

namespace SuperMarketApp.Models
{
    public class Gudang
    {
        public int GudangID { get; set; }
        public string NamaGudang { get; set; }
        public ICollection<Barang> Barangs { get; set; }
    }
}
