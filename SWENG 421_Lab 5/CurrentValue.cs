using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWENG_421_Lab_5
{
    public sealed class CurrentValue
    {
        private static readonly CurrentValue _instance = new CurrentValue();
        public static CurrentValue Instance => _instance;

        private CurrentValue()
        {
            Value = 0.0;
        }

        public double Value { get; set; }
    }
}
