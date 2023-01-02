using Visitor.Concrete;

namespace Visitor
{
    public interface IPhoneVisitor
    {
        void Visit(Nokia phone);
        void Visit(Ericsson phone);
    }
}
