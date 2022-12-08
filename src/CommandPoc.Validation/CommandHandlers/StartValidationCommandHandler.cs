using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CommandPoc.Validation.Commands;
using CommandPoc.Validation.Domain.Services;
using MediatR;

namespace CommandPoc.Validation.CommandHandlers
{
    public class StartValidationCommandHandler :
        IRequestHandler<StartGitHubTerraformValidationCommand, bool>,
        IRequestHandler<StartTerraformValidationCommand, StartTerraformValidationCommandResult>
    {
        TerraformValidationService _service;

        public StartValidationCommandHandler(TerraformValidationService service)
        {
            _service = service;
        }

        public Task<bool> Handle(StartGitHubTerraformValidationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public Task<StartTerraformValidationCommandResult> Handle(StartTerraformValidationCommand request, CancellationToken cancellationToken)
        {
            var resultStatus = _service.Validate(new Domain.Model.TerraformValidation(request.ValidationId));

            return Task.FromResult(new StartTerraformValidationCommandResult(resultStatus));
        }
    }
}