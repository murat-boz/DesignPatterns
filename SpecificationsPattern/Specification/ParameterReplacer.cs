﻿using System.Linq.Expressions;

namespace SpecificationsPattern.Specification
{
    public class ParameterReplacer : ExpressionVisitor
    {
        private readonly ParameterExpression parameter;
        public ParameterReplacer(ParameterExpression parameter)
            => this.parameter = parameter;
        protected override Expression VisitParameter(ParameterExpression node)
            => base.VisitParameter(this.parameter);
    }
}
