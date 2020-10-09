using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace Entities.Concrete
{
   public class Test:IEntity
    {
        public int TestId { get; set; }
        public string TestAdi { get; set; }
        public string TestLinki { get; set; }
        public string TestSoruSayisi { get; set; }
        public bool TestCozulmeSayisi { get; set; }
    }
}
