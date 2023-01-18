namespace ChainOfResponsibility
{
    public abstract class Chain<T>
    {
        internal Chain<T> next;

        public void SetNext(Chain<T> next)
        {
            this.next = next;
        }

        public abstract void Handle(T request);
    }
}
