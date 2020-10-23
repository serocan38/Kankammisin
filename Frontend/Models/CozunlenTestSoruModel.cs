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
        public CozunlenTestSoruModel()
        {
            this.SoruModels = new List<SoruModel>();
            this.SecilenCevaplar = new string(SecilenCevaplar);
        }

    }
}
