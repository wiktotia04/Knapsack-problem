using Google.Protobuf.WellKnownTypes;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    public class Result
    {
        public int TotalValue { get; set; }
        public int TotalWeight { get; set; }
        public List<int> index { get; set; } = new List<int>();

        public Result()
        {
            this.TotalValue = 0;
            this.TotalWeight = 0;
        }

        public override string ToString()
        {
            return $"Total Value: {TotalValue}, Total Weight: {TotalWeight}, index:{string.Join(", ", index)}";
        }
    }
}
