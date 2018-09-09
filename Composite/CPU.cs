using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    public class CPU : Plugin, IPluggable<Plugin>
    {
        public CPU(string name, decimal price) : base(name, price)
        {
            Plugins = new List<Plugin>();
        }

        public IList<Plugin> Plugins { get; set; }

        public void AddPlugin(Plugin plugin)
        {
            Plugins.Add(plugin);
        }
    }
}
