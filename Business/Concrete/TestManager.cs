using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
   public class TestManager:ITestService
   {
       private ITestDal _testDal;

       public TestManager(ITestDal testDal)
       {
           _testDal = testDal;
       }

       public IDataResult<Test> GetById(int id)
        {
            return new SuccessDataResult<Test>(_testDal.Get(t => t.TestId == id));
        }

        public IDataResult<List<Test>> GetList()
        {
            return new SuccessDataResult<List<Test>>(_testDal.GetList().ToList());
        }

        public IResult Add(Test tests)
        {
            _testDal.Add(tests);
            return new SuccessResult("Ekleme Başarılı ");
        }

        public IResult Delete(Test tests)
        {
            _testDal.Add(tests);
            return new SuccessResult("Ekleme Başarılı ");
        }

        public IResult Update(Test tests)
        {
            _testDal.Add(tests);
            return new SuccessResult("Ekleme Başarılı ");
        }
    }
}
