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
    public class ProductManager:IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public IDataResult<Product> GetById(int ID)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ID == ID));
        }

        public IDataResult<List<Product>> GetList()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList().ToList());
        }

        public IDataResult<List<Product>> GetUserType(int userTypeId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetList(p => p.ID == userTypeId).ToList());   //TODO: User Type Ekle Burayı Değiştir
        }

        public IResult Add(Product users)
        {
            //Business Code ** Kurallar.
                _productDal.Add(users);
                return new SuccessResult("Ekleme Başarılı "); 
        }

        public IResult Delete(Product users)
        {
            _productDal.Delete(users);
            return new SuccessResult("Silme Başarılı");
             
        }

        public IResult Update(Product users)
        {
            _productDal.Update(users);
            return new SuccessResult("Güncelleme Başarılı");

        }
    }
}
