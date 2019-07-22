using System;
using System.Collections.Generic;

namespace TemplateMethod
{
    public class Cosmo : Theme
    {
        protected override List<string> GetStyles()
        {
            return new List<string> {
                "cosmo.css",
                "cosmo.min.css",
                "cosmo.scss"
            };
        }
    }
}
