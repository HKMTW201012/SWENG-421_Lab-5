using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWENG_421_Lab_5
{
    public interface ModuleFactoryIF
    {
        IModule Create(string typeName);
    }

    public class ModuleFactory : ModuleFactoryIF
    {
        public IModule Create(string typeName)
        {
            if (string.IsNullOrWhiteSpace(typeName))
                throw new ArgumentException("Module name is empty.");

            Type t = System.Reflection.Assembly.GetExecutingAssembly().GetType(typeName);

            if (t == null)
                throw new InvalidOperationException($"Cannot find module type: {typeName}");

            object obj = Activator.CreateInstance(t);
            if (obj == null)
                throw new InvalidOperationException($"Failed to create instance: {typeName}");

            IModule module = obj as IModule;
            if (module == null)
                throw new InvalidOperationException($"Type is not a valid module: {typeName}");

            return module;
        }

    }
}
