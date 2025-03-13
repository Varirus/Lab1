using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Item
    {
        public int id { get; set; }
        public int weight { get; set; }
        public int value { get; set; }
        public float sortValue { get; set; }

        public Item(int id, int weight, int value)
        {
            this.id = id;
            this.weight = weight;
            this.value = value;
            this.sortValue = value;
            this.sortValue = this.sortValue / weight;
        }

        public override string ToString()
        {
            string output = string.Empty;
            output += "Lp. " + this.id;
            output += " weight: " + this.weight;
            output += " value: " + this.value;
            output += "\n";
            return output;
        }
    }
}
