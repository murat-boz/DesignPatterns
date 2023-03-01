using SpecificationsPattern.Specification;

namespace SpecificationsPattern.Extensions
{
    public static class SpecificationExtensions
    {
        public static Specification<T> And<T>(this Specification<T> left, Specification<T> right)
        {
            return new AndSpecification<T>(left, right);
        }

        public static Specification<T> Or<T>(this Specification<T> left, Specification<T> right)
        {
            return new OrSpecification<T>(left, right);
        }

        public static Specification<T> Equal<T>(this Specification<T> left, Specification<T> right)
        {
            return new EqualSpecification<T>(left, right);
        }

        public static Specification<T> NotEqual<T>(this Specification<T> left, Specification<T> right)
        {
            return new NotEqualSpecification<T>(left, right);
        }
    }
}
