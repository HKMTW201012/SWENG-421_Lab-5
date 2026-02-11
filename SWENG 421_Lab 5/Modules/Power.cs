using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWENG_421_Lab_5.Modules
{
    public class Power : IInputModule
    {
        public string Name => "Power";

        public void Execute(double input)
        {
            double baseVal = CurrentValue.Instance.Value;
            CurrentValue.Instance.Value = Math.Pow(baseVal, input);
        }
    }
}
