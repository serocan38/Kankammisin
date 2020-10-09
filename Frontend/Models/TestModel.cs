using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class TestModel
    {
        [Key]
        public int TestId { get; set; }
        public string TestAdi { get; set; }
        public string TestLinki { get; set; }
        public string TestSahibi { get; set; }
        public int TestSoruSayisi { get; set; }
        public int TestCozulmeSayisi { get; set; }

    }
}
