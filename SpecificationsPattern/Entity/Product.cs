using System;

namespace SpecificationsPattern.Entity
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public bool IsExist { get; set; } = false;
    }
}
