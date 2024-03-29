﻿using SpecificationsPattern.Entity;
using System;
using System.Linq.Expressions;

namespace SpecificationsPattern.Specification
{
    public class IsProductExistSpecification : Specification<Product>
    {
        public override Expression<Func<Product, bool>> ToExpression()
        {
            return p => p.IsExist;
        }
    }
}
