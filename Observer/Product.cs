using System.Collections.Generic;

namespace Observer
{
    public class Product
    {
        private bool exist;

        public List<Observer> ObserverList { get; set; } = new List<Observer>();

        public bool Exist
        {
            get
            {
                return exist;
            }
            set
            {
                if (value)
                {
                    this.Notify();
                }

                exist = value;
            }
        }

        public void Notify()
        {
            this.ObserverList.ForEach(x => x.Update());
        }
    }
}
