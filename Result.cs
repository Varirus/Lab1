using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Result
    {
        public List<int> items { get; set; } = new List<int>();
        public int sumWeight { get; set; } = 0;
        public int sumValue { get; set; } = 0;
        
        public override string ToString()
        {
            string output = string.Empty;
            output += "Items: ";
            foreach (var item in items)
                output += item + " ";

            output += "\n";
            output += "Sum Weight: " + sumWeight + "\n";
            output += "Sum Value: " + sumValue + "\n";
            return output;
        }
    }
}
