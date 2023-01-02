namespace Visitor
{
    public interface IPhone
    {
        void Accept(IPhoneVisitor phoneVisitor);
    }
}
