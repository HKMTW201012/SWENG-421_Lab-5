using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWENG_421_Lab_5.Modules
{
    public class Sum : IInputModule
    {
        public string Name => "Sum";

        public void Execute(double input)
        {
            CurrentValue.Instance.Value += input;
        }
    }
}
