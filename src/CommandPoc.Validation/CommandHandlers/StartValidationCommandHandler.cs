using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandPoc.Validation.Commands;
using MediatR;

namespace CommandPoc.Validation.CommandHandlers
{
    public class StartValidationCommandHandler :
        IRequestHandler<StartGitHubTerraformValidationCommand, bool>,
        IRequestHandler<StartTerraformValidationCommand, bool>
    {
        public Task<bool> Handle(StartGitHubTerraformValidationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Handle(StartTerraformValidationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}