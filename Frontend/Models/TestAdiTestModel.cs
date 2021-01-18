using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Frontend.Models
{
    public class TestAdiTestModel
    {
        public List<IstatistikModel> IstatistikModels { get; set; }
        public string TestAdi { get; set; }

        public List<string> bfflist { get; set; }
        public TestAdiTestModel()
        {
            this.IstatistikModels = new List<IstatistikModel>();
            this.TestAdi = new string(TestAdi);
            this.bfflist = new List<string>();

        }
    }
}
