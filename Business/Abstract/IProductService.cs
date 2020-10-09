using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {//0=admin , 1=kullanici
        IDataResult<Product> GetById(int ID);
        IDataResult<List<Product>> GetList();
        IDataResult<List<Product>> GetUserType(int userTypeId);
        IResult Add(Product users);
        IResult Delete(Product users);
        IResult Update(Product users);


    }
}
