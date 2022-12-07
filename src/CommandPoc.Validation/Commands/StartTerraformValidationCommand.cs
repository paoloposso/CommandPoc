using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandPoc.Core;
using CommandPoc.Core.Messages;

namespace CommandPoc.Validation.Commands
{
    public class StartTerraformValidationCommand : Command<bool>
    {
        public Guid ValidationId { get; private set; }
        public string Directory { get; private set; }
    
        public StartTerraformValidationCommand(
            Guid validationId, 
            string directory
        )
        {
            ValidationId = validationId;
            Directory = directory;
        }
    }
}