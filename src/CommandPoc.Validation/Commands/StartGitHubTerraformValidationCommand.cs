using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandPoc.Core;
using CommandPoc.Core.Messages;

namespace CommandPoc.Validation.Commands
{
    public class StartGitHubTerraformValidationCommand : Command<bool>
    {
        public Guid ValidationId { get; private set; }
        public string RepositoryLocation { get; private set; }
    
        public StartGitHubTerraformValidationCommand(
            Guid validationId, 
            string directory
        )
        {
            ValidationId = validationId;
            RepositoryLocation = directory;
        }
    }
}