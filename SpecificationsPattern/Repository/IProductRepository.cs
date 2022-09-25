using SpecificationsPattern.Entity;
using SpecificationsPattern.Specification;
using System;
using System.Collections.Generic;

namespace SpecificationsPattern.Repository
{
    public interface IProductRepository
    {
        Product GetById(Guid Id);
        List<Product> GetAll();
        List<Product> GetInfoAboutProducts(BaseSpecification<Product> specification);
    }
}
