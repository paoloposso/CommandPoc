using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandPoc.Core;
using CommandPoc.Core.Messages;

namespace CommandPoc.Validation.Commands
{
    public class StartTerraformValidationCommand : Command<StartTerraformValidationCommandResult>
    {
        public string Directory { get; private set; }
    
        public StartTerraformValidationCommand(
            string directory
        )
        {
            Directory = directory;
        }
    }
}