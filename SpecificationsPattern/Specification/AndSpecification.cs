using System;
using System.Linq.Expressions;

namespace SpecificationsPattern.Specification
{
    public class AndSpecification<T> : Specification<T>
    {
        private readonly Specification<T> left;
        private readonly Specification<T> right;

        public AndSpecification(Specification<T> left, Specification<T> right)
        {
            this.left  = left;
            this.right = right;
        }

        public override Expression<Func<T, bool>> ToExpression()
        {
            Expression<Func<T, bool>> leftExpression  = this.left.ToExpression();
            Expression<Func<T, bool>> rightExpression = this.right.ToExpression();

            ParameterExpression parameterExpression = Expression.Parameter(typeof(T));
            BinaryExpression andExpression = Expression.AndAlso(leftExpression.Body, rightExpression.Body);
            andExpression = (BinaryExpression)new ParameterReplacer(parameterExpression).Visit(andExpression);

            return Expression.Lambda<Func<T, bool>>(andExpression, parameterExpression);
        }
    }
}
