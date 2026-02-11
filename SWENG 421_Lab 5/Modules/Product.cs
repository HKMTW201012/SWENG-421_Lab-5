using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWENG_421_Lab_5.Modules
{
    public class Product : IInputModule
    {
        public string Name => "Product";

        public void Execute(double input)
        {
            CurrentValue.Instance.Value *= input;
        }
    }
}
