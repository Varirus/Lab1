using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab1
{
    class Problem
    {
        private int n { get; set; }
        public List<Item> items { get; set; } = new List<Item>();

        public Problem(int n, int seed)
        {
            this.n = n;
            Random random = new Random(seed);
            for (int i = 0; i < n; i++)
                items.Add(new Item(i, random.Next(1, 11), random.Next(1, 11)));
        }

        public override string ToString()
        {
            string output = string.Empty;
            foreach (var item in items)
            {
                output += "No. " + item.id;
                output += " weight: " + item.weight;
                output += " value: " + item.value;
                output += "\n";
            }
            return output;
        }

        public Result Solve(int capacity)
        {
            List<Item> sortedItems = new List<Item>(items);
            // Sorting items in decreasing order by their sortValue 
            sortedItems.Sort(delegate (Item i1, Item i2) { return i2.sortValue.CompareTo(i1.sortValue); });
            Result result = new Result();
            bool isFilled = false;
            while (!isFilled)
            {
                // No items left
                if (sortedItems.Count == 0 || capacity <= 0)
                    isFilled = true;
                // Backpack capacity is too small
                else if (sortedItems.ElementAt(0).weight > capacity)
                    sortedItems.RemoveAt(0);
                // Item can be added to backpack
                else
                {   
                    result.items.Add(sortedItems.ElementAt(0).id);
                    result.sumWeight += sortedItems.ElementAt(0).weight;
                    result.sumValue += sortedItems.ElementAt(0).value;
                    capacity -= sortedItems.ElementAt(0).weight;
                    sortedItems.RemoveAt(0);
                }
            }
            return result;
        }
    }
}
