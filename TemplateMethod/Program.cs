using System;
using System.IO;

namespace TemplateMethod
{
    static class Program
    {
        static void Main(string[] args)
        {
            Theme flatly = new Flatly();
            flatly.DownloadBundle(true);

            Theme cosmo = new Cosmo();
            cosmo.DownloadBundle(false);

            Console.ReadLine();
        }
    }
}
