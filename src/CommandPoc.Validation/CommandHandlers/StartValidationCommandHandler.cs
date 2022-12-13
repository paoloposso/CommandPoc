using CommandPoc.Validation.Commands;
using CommandPoc.Validation.Domain;
using CommandPoc.Validation.Domain.Model;
using MediatR;

namespace CommandPoc.Validation.CommandHandlers
{
    public class StartValidationCommandHandler :
        IRequestHandler<StartGitHubTerraformValidationCommand, bool>,
        IRequestHandler<StartTerraformValidationCommand, StartTerraformValidationCommandResult>
    {
        IValidationRepository _repository;

        public StartValidationCommandHandler(IValidationRepository repository)
        {
            _repository = repository;
        }

        public Task<bool> Handle(StartGitHubTerraformValidationCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public async Task<StartTerraformValidationCommandResult> Handle(StartTerraformValidationCommand request, CancellationToken cancellationToken)
        {

            var terraformValidation = new TerraformValidation(Guid.NewGuid(), "started", DateTime.UtcNow);

            //execute validation here

            terraformValidation.SetStatus("finished");

            await _repository.UpdateValidationStatus(terraformValidation.ValidationId, terraformValidation.Status);

            return new StartTerraformValidationCommandResult(terraformValidation.Status);
        }
    }
}