using System;
using System.Linq.Expressions;

namespace SpecificationsPattern.Specification
{
    public class NotEqualSpecification<T> : Specification<T>
    {
        private readonly Specification<T> _left;
        private readonly Specification<T> _right;

        public NotEqualSpecification(Specification<T> left, Specification<T> right)
        {
            _left  = left;
            _right = right;
        }

        public override Expression<Func<T, bool>> ToExpression()
        {
            Expression<Func<T, bool>> leftExpression  = _left.ToExpression();
            Expression<Func<T, bool>> rightExpression = _right.ToExpression();

            ParameterExpression parameterExpression = Expression.Parameter(typeof(T));

            BinaryExpression notEqualExpression = Expression.NotEqual(leftExpression.Body, rightExpression.Body);
            notEqualExpression = (BinaryExpression)new ParameterReplacer(parameterExpression).Visit(notEqualExpression);

            return Expression.Lambda<Func<T, bool>>(notEqualExpression, parameterExpression);
        }
    }
}
