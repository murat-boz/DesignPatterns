using SpecificationsPattern.Entity;
using System;
using System.Linq.Expressions;

namespace SpecificationsPattern.Specification
{
    public class IsNameNotEmptySpecification : Specification<Product>
    {
        public override Expression<Func<Product, bool>> ToExpression()
        {
            return p => p.Name != string.Empty;
        }
    }
}
