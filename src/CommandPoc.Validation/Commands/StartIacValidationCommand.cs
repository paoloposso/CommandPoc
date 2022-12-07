using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandPoc.Core;

namespace CommandPoc.Validation.Commands
{
    public class StartIacValidationCommand : Command
    {
        public string Directory { get; set; }
    }
}