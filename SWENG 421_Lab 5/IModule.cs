using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWENG_421_Lab_5
{
    public interface IModule
    {
        string Name { get; }
    }

    public interface IInputModule : IModule
    {
        void Execute(double input);
    }

    public interface INoInputModule : IModule
    {
        void Execute();
    }
}
