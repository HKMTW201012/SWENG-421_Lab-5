using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Added this class to test it as a "new added module";
//And the original code remains unchanged.
namespace SWENG_421_Lab_5.Modules
{
    public class Square : INoInputModule
    {
        public string Name => "Square";

        public void Execute()
        {
            double v = CurrentValue.Instance.Value;
            CurrentValue.Instance.Value = v * v;
        }
    }
}
