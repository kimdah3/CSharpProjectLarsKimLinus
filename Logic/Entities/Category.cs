using System;

namespace Logic.Entities
{
    public class Category : IEntity, Data.ICategory
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public Category(string name)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
        }

        public override string ToString()
        {
            return Name;
        }

        public static bool operator ==(Category a, Category b)
        {
            return string.CompareOrdinal(a.Name, b.Name) == 0;
        }

        public static bool operator !=(Category a, Category b)
        {
            return !(a == b);
        }
    }
}
