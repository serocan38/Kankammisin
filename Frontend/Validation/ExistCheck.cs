using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Frontend.Models;

namespace Frontend.Validation
{
    public class ExistCheck
    {
        private readonly KankammisinContext c;

        public ExistCheck(KankammisinContext context)
        {
            c = context;
        }

        public bool userexist(string username)
        {
            var hasKullaniciAdi = c.Users.Where(u => u.kullaniciAdi == username);
            if (hasKullaniciAdi.Count() != 0)
            {
                return true;
            }
            return false;
        }
   

        public bool testExist(string testAdi,string testSahibi)
        {
            var hasTestadi = c.Testler.Where(t => t.TestAdi == testAdi).Where(t=>t.TestSahibi==testSahibi).FirstOrDefault();
            if (hasTestadi !=null)
            {
                return true;
            }

            return false;
        }



        public void TestSil(TestModel testModel)
        {
            c.Remove<TestModel>(testModel);
            var soru = c.Sorular.Where(s => s.testId == testModel.TestId).ToList();
            var ct = c.CozulenTest.Where(ct => ct.testId == testModel.TestId).FirstOrDefault();
            var ista = c.Istatistik.Where(i => i.testAdi == testModel.TestAdi)
                .Where(i => i.cozulen == testModel.TestSahibi).FirstOrDefault();
            c.RemoveRange(soru);
            if (ct!=null)
            {
            c.Remove<CozulenTestModel>(ct);
            c.Remove<IstatistikModel>(ista);
            }

            c.SaveChanges();
        }
    }
}
