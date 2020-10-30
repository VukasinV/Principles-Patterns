using System.Linq;
using System.Collections.Generic;

// Used when we have tree like structure in which every element can be treated as 
// eather element or collection of elements

namespace Patterns.Composite
{
    interface IItem
    {
        void Use();
        int GetValue();
        void Add(IItem itemToAdd);
        void Remove(IItem itemToRemove);
    }

    class Item : IItem
    {
        public int Value { get; set; }
        public void Add(IItem item)
        {
            throw new System.NotImplementedException();
        }

        public int GetValue()
        {
            return Value;
        }

        public void Remove(IItem itemToRemove)
        {
            throw new System.NotImplementedException();
        }

        public void Use()
        {
            throw new System.NotImplementedException();
        }
    }

    class Bag : IItem
    {
        public List<IItem> Items { get; set; } 
        public void Add(IItem itemToAdd)
        {
            this.Items.Add(itemToAdd);
        }

        public int GetValue()
        {
            return Items.Sum(item => item.GetValue());
        }

        public void Remove(IItem itemToRemove)
        {
            this.Items.Remove(itemToRemove);
        }

        public void Use()
        {
            throw new System.NotImplementedException();
        }
    }
}