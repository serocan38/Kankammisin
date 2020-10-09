using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ITestService
    {
        IDataResult<Test> GetById(int id);
        IDataResult<List<Test>> GetList();
        IResult Add(Test tests);
        IResult Delete(Test tests);
        IResult Update(Test tests);


    }
}
