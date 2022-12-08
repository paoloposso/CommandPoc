using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandPoc.Core;
using CommandPoc.Core.Messages;

namespace CommandPoc.Validation.Commands
{
    public class StartTerraformValidationCommandResult
    {
        public string ValidationStatus { get; private set; }

        public StartTerraformValidationCommandResult(string validationStatus) 
        {
            this.ValidationStatus = validationStatus;
        }
    }
}