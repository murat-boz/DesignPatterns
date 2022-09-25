using SpecificationsPattern.Repository;
using SpecificationsPattern.Specification;
using System;

namespace SpecificationsPattern
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IProductRepository productRepository = new InMemoryProductRepository();

            Console.WriteLine("SatisfiedByExpression is beginning");
            SatisfiedByExpression(productRepository);
            Console.WriteLine("SatisfiedByExpression is ended");

            Console.WriteLine();

            Console.WriteLine("SatisfiedByMethod is beginning");
            SatisfiedByMethod(productRepository);
            Console.WriteLine("SatisfiedByMethod is ended");

            Console.ReadLine();
        }

        private static void SatisfiedByExpression(IProductRepository productRepository)
        {
            var list = productRepository.GetInfoAboutProducts(new IsProductExistSpecification());

            foreach (var item in list)
            {
                Console.WriteLine(item.Name);
            }
        }

        private static void SatisfiedByMethod(IProductRepository productRepository)
        {
            var list = productRepository.GetAll();

            var isProductExistSpecification = new IsProductExistSpecification();

            foreach (var item in list)
            {
                if (isProductExistSpecification.IsSatisfiedBy(item))
                {
                    Console.WriteLine(item.Name);
                }
            }
        }
    }
}