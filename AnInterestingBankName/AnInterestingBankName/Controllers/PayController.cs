using AnInterestingBankName.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AnInterestingBankName.Controllers
{
    public class PayModel
    {
        public string SaticiKodu { get; set; }
        public string SaticiSifre { get; set; }
        public string KartNo { get; set; }
        public string SonKullanmaAy { get; set; }
        public string SonKullanmaYil { get; set; }
        public string CVCKodu { get; set; }
        public decimal Bakiye { get; set; }
    }

    public class PayController : ApiController
    {
        AnInterestingBankName_Model db = new AnInterestingBankName_Model();

        // GET: api/Pay
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Pay/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Pay
        public string Post(PayModel pm)
        {
            SanalPosMusteriler spm = db.SanalPosMusteriler.FirstOrDefault(s => s.SaticiKodu == pm.SaticiKodu && s.Sifre == pm.SaticiSifre);

            if (spm == null)
            {
                return "67953";
            }
            if (spm.IsActive == false)
            {
                return "97624";
            }
            Kartlar k = db.Kartlar.FirstOrDefault(s => s.KartNo == pm.KartNo);
            if (k == null)
            {
                return "97618";
            }
            if (Convert.ToInt32("20" + k.SonKullanmaYil) < Convert.ToInt32(DateTime.Now.Year))
            {
                return "34976";
            }
            if (Convert.ToInt32("20" + k.SonKullanmaYil) == Convert.ToInt32(DateTime.Now.Year))
            {
                if (!(Convert.ToInt32(k.SonKullanmaAy) > Convert.ToInt32(DateTime.Now.Month)))
                {
                    return "61675";
                }
            }
            if (k.CVCKodu != pm.CVCKodu)
            {
                return "31864";
            }
            if (k.Hesaplar.IsActive == false)
            {
                return "94628";
            }
            if (k.Hesaplar.Bakiye < pm.Bakiye)
            {
                return "96483";
            }
            Hesaplar h = db.Hesaplar.Find(k.Hesap_ID);
            h.Bakiye -= pm.Bakiye;
            db.SaveChanges();
            return "11111";
        }

        // PUT: api/Pay/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Pay/5
        public void Delete(int id)
        {
        }
    }
}
