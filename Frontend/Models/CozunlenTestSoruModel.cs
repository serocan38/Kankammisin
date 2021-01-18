using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class CozunlenTestSoruModel
    {
        public List<SoruModel> SoruModels { get; set; }
        public string SecilenCevaplar { get; set; }
        public string Kankalik { get; set; }
        public string Cozen { get; set; }
        public string TestAdi { get; set; }

        public CozunlenTestSoruModel()
        {
            this.SoruModels = new List<SoruModel>();
            this.SecilenCevaplar = new string(SecilenCevaplar);
            this.Kankalik = new string(Kankalik);
            this.Cozen = new string(Cozen);
            this.TestAdi = new string(TestAdi);
        }

    }
}
