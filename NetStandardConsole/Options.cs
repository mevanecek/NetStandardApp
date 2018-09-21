﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommandLine;

namespace NetStandardConsole
{
    class Options
    {
        [Option('o', "organization", Required = true, HelpText = "The organization whose VSTS service is being accessed (<organization.visualstudio.com>).")]
        public string Organization { get; set; }

        [Option('p', "projectname", Required = true, HelpText = "The name of the VSTS project that is the target of the operation.")]
        public string ProjectName { get; set; }
    }
}
