using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWENG_421_Lab_5.Modules
{
    public class Log : INoInputModule
    {
        public string Name => "Log";

        public void Execute()
        {
            double v = CurrentValue.Instance.Value;
            if (v <= 0)
            {
                throw new InvalidOperationException("Log is UNAVAILABLE for current value <= 0.");
            }
            CurrentValue.Instance.Value = Math.Log(v);
        }
    }
}
