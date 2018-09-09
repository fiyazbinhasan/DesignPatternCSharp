using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composite
{
    public class Computer : IPluggable<Plugin>
    {
        public Computer()
        {
            Plugins = new List<Plugin>();
        }

        public IList<Plugin> Plugins { get; set; }

        public void AddPlugin(Plugin plugin)
        {
            Plugins.Add(plugin);
        }

        public decimal GetTotal()
        {
            var sum = 0.0M;

            if (Plugins.Count == 0)
                return sum;
            else
            {
                foreach (var plugin in Plugins)
                {
                    sum = sum + Sum(plugin);
                }
                return sum;
            }
            
        }

        private decimal Sum(Plugin plugin)
        {
            decimal price = plugin.Price;

            if (plugin is IPluggable<Plugin> node)
            {
                foreach (var child in node.Plugins)
                {
                    price += Sum(child);
                }
            }

            return price;
        }
    }
}
