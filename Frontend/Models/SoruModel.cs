using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class SoruModel
    {
        [Key]
        public int soruId { get; set; }
        public string soruAdi { get; set; }
        public int testId { get; set; }
        public string soru { get; set; }
        public string cevap1 { get; set; }
        public string cevap2 { get; set; }
        public string cevap3 { get; set; }
        public string cevap4 { get; set; }
        public int dogruCevap { get; set; }

        public string toStrings()
        {
            return "Soru{" +
                   "soruId=" + soruId +
                   ", sahipUsername='" + testId + '\'' +
                   ", soru='" + soru + '\'' +
                   ", cevap1='" + cevap1 + '\'' +
                   ", cevap2='" + cevap2 + '\'' +
                   ", cevap3='" + cevap3 + '\'' +
                   ", cevap4='" + cevap4 + '\'' +
                   ", dogruCevap ='" + dogruCevap + '\'' +
                   '}';
        }

    }
}
