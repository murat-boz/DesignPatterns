using SpecificationsPattern.Entity;
using SpecificationsPattern.Specification;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SpecificationsPattern.Repository
{
    public class InMemoryProductRepository : IProductRepository
    {
        public List<Product> Products { get; private set; } = new List<Product>();

        public InMemoryProductRepository()
        {
            this.CreateProducts();
        }

        public List<Product> GetAll()
        {
            return this.Products;
        }

        public Product GetById(Guid Id)
        {
            return this.Products.FirstOrDefault(x => x.Id == Id);
        }

        public List<Product> GetInfoAboutProducts(BaseSpecification<Product> specification)
        {
            return this.Products.AsQueryable<Product>()
                                .Where(specification)
                                .ToList();
        }

        private void CreateProducts()
        {
            this.Products = new List<Product>
            {
                new Product
                {
                    Id      = Guid.NewGuid(),
                    Name    = "First Product",
                    IsExist = true
                },
                new Product
                {
                    Id      = Guid.NewGuid(),
                    Name    = "Second Product",
                    IsExist = false
                },
                new Product
                {
                    Id      = Guid.NewGuid(),
                    Name    = "Third Product",
                    IsExist = true
                }
            };
        }
    }
}
