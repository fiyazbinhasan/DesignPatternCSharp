using System;
using System.Collections.Generic;

namespace TemplateMethod
{
    public class Flatly : Theme
    {
        public override List<string> GetStyles()
        {
            return new List<string> {
                "cosmo.css",
                "cosmo.min.css",
                "cosmo.scss"
            };
        }
    }
}
