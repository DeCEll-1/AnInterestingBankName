using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AnInterestingBankName.Models
{
    public class Logs
    {
        public int ID { get; set; }

        public string SaticiKodu { get; set; }

        public string KartNo { get; set; }

        public decimal Bakiye { get; set; }

        public DateTime Tarih { get; set; }

    }
}