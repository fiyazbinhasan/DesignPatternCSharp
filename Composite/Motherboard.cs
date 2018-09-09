using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class Motherboard : Plugin, IPluggable<Plugin>
    {
        public Motherboard(string name, decimal price) : base(name, price)
        {
            Plugins = new List<Plugin>();
        }

        public IList<Plugin> Plugins { get; }

        public void AddPlugin(Plugin plugin)
        {
            Plugins.Add(plugin);
        }
    }
}
