using System;
using System.Collections.Generic;

namespace TemplateMethod
{
    public class Flatly : Theme
    {
        protected override List<string> GetStyles()
        {
            return new List<string> {
                "flatly.css",
                "flatly.min.css",
                "flatly.scss"
            };
        }
    }
}
