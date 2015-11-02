using System;
using System.Collections.Generic;

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

    }

    public class DistinctCategoryComparer : IEqualityComparer<Category>
    {
        public bool Equals(Category x, Category y)
        {
            return x.Name == y.Name;
        }

        public int GetHashCode(Category obj)
        {
            return obj.Name.GetHashCode();
        }
    }
}
