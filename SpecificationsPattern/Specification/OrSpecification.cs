using System;
using System.Linq.Expressions;

namespace SpecificationsPattern.Specification
{
    public class OrSpecification<T> : Specification<T>
    {
        private readonly Specification<T> left;
        private readonly Specification<T> right;

        public OrSpecification(Specification<T> left, Specification<T> right)
        {
            this.left = left;
            this.right = right;
        }

        public override Expression<Func<T, bool>> ToExpression()
        {
            Expression<Func<T, bool>> leftExpression  = this.left.ToExpression();
            Expression<Func<T, bool>> rightExpression = this.right.ToExpression();

            ParameterExpression parameterExpression = Expression.Parameter(typeof(T));
            BinaryExpression orExpression = Expression.OrElse(leftExpression.Body, rightExpression.Body);
            orExpression = (BinaryExpression)new ParameterReplacer(parameterExpression).Visit(orExpression);

            return Expression.Lambda<Func<T, bool>>(orExpression, parameterExpression);
        }
    }
}
