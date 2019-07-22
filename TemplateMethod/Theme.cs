using System;
using System.Collections.Generic;

namespace TemplateMethod
{
    public abstract class Theme
    {
        private IEnumerable<string> GetScripts()
        {
            return new List<string> {
                "jquery.js",
                "jquery.min.js"
            };
        }

        protected abstract List<string> GetStyles();

        public List<string> DownloadBundle(bool includeScript)
        {
            if (!includeScript)
                return GetStyles();

            var bundle = new List<string>();

            bundle.AddRange(GetStyles());
            bundle.AddRange(GetScripts());

            return bundle;
        }
    }
}
