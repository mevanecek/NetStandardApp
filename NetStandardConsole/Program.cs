using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;
using NetStandardLibrary;

namespace NetStandardConsole
{
    class Program
    {
        static void PrintOptions(Options opts)
        {
            DoSomethingUseful dsu = new DoSomethingUseful();
            dsu.Organization = opts.Organization;
            dsu.ProjectName = opts.ProjectName;
            Debug.WriteLine(dsu.ToString());
        }

        static void Main(string[] args)
        {
            var result = Parser.Default.ParseArguments<Options>(args)
                .WithParsed<Options>(opts => PrintOptions(opts));

        }
    }
}
